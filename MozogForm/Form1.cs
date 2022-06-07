using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozogForm {
    public partial class Form1 : Form {
        private const int MOVE_SIZE = 10;
        
        public Form1() {
            InitializeComponent();
        }

        private void buttonFSZ_Click(object sender, EventArgs e) {
            Top = 0;
        }

        private void buttonF_Click(object sender, EventArgs e) {
            Top -= MOVE_SIZE;
            if (Top < 0) {
                Top = 0;
            } else if (Top > Screen.PrimaryScreen.WorkingArea.Height - Height) {
                Top = Screen.PrimaryScreen.WorkingArea.Height - Height;
            }
        }
    }
}
