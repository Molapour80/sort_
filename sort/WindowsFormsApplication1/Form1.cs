using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] n = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
                n[i] = int.Parse( listBox1.Items[i].ToString());

            Array.Sort(n);

            listBox2.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox2.Items.Add(n[i]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] n = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
                n[i] = int.Parse(listBox1.Items[i].ToString());

            Array.Sort(n);
            Array.Reverse(n);

            listBox2.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox2.Items.Add(n[i]);
        }
    }
}
