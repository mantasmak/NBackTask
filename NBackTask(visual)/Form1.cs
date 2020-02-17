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
    public partial class NbackTask : Form
    {
        NBackTask nback;
        List<String> sequence;
        int iteration = -1;
        System.Timers.Timer mainTimer;
        Stopwatch stopwatch;
        int turn = -1;

        public NbackTask()
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

            System.Timers.Timer timer = new System.Timers.Timer { Interval = 200 };
            timer.Enabled = true;
            timer.AutoReset = false;
            if (nback.CheckAnswer(iteration - turn) == true)   //correct
            {
                nback.AddAnswer(new Answer(true, true, stopwatch.ElapsedMilliseconds));
                picTop.BackColor = Color.Green;
                picBottom.BackColor = Color.Green;
            }
            else                                        //wrong
            {
                nback.AddAnswer(new Answer(true, false, stopwatch.ElapsedMilliseconds));
                picTop.BackColor = Color.Red;
                picBottom.BackColor = Color.Red;
            }
            timer.Elapsed += OnTimerEvent;
            turn--;
            if (turn < 0)
            {
                butPositive.Enabled = false;
                butNegative.Enabled = false;
            }
        }

        private void butNegative_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            
            System.Timers.Timer timer = new System.Timers.Timer { Interval = 200 };
            timer.Enabled = true;
            timer.AutoReset = false;
            if (nback.CheckAnswer(iteration - turn) == true)   //wrong
            {
                nback.AddAnswer(new Answer(false, false, stopwatch.ElapsedMilliseconds));
                picTop.BackColor = Color.Red;
                picBottom.BackColor = Color.Red;
            }
            else                                        //correct
            {
                nback.AddAnswer(new Answer(false, true, stopwatch.ElapsedMilliseconds));
                picTop.BackColor = Color.Green;
                picBottom.BackColor = Color.Green;
            }
            timer.Elapsed += OnTimerEvent;
            turn--;
            if (turn < 0)
            {
                butPositive.Enabled = false;
                butNegative.Enabled = false;
            }
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

        delegate void SetLabelTextCallback(String text);
        public void SetLabelText(String number)
        {
            if (this.labNumber.InvokeRequired)
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabelText);
                Invoke(d, new object[] { number });
            }
            else
            {
                butPositive.Enabled = true;
                butNegative.Enabled = true;
                labNumber.Text = number;
            }
        }

        private void NextNumberEvent(object sender, EventArgs e)
        {
            if (sequence.Count - 1 == iteration)
            {
                mainTimer.Stop();
                ShowEndingScreen();
                return;
            }

            iteration++;
            turn++;
            SetLabelText(sequence[iteration]);
            Thread.Sleep(844);
            stopwatch.Reset();
            stopwatch.Start();
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
            nback.CreateReport();
            Application.Exit();
        }
        
        private void butTest1_Click(object sender, EventArgs e)
        {
            StartTest("15123535242978768131", 2);
        }
        
        private void butTest2_Click(object sender, EventArgs e)
        {
            StartTest("23245454797616434321", 2);
        }
        
        private void butTest3_Click(object sender, EventArgs e)
        {
            StartTest("23224564564589729732", 3);
        }
        
        private void butTest4_Click(object sender, EventArgs e)
        {
            StartTest("23452379817921672867", 4);
        }

        private void butTest5_Click(object sender, EventArgs e)
        {
            StartTest("23456237592145945479", 5);
        }

        private void StartTest(String seq, int n)
        {
            if (textBoxName.Text == "")
            {
                return;
            }

            Char[] numbers = seq.ToCharArray();
            List<String> numToStr = new List<String>();
            foreach (Char num in numbers)
            {
                numToStr.Add(num.ToString());
            }
            nback.StartTest(textBoxName.Text, n, numToStr);

            sequence = numToStr;

            butTest1.Visible = false;
            butTest2.Visible = false;
            butTest3.Visible = false;
            butTest4.Visible = false;
            butTest5.Visible = false;
            butPositive.Visible = true;
            butNegative.Visible = true;
            labNumber.Visible = true;
            labName.Visible = false;
            textBoxName.Visible = false;

            mainTimer = new System.Timers.Timer { Interval = 3000 };
            mainTimer.Enabled = true;
            mainTimer.Elapsed += NextNumberEvent;
            mainTimer.Start();
        }
    }
}
