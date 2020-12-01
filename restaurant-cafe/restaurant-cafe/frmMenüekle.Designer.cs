namespace restaurant_cafe
{
    partial class frmMenüekle
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
            this.rdicecek = new System.Windows.Forms.RadioButton();
            this.rdanayemek = new System.Windows.Forms.RadioButton();
            this.rdtatli = new System.Windows.Forms.RadioButton();
            this.rdcorba = new System.Windows.Forms.RadioButton();
            this.rdsalata = new System.Windows.Forms.RadioButton();
            this.rdfastfood = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbfiyati = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button16 = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btndüzenle = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdicecek
            // 
            this.rdicecek.AutoSize = true;
            this.rdicecek.BackColor = System.Drawing.Color.Transparent;
            this.rdicecek.Location = new System.Drawing.Point(329, 79);
            this.rdicecek.Name = "rdicecek";
            this.rdicecek.Size = new System.Drawing.Size(66, 20);
            this.rdicecek.TabIndex = 0;
            this.rdicecek.TabStop = true;
            this.rdicecek.Text = "İçecek";
            this.rdicecek.UseVisualStyleBackColor = false;
            this.rdicecek.CheckedChanged += new System.EventHandler(this.rdicecek_CheckedChanged);
            // 
            // rdanayemek
            // 
            this.rdanayemek.AutoSize = true;
            this.rdanayemek.BackColor = System.Drawing.Color.Transparent;
            this.rdanayemek.Location = new System.Drawing.Point(205, 79);
            this.rdanayemek.Name = "rdanayemek";
            this.rdanayemek.Size = new System.Drawing.Size(96, 20);
            this.rdanayemek.TabIndex = 1;
            this.rdanayemek.TabStop = true;
            this.rdanayemek.Text = "Ana Yemek";
            this.rdanayemek.UseVisualStyleBackColor = false;
            this.rdanayemek.CheckedChanged += new System.EventHandler(this.rdanayemek_CheckedChanged);
            // 
            // rdtatli
            // 
            this.rdtatli.AutoSize = true;
            this.rdtatli.BackColor = System.Drawing.Color.Transparent;
            this.rdtatli.Location = new System.Drawing.Point(438, 79);
            this.rdtatli.Name = "rdtatli";
            this.rdtatli.Size = new System.Drawing.Size(52, 20);
            this.rdtatli.TabIndex = 2;
            this.rdtatli.TabStop = true;
            this.rdtatli.Text = "Tatlı";
            this.rdtatli.UseVisualStyleBackColor = false;
            this.rdtatli.CheckedChanged += new System.EventHandler(this.rdtatli_CheckedChanged);
            // 
            // rdcorba
            // 
            this.rdcorba.AutoSize = true;
            this.rdcorba.BackColor = System.Drawing.Color.Transparent;
            this.rdcorba.Location = new System.Drawing.Point(535, 79);
            this.rdcorba.Name = "rdcorba";
            this.rdcorba.Size = new System.Drawing.Size(63, 20);
            this.rdcorba.TabIndex = 3;
            this.rdcorba.TabStop = true;
            this.rdcorba.Text = "Çorba";
            this.rdcorba.UseVisualStyleBackColor = false;
            this.rdcorba.CheckedChanged += new System.EventHandler(this.rdcorba_CheckedChanged);
            // 
            // rdsalata
            // 
            this.rdsalata.AutoSize = true;
            this.rdsalata.BackColor = System.Drawing.Color.Transparent;
            this.rdsalata.Location = new System.Drawing.Point(633, 79);
            this.rdsalata.Name = "rdsalata";
            this.rdsalata.Size = new System.Drawing.Size(65, 20);
            this.rdsalata.TabIndex = 4;
            this.rdsalata.TabStop = true;
            this.rdsalata.Text = "Salata";
            this.rdsalata.UseVisualStyleBackColor = false;
            this.rdsalata.CheckedChanged += new System.EventHandler(this.rdsalata_CheckedChanged);
            // 
            // rdfastfood
            // 
            this.rdfastfood.AutoSize = true;
            this.rdfastfood.BackColor = System.Drawing.Color.Transparent;
            this.rdfastfood.Location = new System.Drawing.Point(733, 79);
            this.rdfastfood.Name = "rdfastfood";
            this.rdfastfood.Size = new System.Drawing.Size(79, 20);
            this.rdfastfood.TabIndex = 5;
            this.rdfastfood.TabStop = true;
            this.rdfastfood.Text = "Fastfood";
            this.rdfastfood.UseVisualStyleBackColor = false;
            this.rdfastfood.CheckedChanged += new System.EventHandler(this.rdfastfood_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(140, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ürün ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(140, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(140, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ürün Fyatı:";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(273, 170);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(122, 22);
            this.tbid.TabIndex = 9;
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(273, 210);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(122, 22);
            this.tbadi.TabIndex = 10;
            // 
            // tbfiyati
            // 
            this.tbfiyati.Location = new System.Drawing.Point(273, 250);
            this.tbfiyati.Name = "tbfiyati";
            this.tbfiyati.Size = new System.Drawing.Size(122, 22);
            this.tbfiyati.TabIndex = 11;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnkaydet.BackgroundImage = global::restaurant_cafe.Properties.Resources.Checklist_512;
            this.btnkaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkaydet.Location = new System.Drawing.Point(988, 550);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(89, 81);
            this.btnkaydet.TabIndex = 12;
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(143, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 310);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Ürün Kodu";
            this.ID.Name = "ID";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.BackgroundImage = global::restaurant_cafe.Properties.Resources.Home_icon_black;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Location = new System.Drawing.Point(1154, 44);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(77, 67);
            this.button16.TabIndex = 18;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.Transparent;
            this.btniptal.BackgroundImage = global::restaurant_cafe.Properties.Resources._1_08_512;
            this.btniptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btniptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniptal.Location = new System.Drawing.Point(988, 238);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(89, 81);
            this.btniptal.TabIndex = 19;
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.BackgroundImage = global::restaurant_cafe.Properties.Resources._91_UI_app_icons_100_ai_512;
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.Location = new System.Drawing.Point(988, 343);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(89, 81);
            this.btnsil.TabIndex = 20;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackgroundImage = global::restaurant_cafe.Properties.Resources._698438_icon_33_clipboard_add_512;
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnekle.Location = new System.Drawing.Point(988, 132);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(90, 81);
            this.btnekle.TabIndex = 21;
            this.btnekle.Text = "Ekle ";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndüzenle
            // 
            this.btndüzenle.BackgroundImage = global::restaurant_cafe.Properties.Resources.pen_write_file_512;
            this.btndüzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndüzenle.Location = new System.Drawing.Point(988, 446);
            this.btndüzenle.Name = "btndüzenle";
            this.btndüzenle.Size = new System.Drawing.Size(89, 81);
            this.btndüzenle.TabIndex = 22;
            this.btndüzenle.UseVisualStyleBackColor = true;
            this.btndüzenle.Click += new System.EventHandler(this.btndüzenle_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(1063, 446);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1111, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "* Yeni Ürün";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1111, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "* İptal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1111, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "* Sil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1111, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "* Düzenle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1111, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 41;
            this.label8.Text = "* Kaydet";
            // 
            // frmMenüekle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::restaurant_cafe.Properties.Resources.pmbe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btndüzenle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btniptal);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.tbfiyati);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdfastfood);
            this.Controls.Add(this.rdsalata);
            this.Controls.Add(this.rdcorba);
            this.Controls.Add(this.rdtatli);
            this.Controls.Add(this.rdanayemek);
            this.Controls.Add(this.rdicecek);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenüekle";
            this.Text = "v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenüekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdicecek;
        private System.Windows.Forms.RadioButton rdanayemek;
        private System.Windows.Forms.RadioButton rdtatli;
        private System.Windows.Forms.RadioButton rdcorba;
        private System.Windows.Forms.RadioButton rdsalata;
        private System.Windows.Forms.RadioButton rdfastfood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbfiyati;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button btndüzenle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}