using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel2.Height = 89;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            NewAdmission na = new NewAdmission();
            na.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            if (username == "student" && password == "student")
            {
               panel5.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalied userName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      private void toolStripMenuItem2ToolSripDropDownMenutoolStripMenuItem1_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            NewAdmission na = new NewAdmission();
            na.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upgradeSemester up = new upgradeSemester();
            up.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fees f = new fees();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            searchStudent sd = new searchStudent();
            sd.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IndividualDetails id = new IndividualDetails();
            id.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddTeachersInformation at = new AddTeachersInformation();
            at.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SearchTeachers st = new SearchTeachers();
            st.Show();
           // menu m = new menu();
          //  m.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (panel2.Height == 142)
            {
                panel2.Height = 89;
           }
            else
           {
               panel2.Height = 142;
           }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Height = 89;
            panel3.Height = 89;
            panel4.Height = 89;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 142)
            {
                panel3.Height = 89;
            }
            else
            {
                panel3.Height = 142;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NewAdmission ad = new NewAdmission();
            ad.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (panel4.Height == 142)
            {
                panel4.Height = 89;
            }
            else
            {
                panel4.Height = 142;
            }

        }
    }
}
