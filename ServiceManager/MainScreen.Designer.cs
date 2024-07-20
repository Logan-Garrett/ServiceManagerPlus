using System.Drawing;

namespace ServiceManager
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.ProgramName = new System.Windows.Forms.Label();
            this.Select_Folder_Location = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserTextBox = new System.Windows.Forms.TextBox();
            this.TestServerConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Arial", 10F);
            this.Add.Location = new System.Drawing.Point(160, 222);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(217, 35);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Arial", 10F);
            this.Delete.Location = new System.Drawing.Point(393, 222);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(217, 35);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ServiceName
            // 
            this.ServiceName.Font = new System.Drawing.Font("Arial", 20F);
            this.ServiceName.ForeColor = System.Drawing.Color.LightGray;
            this.ServiceName.Location = new System.Drawing.Point(160, 159);
            this.ServiceName.Multiline = true;
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(450, 40);
            this.ServiceName.TabIndex = 2;
            this.ServiceName.Text = "Service Name Here...";
            this.ServiceName.Click += new System.EventHandler(this.ServiceNameClear_Click);
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramName.Location = new System.Drawing.Point(224, 83);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(343, 46);
            this.ProgramName.TabIndex = 3;
            this.ProgramName.Text = "Service Manager+";
            // 
            // Select_Folder_Location
            // 
            this.Select_Folder_Location.Font = new System.Drawing.Font("Arial", 10F);
            this.Select_Folder_Location.Location = new System.Drawing.Point(160, 275);
            this.Select_Folder_Location.Name = "Select_Folder_Location";
            this.Select_Folder_Location.Size = new System.Drawing.Size(160, 41);
            this.Select_Folder_Location.TabIndex = 4;
            this.Select_Folder_Location.Text = "Select Folder Location";
            this.Select_Folder_Location.UseVisualStyleBackColor = true;
            this.Select_Folder_Location.Click += new System.EventHandler(this.Select_Folder_Location_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // folderBrowserTextBox
            // 
            this.folderBrowserTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.folderBrowserTextBox.Location = new System.Drawing.Point(326, 275);
            this.folderBrowserTextBox.Multiline = true;
            this.folderBrowserTextBox.Name = "folderBrowserTextBox";
            this.folderBrowserTextBox.Size = new System.Drawing.Size(284, 41);
            this.folderBrowserTextBox.TabIndex = 5;
            // 
            // TestServerConnection
            // 
            this.TestServerConnection.Location = new System.Drawing.Point(213, 391);
            this.TestServerConnection.Name = "TestServerConnection";
            this.TestServerConnection.Size = new System.Drawing.Size(75, 23);
            this.TestServerConnection.TabIndex = 6;
            this.TestServerConnection.Text = "TestServerConnection";
            this.TestServerConnection.UseVisualStyleBackColor = true;
            this.TestServerConnection.Click += new System.EventHandler(this.TestServerConnection_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestServerConnection);
            this.Controls.Add(this.folderBrowserTextBox);
            this.Controls.Add(this.Select_Folder_Location);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.ServiceName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.Text = "ServiceManger+";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox ServiceName;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Button Select_Folder_Location;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox folderBrowserTextBox;
        private System.Windows.Forms.Button TestServerConnection;
    }
}

