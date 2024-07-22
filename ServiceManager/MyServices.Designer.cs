using System.Windows.Forms;

namespace ServiceManager
{
    partial class MyServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyServices));
            this.ServicesGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesGridView
            // 
            this.ServicesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ServicesGridView.Location = new System.Drawing.Point(49, 78);
            this.ServicesGridView.Name = "ServicesGridView";
            this.ServicesGridView.Size = new System.Drawing.Size(695, 279);
            this.ServicesGridView.TabIndex = 0;
            // 
            // ServiceId
            // 
            this.dataGridViewTextBoxColumn1.Name = "ServiceId";
            // 
            // Service Name
            // 
            this.dataGridViewTextBoxColumn2.Name = "ServiceName";
            // 
            // Service Version
            // 
            this.dataGridViewTextBoxColumn3.Name = "ServiceVersion";
            // 
            // Service Description
            // 
            this.dataGridViewTextBoxColumn4.Name = "ServiceDescription";
            // 
            // Service Addition Date
            // 
            this.dataGridViewTextBoxColumn5.Name = "ServiceAdditionDate";
            // 
            // Service FilePath
            // 
            this.dataGridViewTextBoxColumn6.Name = "ServiceFilePath";
            // 
            // MyServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ServiceManager.Properties.Resources.vector_background_design_with_blue_gears;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServicesGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyServices";
            this.Text = "MyServices";
            ((System.ComponentModel.ISupportInitialize)(this.ServicesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ServicesGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}