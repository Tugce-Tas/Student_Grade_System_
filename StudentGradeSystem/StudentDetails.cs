using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentGradeSystem
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public string number2;

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T00O72S;Initial Catalog=DBStudentGradeSystem;Integrated Security=True");
       
        private void StudentDetails_Load(object sender, EventArgs e)
        {
           number.Text = number2;
           baglanti.Open();
           SqlCommand cmd = new SqlCommand("Select * from TBLCLASS where NUMBER=@P1", baglanti);
            cmd.Parameters.AddWithValue("@p1", number2);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                namesurname.Text = reader[2].ToString() + " " + reader[3].ToString();
                exam1.Text = reader[4].ToString();
                exam2.Text = reader[5].ToString();
                exam3.Text = reader[6].ToString();
                lblaverage.Text = reader[7].ToString();
                if (!lblaverage.Text.Equals(""))
                    lblsituation.Text = reader[8].ToString() == "True" ? "Passed" : "Failed";
                else
                    lblsituation.Text = "";
            }
            baglanti.Close();
        }

    }
}
