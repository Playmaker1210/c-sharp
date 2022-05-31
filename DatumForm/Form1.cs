using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumForm {
    public partial class Form1 : Form {
        private int ev = 0;
        private int honap = 0;
        private int nap = 0;
        private int ora = 0;
        private int perc = 0;
        private int mp = 0;
        
        public Form1() {
            InitializeComponent();
        }

        private void oraUpdate() {
            mtbPerc.Text = String.Format("{0}:{1}:{2}", dtpNaptar.Value.Hour + (int)numericUpDown1.Value, dtpNaptar.Value.Minute + (int)numericUpDown2.Value, dtpNaptar.Value.Second + (int)numericUpDown3.Value);
        }

        private void Form1_Load(object sender, EventArgs e) {
            oraUpdate();
        }

        private void button1_Click(object sender, EventArgs e) {
            /*ev = Convert.ToInt32(numericUpDown4.Value + dtpNaptar.Value.Year);
            Label.Text = String.Format("{0}.", ev);
            honap = Convert.ToInt32(numericUpDown5.Value + dtpNaptar.Value.Month);
            Label.Text += String.Format("{0}.", honap);
            nap = Convert.ToInt32(numericUpDown6.Value + dtpNaptar.Value.Day);
            Label.Text += String.Format("{0}.", nap);*/

            oraUpdate();
            
            dtpNaptar.Value = dtpNaptar.Value.AddYears((int)numericUpDown4.Value);
            Label.Text = dtpNaptar.Value.Year.ToString() + ".";
            dtpNaptar.Value = dtpNaptar.Value.AddMonths((int)numericUpDown5.Value);
            Label.Text += dtpNaptar.Value.Month.ToString() + ".";
            dtpNaptar.Value = dtpNaptar.Value.AddDays((int)numericUpDown6.Value);
            Label.Text += dtpNaptar.Value.Day.ToString() + ".";      
        }
    }
}
