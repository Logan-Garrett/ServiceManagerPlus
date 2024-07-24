namespace ServiceManager
{
    partial class information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(information));
            this.informationGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoHeaderLabel = new System.Windows.Forms.Label();
            this.informationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationGroupBox
            // 
            this.informationGroupBox.Controls.Add(this.InfoHeaderLabel);
            this.informationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.informationGroupBox.Location = new System.Drawing.Point(204, 28);
            this.informationGroupBox.Name = "informationGroupBox";
            this.informationGroupBox.Size = new System.Drawing.Size(360, 381);
            this.informationGroupBox.TabIndex = 0;
            this.informationGroupBox.TabStop = false;
            this.informationGroupBox.Enter += new System.EventHandler(this.information_Enter);
            // 
            // InfoHeaderLabel
            // 
            this.InfoHeaderLabel.AutoSize = true;
            this.InfoHeaderLabel.Location = new System.Drawing.Point(159, 16);
            this.InfoHeaderLabel.Name = "InfoHeaderLabel";
            this.InfoHeaderLabel.Size = new System.Drawing.Size(25, 13);
            this.InfoHeaderLabel.TabIndex = 0;
            this.InfoHeaderLabel.Text = "Info";
            this.InfoHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceManager.Properties.Resources.vector_background_design_with_blue_gears;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.informationGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "information";
            this.Text = "information";
            this.informationGroupBox.ResumeLayout(false);
            this.informationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox informationGroupBox;
        private System.Windows.Forms.Label InfoHeaderLabel;
    }
}