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
    public partial class IndividualDetails : Form
    {
        public IndividualDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-NRMHQ6P3;database=collage;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from NewAdmission where NAID='"+textBox1.Text+"'";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                label14.Text = ds.Tables[0].Rows[0][1].ToString();
                label15.Text = ds.Tables[0].Rows[0][2].ToString();
                label16.Text = ds.Tables[0].Rows[0][3].ToString();
                label17.Text = ds.Tables[0].Rows[0][4].ToString();
                label18.Text = ds.Tables[0].Rows[0][5].ToString();
                label19.Text = ds.Tables[0].Rows[0][6].ToString();
                label20.Text = ds.Tables[0].Rows[0][7].ToString();
                label21.Text = ds.Tables[0].Rows[0][8].ToString();
                label22.Text = ds.Tables[0].Rows[0][9].ToString();
                label23.Text = ds.Tables[0].Rows[0][10].ToString();
                label24.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("NO Record found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label14.Text = "__________";
            label15.Text = "__________";
            label16.Text = "__________";
            label17.Text = "__________";
            label18.Text = "__________";
            label19.Text = "__________";
            label20.Text = "__________";
            label21.Text = "__________";
            label22.Text = "__________";
            label23.Text = "__________";
            label24.Text = "__________";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
