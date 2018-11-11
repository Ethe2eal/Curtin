using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPARQLDemo
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your feedback!");
            this.Close();
            
        }


    }
}
