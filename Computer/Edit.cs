using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Computer
{
    public partial class Edit : Form
    {

        SqlConnection con = new SqlConnection();
        SqlDataReader dataReader;
        SqlCommand com = new SqlCommand();

        private string deviceName;
        private List<string> configurations;
        private string roomCategory;

        public Edit(string deviceName, List<string> configurations)
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

            this.deviceName = deviceName;
            this.configurations = configurations;

            SearchName.Text = deviceName;
            ConfigOpions.ClearSelected();
            foreach (string config in configurations)
            {
                int index = ConfigOpions.Items.IndexOf(config);
                if (index >= 0)
                {
                    ConfigOpions.SetItemChecked(index, true);
                }
            }

            com.CommandText = "SELECT Room_Category FROM SetUpConfig WHERE Name = @deviceName";
            com.Parameters.AddWithValue("@deviceName", deviceName); 
            dataReader = com.ExecuteReader();
            if (dataReader.Read())
            {
                roomCategory = dataReader["Room_Category"].ToString();

            }
            dataReader.Close();

            foreach (var item in AreaChoosingBox.Items)
            {
                if (item.ToString() == roomCategory)
                {
                    AreaChoosingBox.SelectedItem = item;
                    break;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void but_update_Click(object sender, EventArgs e)
        {
            /*if (AreaChoosingBox.SelectedItem == null || SearchName.Text == null || ConfigOpions.CheckedItems.Count == 0)
                MessageBox.Show("Please fill out all the field.");
            else
            {
                foreach (var item in ConfigOpions.CheckedItems)
                {
                    com.CommandText = "INSERT INTO SetUpConfig(Room_Category, Name, Config_Options) VALUES('" + AreaChoosingBox.SelectedItem + "', '" + SearchName.Text + "', '" + item + "')";
                    com.ExecuteNonQuery();
                }

                MessageBox.Show("Option(s) updated successfully.");

                AreaChoosingBox.SelectedItem = null;
                SearchName.Text = "";
                for (int i = 0; i < ConfigOpions.Items.Count; i++)
                {
                    ConfigOpions.SetItemCheckState(i, CheckState.Unchecked);
                }
            }*/

            if (AreaChoosingBox.SelectedItem == null || string.IsNullOrEmpty(SearchName.Text) || ConfigOpions.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {
                string updatedDeviceName = SearchName.Text;
                string updatedRoomCategory = AreaChoosingBox.SelectedItem.ToString();

                com.CommandText = "UPDATE SetUpConfig SET Room_Category = @roomCategory WHERE Name = @dN";
                com.Parameters.AddWithValue("@roomCategory", updatedRoomCategory);
                com.Parameters.AddWithValue("@dN", deviceName);
                com.ExecuteNonQuery();

                com.CommandText = "DELETE FROM SetUpConfig WHERE Name = @Name";
                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Name", updatedDeviceName);
                com.ExecuteNonQuery();

                foreach (var item in ConfigOpions.CheckedItems)
                {
                    com.CommandText = "INSERT INTO SetUpConfig(Room_Category, Name, Config_Options) VALUES(@roomCategory, @device, @configOption)";
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@roomCategory", updatedRoomCategory);
                    com.Parameters.AddWithValue("@device", updatedDeviceName);
                    com.Parameters.AddWithValue("@configOption", item);
                    com.ExecuteNonQuery();
                }

                MessageBox.Show("Data updated successfully.");

                DialogResult = DialogResult.OK;
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

        private void but_back_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
    }
}
