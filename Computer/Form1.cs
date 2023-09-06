using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand com = new SqlCommand();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sri Akash\Maniraj Sir Project\Computer\Computer.mdf;Integrated Security=True;";
            con.Open();
            com.Connection = con;

            if (OptionBox.Text == "")
                MessageBox.Show("Please fill out the field.");
            else
            {
                com.CommandText = "insert into Options(OptionName) values('" + OptionBox.Text + "')";
                com.ExecuteNonQuery();
                MessageBox.Show("Option Added");

                OptionBox.Clear();
            }

            con.Close();
        }

        private void but_home_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Hide();
        }

        private void Mainheading_Click(object sender, EventArgs e)
        {

        }
    }
}
