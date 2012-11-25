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
    public partial class frmStudentDetails : Form
    {
        //Creating a singleton instance of the form
        private static frmStudentDetails studentDetails;
       
        Student objStudent = new Student();

        public frmStudentDetails()
        {
            InitializeComponent();
        }

        public static frmStudentDetails GetStudentDetailsForm
        {
            get { return studentDetails; }
            set { studentDetails = value; }
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmStudentRegistration objStudentRegistration = new frmStudentRegistration();
            objStudentRegistration.MdiParent = this.MdiParent;
            objStudentRegistration.Show();
            
           
            this.Hide();
        }

        private void frmStudentDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool blnResult = objStudent.SaveStudent(GetValuesFromDataGridView());
        }

        //Reading values in the data grid and assigning values to student object
        private List<StudentProperty> GetValuesFromDataGridView()
        {
            List<StudentProperty> objStudentPropertyList = new List<StudentProperty>();

            for (int i = 0; i <= gvStudentDetails.Rows.Count - 1; i++)
            {
                StudentProperty objStudentProperty = new StudentProperty();
                objStudentProperty.Active = Convert.ToBoolean(gvStudentDetails.Rows[i].Cells[4].Value.ToString());
                objStudentProperty.DOB = Convert.ToDateTime(gvStudentDetails.Rows[i].Cells[2].Value.ToString());
                objStudentProperty.GradePointAvg = (decimal)gvStudentDetails.Rows[i].Cells[3].Value;
                objStudentProperty.Name = gvStudentDetails.Rows[i].Cells[1].Value.ToString();
                objStudentProperty.StudentID = gvStudentDetails.Rows[i].Cells[0].Value.ToString();

                //Adding sdtudent objects to list
                objStudentPropertyList.Add(objStudentProperty);
            }

            return objStudentPropertyList;
        }

        public void LoadDataToGrid(List<StudentProperty> objStudentList)
        {
            //binding student generic list object to datagrid
            gvStudentDetails.DataSource = null;
            gvStudentDetails.DataSource = objStudentList;
        }

    }
}
