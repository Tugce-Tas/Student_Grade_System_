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
    public partial class TeacherDetails : Form
    {
        public TeacherDetails()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T00O72S;Initial Catalog=DBStudentGradeSystem;Integrated Security=True");



        private void TeacherDetails_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBStudentGradeSystemDataSet.TBLCLASS' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLCLASSTableAdapter.Fill(this.dBStudentGradeSystemDataSet.TBLCLASS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLCLASS (NUMBER, NAME, SURNAME) values (@P1, @P2, @P3)", baglanti);
            cmd.Parameters.AddWithValue("@P1", MskNumber.Text);
            cmd.Parameters.AddWithValue("@P2", LblName.Text);
            cmd.Parameters.AddWithValue("@P3", LblSurname.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("The student has been successfully added");
            this.tBLCLASSTableAdapter.Fill(this.dBStudentGradeSystemDataSet.TBLCLASS);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosed = dataGridView1.SelectedCells[0].RowIndex;
            MskNumber.Text = dataGridView1.Rows[choosed].Cells[1].Value.ToString();
            LblName.Text = dataGridView1.Rows[choosed].Cells[2].Value.ToString();
            LblSurname.Text = dataGridView1.Rows[choosed].Cells[3].Value.ToString();
            LblExam1.Text = dataGridView1.Rows[choosed].Cells[4].Value.ToString();
            LblExam2.Text = dataGridView1.Rows[choosed].Cells[5].Value.ToString();
            LblExam3.Text = dataGridView1.Rows[choosed].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double average, e1, e2, e3;
            string situation;

            e1 = Convert.ToDouble(LblExam1.Text);
            e2 = Convert.ToDouble(LblExam2.Text);
            e3 = Convert.ToDouble(LblExam3.Text);

            average = (e1 + e2 + e3) / 3; 
            LblAverage.Text = average.ToString();

            situation = average >= 50 ? "True" : "False";

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update TBLCLASS set EXAM1=@P1, EXAM2=@P2, EXAM3=@P3, AVERAGE=@P4, SITUATION=@P5 WHERE NUMBER=@P6", baglanti);
            cmd.Parameters.AddWithValue("@P1", LblExam1.Text);
            cmd.Parameters.AddWithValue("@P2", LblExam2.Text);
            cmd.Parameters.AddWithValue("@P3", LblExam3.Text);
            cmd.Parameters.AddWithValue("@P4", decimal.Parse(LblAverage.Text));
            cmd.Parameters.AddWithValue("@P5", situation);
            cmd.Parameters.AddWithValue("@P6", MskNumber.Text);

            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Grades updated succesfully!");
            this.tBLCLASSTableAdapter.Fill(this.dBStudentGradeSystemDataSet.TBLCLASS);

        }
    }
}
