using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJump {
    public partial class JumpForm : Form {
        public JumpForm() {
            InitializeComponent();
        }

        private void JumpForm_Load(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            Top = 0;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }

        private void button4_Click(object sender, EventArgs e) {
            Left = 0;
            Top = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void button2_Click(object sender, EventArgs e) {
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }
    }
}
