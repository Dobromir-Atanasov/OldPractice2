using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeCatchMeGame
{
    public partial class Form1 : Form
    {
        int attempts = 1;
        string msg = "You've got me at the first click!";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            btnCatchMe.Text = " :( ";
            System.Media.SystemSounds.Asterisk.Play();
            MessageBox.Show(msg);
        }

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - btnCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - btnCatchMe.ClientSize.Height;
            this.btnCatchMe.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            attempts++;
            msg = "You've clicked " + attempts + " times!";
            System.Media.SystemSounds.Beep.Play();
        }
    }
}
