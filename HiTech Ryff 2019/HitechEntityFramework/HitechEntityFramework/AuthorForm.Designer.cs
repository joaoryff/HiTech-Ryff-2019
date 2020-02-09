namespace HitechEntityFramework
{
    partial class AuthorForm
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
            this.comboBoxAuthorLName = new System.Windows.Forms.ComboBox();
            this.comboBoxAuthorFname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAuthorIDsave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.SaveInventoryBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAuthorLName
            // 
            this.comboBoxAuthorLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxAuthorLName.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthorLName.FormattingEnabled = true;
            this.comboBoxAuthorLName.Location = new System.Drawing.Point(117, 124);
            this.comboBoxAuthorLName.Name = "comboBoxAuthorLName";
            this.comboBoxAuthorLName.Size = new System.Drawing.Size(150, 32);
            this.comboBoxAuthorLName.TabIndex = 144;
            // 
            // comboBoxAuthorFname
            // 
            this.comboBoxAuthorFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxAuthorFname.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthorFname.FormattingEnabled = true;
            this.comboBoxAuthorFname.Location = new System.Drawing.Point(117, 78);
            this.comboBoxAuthorFname.Name = "comboBoxAuthorFname";
            this.comboBoxAuthorFname.Size = new System.Drawing.Size(150, 32);
            this.comboBoxAuthorFname.TabIndex = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(9, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 142;
            this.label7.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 141;
            this.label4.Text = "Last Name";
            // 
            // comboBoxAuthorIDsave
            // 
            this.comboBoxAuthorIDsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBoxAuthorIDsave.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthorIDsave.FormattingEnabled = true;
            this.comboBoxAuthorIDsave.Location = new System.Drawing.Point(117, 38);
            this.comboBoxAuthorIDsave.Name = "comboBoxAuthorIDsave";
            this.comboBoxAuthorIDsave.Size = new System.Drawing.Size(150, 32);
            this.comboBoxAuthorIDsave.TabIndex = 146;
            this.comboBoxAuthorIDsave.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthorIDsave_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 24);
            this.label3.TabIndex = 145;
            this.label3.Text = "ID";
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DelBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DelBtn.Location = new System.Drawing.Point(154, 182);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(113, 63);
            this.DelBtn.TabIndex = 149;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // SaveInventoryBtn
            // 
            this.SaveInventoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveInventoryBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInventoryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SaveInventoryBtn.Location = new System.Drawing.Point(13, 182);
            this.SaveInventoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveInventoryBtn.Name = "SaveInventoryBtn";
            this.SaveInventoryBtn.Size = new System.Drawing.Size(113, 63);
            this.SaveInventoryBtn.TabIndex = 147;
            this.SaveInventoryBtn.Text = "Save";
            this.SaveInventoryBtn.UseVisualStyleBackColor = false;
            this.SaveInventoryBtn.Click += new System.EventHandler(this.SaveInventoryBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UpdateBtn.Location = new System.Drawing.Point(13, 266);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(113, 63);
            this.UpdateBtn.TabIndex = 148;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(154, 266);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 63);
            this.ExitButton.TabIndex = 150;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HitechEntityFramework.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(284, 345);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.SaveInventoryBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.comboBoxAuthorIDsave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAuthorLName);
            this.Controls.Add(this.comboBoxAuthorFname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuthorLName;
        private System.Windows.Forms.ComboBox comboBoxAuthorFname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAuthorIDsave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button SaveInventoryBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ExitButton;
    }
}