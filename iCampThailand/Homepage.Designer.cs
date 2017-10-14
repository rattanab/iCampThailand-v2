namespace iCampThailand
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.newSessionButton = new System.Windows.Forms.Button();
            this.sessionSelectorBox = new System.Windows.Forms.ComboBox();
            this.campSessionGroup = new System.Windows.Forms.GroupBox();
            this.menuGroup = new System.Windows.Forms.GroupBox();
            this.regActButton = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.exportGroup = new System.Windows.Forms.GroupBox();
            this.exDetailButton = new System.Windows.Forms.Button();
            this.exSignupButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.campSessionGroup.SuspendLayout();
            this.menuGroup.SuspendLayout();
            this.exportGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // newSessionButton
            // 
            this.newSessionButton.BackColor = System.Drawing.Color.DarkOrange;
            this.newSessionButton.FlatAppearance.BorderSize = 0;
            this.newSessionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newSessionButton.Location = new System.Drawing.Point(217, 23);
            this.newSessionButton.Name = "newSessionButton";
            this.newSessionButton.Size = new System.Drawing.Size(91, 28);
            this.newSessionButton.TabIndex = 1;
            this.newSessionButton.Text = "New Session";
            this.newSessionButton.UseVisualStyleBackColor = false;
            // 
            // sessionSelectorBox
            // 
            this.sessionSelectorBox.FormattingEnabled = true;
            this.sessionSelectorBox.Location = new System.Drawing.Point(11, 23);
            this.sessionSelectorBox.Name = "sessionSelectorBox";
            this.sessionSelectorBox.Size = new System.Drawing.Size(188, 28);
            this.sessionSelectorBox.TabIndex = 2;
            // 
            // campSessionGroup
            // 
            this.campSessionGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.campSessionGroup.Controls.Add(this.sessionSelectorBox);
            this.campSessionGroup.Controls.Add(this.newSessionButton);
            this.campSessionGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.campSessionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campSessionGroup.ForeColor = System.Drawing.Color.White;
            this.campSessionGroup.Location = new System.Drawing.Point(12, 58);
            this.campSessionGroup.Name = "campSessionGroup";
            this.campSessionGroup.Size = new System.Drawing.Size(330, 61);
            this.campSessionGroup.TabIndex = 0;
            this.campSessionGroup.TabStop = false;
            this.campSessionGroup.Text = "Camp Session";
            // 
            // menuGroup
            // 
            this.menuGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.menuGroup.Controls.Add(this.regActButton);
            this.menuGroup.Controls.Add(this.reviewButton);
            this.menuGroup.Controls.Add(this.registrationButton);
            this.menuGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGroup.ForeColor = System.Drawing.Color.White;
            this.menuGroup.Location = new System.Drawing.Point(12, 139);
            this.menuGroup.Name = "menuGroup";
            this.menuGroup.Size = new System.Drawing.Size(529, 78);
            this.menuGroup.TabIndex = 1;
            this.menuGroup.TabStop = false;
            this.menuGroup.Text = "Menu";
            // 
            // regActButton
            // 
            this.regActButton.BackColor = System.Drawing.Color.DarkOrange;
            this.regActButton.FlatAppearance.BorderSize = 0;
            this.regActButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regActButton.ForeColor = System.Drawing.Color.White;
            this.regActButton.Location = new System.Drawing.Point(172, 27);
            this.regActButton.Name = "regActButton";
            this.regActButton.Size = new System.Drawing.Size(168, 33);
            this.regActButton.TabIndex = 2;
            this.regActButton.Text = "Register Activities";
            this.regActButton.UseVisualStyleBackColor = false;
            this.regActButton.Click += new System.EventHandler(this.regActButton_Click);
            // 
            // reviewButton
            // 
            this.reviewButton.BackColor = System.Drawing.Color.DarkOrange;
            this.reviewButton.FlatAppearance.BorderSize = 0;
            this.reviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reviewButton.ForeColor = System.Drawing.Color.White;
            this.reviewButton.Location = new System.Drawing.Point(355, 27);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(158, 33);
            this.reviewButton.TabIndex = 1;
            this.reviewButton.Text = "Review?";
            this.reviewButton.UseVisualStyleBackColor = false;
            // 
            // registrationButton
            // 
            this.registrationButton.BackColor = System.Drawing.Color.DarkOrange;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.ForeColor = System.Drawing.Color.White;
            this.registrationButton.Location = new System.Drawing.Point(11, 27);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(146, 33);
            this.registrationButton.TabIndex = 0;
            this.registrationButton.Text = "Registration";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // exportGroup
            // 
            this.exportGroup.BackColor = System.Drawing.Color.YellowGreen;
            this.exportGroup.Controls.Add(this.exDetailButton);
            this.exportGroup.Controls.Add(this.exSignupButton);
            this.exportGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportGroup.ForeColor = System.Drawing.Color.White;
            this.exportGroup.Location = new System.Drawing.Point(12, 242);
            this.exportGroup.Name = "exportGroup";
            this.exportGroup.Size = new System.Drawing.Size(382, 70);
            this.exportGroup.TabIndex = 2;
            this.exportGroup.TabStop = false;
            this.exportGroup.Text = "Export";
            // 
            // exDetailButton
            // 
            this.exDetailButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exDetailButton.FlatAppearance.BorderSize = 0;
            this.exDetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exDetailButton.ForeColor = System.Drawing.Color.White;
            this.exDetailButton.Location = new System.Drawing.Point(196, 25);
            this.exDetailButton.Name = "exDetailButton";
            this.exDetailButton.Size = new System.Drawing.Size(168, 33);
            this.exDetailButton.TabIndex = 4;
            this.exDetailButton.Text = "Detail";
            this.exDetailButton.UseVisualStyleBackColor = false;
            // 
            // exSignupButton
            // 
            this.exSignupButton.BackColor = System.Drawing.Color.DarkOrange;
            this.exSignupButton.FlatAppearance.BorderSize = 0;
            this.exSignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exSignupButton.ForeColor = System.Drawing.Color.White;
            this.exSignupButton.Location = new System.Drawing.Point(11, 25);
            this.exSignupButton.Name = "exSignupButton";
            this.exSignupButton.Size = new System.Drawing.Size(168, 33);
            this.exSignupButton.TabIndex = 3;
            this.exSignupButton.Text = "Signup Sheet";
            this.exSignupButton.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(481, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(200, 100);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(693, 333);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.exportGroup);
            this.Controls.Add(this.menuGroup);
            this.Controls.Add(this.campSessionGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.Text = "iCampThailand Home";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.campSessionGroup.ResumeLayout(false);
            this.menuGroup.ResumeLayout(false);
            this.exportGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newSessionButton;
        private System.Windows.Forms.ComboBox sessionSelectorBox;
        private System.Windows.Forms.GroupBox campSessionGroup;
        private System.Windows.Forms.GroupBox menuGroup;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Button regActButton;
        private System.Windows.Forms.Button reviewButton;
        private System.Windows.Forms.GroupBox exportGroup;
        private System.Windows.Forms.Button exDetailButton;
        private System.Windows.Forms.Button exSignupButton;
        private System.Windows.Forms.PictureBox logo;
    }
}

