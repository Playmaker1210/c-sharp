using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikusForm {
    public partial class Form1 : Form {
        private Random random = new Random();

        private double atlag;
        private int osszeg;
        private int db;
        private int min = Int32.MaxValue;
        private int max = Int32.MinValue;
        
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e) {
            int i = random.Next(Int16.MinValue, Int16.MaxValue);
            Label label = new Label();
            label.Location = new Point(e.X, e.Y);
            label.Text = i.ToString();
            label.AutoSize = true;
            Controls.Add(label);
            db++;
            osszeg += i;
            atlag = osszeg / (double)db;
            if (min > i) min = i;
            if (max < i) max = i;
            label1.Text = String.Format("Darabszam: {0}, összeg: {1}, átlag: {2}, minimum: {3}, maximum: {4} ", db, osszeg, Math.Round(atlag,2), min, max);
        }
    }
}
