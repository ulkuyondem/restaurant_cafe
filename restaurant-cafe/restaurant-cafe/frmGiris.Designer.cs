namespace restaurant_cafe
{
    partial class frmGiris
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
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.tbkullanici = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbsifre
            // 
            this.tbsifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsifre.Location = new System.Drawing.Point(1115, 354);
            this.tbsifre.Multiline = true;
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.PasswordChar = '*';
            this.tbsifre.Size = new System.Drawing.Size(223, 25);
            this.tbsifre.TabIndex = 1;
            this.tbsifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbsifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiris.BackColor = System.Drawing.Color.Transparent;
            this.btnGiris.BackgroundImage = global::restaurant_cafe.Properties.Resources.confirmed_yes_check_ok_accept_positiv_green;
            this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiris.Location = new System.Drawing.Point(1134, 408);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(92, 69);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(977, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(977, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre:";
            // 
            // btnCikis
            // 
            this.btnCikis.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.BackColor = System.Drawing.Color.Transparent;
            this.btnCikis.BackgroundImage = global::restaurant_cafe.Properties.Resources.exit_remove_delete_cross;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(1235, 408);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(91, 69);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // tbkullanici
            // 
            this.tbkullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbkullanici.Location = new System.Drawing.Point(1115, 321);
            this.tbkullanici.Multiline = true;
            this.tbkullanici.Name = "tbkullanici";
            this.tbkullanici.Size = new System.Drawing.Size(223, 25);
            this.tbkullanici.TabIndex = 7;
            this.tbkullanici.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGiris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::restaurant_cafe.Properties.Resources.IMG_20160609_WA0014;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.tbkullanici);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.tbsifre);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Girişi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox tbkullanici;
    }
}

