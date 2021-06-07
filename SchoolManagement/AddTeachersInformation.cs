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
    public partial class AddTeachersInformation : Form
    {
        public AddTeachersInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool ischecked = radioButton1.Checked;
            if (ischecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,yer,adr) values" +
                " ('"+textBox1.Text+ "','" + gender + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"' ,'" +comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + richTextBox1.Text + "')";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Inserted! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
