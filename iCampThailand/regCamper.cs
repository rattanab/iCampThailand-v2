using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace iCampThailand {
	public partial class regCamper : Form {
		string cs = @"server=localhost;userid=root;password='';database=icamp";

		MySqlConnection conn = null;

		MySqlDataReader reader = null;
		public string sessionSelect;

		public regCamper() {
			conn = new MySqlConnection(cs);
			InitializeComponent();
		}

		private void Register_Load(object sender, EventArgs e) {
			try {
				conn.Open();

				String cmdText = "SELECT CamperName FROM camper"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					camperListBox.Items.Add(reader.GetString(0)); // get the information as a string at the column index 0
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
			getdatevalue();
		}

		private void cselectbutton_Click(object sender, EventArgs e) {
			//string cs = @"server=localhost;userid=root;password='';database=icamp";

			//MySqlConnection conn = null;
			//MySqlDataReader reader = null;
			enableinput();
			try {
				//  conn = new MySqlConnection(cs);
				conn.Open();

				String cmdText = "SELECT * FROM camper WHERE CamperName='" + camperListBox.Text + "'"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					cnameBox.Text = reader.GetString(1); // get the information as a string at the column index 0
					nickNameBox.Text = reader.GetString(2);
					bunkBox.Text = reader.GetString(3);
					ageBox.Text = reader.GetString(4);
					nationBox.Text = reader.GetString(5);
					dietBox.Text = reader.GetString(9);
					mneedBox.Text = reader.GetString(8);
					sdatePicker.Value = reader.GetDateTime(6);
					edatePicker.Value = reader.GetDateTime(7);
					transportBox.Text = reader.GetString(10);
					p1nameBox.Text = reader.GetString(11);
					p1contactBox.Text = reader.GetString(12);
					p1emailBox.Text = reader.GetString(13);
					p2nameBox.Text = reader.GetString(14);
					p2contactBox.Text = reader.GetString(15);
					p2emailBox.Text = reader.GetString(16);
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
			submitbutton.Enabled = true;
		}

		private void cnewbutton_Click(object sender, EventArgs e) {
			camperListBox.Enabled = false;
			enableinput();
			cnameBox.Text = "Name";
			nickNameBox.Text = "Nickname";
			bunkBox.Text = "Bunk";
			ageBox.Text = "Age";
			nationBox.Text = "Nationality";
			dietBox.Text = "Dietary Needs";
			mneedBox.Text = "Medical Needs";
			getdatevalue();
			transportBox.Text = "Transportation";
			p1nameBox.Text = "Name";
			p1contactBox.Text = "Contact";
			p1emailBox.Text = "Email";
			p2nameBox.Text = "Name";
			p2contactBox.Text = "Contact";
			p2emailBox.Text = "Email";
			submitbutton.Enabled = true;
            MessageBox.Show("Please fill in new camper detail and hit Submit.");
		}

		private void submitbutton_Click(object sender, EventArgs e) {
			if (camperListBox.Enabled == false) {
				try {
					conn.Open();
					MySqlCommand cmd = new MySqlCommand("INSERT INTO camper (" +
					                                    "CamperName,CamperNickName,Bunk,Age,Nationality,StartDate,EndDate,MedicalNeed,DietNeed,Transport,PG1Name,PG1Contact,PG1Email,PG2Name,PG2Contact,PG2Email)" +
					                                    "VALUES ('" + cnameBox.Text + "','" + nickNameBox.Text + "'," +
					                                    bunkBox.Text + "," + ageBox.Text + ",'" + nationBox.Text +
					                                    "','" + sdatePicker.Value.ToString("yyyy-MM-dd") + "','" +
					                                    edatePicker.Value.ToString("yyyy-MM-dd") + "','" +
					                                    mneedBox.Text + "','" + dietBox.Text + "','" +
					                                    transportBox.Text + "','" + p1nameBox.Text + "'," +
					                                    p1contactBox.Text + ",'" + p1emailBox + "','" + p2nameBox.Text +
					                                    "'," + p2contactBox.Text + ",'" + p2emailBox.Text + "')", conn);
					cmd.ExecuteNonQuery();
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
				MessageBox.Show("New Camper Registered.");
			}
			else {
				try {
					conn.Open();
					MySqlCommand cmd = new MySqlCommand("UPDATE camper SET " +
					                                    "CamperName='" + cnameBox.Text + "'," +
					                                    "CamperNickName='" + nickNameBox.Text + "'," +
					                                    "Bunk=" + bunkBox.Text + "," +
					                                    "Age=" + ageBox.Text + "," +
					                                    "Nationality='" + nationBox.Text + "'," +
					                                    "StartDate='" + sdatePicker.Value.ToString("yyyy-MM-dd") + "'," +
					                                    "EndDate='" + edatePicker.Value.ToString("yyyy-MM-dd") + "'," +
					                                    "DietNeed='" + mneedBox.Text + "'," +
					                                    "Transport='" + transportBox.Text + "'," +
					                                    "PG1Name='" + p1nameBox.Text + "'," +
					                                    "PG1Contact=" + p1contactBox.Text + "," +
					                                    "PG1Email='" + p1emailBox.Text + "'," +
					                                    "PG2Name='" + p2nameBox.Text + "'," +
					                                    "PG2Contact=" + p2contactBox.Text + "," +
					                                    "PG2Email='" + p2emailBox.Text + "'" +
					                                    " WHERE CamperName='" + camperListBox.Text + "';", conn);
					cmd.ExecuteNonQuery();
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
				MessageBox.Show("Existing Camper Information Updated.");
			}
			submitbutton.Enabled = false;
			camperListBox.Enabled = true;
		}

		private void getdatevalue() {
			if (sessionSelect != "") {
				try {
					conn.Open();
					MySqlCommand cmd =
						new MySqlCommand(
							"SELECT SessionDateStart, SessionDateEnd FROM camp_session WHERE SessionName='" + sessionSelect + "';", conn);
					reader = cmd.ExecuteReader();
					while (reader.Read()) {
						sdatePicker.Value = reader.GetDateTime(0);
						sdatePicker.MinDate = reader.GetDateTime(0);
						edatePicker.MinDate = reader.GetDateTime(0);
						edatePicker.Value = reader.GetDateTime(1);
						sdatePicker.MaxDate = reader.GetDateTime(1);
						edatePicker.MaxDate = reader.GetDateTime(1);
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
			else {
				MessageBox.Show("Warning: No Session Selected");
			}
		}

		private void enableinput() {
			cnameBox.Enabled = true;
			nickNameBox.Enabled = true;
			bunkBox.Enabled = true;
			ageBox.Enabled = true;
			nationBox.Enabled = true;
			dietBox.Enabled = true;
			mneedBox.Enabled = true;
			sdatePicker.Enabled = true;
			edatePicker.Enabled = true;
			transportBox.Enabled = true;
			p1nameBox.Enabled = true;
			p1contactBox.Enabled = true;
			p1emailBox.Enabled = true;
			p2nameBox.Enabled = true;
			p2contactBox.Enabled = true;
			p2emailBox.Enabled = true;
		}
	}
}