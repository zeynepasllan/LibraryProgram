
namespace KutuphaneProgrami
{
    partial class Kitap_Islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Islemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.textKTPIDD = new System.Windows.Forms.TextBox();
            this.buttonKTPEKLE = new System.Windows.Forms.Button();
            this.buttonKTPSIL = new System.Windows.Forms.Button();
            this.buttonKTPGUNC = new System.Windows.Forms.Button();
            this.dgwKITAP = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textKITAPADI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textYAZARI = new System.Windows.Forms.TextBox();
            this.dtpBASIMTARIHI = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textYAYINEVI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSAYFASAYISI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTURU = new System.Windows.Forms.TextBox();
            this.buttonKTPHNANASAYFA = new System.Windows.Forms.Button();
            this.textKITAPARA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKITAP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(570, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // textKTPIDD
            // 
            this.textKTPIDD.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKTPIDD.Location = new System.Drawing.Point(607, 53);
            this.textKTPIDD.Name = "textKTPIDD";
            this.textKTPIDD.Size = new System.Drawing.Size(100, 26);
            this.textKTPIDD.TabIndex = 1;
    
            // 
            // buttonKTPEKLE
            // 
            this.buttonKTPEKLE.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPEKLE.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPEKLE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPEKLE.Location = new System.Drawing.Point(37, 372);
            this.buttonKTPEKLE.Name = "buttonKTPEKLE";
            this.buttonKTPEKLE.Size = new System.Drawing.Size(75, 33);
            this.buttonKTPEKLE.TabIndex = 14;
            this.buttonKTPEKLE.Text = "EKLE";
            this.buttonKTPEKLE.UseVisualStyleBackColor = false;
            this.buttonKTPEKLE.Click += new System.EventHandler(this.buttonKTPEKLE_Click);
            // 
            // buttonKTPSIL
            // 
            this.buttonKTPSIL.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPSIL.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPSIL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPSIL.Location = new System.Drawing.Point(713, 53);
            this.buttonKTPSIL.Name = "buttonKTPSIL";
            this.buttonKTPSIL.Size = new System.Drawing.Size(75, 26);
            this.buttonKTPSIL.TabIndex = 15;
            this.buttonKTPSIL.Text = "SİL";
            this.buttonKTPSIL.UseVisualStyleBackColor = false;
            this.buttonKTPSIL.Click += new System.EventHandler(this.buttonKTPSIL_Click);
            // 
            // buttonKTPGUNC
            // 
            this.buttonKTPGUNC.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPGUNC.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPGUNC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPGUNC.Location = new System.Drawing.Point(140, 372);
            this.buttonKTPGUNC.Name = "buttonKTPGUNC";
            this.buttonKTPGUNC.Size = new System.Drawing.Size(92, 33);
            this.buttonKTPGUNC.TabIndex = 16;
            this.buttonKTPGUNC.Text = "GÜNCELLE";
            this.buttonKTPGUNC.UseVisualStyleBackColor = false;
            this.buttonKTPGUNC.Click += new System.EventHandler(this.buttonKTPGUNC_Click);
            // 
            // dgwKITAP
            // 
            this.dgwKITAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKITAP.Location = new System.Drawing.Point(265, 85);
            this.dgwKITAP.Name = "dgwKITAP";
            this.dgwKITAP.Size = new System.Drawing.Size(552, 277);
            this.dgwKITAP.TabIndex = 17;
            this.dgwKITAP.SelectionChanged += new System.EventHandler(this.dgwKITAP_SelectionChanged);
            this.dgwKITAP.Click += new System.EventHandler(this.kitapislem_Load);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(328, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "KİTAP İŞLEMLERİ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textKITAPADI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textYAZARI);
            this.groupBox1.Controls.Add(this.dtpBASIMTARIHI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textYAYINEVI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textSAYFASAYISI);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textTURU);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(7, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 306);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // textKITAPADI
            // 
            this.textKITAPADI.Location = new System.Drawing.Point(109, 48);
            this.textKITAPADI.Name = "textKITAPADI";
            this.textKITAPADI.Size = new System.Drawing.Size(125, 26);
            this.textKITAPADI.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yazarı:";
            // 
            // textYAZARI
            // 
            this.textYAZARI.Location = new System.Drawing.Point(109, 85);
            this.textYAZARI.Name = "textYAZARI";
            this.textYAZARI.Size = new System.Drawing.Size(125, 26);
            this.textYAZARI.TabIndex = 5;
            // 
            // dtpBASIMTARIHI
            // 
            this.dtpBASIMTARIHI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBASIMTARIHI.Location = new System.Drawing.Point(109, 230);
            this.dtpBASIMTARIHI.Name = "dtpBASIMTARIHI";
            this.dtpBASIMTARIHI.Size = new System.Drawing.Size(125, 26);
            this.dtpBASIMTARIHI.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yayınevi:";
            // 
            // textYAYINEVI
            // 
            this.textYAYINEVI.Location = new System.Drawing.Point(109, 124);
            this.textYAYINEVI.Name = "textYAYINEVI";
            this.textYAYINEVI.Size = new System.Drawing.Size(125, 26);
            this.textYAYINEVI.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // textSAYFASAYISI
            // 
            this.textSAYFASAYISI.Location = new System.Drawing.Point(109, 160);
            this.textSAYFASAYISI.Name = "textSAYFASAYISI";
            this.textSAYFASAYISI.Size = new System.Drawing.Size(125, 26);
            this.textSAYFASAYISI.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Türü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Basım Tarihi:";
            // 
            // textTURU
            // 
            this.textTURU.Location = new System.Drawing.Point(109, 194);
            this.textTURU.Name = "textTURU";
            this.textTURU.Size = new System.Drawing.Size(125, 26);
            this.textTURU.TabIndex = 11;
            // 
            // buttonKTPHNANASAYFA
            // 
            this.buttonKTPHNANASAYFA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHNANASAYFA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHNANASAYFA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHNANASAYFA.Location = new System.Drawing.Point(700, 372);
            this.buttonKTPHNANASAYFA.Name = "buttonKTPHNANASAYFA";
            this.buttonKTPHNANASAYFA.Size = new System.Drawing.Size(117, 48);
            this.buttonKTPHNANASAYFA.TabIndex = 24;
            this.buttonKTPHNANASAYFA.Text = "KÜTÜPHANEYE DÖN";
            this.buttonKTPHNANASAYFA.UseVisualStyleBackColor = false;
            this.buttonKTPHNANASAYFA.Click += new System.EventHandler(this.buttonKTPHNANASAYFA_Click);
            // 
            // textKITAPARA
            // 
            this.textKITAPARA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKITAPARA.Location = new System.Drawing.Point(376, 54);
            this.textKITAPARA.Name = "textKITAPARA";
            this.textKITAPARA.Size = new System.Drawing.Size(100, 26);
            this.textKITAPARA.TabIndex = 25;
            this.textKITAPARA.TextChanged += new System.EventHandler(this.textKITAPARA_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlText;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(261, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kitap Adı ARA:";
            // 
            // Kitap_Islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 427);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textKITAPARA);
            this.Controls.Add(this.buttonKTPHNANASAYFA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgwKITAP);
            this.Controls.Add(this.buttonKTPGUNC);
            this.Controls.Add(this.buttonKTPSIL);
            this.Controls.Add(this.buttonKTPEKLE);
            this.Controls.Add(this.textKTPIDD);
            this.Controls.Add(this.label1);
            this.Name = "Kitap_Islemleri";
            this.Text = "KİTAP İŞLEMLERİ";
            this.Load += new System.EventHandler(this.kitapislem_Load);
            this.Click += new System.EventHandler(this.kitapislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKITAP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKTPIDD;
        private System.Windows.Forms.Button buttonKTPEKLE;
        private System.Windows.Forms.Button buttonKTPSIL;
        private System.Windows.Forms.Button buttonKTPGUNC;
        private System.Windows.Forms.DataGridView dgwKITAP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKITAPADI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textYAZARI;
        private System.Windows.Forms.DateTimePicker dtpBASIMTARIHI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textYAYINEVI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSAYFASAYISI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textTURU;
        private System.Windows.Forms.Button buttonKTPHNANASAYFA;
        private System.Windows.Forms.TextBox textKITAPARA;
        private System.Windows.Forms.Label label9;
    }
}