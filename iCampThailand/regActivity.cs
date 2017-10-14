using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace iCampThailand {
	public partial class regActivity : Form {
		string cs = @"server=localhost;userid=root;password='';database=icamp";

		MySqlConnection conn = null;
		MySqlDataReader reader = null;
		public string sessionSelect;

		public regActivity() {
			InitializeComponent();
			conn = new MySqlConnection(cs);
		}

		private void regActivity_Load(object sender, EventArgs e) {
			loaddb();
			getdatevalue();
		}

		private void loadsub1() {
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=1;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					sub1Box.Items.Add(reader.GetString(0));
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

		private void loadsub2() {
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=2;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					sub2Box.Items.Add(reader.GetString(0));
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

		private void loadsub3() {
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=3;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					sub3Box.Items.Add(reader.GetString(0));
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

		private void loadsub4() {
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=4;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					sub4Box.Items.Add(reader.GetString(0));
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

		private void loadsub5() {
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=5;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					sub5Box.Items.Add(reader.GetString(0));
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

		private void getdatevalue() {
			if (sessionSelect != "") {
				try {
					conn.Open();

					MySqlCommand cmd =
						new MySqlCommand(
							"SELECT SessionDateStart, SessionDateEnd FROM camp_session WHERE SessionName='" + sessionSelect + "';", conn);

					reader = cmd.ExecuteReader();
					while (reader.Read()) {
						dateTimePicker1.MinDate = reader.GetDateTime(0);
						dateTimePicker1.MaxDate = reader.GetDateTime(1);
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

		private void savebutton_Click(object sender, EventArgs e) {
			saveinfo();
		}

		private void saveinfo() {
			if (sub1Box.Text != "" && sub2Box.Text != "" && sub3Box.Text != "" && sub4Box.Text != "" && sub5Box.Text != "") {
				try {
					conn.Open();

					MySqlCommand cmd =
						new MySqlCommand(
							"INSERT INTO activity_selection (CamperID, Date, SubjectNum, Activity) VALUES ((SELECT CamperID FROM camper WHERE CamperName='" +
							cnameBox.Text + "'), '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 1, '" + sub1Box.Text +
							"');\n" +
							"INSERT INTO activity_selection (CamperID, Date, SubjectNum, Activity) VALUES ((SELECT CamperID FROM camper WHERE CamperName='" +
							cnameBox.Text + "'), '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 2, '" + sub2Box.Text +
							"');\n" +
							"INSERT INTO activity_selection (CamperID, Date, SubjectNum, Activity) VALUES ((SELECT CamperID FROM camper WHERE CamperName='" +
							cnameBox.Text + "'), '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 3, '" + sub3Box.Text +
							"');\n" +
							"INSERT INTO activity_selection (CamperID, Date, SubjectNum, Activity) VALUES ((SELECT CamperID FROM camper WHERE CamperName='" +
							cnameBox.Text + "'), '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 4, '" + sub4Box.Text +
							"');\n" +
							"INSERT INTO activity_selection (CamperID, Date, SubjectNum, Activity) VALUES ((SELECT CamperID FROM camper WHERE CamperName='" +
							cnameBox.Text +
							"'), '" + dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 5, '" + sub5Box.Text + "'); "
							, conn);
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
				MessageBox.Show("Activities Saved");
			}
			else {
				MessageBox.Show("Warning: Activity Selection Incomplete.");
			}
		}

		private void selectbutton_Click(object sender, EventArgs e) {
			loadsub1();
			loadsub2();
			loadsub3();
			loadsub4();
			loadsub5();
            MessageBox.Show("Activities loaded");
		}

		private void cbunknoBox_SelectedIndexChanged(object sender, EventArgs e) {
			cnameBox.Items.Clear();
			try {
				conn.Open();

				String cmdText = "SELECT CamperName FROM camper WHERE bunk=" + cbunknoBox.Text + ";"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					cnameBox.Items.Add(reader.GetString(0));
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

		private void clearbutton_Click(object sender, EventArgs e) {
			cbunknoBox.Items.Clear();
			cbunknoBox.Text = "";
			cnameBox.Items.Clear();
			cnameBox.Text = "";
			loaddb();
		}

		private void loaddb() {
			try {
				conn.Open();

				String cmdText = "SELECT Bunk,CamperName FROM camper ORDER BY Bunk,CamperName ASC;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					if (cbunknoBox.Items.Contains(reader.GetString(0)) == false) {
						cbunknoBox.Items.Add(reader.GetString(0));
					}
					if (cnameBox.Items.Contains(reader.GetString(1)) == false) {
						cnameBox.Items.Add(reader.GetString(1));
					}
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

        private void savenextbutton_Click(object sender, EventArgs e) {
	        saveinfo();
	        if (cnameBox.SelectedIndex < cnameBox.Items.Count-1) {
		        cnameBox.SelectedIndex = cnameBox.SelectedIndex + 1;
	        }
	        else if (cbunknoBox.SelectedIndex < cbunknoBox.Items.Count-1) {
		        cbunknoBox.SelectedIndex = cbunknoBox.SelectedIndex + 1;
		        cnameBox.SelectedIndex = 0;
	        }
	        else {
		        MessageBox.Show("Activities saved but no more camper.");
	        }
        }
    }
}