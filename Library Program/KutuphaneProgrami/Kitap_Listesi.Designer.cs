
namespace KutuphaneProgrami
{
    partial class Kitap_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Listesi));
            this.label1 = new System.Windows.Forms.Label();
            this.textKITAPARA = new System.Windows.Forms.TextBox();
            this.dgwKITAPARA = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonKTPHNANASAYFA = new System.Windows.Forms.Button();
            this.dgwKITAPBILGI = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBASIMTARIHI = new System.Windows.Forms.TextBox();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYAZAR = new System.Windows.Forms.TextBox();
            this.textBoxTURU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYAYINEVI = new System.Windows.Forms.TextBox();
            this.textBoxSYFSAYISI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonKITAPARA = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKITAPARA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKITAPBILGI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(302, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // textKITAPARA
            // 
            this.textKITAPARA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKITAPARA.Location = new System.Drawing.Point(378, 56);
            this.textKITAPARA.Name = "textKITAPARA";
            this.textKITAPARA.Size = new System.Drawing.Size(100, 26);
            this.textKITAPARA.TabIndex = 1;
            this.textKITAPARA.TextChanged += new System.EventHandler(this.textKITAPARA_TextChanged);
            // 
            // dgwKITAPARA
            // 
            this.dgwKITAPARA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKITAPARA.Location = new System.Drawing.Point(293, 84);
            this.dgwKITAPARA.Name = "dgwKITAPARA";
            this.dgwKITAPARA.Size = new System.Drawing.Size(527, 249);
            this.dgwKITAPARA.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlText;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(340, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "KİTAP LİSTESİ";
            // 
            // buttonKTPHNANASAYFA
            // 
            this.buttonKTPHNANASAYFA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHNANASAYFA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHNANASAYFA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHNANASAYFA.Location = new System.Drawing.Point(703, 339);
            this.buttonKTPHNANASAYFA.Name = "buttonKTPHNANASAYFA";
            this.buttonKTPHNANASAYFA.Size = new System.Drawing.Size(117, 48);
            this.buttonKTPHNANASAYFA.TabIndex = 31;
            this.buttonKTPHNANASAYFA.Text = "KÜTÜPHANEYE DÖN";
            this.buttonKTPHNANASAYFA.UseVisualStyleBackColor = false;
            this.buttonKTPHNANASAYFA.Click += new System.EventHandler(this.buttonKTPHNANASAYFA_Click);
            // 
            // dgwKITAPBILGI
            // 
            this.dgwKITAPBILGI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKITAPBILGI.Location = new System.Drawing.Point(474, 168);
            this.dgwKITAPBILGI.Name = "dgwKITAPBILGI";
            this.dgwKITAPBILGI.Size = new System.Drawing.Size(75, 46);
            this.dgwKITAPBILGI.TabIndex = 35;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(119, 34);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(133, 26);
            this.textBoxID.TabIndex = 58;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Basım Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ad:";
            // 
            // textBoxBASIMTARIHI
            // 
            this.textBoxBASIMTARIHI.Location = new System.Drawing.Point(119, 225);
            this.textBoxBASIMTARIHI.Name = "textBoxBASIMTARIHI";
            this.textBoxBASIMTARIHI.Size = new System.Drawing.Size(133, 26);
            this.textBoxBASIMTARIHI.TabIndex = 56;
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(119, 72);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(133, 26);
            this.textBoxAD.TabIndex = 46;
    
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "Türü:";
            // 
            // textBoxYAZAR
            // 
            this.textBoxYAZAR.Location = new System.Drawing.Point(119, 105);
            this.textBoxYAZAR.Name = "textBoxYAZAR";
            this.textBoxYAZAR.Size = new System.Drawing.Size(133, 26);
            this.textBoxYAZAR.TabIndex = 48;
            // 
            // textBoxTURU
            // 
            this.textBoxTURU.Location = new System.Drawing.Point(119, 194);
            this.textBoxTURU.Name = "textBoxTURU";
            this.textBoxTURU.Size = new System.Drawing.Size(133, 26);
            this.textBoxTURU.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Yazar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Sayfa Sayısı:";
            // 
            // textBoxYAYINEVI
            // 
            this.textBoxYAYINEVI.Location = new System.Drawing.Point(119, 137);
            this.textBoxYAYINEVI.Name = "textBoxYAYINEVI";
            this.textBoxYAYINEVI.Size = new System.Drawing.Size(133, 26);
            this.textBoxYAYINEVI.TabIndex = 50;
            // 
            // textBoxSYFSAYISI
            // 
            this.textBoxSYFSAYISI.Location = new System.Drawing.Point(119, 165);
            this.textBoxSYFSAYISI.Name = "textBoxSYFSAYISI";
            this.textBoxSYFSAYISI.Size = new System.Drawing.Size(133, 26);
            this.textBoxSYFSAYISI.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Yayınevi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Kitap ID ARA:";
            // 
            // buttonKITAPARA
            // 
            this.buttonKITAPARA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKITAPARA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKITAPARA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKITAPARA.Location = new System.Drawing.Point(484, 56);
            this.buttonKITAPARA.Name = "buttonKITAPARA";
            this.buttonKITAPARA.Size = new System.Drawing.Size(183, 26);
            this.buttonKITAPARA.TabIndex = 2;
            this.buttonKITAPARA.Text = "KİTABI KİMLER ALMIŞ?";
            this.buttonKITAPARA.UseVisualStyleBackColor = false;
            this.buttonKITAPARA.Click += new System.EventHandler(this.buttonKITAPARA_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBASIMTARIHI);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.textBoxSYFSAYISI);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxYAYINEVI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAD);
            this.groupBox1.Controls.Add(this.textBoxTURU);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxYAZAR);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 274);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bilgileri";
            // 
            // Kitap_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(832, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonKTPHNANASAYFA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgwKITAPARA);
            this.Controls.Add(this.buttonKITAPARA);
            this.Controls.Add(this.textKITAPARA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwKITAPBILGI);
            this.Name = "Kitap_Listesi";
            this.Text = "KİTAP LİSTESİ";
        
            ((System.ComponentModel.ISupportInitialize)(this.dgwKITAPARA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKITAPBILGI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKITAPARA;
        private System.Windows.Forms.DataGridView dgwKITAPARA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonKTPHNANASAYFA;
        private System.Windows.Forms.DataGridView dgwKITAPBILGI;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBASIMTARIHI;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYAZAR;
        private System.Windows.Forms.TextBox textBoxTURU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYAYINEVI;
        private System.Windows.Forms.TextBox textBoxSYFSAYISI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonKITAPARA;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}