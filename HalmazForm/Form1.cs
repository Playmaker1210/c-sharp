using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalmazForm {
    public partial class Form1 : Form {
        Random random = new Random();
        
        public Form1() {
            InitializeComponent();
        }
        
        private void HalmazGeneral(ListBox lb, int n) {
            int elem;
            lb.Items.Clear();

            for (int i = 0; i < n; i++) {
                do {
                    elem = random.Next(n * 5);
                } while (Bennevan(lb, elem));
                lb.Items.Add(elem);
            }
        }

        private bool Bennevan(ListBox lb, object elem) {
            for (int i = 0; i < lb.Items.Count; i++) {
                if (lb.Items[i].Equals(elem)) {
                    return true;
                }
            }
            return false;
        }

        private void UnioCalc(ListBox a, ListBox b, ListBox unio) {
            unio.Items.Clear();
            for (int i = 0; i < a.Items.Count; i++) {
                if(!Bennevan(unio, a.Items[i])) {
                    unio.Items.Add(a.Items[i]);
                }
            }
            for (int i = 0; i < b.Items.Count; i++) {
                if (!Bennevan(unio, b.Items[i])) {
                    unio.Items.Add(b.Items[i]);
                }
            }
        }

        private void MetszetCalc(ListBox a, ListBox b, ListBox metszet) {
            metszet.Items.Clear();
            for (int i = 0; i < a.Items.Count; i++) {
                if (Bennevan(b, a.Items[i])) {
                    metszet.Items.Add(a.Items[i]);
                }
            }
        }

        private void KulonbsegCalc(ListBox a, ListBox b, ListBox kulonbseg) {
            kulonbseg.Items.Clear();
            for (int i = 0; i < a.Items.Count; i++) {
                if (!Bennevan(b, a.Items[i])) {
                    kulonbseg.Items.Add(a.Items[i]);
                }
            }
        }

        

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            HalmazGeneral(A, (int)numericUpDown2.Value);
            HalmazGeneral(B, (int)numericUpDown1.Value);
            MetszetCalc(A, B, Metszet);
            UnioCalc(A, B, Unio);
            KulonbsegCalc(A, B, CsakA);
            KulonbsegCalc(B, A, CsakB);
        }
    }
}
