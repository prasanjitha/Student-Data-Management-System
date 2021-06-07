using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class NewAdmission : Form
    {
        public NewAdmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fullName = textFullName.Text;
            String mname = textMother.Text;
            String gender = "";
            bool ischecked = radioButtonMale.Checked;
            if (ischecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text; 
            }
            String dob = dateTimePickerBirthday.Text;
            Int64 mobile = Int64.Parse(textBoxMobile.Text);
            String email = textBoxEmail.Text;
            String semester = comboBoxSem.Text;
            String program = comboBoxProgramming.Text;
            String schoolName = textBoxSchool.Text;
            String address = richTextBoxAddress.Text;
            String duration = comboBoxDuration.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into NewAdmission (fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres) " +
                "values('" + fullName + "','" + mname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + program + "','" + schoolName + "','" + duration + "','" + address + "')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            MessageBox.Show("Data Saved. Remember thr registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxMobile.Clear();
            textBoxSchool.ResetText();
            textFullName.Clear();
            textMother.Clear();
            richTextBoxAddress.Clear();
            comboBoxDuration.ResetText();
            comboBoxProgramming.ResetText();
            comboBoxSem.ResetText();
            dateTimePickerBirthday.ResetText();
        }

        private void NewAdmission_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from NewAdmission";
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Int64 abc = Convert.ToInt64
                (ds.Tables[0].Rows[0][0]);
            label13.Text = (abc+1).ToString();
        }
    }
}
