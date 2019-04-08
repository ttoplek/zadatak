using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Diagnostics.Stopwatch sat = new System.Diagnostics.Stopwatch();
        string recenica;
        private void buttonUnos_Click(object sender, EventArgs e)
        {
            
            recenica = textBoxRecenica.Text;

        }
        
        private void textBoxPretipkavanja_TextChanged(object sender, EventArgs e)
        {
            
            
            
            if (recenica == textBoxPretipkavanja.Text)
            {
                sat.Stop();
                textBoxPretipkavanja.Clear();
                textBoxRecenica.Clear();
                labelTime.Text = sat.Elapsed.TotalSeconds.ToString();

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            sat.Reset();
            sat.Start();
                      
        }
    }
}
