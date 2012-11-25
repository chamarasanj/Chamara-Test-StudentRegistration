using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogicLayer;

namespace StudentSystem
{
    public partial class frmStudentRegistration : Form
    {

        Student objStudent = new Student();
        List<StudentProperty> objStudentList = new List<StudentProperty>();
        frmStudentDetails objFrmStudentDetails = new frmStudentDetails();
       
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            int intStudentNumber = 0;
            try
            {
                //getting the next Student ID 
                intStudentNumber = objStudent.GetNextStudentID();
              //  this.Top = 300;
                this.Left = 700;
              
            }
            catch (Exception)
            {
                
                throw;
            }

            lblStudentID.Text = intStudentNumber.ToString ();
        }

     

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Adding Student objects to Student Generic List
            objStudentList.Add(GetValuesFromControls());

            if (frmStudentDetails.GetStudentDetailsForm == null)
            {
                frmStudentDetails.GetStudentDetailsForm = new frmStudentDetails();
                frmStudentDetails.GetStudentDetailsForm.MdiParent = this.MdiParent;
                
                frmStudentDetails.GetStudentDetailsForm.Show();
                frmStudentDetails.GetStudentDetailsForm.LoadDataToGrid(objStudentList);
            }
            else
            {
                frmStudentDetails.GetStudentDetailsForm.Focus();
                frmStudentDetails.GetStudentDetailsForm.LoadDataToGrid(objStudentList);
            }

            //incrementing student id by 1 and assgning it to the label
            int intStudentNumericID = int.Parse(lblStudentID.Text);
            intStudentNumericID = 1 + intStudentNumericID;
            lblStudentID.Text = intStudentNumericID.ToString();

            //intializing control values
            ClearControls();
           
        }

        private void ClearControls()
        {
            txtGPA.Text = "0.0";
            txtName.Text = string.Empty;
            dtpDOB.Value = DateTime.Today;
            chkActive.Checked = false;
        }

        //Getting control values and assigning values to Student object
        private StudentProperty GetValuesFromControls()
        {
            StudentProperty objStudentProp = new StudentProperty();

            objStudentProp.DOB = dtpDOB.Value;

            decimal decGPA;

            //Checking whether the GPA value is a decimal value
            bool blnGPA = decimal.TryParse(txtGPA.Text, out decGPA);
            if (blnGPA)
            {
                objStudentProp.GradePointAvg = decimal.Parse(txtGPA.Text);
            }
            else
            {
                MessageBox.Show("Invalid GPA");
                txtGPA.Focus();
                txtGPA.Text = "0.0";
            }

            objStudentProp.Name = txtName.Text;
            objStudentProp.StudentID = lblStudentID.Text;
            objStudentProp.Active = chkActive.Checked;

            return objStudentProp;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();
        }
        private bool ValidateName()
        {
            bool bStatus = true;
            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Please enter your Name");
                bStatus = false;
            }
            else
                errorProvider1.SetError(txtName, "");
            return bStatus;
        }
    }
}
