using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form2 : Form
    {

        string check;
        SqlDataAdapter adapter;
        DataTable dt;

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form2()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sri Akash\Maniraj Sir Project\Computer\Computer.mdf;Integrated Security=True;";
            con.Open();
            com.Connection = con;

            adapter = new SqlDataAdapter(@"select Category,Name from Room;", con);
            dt = new DataTable();
            adapter.Fill(dt);
            roomList.DataSource = dt;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
        }

        private void AddName_Click(object sender, EventArgs e)
        { 

            if (NameBox.Text == "")
                MessageBox.Show("Please fill out the field.");
            else
            {
                if (Room.Checked == true)
                    check = Room.Text;
                else if (Area.Checked == true)
                    check = Area.Text;
                com.CommandText = "INSERT INTO Room(Category, Name) VALUES ('" + check + "', '" + NameBox.Text + "')";
                com.ExecuteNonQuery();
                if (check.ToLower() == "room")
                    MessageBox.Show("Room Added");
                else
                    MessageBox.Show("Area Added");
                Room.Checked = false;
                Area.Checked = false;
                NameBox.Text = null;
            }

            con.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            Room.Checked = false;
            Area.Checked = false;
            NameBox.Text = null;
        }

        private void but_home_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Hide();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
