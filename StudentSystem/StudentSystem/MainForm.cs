using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void newRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudentDetails objFrmStudentDetails = new frmStudentDetails();
           // objFrmStudentDetails.mdich
            objFrmStudentDetails.MdiParent = this;
            objFrmStudentDetails.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
