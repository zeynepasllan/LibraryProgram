
namespace KutuphaneProgrami
{
    partial class Kutuphane_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kutuphane_Giris));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGIRIS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textKULLANICIADI = new System.Windows.Forms.TextBox();
            this.textSIFRE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(190, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "PERSONEL GİRİŞ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonGIRIS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textKULLANICIADI);
            this.groupBox1.Controls.Add(this.textSIFRE);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(124, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // buttonGIRIS
            // 
            this.buttonGIRIS.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonGIRIS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGIRIS.Location = new System.Drawing.Point(110, 125);
            this.buttonGIRIS.Name = "buttonGIRIS";
            this.buttonGIRIS.Size = new System.Drawing.Size(96, 33);
            this.buttonGIRIS.TabIndex = 4;
            this.buttonGIRIS.Text = "GİRİŞ YAP";
            this.buttonGIRIS.UseVisualStyleBackColor = false;
            this.buttonGIRIS.Click += new System.EventHandler(this.buttonGIRIS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // textKULLANICIADI
            // 
            this.textKULLANICIADI.Location = new System.Drawing.Point(171, 38);
            this.textKULLANICIADI.Name = "textKULLANICIADI";
            this.textKULLANICIADI.Size = new System.Drawing.Size(100, 26);
            this.textKULLANICIADI.TabIndex = 1;
            // 
            // textSIFRE
            // 
            this.textSIFRE.Location = new System.Drawing.Point(171, 82);
            this.textSIFRE.Name = "textSIFRE";
            this.textSIFRE.PasswordChar = '*';
            this.textSIFRE.Size = new System.Drawing.Size(100, 26);
            this.textSIFRE.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(439, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "GERİ DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kutuphane_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Kutuphane_Giris";
            this.Text = "PERSONEL GİRİŞ";

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGIRIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKULLANICIADI;
        private System.Windows.Forms.TextBox textSIFRE;
        private System.Windows.Forms.Button button1;
    }
}