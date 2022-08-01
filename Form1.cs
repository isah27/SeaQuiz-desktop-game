using System;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class Form1 : Form
    {
        FormAddQuestion fab;
        FormSearchQuestion fsb;
        public Form1()
        {
            InitializeComponent();
            fab = new FormAddQuestion();
            fsb = new FormSearchQuestion();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            fab.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            fsb.Show();
            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
