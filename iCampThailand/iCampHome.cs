using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Add MySql Library

namespace iCampThailand {
	public partial class iCampHome : Form {
		string cs = @"server=localhost;userid=root;password='';database=icamp";

		MySqlConnection conn = null;
		MySqlDataReader reader = null;

		public iCampHome() {
			InitializeComponent();
			conn = new MySqlConnection(cs);
		}

		private void iCampHome_Load(object sender, EventArgs e) {
			try {
				conn.Open();

				String cmdText = "SELECT SessionName FROM camp_session"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					sessionSelectorBox.Items.Add(reader.GetString(0)); // get the information as a string at the column index 0
				}
			}
			catch (MySqlException ex) {
				MessageBox.Show("Error: " + ex.ToString());
			}
			finally // what to do after try/catch is done
			{
				if (conn != null) {
					conn.Close();
				}
			}
		}

		private void registrationButton_Click(object sender, EventArgs e) {
			regCamper regCamper = new regCamper();
			//this.Hide();
			regCamper.sessionSelect = sessionSelectorBox.Text;
			regCamper.Show();
		}

		private void regActButton_Click(object sender, EventArgs e) {
			regActivity regActivity = new regActivity();
			//this.Hide();
			regActivity.sessionSelect = sessionSelectorBox.Text;
			regActivity.Show();
		}

		private void campeMenurGroup_Enter(object sender, EventArgs e) { }

		private void orgactButton_Click(object sender, EventArgs e) {
			OrganiserActivityForm organiserActivityForm = new OrganiserActivityForm();
			organiserActivityForm.sessionSelect = sessionSelectorBox.Text;
			organiserActivityForm.Show();
			this.Hide();
		}

		private void newSessionButton_Click(object sender, EventArgs e) {
			newSession newSession = new newSession();
			newSession.Show();
		}

        private void exSignUpButton_Click(object sender, EventArgs e) {
	        MessageBox.Show("Not yet Implemented.");
//	        String strDownloadFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv"; 

	        // Your Function for Retrieving Data 
//	        DataTable dtA = RetrieveData(); 
// 
//	        Response.Clear(); 
//	        Response.ContentType = "text/plain"; 
//	        Response.AppendHeader("content-disposition", "attachment; filename=" + strDownloadFileName); // myData - file name (also can be bring from DB) 
// 
//	        //MyData - your data ... 
//	        Byte[] myData = csvBytesWriter(ref dtA); 
// 
//	        Response.BinaryWrite(myData);  // Binary data - see myData -   
//	        Response.End(); 
        }
		protected DataTable RetrieveData() 
		{ 
			DataTable dt = new DataTable(); 
			// Here you LOGIC for Retrieving Data Table... 
 
			//Below just for test purpose ... 
			dt.TableName = "TEST"; 
			dt.Columns.Add("TestA"); 
			dt.Columns.Add("TestB"); 
			dt.Columns.Add("TestC"); 
			dt.Columns.Add("TestD,E"); 
 
			DataRow dr = dt.NewRow(); 
			dr["TestA"] = @"A' "; 
			dr["TestB"] = @"B"" "; 
			dr["TestC"] = @"C<> "; 
			dr["TestD,E"] = @",C, "; 
 
			dt.Rows.Add(dr); 
			return dt; 
		}

        private void excschduleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet Implemented.");
        }
    }
}