using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC_Manager
{
    public partial class Form2 : Form
    {
        // This variable will be the loop counter.  
        private int counter;

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            counter = 0;
            timer1.Interval = 600;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (counter >= 10)
            {
                // Exit loop code.  
                timer1.Enabled = false;
                counter = 0;
            }
            else
            {
                // Run your procedure here.  
                // Increment counter.  
                counter = counter + 1;
                label1.Text = "Procedures Run: " + counter.ToString();
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InitializeTimer();
        }
    }
}
