
namespace KutuphaneProgrami
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.buttonOGRGİRİS = new System.Windows.Forms.Button();
            this.buttonKTPHANEGİRİS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOGRGİRİS
            // 
            this.buttonOGRGİRİS.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonOGRGİRİS.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOGRGİRİS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOGRGİRİS.Location = new System.Drawing.Point(214, 171);
            this.buttonOGRGİRİS.Name = "buttonOGRGİRİS";
            this.buttonOGRGİRİS.Size = new System.Drawing.Size(165, 64);
            this.buttonOGRGİRİS.TabIndex = 0;
            this.buttonOGRGİRİS.Text = "ÖĞRENCİ GİRİŞİ";
            this.buttonOGRGİRİS.UseVisualStyleBackColor = false;
            this.buttonOGRGİRİS.Click += new System.EventHandler(this.buttonOGRGİRİS_Click);
            // 
            // buttonKTPHANEGİRİS
            // 
            this.buttonKTPHANEGİRİS.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHANEGİRİS.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHANEGİRİS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHANEGİRİS.Location = new System.Drawing.Point(214, 258);
            this.buttonKTPHANEGİRİS.Name = "buttonKTPHANEGİRİS";
            this.buttonKTPHANEGİRİS.Size = new System.Drawing.Size(165, 64);
            this.buttonKTPHANEGİRİS.TabIndex = 1;
            this.buttonKTPHANEGİRİS.Text = "KÜTÜPHANE GİRİŞİ";
            this.buttonKTPHANEGİRİS.UseVisualStyleBackColor = false;
            this.buttonKTPHANEGİRİS.Click += new System.EventHandler(this.buttonKTPHANEGİRİS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "KİTAP DÜNYASINA HOŞGELDİNİZ";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKTPHANEGİRİS);
            this.Controls.Add(this.buttonOGRGİRİS);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Giris";
            this.Text = "KİTAP DÜNYASI";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOGRGİRİS;
        private System.Windows.Forms.Button buttonKTPHANEGİRİS;
        private System.Windows.Forms.Label label1;
    }
}