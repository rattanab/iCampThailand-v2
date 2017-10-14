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
	public partial class newSession : Form {
		string cs = @"server=localhost;userid=root;password='';database=icamp";

		MySqlConnection conn = null;
		MySqlDataReader reader = null;

		public newSession() {
			InitializeComponent();
			conn = new MySqlConnection(cs);
		}

		private void add_Click(object sender, EventArgs e) {
			if (sessionNameBox.Text != "") {
				try {
					conn.Open();

					String cmdText = "INSERT INTO camp_session (SessionName, SessionDateStart, SessionDateEnd) VALUES ('" +
					                 sessionNameBox.Text + "', '" + sessionSDate.Value.Date.ToString("yyyy-MM-dd") + "', '" +
					                 sessionEDate.Value.Date.ToString("yyyy-MM-dd") + "');"; // sql command as string
					MySqlCommand cmd = new MySqlCommand(cmdText, conn); // set the command to the connection
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
				MessageBox.Show("Session Added");
			}
			else {
				MessageBox.Show("Session Detail Incomplete.");
			}
		}
	}
}