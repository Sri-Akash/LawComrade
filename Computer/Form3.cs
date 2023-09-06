using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form3 : Form
    {

        SqlConnection con = new SqlConnection();
        SqlDataReader dataReader;
        SqlCommand com = new SqlCommand();


        public Form3()
        {
            InitializeComponent();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sri Akash\Maniraj Sir Project\Computer\Computer.mdf;Integrated Security=True;";
            con.Open();
            com.Connection = con;

            com.CommandText = "Select OptionName from Options";
            dataReader = com.ExecuteReader();

            while (dataReader.Read())
            {
                ConfigOpions.Items.Add(dataReader.GetValue(0));
            }
            dataReader.Close();


            com.CommandText = "Select Name from Room";
            dataReader = com.ExecuteReader();

            while (dataReader.Read())
            {
                AreaChoosingBox.Items.Add(dataReader.GetValue(0));
            }
            dataReader.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void AddBox_Click(object sender, EventArgs e)
        {
            if (AreaChoosingBox.SelectedItem == null || SearchName.Text == null || ConfigOpions.CheckedItems.Count == 0)
                MessageBox.Show("Please fill out all the field.");
            else
            {
                foreach (var item in ConfigOpions.CheckedItems)
                {
                    com.CommandText = "INSERT INTO SetUpConfig(Room_Category, Name, Config_Options) VALUES('" + AreaChoosingBox.SelectedItem + "', '" + SearchName.Text + "', '" + item + "')";
                    com.ExecuteNonQuery();
                }

                MessageBox.Show("Option(s) added successfully.");

                AreaChoosingBox.SelectedItem = null;
                SearchName.Text = "";
                for (int i = 0; i < ConfigOpions.Items.Count; i++)
                {
                    ConfigOpions.SetItemCheckState(i, CheckState.Unchecked);
                }

            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            AreaChoosingBox.SelectedItem = null;
            SearchName.Text = null;
            for (int i = 0; i < ConfigOpions.Items.Count; i++)
            {
                ConfigOpions.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void but_home_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Hide();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
