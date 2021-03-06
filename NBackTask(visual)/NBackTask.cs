﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using System.IO;
using System.Net.Mail;

namespace NBackTask
{
    public class NBackTask
    {
        private List<System.IO.UnmanagedMemoryStream> sounds;
        private List<System.IO.UnmanagedMemoryStream> soundSequence;
        private List<String> sequence;
        private int n;
        private List<Answer> answer;
        private int sequenceSize;
        private String name;


        public NBackTask()
        {
            sequence = new List<String>();
            answer = new List<Answer>();
            soundSequence = new List<System.IO.UnmanagedMemoryStream>();
            sounds = new List<System.IO.UnmanagedMemoryStream>();
            sequenceSize = 20;
        }

        private void AddAnswers()
        {
            List<int> skip = new List<int>();
            int answer;
            Random rnd = new Random();
            for (int i = 0; i < sequenceSize - n; i++)
            {
                if (rnd.NextDouble() <= 0.1 && !skip.Contains(i))
                {
                    answer = rnd.Next(1, 9);
                    sequence[i] = answer.ToString();
                    sequence[i + n] = answer.ToString();
                    skip.Add(i + n);
                }
            }
        }

        private void GenerateSequence()
        {
            Random rnd = new Random();
            for (int i = 0 ; i < sequenceSize ; i++)
            {
                sequence.Add(rnd.Next(1, 9).ToString());
            }
        }

        private void LoadSounds()
        {
            sounds.Add(Properties.Resources._1);
            sounds.Add(Properties.Resources._2);
            sounds.Add(Properties.Resources._3);
            sounds.Add(Properties.Resources._4);
            sounds.Add(Properties.Resources._5);
            sounds.Add(Properties.Resources._6);
            sounds.Add(Properties.Resources._7);
            sounds.Add(Properties.Resources._8);
            sounds.Add(Properties.Resources._9);
        }

        private void ConvertNumbersToSounds()
        {
            foreach (String number in sequence)
            {
                soundSequence.Add(sounds[Convert.ToInt32(number) - 1]);
            }
        }

        private void SetSequence()
        {
            GenerateSequence();
            AddAnswers();
            LoadSounds();
            ConvertNumbersToSounds();
        }

        private void SetSequence(List<String> manualSeq)
        {
            AddManualSequence(manualSeq);
            LoadSounds();
            ConvertNumbersToSounds();
        }

        private void AddManualSequence(List<String> manualSeq)
        {
            sequence = manualSeq;
        }

        public List<System.IO.UnmanagedMemoryStream> GetSoundSequence()
        {
            return soundSequence;
        }

        public void StartTest(String name, int N)
        {
            n = N;
            this.name = name;
            SetSequence();
        }

        public void StartTest(String name, int N, List<String> manualSeq)
        {
            n = N;
            this.name = name;
            SetSequence(manualSeq);
        }

        public bool CheckAnswer(int iteration)
        {
            if (iteration < n)
            {
                return false;
            }

            if (sequence[iteration] == sequence[iteration - n])
                return true;
            else
                return false;
        }

        public void AddAnswer(Answer ans)
        {
            answer.Add(ans);
        }

        private int CalculeteCorrectAnswers()
        {
            return answer.Where(a => a.Correct == true).Count();
        }

        private int CalculeteIncorrectAnswers()
        {
            return answer.Where(a => a.Correct == false).Count();
        }

        public void CreateReport()
        {
            List<String> fileText = new List<String>();
            int i = 0;
            
            fileText.Add(DateTime.Now.ToString("yyyy-MM-dd H:mm") + " | N = " + n);

            foreach(var num in sequence)
            {
                if(answer.Count > i)
                {
                    fileText.Add(num + " " + answer[i].ToString());
                    Console.WriteLine(num + answer[i].ToString());
                    i++;
                }
                else
                {
                    fileText.Add(num);
                    Console.WriteLine(num);
                }
            }
            fileText.Add("Teisingai: " + CalculeteCorrectAnswers() + " Neteisingai: " + CalculeteIncorrectAnswers());
            fileText.Add("\n");
            File.AppendAllLines(name + ".txt", fileText);
            //SendReport(String.Join("\n", fileText));
        }

        private void SendReport(String body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("");
                mail.To.Add("");
                mail.Subject = "[NBackTask] " + name + " | N=" + n;
                mail.Body = body;

                Attachment attachment;
                attachment = new Attachment(name + ".txt");
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("", "");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        
    }
}
