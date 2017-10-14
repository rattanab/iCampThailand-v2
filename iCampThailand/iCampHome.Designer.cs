namespace iCampThailand
{
    partial class iCampHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iCampHome));
            this.logo = new System.Windows.Forms.PictureBox();
            this.sessionSelectorBox = new System.Windows.Forms.ComboBox();
            this.newSessionButton = new System.Windows.Forms.Button();
            this.campeMenurGroup = new System.Windows.Forms.GroupBox();
            this.regActButton = new System.Windows.Forms.Button();
            this.excschduleButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.campSessionGroup = new System.Windows.Forms.GroupBox();
            this.icampmenuGroup = new System.Windows.Forms.GroupBox();
            this.exSignUpButton = new System.Windows.Forms.Button();
            this.orgactButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.campeMenurGroup.SuspendLayout();
            this.campSessionGroup.SuspendLayout();
            this.icampmenuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(278, 22);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(300, 150);
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // sessionSelectorBox
            // 
            this.sessionSelectorBox.FormattingEnabled = true;
            this.sessionSelectorBox.Location = new System.Drawing.Point(35, 25);
            this.sessionSelectorBox.Name = "sessionSelectorBox";
            this.sessionSelectorBox.Size = new System.Drawing.Size(188, 28);
            this.sessionSelectorBox.TabIndex = 2;
            // 
            // newSessionButton
            // 
            this.newSessionButton.BackColor = System.Drawing.Color.DarkOrange;
            this.newSessionButton.FlatAppearance.BorderSize = 0;
            this.newSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSessionButton.Location = new System.Drawing.Point(247, 25);
            this.newSessionButton.Name = "newSessionButton";
            this.newSessionButton.Size = new System.Drawing.Size(91, 28);
            this.newSessionButton.TabIndex = 1;
            this.newSessionButton.Text = "New Session";
            this.newSessionButton.UseVisualStyleBackColor = false;
            this.newSessionButton.Click += new System.EventHandler(this.newSessionButton_Click);
            // 
            // campeMenurGroup
            // 
            this.campeMenurGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.campeMenurGroup.Controls.Add(this.regActButton);
            this.campeMenurGroup.Controls.Add(this.excschduleButton);
            this.campeMenurGroup.Controls.Add(this.registrationButton);
            this.campeMenurGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campeMenurGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campeMenurGroup.ForeColor = System.Drawing.Color.White;
            this.campeMenurGroup.Location = new System.Drawing.Point(127, 289);
            this.campeMenurGroup.Name = "campeMenurGroup";
            this.campeMenurGroup.Size = new System.Drawing.Size(267, 310);
            this.campeMenurGroup.TabIndex = 5;
            this.campeMenurGroup.TabStop = false;
            this.campeMenurGroup.Text = "Camper Menu";
            this.campeMenurGroup.Enter += new System.EventHandler(this.campeMenurGroup_Enter);
            // 
            // regActButton
            // 
            this.regActButton.BackColor = System.Drawing.Color.DarkOrange;
            this.regActButton.FlatAppearance.BorderSize = 0;
            this.regActButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regActButton.ForeColor = System.Drawing.Color.White;
            this.regActButton.Location = new System.Drawing.Point(36, 118);
            this.regActButton.Name = "regActButton";
            this.regActButton.Size = new System.Drawing.Size(189, 45);
            this.regActButton.TabIndex = 2;
            this.regActButton.Text = "Register Activities";
            this.regActButton.UseVisualStyleBackColor = false;
            this.regActButton.Click += new System.EventHandler(this.regActButton_Click);
            // 
            // excschduleButton
            // 
            this.excschduleButton.BackColor = System.Drawing.Color.DarkOrange;
            this.excschduleButton.FlatAppearance.BorderSize = 0;
            this.excschduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excschduleButton.ForeColor = System.Drawing.Color.White;
            this.excschduleButton.Location = new System.Drawing.Point(51, 200);
            this.excschduleButton.Name = "excschduleButton";
            this.excschduleButton.Size = new System.Drawing.Size(158, 57);
            this.excschduleButton.TabIndex = 1;
            this.excschduleButton.Text = "Export Camper\'s Schdule";
            this.excschduleButton.UseVisualStyleBackColor = false;
            this.excschduleButton.Click += new System.EventHandler(this.excschduleButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.DarkOrange;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(36, 39);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(189, 41);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Camper Registration";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // campSessionGroup
            // 
            this.campSessionGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.campSessionGroup.Controls.Add(this.sessionSelectorBox);
            this.campSessionGroup.Controls.Add(this.newSessionButton);
            this.campSessionGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campSessionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campSessionGroup.ForeColor = System.Drawing.Color.White;
            this.campSessionGroup.Location = new System.Drawing.Point(255, 192);
            this.campSessionGroup.Name = "campSessionGroup";
            this.campSessionGroup.Size = new System.Drawing.Size(363, 68);
            this.campSessionGroup.TabIndex = 4;
            this.campSessionGroup.TabStop = false;
            this.campSessionGroup.Text = "Camp Session";
            // 
            // icampmenuGroup
            // 
            this.icampmenuGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.icampmenuGroup.Controls.Add(this.exSignUpButton);
            this.icampmenuGroup.Controls.Add(this.orgactButton);
            this.icampmenuGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icampmenuGroup.ForeColor = System.Drawing.Color.White;
            this.icampmenuGroup.Location = new System.Drawing.Point(482, 289);
            this.icampmenuGroup.Name = "icampmenuGroup";
            this.icampmenuGroup.Size = new System.Drawing.Size(276, 310);
            this.icampmenuGroup.TabIndex = 6;
            this.icampmenuGroup.TabStop = false;
            this.icampmenuGroup.Text = "Organizer Menu";
            // 
            // exSignUpButton
            // 
            this.exSignUpButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exSignUpButton.FlatAppearance.BorderSize = 0;
            this.exSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exSignUpButton.ForeColor = System.Drawing.Color.White;
            this.exSignUpButton.Location = new System.Drawing.Point(55, 112);
            this.exSignUpButton.Name = "exSignUpButton";
            this.exSignUpButton.Size = new System.Drawing.Size(168, 57);
            this.exSignUpButton.TabIndex = 4;
            this.exSignUpButton.Text = "Export Sign Up Sheet";
            this.exSignUpButton.UseVisualStyleBackColor = false;
            this.exSignUpButton.Click += new System.EventHandler(this.exSignUpButton_Click);
            // 
            // orgactButton
            // 
            this.orgactButton.BackColor = System.Drawing.Color.DarkOrange;
            this.orgactButton.FlatAppearance.BorderSize = 0;
            this.orgactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orgactButton.ForeColor = System.Drawing.Color.White;
            this.orgactButton.Location = new System.Drawing.Point(55, 39);
            this.orgactButton.Name = "orgactButton";
            this.orgactButton.Size = new System.Drawing.Size(168, 41);
            this.orgactButton.TabIndex = 3;
            this.orgactButton.Text = "Activity Organizer";
            this.orgactButton.UseVisualStyleBackColor = false;
            this.orgactButton.Click += new System.EventHandler(this.orgactButton_Click);
            // 
            // iCampHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(861, 639);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.campeMenurGroup);
            this.Controls.Add(this.campSessionGroup);
            this.Controls.Add(this.icampmenuGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "iCampHome";
            this.Text = "iCamp Thailand";
            this.Load += new System.EventHandler(this.iCampHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.campeMenurGroup.ResumeLayout(false);
            this.campSessionGroup.ResumeLayout(false);
            this.icampmenuGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ComboBox sessionSelectorBox;
        private System.Windows.Forms.Button newSessionButton;
        private System.Windows.Forms.GroupBox campeMenurGroup;
        private System.Windows.Forms.Button regActButton;
        private System.Windows.Forms.Button excschduleButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.GroupBox campSessionGroup;
        private System.Windows.Forms.GroupBox icampmenuGroup;
        private System.Windows.Forms.Button exSignUpButton;
        private System.Windows.Forms.Button orgactButton;
    }
}

