
namespace KutuphaneProgrami
{
    partial class Ogrenci_Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Anasayfa));
            this.buttonEMANETLISTE = new System.Windows.Forms.Button();
            this.buttonKITAPLISTE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEMANETLISTE
            // 
            this.buttonEMANETLISTE.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonEMANETLISTE.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEMANETLISTE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEMANETLISTE.Location = new System.Drawing.Point(198, 137);
            this.buttonEMANETLISTE.Name = "buttonEMANETLISTE";
            this.buttonEMANETLISTE.Size = new System.Drawing.Size(179, 58);
            this.buttonEMANETLISTE.TabIndex = 0;
            this.buttonEMANETLISTE.Text = "BORÇ SORGULA";
            this.buttonEMANETLISTE.UseVisualStyleBackColor = false;
            this.buttonEMANETLISTE.Click += new System.EventHandler(this.buttonEMANETLISTE_Click);
            // 
            // buttonKITAPLISTE
            // 
            this.buttonKITAPLISTE.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKITAPLISTE.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKITAPLISTE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKITAPLISTE.Location = new System.Drawing.Point(198, 223);
            this.buttonKITAPLISTE.Name = "buttonKITAPLISTE";
            this.buttonKITAPLISTE.Size = new System.Drawing.Size(179, 56);
            this.buttonKITAPLISTE.TabIndex = 1;
            this.buttonKITAPLISTE.Text = "KİTAP ARA";
            this.buttonKITAPLISTE.UseVisualStyleBackColor = false;
            this.buttonKITAPLISTE.Click += new System.EventHandler(this.buttonKITAPLISTE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(382, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "GİRİŞE DÖN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(214, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "KİTAP DÜNYASI";
            // 
            // Ogrenci_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKITAPLISTE);
            this.Controls.Add(this.buttonEMANETLISTE);
            this.Name = "Ogrenci_Anasayfa";
            this.Text = "KİTAP DÜNYASI";
      
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEMANETLISTE;
        private System.Windows.Forms.Button buttonKITAPLISTE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}