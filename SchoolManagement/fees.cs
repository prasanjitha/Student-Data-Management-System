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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          


            if (textBox1.Text!="")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID='" + textBox1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if(ds.Tables[0].Rows.Count != 0)
                {
                    label6.Text = ds.Tables[0].Rows[0][0].ToString();
                    label7.Text = ds.Tables[0].Rows[0][1].ToString();
                    label8.Text = ds.Tables[0].Rows[0][2].ToString();
                }
                
            }
            else
            {
                label6.Text = "_________";
                label7.Text = "_________";
                label8.Text = "_________";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from fees where NAID='" + textBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "insert into fees (NAID,fees) values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                if (MessageBox.Show("Fees Submission successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label6.Text = "_________";
                    label7.Text = "_________";
                    label8.Text = "_________";
                }
            }
            else
            {
                MessageBox.Show("Fees is Already Submitd.");
                

                }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
