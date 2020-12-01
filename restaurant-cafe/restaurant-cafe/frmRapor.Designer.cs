namespace restaurant_cafe
{
    partial class frmRapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.restaurantDataSet = new restaurant_cafe.restaurantDataSet();
            this.rezervasyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyonTableAdapter = new restaurant_cafe.restaurantDataSetTableAdapters.rezervasyonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::restaurant_cafe.Properties.Resources.Home_icon_black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(770, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 67);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rezervasyonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "restaurant_cafe.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(712, 354);
            this.reportViewer1.TabIndex = 23;
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyonBindingSource
            // 
            this.rezervasyonBindingSource.DataMember = "rezervasyon";
            this.rezervasyonBindingSource.DataSource = this.restaurantDataSet;
            // 
            // rezervasyonTableAdapter
            // 
            this.rezervasyonTableAdapter.ClearBeforeFill = true;
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 418);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rezervasyonBindingSource;
        private restaurantDataSet restaurantDataSet;
        private restaurantDataSetTableAdapters.rezervasyonTableAdapter rezervasyonTableAdapter;
    }
}