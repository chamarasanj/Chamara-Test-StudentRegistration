using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using System.Data.SqlClient;


namespace BussinessLogicLayer
{

    public class Student
    {

        DataAccessMain objDataAccess = new DataAccessMain();

        public int GetNextStudentID()
        {
            int intNextStudentID = 0;

            SqlCommand comm = new SqlCommand();

            //Stored procedure name
            comm.CommandText = "Sp_GetNextStudentID";

            try
            {
                //getting the next student id from database
                intNextStudentID = objDataAccess.GetScalerValue(comm);
            }
            catch (Exception)
            {
                throw;
            }

            return intNextStudentID;
        }

        //saving or editing student
        public bool SaveStudent(List<StudentProperty> list)
        {
            bool blnResult = false;

            foreach (StudentProperty student in list)
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SP_ManageStudent";
                comm.Parameters.AddWithValue("@Active", student.Active);
                comm.Parameters.AddWithValue("@DOB", student.DOB);
                comm.Parameters.AddWithValue("@GradePointAvg", student.GradePointAvg);
                comm.Parameters.AddWithValue("@Name", student.Name);
                comm.Parameters.AddWithValue("@StudentID", student.StudentID);

                blnResult = objDataAccess.ExecuteSqlCommand(comm);

            }
            return blnResult;
        }
    }
}
