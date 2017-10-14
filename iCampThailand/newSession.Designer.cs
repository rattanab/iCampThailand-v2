namespace iCampThailand
{
    partial class newSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newSession));
            this.sessionNameBox = new System.Windows.Forms.TextBox();
            this.sessionGroup = new System.Windows.Forms.GroupBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sessionEDate = new System.Windows.Forms.DateTimePicker();
            this.sessionSDate = new System.Windows.Forms.DateTimePicker();
            this.snamelabel = new System.Windows.Forms.Label();
            this.sessionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sessionNameBox
            // 
            this.sessionNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sessionNameBox.Location = new System.Drawing.Point(170, 35);
            this.sessionNameBox.Name = "sessionNameBox";
            this.sessionNameBox.Size = new System.Drawing.Size(161, 26);
            this.sessionNameBox.TabIndex = 0;
            this.sessionNameBox.Text = "Session Name";
            // 
            // sessionGroup
            // 
            this.sessionGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.sessionGroup.Controls.Add(this.addbutton);
            this.sessionGroup.Controls.Add(this.label2);
            this.sessionGroup.Controls.Add(this.label1);
            this.sessionGroup.Controls.Add(this.sessionEDate);
            this.sessionGroup.Controls.Add(this.sessionSDate);
            this.sessionGroup.Controls.Add(this.snamelabel);
            this.sessionGroup.Controls.Add(this.sessionNameBox);
            this.sessionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionGroup.ForeColor = System.Drawing.Color.White;
            this.sessionGroup.Location = new System.Drawing.Point(32, 57);
            this.sessionGroup.Name = "sessionGroup";
            this.sessionGroup.Size = new System.Drawing.Size(501, 189);
            this.sessionGroup.TabIndex = 1;
            this.sessionGroup.TabStop = false;
            this.sessionGroup.Text = "Add Session";
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.addbutton.FlatAppearance.BorderSize = 0;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Location = new System.Drawing.Point(190, 142);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(125, 31);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add Session";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Session End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Session Start Date";
            // 
            // sessionEDate
            // 
            this.sessionEDate.Location = new System.Drawing.Point(170, 101);
            this.sessionEDate.Name = "sessionEDate";
            this.sessionEDate.Size = new System.Drawing.Size(307, 26);
            this.sessionEDate.TabIndex = 3;
            // 
            // sessionSDate
            // 
            this.sessionSDate.Location = new System.Drawing.Point(170, 68);
            this.sessionSDate.Name = "sessionSDate";
            this.sessionSDate.Size = new System.Drawing.Size(307, 26);
            this.sessionSDate.TabIndex = 2;
            // 
            // snamelabel
            // 
            this.snamelabel.AutoSize = true;
            this.snamelabel.Location = new System.Drawing.Point(42, 37);
            this.snamelabel.Name = "snamelabel";
            this.snamelabel.Size = new System.Drawing.Size(124, 20);
            this.snamelabel.TabIndex = 1;
            this.snamelabel.Text = "Session Name";
            // 
            // newSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(572, 307);
            this.Controls.Add(this.sessionGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newSession";
            this.Text = "iCamp Add Session";
            this.sessionGroup.ResumeLayout(false);
            this.sessionGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sessionNameBox;
        private System.Windows.Forms.GroupBox sessionGroup;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker sessionEDate;
        private System.Windows.Forms.DateTimePicker sessionSDate;
        private System.Windows.Forms.Label snamelabel;
    }
}