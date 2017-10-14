using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add MySql Library
using MySql.Data.MySqlClient;

namespace iCampThailand
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            string cs = @"server=localhost;userid=root;password='';database=icamp";

            MySqlConnection conn = null;
            MySqlDataReader reader = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                String cmdText = "SELECT SessionName FROM camp_session"; // sql command as string
                MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
                reader = cmd.ExecuteReader(); // excute and get into the datareader
                //cmd.ExecuteNonQuery(); Execute with no query
                while (reader.Read())
                {
                    sessionSelectorBox.Items.Add(reader.GetString(0)); // get the information as a string at the column index 0
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally // what to do after try/catch is done
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            regCamper regCamper = new regCamper();
            //this.Hide();
            regCamper.sessionSelect = sessionSelectorBox.Text;
            regCamper.Show();

        }

        private void regActButton_Click(object sender, EventArgs e)
        {
            regActivity regActivity = new regActivity();
            //this.Hide();
            regActivity.Show();
        }
        
    }
}