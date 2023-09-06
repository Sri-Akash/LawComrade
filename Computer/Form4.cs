using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataReader dataReader;
        SqlCommand com = new SqlCommand();
        DataTable dt, dtt, det;
        SqlDataAdapter adap, bdap, cdap;


        public Form4()
        {
            InitializeComponent();
            SearchGroup.Hide();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Sri Akash\Maniraj Sir Project\Computer\Computer.mdf;Integrated Security=True;";
            con.Open();
            com.Connection = con;

            com.CommandText = "SELECT Name FROM Room";
            dataReader = com.ExecuteReader();

            while (dataReader.Read())
            {
                RoomSelection.Items.Add(dataReader.GetValue(0));
            }
            dataReader.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void RoomSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void NameSearchBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            manual_search();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RecordList.SelectedRows[0];
                string deviceName = selectedRow.Cells["DeviceName"].Value.ToString();

                List<string> configurations = new List<string>();
                foreach (DataGridViewColumn column in RecordList.Columns)
                {
                    if (column.HeaderText != "DeviceName" && Convert.ToString(selectedRow.Cells[column.Index].Value) == "✔")
                    {
                        configurations.Add(column.HeaderText);
                    }
                }

                Edit editForm = new Edit(deviceName, configurations);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RecordList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = RecordList.SelectedRows[0];

                    string deviceNameToDelete = selectedRow.Cells["DeviceName"].Value.ToString();

                    
                    string deleteQuery = "DELETE FROM SetUpConfig WHERE Name = @deviceName";
                    
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@deviceName", deviceNameToDelete);
                        cmd.ExecuteNonQuery();
                    }
                    
                    RecordList.Rows.RemoveAt(selectedRow.Index);
                }
            }
        }

        private void but_home_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Hide();
        }

        private void but_back_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Manual_CheckedChanged_1(object sender, EventArgs e)
        {
            SearchGroup.Show();
            RoomSelection.SelectedItem = null;
            NameSearchBox.Text = string.Empty;
        }

        void manual_search()
        {
            string searchRoom = RoomSelection.SelectedItem.ToString();
            string searchDevice = NameSearchBox.Text;

            bdap = new SqlDataAdapter(@"SELECT DISTINCT Name AS DeviceName FROM SetUpConfig where Name = @device and Room_Category = @room", con);
            bdap.SelectCommand.Parameters.AddWithValue("@room", searchRoom);
            bdap.SelectCommand.Parameters.AddWithValue("@device", searchDevice);
            dt = new DataTable();
            bdap.Fill(dt);

            adap = new SqlDataAdapter(@"SELECT OptionName FROM Options", con);
            dtt = new DataTable();
            adap.Fill(dtt);

            DataTable displayTable = new DataTable();

            displayTable.Columns.Add("DeviceName", typeof(string));

            foreach (DataRow optionRow in dtt.Rows)
            {
                string optionName = optionRow["OptionName"].ToString();
                displayTable.Columns.Add(optionName, typeof(string));
            }

            foreach (DataRow deviceRow in dt.Rows)
            {
                string deviceName = deviceRow["DeviceName"].ToString();
                DataRow newRow = displayTable.NewRow();
                newRow["DeviceName"] = deviceName;

                foreach (DataRow optionRow in dtt.Rows)
                {
                    string optionName = optionRow["OptionName"].ToString();
                    cdap = new SqlDataAdapter(@"SELECT Config_Options FROM SetUpConfig WHERE Name = @device AND Config_Options = @option", con);
                    cdap.SelectCommand.Parameters.AddWithValue("@device", deviceName);
                    cdap.SelectCommand.Parameters.AddWithValue("@option", optionName);
                    det = new DataTable();
                    cdap.Fill(det);

                    if (det.Rows.Count > 0)
                    {
                        newRow[optionName] = "✔";
                    }
                    /*else
                    {
                        newRow[optionName] = "❌";
                    }*/
                }

                displayTable.Rows.Add(newRow);
            }

            RecordList.DataSource = displayTable;
        }
        private void NewBox_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        void AllRecords_CheckedChanged(object sender, EventArgs e)
        {
            SearchGroup.Hide();
            //RecordList.Rows.Clear();
            //RecordList.Columns.Clear();

            bdap = new SqlDataAdapter(@"SELECT DISTINCT Name AS DeviceName FROM SetUpConfig", con);
            dt = new DataTable();
            bdap.Fill(dt);

            adap = new SqlDataAdapter(@"SELECT OptionName FROM Options", con);
            dtt = new DataTable();
            adap.Fill(dtt);

            DataTable displayTable = new DataTable();

            displayTable.Columns.Add("DeviceName", typeof(string));

            foreach (DataRow optionRow in dtt.Rows)
            {
                string optionName = optionRow["OptionName"].ToString();
                displayTable.Columns.Add(optionName, typeof(string));
            }

            foreach (DataRow deviceRow in dt.Rows)
            {
                string deviceName = deviceRow["DeviceName"].ToString();
                DataRow newRow = displayTable.NewRow();
                newRow["DeviceName"] = deviceName;

                foreach (DataRow optionRow in dtt.Rows)
                {
                    string optionName = optionRow["OptionName"].ToString();
                    cdap = new SqlDataAdapter(@"SELECT Config_Options FROM SetUpConfig WHERE Name = @device AND Config_Options = @option", con);
                    cdap.SelectCommand.Parameters.AddWithValue("@device", deviceName);
                    cdap.SelectCommand.Parameters.AddWithValue("@option", optionName);
                    det = new DataTable();
                    cdap.Fill(det);

                    if (det.Rows.Count > 0)
                    {
                        newRow[optionName] = "✔";
                    }
                    /*else
                    {
                        newRow[optionName] = "❌";
                    }*/
                }

                displayTable.Rows.Add(newRow);
            }

            RecordList.DataSource = displayTable;
        }
    }
}
