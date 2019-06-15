using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Media;

namespace NBackTask
{
    public partial class Form1 : Form
    {
        NBackTask nback;
        List<System.IO.UnmanagedMemoryStream> sequence;
        int iteration = -1;
        System.Timers.Timer mainTimer;
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            nback = new NBackTask();
            stopwatch = new Stopwatch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void butPositive_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            nback.AddAnswer(new Answer(true, stopwatch.ElapsedMilliseconds));

            System.Timers.Timer timer = new System.Timers.Timer { Interval = 200 };
            timer.Enabled = true;
            timer.AutoReset = false;
            if (nback.CheckAnswer(iteration) == true)   //correct
            {
                picTop.BackColor = Color.Green;
                picBottom.BackColor = Color.Green;
                labCorrect.Visible = true;
            }
            else                                        //wrong
            {
                picTop.BackColor = Color.Red;
                picBottom.BackColor = Color.Red;
                labWrong.Visible = true;
            }
            timer.Elapsed += OnTimerEvent;
            butPositive.Enabled = false;
            butNegative.Enabled = false;
        }

        private void butNegative_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            nback.AddAnswer(new Answer(false, stopwatch.ElapsedMilliseconds));
            
            System.Timers.Timer timer = new System.Timers.Timer { Interval = 200 };
            timer.Enabled = true;
            timer.AutoReset = false;
            if (nback.CheckAnswer(iteration) == true)   //wrong
            {
                picTop.BackColor = Color.Red;
                picBottom.BackColor = Color.Red;
                labWrong.Visible = true;
            }
            else                                        //correct
            {
                picTop.BackColor = Color.Green;
                picBottom.BackColor = Color.Green;
                labCorrect.Visible = true;
            }
            timer.Elapsed += OnTimerEvent;
            butPositive.Enabled = false;
            butNegative.Enabled = false;
        }

        delegate void SetLabelVisibleCallback();
        public void SetLabelVisible()
        {
            if (this.labNumber.InvokeRequired)
            {
                SetLabelVisibleCallback d = new SetLabelVisibleCallback(SetLabelVisible);
                Invoke(d, new object[] {  });
            }
            else
            {
                labCorrect.Visible = false;
                labWrong.Visible = false;
            }
        }

        private void OnTimerEvent(object sender, ElapsedEventArgs e)
        {
            picTop.BackColor = SystemColors.ButtonFace;
            picBottom.BackColor = SystemColors.ButtonFace;
            SetLabelVisible();
            System.Timers.Timer timer = (System.Timers.Timer)sender;
            timer.Close();
        }

        delegate void SetLabelTextCallback(System.IO.UnmanagedMemoryStream text);
        public void SetLabelText(System.IO.UnmanagedMemoryStream sound)
        {
            if (this.labNumber.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabelText);
                Invoke(d, new object[] { sound });
            }
            else
            {
                butPositive.Enabled = true;
                butNegative.Enabled = true;
                SoundPlayer player = new SoundPlayer();
                sound.Position = 0;
                player.Stream = null;
                player.Stream = sound;
                player.Play();
            }
        }

        private void NextNumberEvent(object sender, EventArgs e)
        {
            if (sequence.Count - 1 == iteration)
            {
                nback.CreateReport();
                mainTimer.Stop();
                ShowEndingScreen();
                return;
            }

            iteration++;
            SetLabelText(sequence[iteration]);
            Thread.Sleep(844);
            stopwatch.Reset();
            stopwatch.Start();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxN.Text, "^[2-5]$") || textBoxName.Text == "" || !System.Text.RegularExpressions.Regex.IsMatch(textBoxSeq.Text, @"^[0-9]*$"))
            {
                return;
            }

            if (textBoxSeq.Text == "")
                nback.StartTest(textBoxName.Text, Convert.ToInt32(textBoxN.Text));
            else
            {
                Char[] numbers = textBoxSeq.Text.ToCharArray();
                List<String> numToStr = new List<String>();
                foreach (Char num in numbers)
                {
                    numToStr.Add(num.ToString());
                }
                nback.StartTest(textBoxName.Text, Convert.ToInt32(textBoxN.Text), numToStr);
            }
            sequence = nback.GetSequence();

            butStart.Visible = false;
            butPositive.Visible = true;
            butNegative.Visible = true;
            labNumber.Visible = true;
            textBoxN.Visible = false;
            labN.Visible = false;
            labName.Visible = false;
            textBoxName.Visible = false;
            labSequence.Visible = false;
            textBoxSeq.Visible = false;

            mainTimer = new System.Timers.Timer { Interval = 3000 };
            mainTimer.Enabled = true;
            mainTimer.Elapsed += NextNumberEvent;
            mainTimer.Start();
        }

        delegate void ShowEndingScreenCallback();
        private void ShowEndingScreen()
        {
            if (this.butPositive.InvokeRequired)
            {
                ShowEndingScreenCallback d = new ShowEndingScreenCallback(ShowEndingScreen);
                Invoke(d, new object[] {  });
            }
            else
            {
                butPositive.Visible = false;
                butNegative.Visible = false;
                labNumber.Visible = false;
                labEnding.Visible = true;
                butEnd.Visible = true;
            }
        }

        private void butEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxN_TextChanged_1(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxN.Text, "^[2-5]$"))
            {
                //textBoxN.Text = "";
                textBoxN.BackColor = Color.PaleVioletRed;
            }
            else
            {
                textBoxN.BackColor = Color.White;
            }
        }

        private void textBoxSeq_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxSeq.Text, @"^[0-9]*$"))
            {
                //textBoxN.Text = "";
                textBoxSeq.BackColor = Color.PaleVioletRed;
            }
            else
            {
                textBoxSeq.BackColor = Color.White;
            }
        }
    }
}
