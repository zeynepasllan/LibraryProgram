
namespace KutuphaneProgrami
{
    partial class Iade_Islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Iade_Islemleri));
            this.dgwemanetliste = new System.Windows.Forms.DataGridView();
            this.textEMANETID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textogrid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textktpid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textborc = new System.Windows.Forms.TextBox();
            this.dtpTESLIMEDILENTARIH = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonIADEET = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textEMANETARA = new System.Windows.Forms.TextBox();
            this.buttonSIL = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textiade = new System.Windows.Forms.TextBox();
            this.textkitapalimi = new System.Windows.Forms.TextBox();
            this.buttonKTPHNANASAYFA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwemanetliste)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwemanetliste
            // 
            this.dgwemanetliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwemanetliste.Location = new System.Drawing.Point(316, 80);
            this.dgwemanetliste.Name = "dgwemanetliste";
            this.dgwemanetliste.Size = new System.Drawing.Size(550, 312);
            this.dgwemanetliste.TabIndex = 0;
            // 
            // textEMANETID
            // 
            this.textEMANETID.Location = new System.Drawing.Point(159, 28);
            this.textEMANETID.Name = "textEMANETID";
            this.textEMANETID.Size = new System.Drawing.Size(115, 26);
            this.textEMANETID.TabIndex = 1;
            this.textEMANETID.TextChanged += new System.EventHandler(this.textEMANETID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emanet ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğrenci ID:";
            // 
            // textogrid
            // 
            this.textogrid.Location = new System.Drawing.Point(159, 64);
            this.textogrid.Name = "textogrid";
            this.textogrid.Size = new System.Drawing.Size(115, 26);
            this.textogrid.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap ID:";
            // 
            // textktpid
            // 
            this.textktpid.Location = new System.Drawing.Point(159, 100);
            this.textktpid.Name = "textktpid";
            this.textktpid.Size = new System.Drawing.Size(115, 26);
            this.textktpid.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kitap Alım Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "İade Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Borç:";
            // 
            // textborc
            // 
            this.textborc.Location = new System.Drawing.Point(159, 215);
            this.textborc.Name = "textborc";
            this.textborc.ReadOnly = true;
            this.textborc.Size = new System.Drawing.Size(115, 26);
            this.textborc.TabIndex = 11;
            // 
            // dtpTESLIMEDILENTARIH
            // 
            this.dtpTESLIMEDILENTARIH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTESLIMEDILENTARIH.Location = new System.Drawing.Point(159, 251);
            this.dtpTESLIMEDILENTARIH.Name = "dtpTESLIMEDILENTARIH";
            this.dtpTESLIMEDILENTARIH.Size = new System.Drawing.Size(115, 26);
            this.dtpTESLIMEDILENTARIH.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Teslim Edilen Tarih:";
            // 
            // buttonIADEET
            // 
            this.buttonIADEET.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonIADEET.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIADEET.Location = new System.Drawing.Point(152, 283);
            this.buttonIADEET.Name = "buttonIADEET";
            this.buttonIADEET.Size = new System.Drawing.Size(130, 50);
            this.buttonIADEET.TabIndex = 15;
            this.buttonIADEET.Text = "KİTAP İADE ET";
            this.buttonIADEET.UseVisualStyleBackColor = false;
            this.buttonIADEET.Click += new System.EventHandler(this.buttonIADEET_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(592, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Emanet ID:";
            // 
            // textEMANETARA
            // 
            this.textEMANETARA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEMANETARA.Location = new System.Drawing.Point(680, 50);
            this.textEMANETARA.Name = "textEMANETARA";
            this.textEMANETARA.Size = new System.Drawing.Size(100, 26);
            this.textEMANETARA.TabIndex = 17;
            // 
            // buttonSIL
            // 
            this.buttonSIL.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonSIL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSIL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSIL.Location = new System.Drawing.Point(786, 49);
            this.buttonSIL.Name = "buttonSIL";
            this.buttonSIL.Size = new System.Drawing.Size(80, 26);
            this.buttonSIL.TabIndex = 18;
            this.buttonSIL.Text = "SİL";
            this.buttonSIL.UseVisualStyleBackColor = false;
            this.buttonSIL.Click += new System.EventHandler(this.buttonSIL_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlText;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(358, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "İADE İŞLEMLERİ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textiade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textkitapalimi);
            this.groupBox1.Controls.Add(this.textEMANETID);
            this.groupBox1.Controls.Add(this.textogrid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textktpid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonIADEET);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpTESLIMEDILENTARIH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textborc);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 342);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Bilgileri";
       
            // 
            // textiade
            // 
            this.textiade.Location = new System.Drawing.Point(159, 181);
            this.textiade.Name = "textiade";
            this.textiade.ReadOnly = true;
            this.textiade.Size = new System.Drawing.Size(115, 26);
            this.textiade.TabIndex = 34;
            // 
            // textkitapalimi
            // 
            this.textkitapalimi.Location = new System.Drawing.Point(159, 141);
            this.textkitapalimi.Name = "textkitapalimi";
            this.textkitapalimi.ReadOnly = true;
            this.textkitapalimi.Size = new System.Drawing.Size(115, 26);
            this.textkitapalimi.TabIndex = 33;
            // 
            // buttonKTPHNANASAYFA
            // 
            this.buttonKTPHNANASAYFA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHNANASAYFA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHNANASAYFA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHNANASAYFA.Location = new System.Drawing.Point(749, 398);
            this.buttonKTPHNANASAYFA.Name = "buttonKTPHNANASAYFA";
            this.buttonKTPHNANASAYFA.Size = new System.Drawing.Size(117, 48);
            this.buttonKTPHNANASAYFA.TabIndex = 32;
            this.buttonKTPHNANASAYFA.Text = "KÜTÜPHANEYE DÖN";
            this.buttonKTPHNANASAYFA.UseVisualStyleBackColor = false;
            this.buttonKTPHNANASAYFA.Click += new System.EventHandler(this.buttonKTPHNANASAYFA_Click);
            // 
            // Iade_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.buttonKTPHNANASAYFA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSIL);
            this.Controls.Add(this.textEMANETARA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgwemanetliste);
            this.Name = "Iade_Islemleri";
            this.Text = "İADE İŞLEMLERİ";
          
            ((System.ComponentModel.ISupportInitialize)(this.dgwemanetliste)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwemanetliste;
        private System.Windows.Forms.TextBox textEMANETID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textogrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textktpid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textborc;
        private System.Windows.Forms.DateTimePicker dtpTESLIMEDILENTARIH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonIADEET;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEMANETARA;
        private System.Windows.Forms.Button buttonSIL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKTPHNANASAYFA;
        private System.Windows.Forms.TextBox textkitapalimi;
        private System.Windows.Forms.TextBox textiade;
    }
}