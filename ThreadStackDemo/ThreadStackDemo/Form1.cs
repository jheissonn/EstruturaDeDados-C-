using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace ThreadStackDemo
{
    //Referência para estudos: Diferenças entre List, LinkedList, Arrays, ArrayList, Stack, Queue
    public partial class Form1 : Form
    {
        List<Thread> lt = new List<Thread>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lt.Add(new Thread(() => ThreadStack(richTextBox1)));
            lt.Add(new Thread(() => ThreadStack(richTextBox2)));
            lt.Add(new Thread(() => ThreadStack(richTextBox3)));
            lt.Add(new Thread(() => ThreadStack(richTextBox4)));
        }

        private static void UpdateRichText(RichTextBox rt, Stack<int> s)
        {
            rt.Clear();
            foreach (int i in s)
            {
                rt.AppendText(i.ToString() + Environment.NewLine);
            }

        }
        private void ThreadStack(RichTextBox rt)
        {
            Stack<int> s = new Stack<int>();
            Random r = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            Random op = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            

            while (true)
            {
                if (op.Next(2) == 0 && s.Count != 0)
                {
                    s.Pop();

                }
                else
                {
                    s.Push(r.Next(1, 1001));
                }

                if (rt.InvokeRequired)
                {
                    MethodInvoker m = new MethodInvoker(() => UpdateRichText(rt, s));
                    rt.Invoke(m);
                }
                else
                {
                    UpdateRichText(rt, s);
                }

                Thread.Sleep(500);
                Application.DoEvents();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Thread t in lt)
            {
                t.Start();
                Thread.Sleep(500);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Thread t in lt)
            {
                t.Suspend();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Thread t in lt)
            {
                t.Resume();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Thread t in lt)
            {
                t.Abort();
            }

        }
    }
}
