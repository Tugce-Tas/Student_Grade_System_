using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentDetails studentDetails = new StudentDetails();
            studentDetails.number2 = loginNumber.Text;  
            studentDetails.Show();
        }

        private void loginNumber_TextChanged(object sender, EventArgs e)
        {
            if (loginNumber.Text == "1111")
            {
                TeacherDetails teacherDetails = new TeacherDetails();
                teacherDetails.Show();
            }
        }
        /*
        private void loginNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (loginNumber.Text == "1111")
            {
                TeacherDetails teacherDetails = new TeacherDetails();
                teacherDetails.Show();
            }
        }*/
    }
}
