using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triple_Machine
{
    public partial class frmTriple : Form
    {
        public frmTriple()
        {
            InitializeComponent();
        }

        private void btnTriple_Click(object sender, EventArgs e)
        {
            lblOuput.Text = "";
            string userInput = txtInput.Text;
            double Input = 0;
            try
            {
                Input = double.Parse(userInput);
                lblOuput.Text = (Input * 3).ToString();
            }
            catch (Exception ex)
            {
                lblOuput.Text = ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOuput.Text = "";
            txtInput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            const string message = "Do you want to exit?";
            const string caption = "Exit";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
