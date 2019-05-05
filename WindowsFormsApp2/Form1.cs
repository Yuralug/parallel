using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        




        private void Button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();   
          int  count = Convert.ToInt32(textBox1.Text);
            List<Thread> threads = new List<Thread>();
           
                for (int i = 0; i < count; i++)
                {

                    threads.Add(new Thread(Method));
                    threads[i].IsBackground = true;
                    threads[i].Start();

                                       
                }
            }
        

            private void Method()
            {
                while (progressBar1.Value<1000)
                {
                Random rand = new Random();
                int k = rand.Next(5);
                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value+=k));
                Thread.Sleep(30);
                
            }
            }
        }
    }

