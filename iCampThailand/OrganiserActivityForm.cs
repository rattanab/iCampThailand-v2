using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace iCampThailand {
	public partial class OrganiserActivityForm : Form {
		string cs = @"server=localhost;userid=root;password='';database=icamp";

		MySqlConnection conn = null;

		MySqlDataReader reader = null;
		public string sessionSelect;

		public OrganiserActivityForm() {
			conn = new MySqlConnection(cs);
			InitializeComponent();
		}

		private void Back_Click(object sender, EventArgs e) {
			iCampHome iCampHome = new iCampHome();
			iCampHome.Show();
			this.Hide();
		}

		private void addActButton_Click(object sender, EventArgs e) {
			switch (sublist.Text) {
				case "Subject 1":
					try {
						conn.Open();

						String cmdText = "INSERT INTO activity_availability VALUES ('" +
						                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 1, '" + actList.Text +
						                 "');"; // sql command as string
						MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
						cmd.ExecuteNonQuery(); // excute and get into the datareader
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
					updatesub1();
					break;
				case "Subject 2":
					try {
						conn.Open();

						String cmdText = "INSERT INTO activity_availability VALUES ('" +
						                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 2, '" + actList.Text +
						                 "');"; // sql command as string
						MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
						cmd.ExecuteNonQuery(); // excute and get into the datareader
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
					updatesub2();
					break;
				case "Subject 3":
					try {
						conn.Open();

						String cmdText = "INSERT INTO activity_availability VALUES ('" +
						                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 3, '" + actList.Text +
						                 "');"; // sql command as string
						MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
						cmd.ExecuteNonQuery(); // excute and get into the datareader
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
					updatesub3();
					break;
				case "Subject 4":
					try {
						conn.Open();

						String cmdText = "INSERT INTO activity_availability VALUES ('" +
						                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 4, '" + actList.Text +
						                 "');"; // sql command as string
						MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
						cmd.ExecuteNonQuery(); // excute and get into the datareader
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
					updatesub4();
					break;
				case "Subject 5":
					try {
						conn.Open();

						String cmdText = "INSERT INTO activity_availability VALUES ('" +
						                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "', 5, '" + actList.Text +
						                 "');"; // sql command as string
						MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
						cmd.ExecuteNonQuery(); // excute and get into the datareader
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
					updatesub5();
					break;
			}
		}

		private void Delete1_Click(object sender, EventArgs e) {
			if (ActivityBox1.SelectedIndex == -1) {
				MessageBox.Show("Select An Item To Be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else {
				try {
					conn.Open();

					String cmdText = "DELETE FROM activity_availability WHERE date='" +
					                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=1 AND activity_name='" +
					                 ActivityBox1.SelectedItem + "';";
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
					cmd.ExecuteNonQuery(); // excute and get into the datareader
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
				updatesub1();
			}
		}

		private void Delete2_Click(object sender, EventArgs e) {
			if (ActivityBox2.SelectedIndex == -1) {
				MessageBox.Show("Select An Item To Be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else {
				try {
					conn.Open();

					String cmdText = "DELETE FROM activity_availability WHERE date='" +
					                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=2 AND activity_name='" +
					                 ActivityBox2.SelectedItem + "';";
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
					cmd.ExecuteNonQuery(); // excute and get into the datareader
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
				updatesub2();
			}
		}

		private void Delete3_Click(object sender, EventArgs e) {
			if (ActivityBox3.SelectedIndex == -1) {
				MessageBox.Show("Select An Item To Be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else {
				try {
					conn.Open();

					String cmdText = "DELETE FROM activity_availability WHERE date='" +
					                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=3 AND activity_name='" +
					                 ActivityBox3.SelectedItem + "';";
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
					cmd.ExecuteNonQuery(); // excute and get into the datareader
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
				updatesub3();
			}
		}

		private void Delete4_Click(object sender, EventArgs e) {
			if (ActivityBox4.SelectedIndex == -1) {
				MessageBox.Show("Select An Item To Be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else {
				try {
					conn.Open();

					String cmdText = "DELETE FROM activity_availability WHERE date='" +
					                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=4 AND activity_name='" +
					                 ActivityBox4.SelectedItem + "';";
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
					cmd.ExecuteNonQuery(); // excute and get into the datareader
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
				updatesub4();
			}
		}

		private void Delete5_Click(object sender, EventArgs e) {
			if (ActivityBox5.SelectedIndex == -1) {
				MessageBox.Show("Select An Item To Be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else {
				try {
					conn.Open();

					String cmdText = "DELETE FROM activity_availability WHERE date='" +
					                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=5 AND activity_name='" +
					                 ActivityBox5.SelectedItem + "';";
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
					cmd.ExecuteNonQuery(); // excute and get into the datareader
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
				updatesub5();
			}
		}

		private void selectButton_Click(object sender, EventArgs e) {
			updatesub1();
			updatesub2();
			updatesub3();
			updatesub4();
			updatesub5();
			MessageBox.Show("Activities Loaded.");
		}

		private void OrganiserActivityForm_Load(object sender, EventArgs e) {
			try {
				conn.Open();

				String cmdText = "SELECT ActivityName FROM activity"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					actList.Items.Add(reader.GetString(0)); // get the information as a string at the column index 0
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
			dateload();
		}

		private void dateload() {
			if (sessionSelect != "") {
				try {
					conn.Open();

					String cmdText = "SELECT SessionDateStart,SessionDateEnd FROM camp_session WHERE SessionName='" + sessionSelect +
					                 "';"; // sql command as string
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
					reader = cmd.ExecuteReader(); // excute and get into the datareader
					//cmd.ExecuteNonQuery(); Execute with no query
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

		private void updatesub1() {
			ActivityBox1.Items.Clear();
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=1;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					ActivityBox1.Items.Add(reader.GetString(0));
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

		private void updatesub2() {
			ActivityBox2.Items.Clear();
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=2;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					ActivityBox2.Items.Add(reader.GetString(0));
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

		private void updatesub3() {
			ActivityBox3.Items.Clear();
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=3;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					ActivityBox3.Items.Add(reader.GetString(0));
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

		private void updatesub4() {
			ActivityBox4.Items.Clear();
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=4;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					ActivityBox4.Items.Add(reader.GetString(0));
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

		private void updatesub5() {
			ActivityBox5.Items.Clear();
			try {
				conn.Open();

				String cmdText = "SELECT activity_name FROM activity_availability WHERE date='" +
				                 dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "' AND timeslot=5;"; // sql command as string
				MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
				reader = cmd.ExecuteReader(); // excute and get into the datareader
				//cmd.ExecuteNonQuery(); Execute with no query
				while (reader.Read()) {
					ActivityBox5.Items.Add(reader.GetString(0));
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
	}
}