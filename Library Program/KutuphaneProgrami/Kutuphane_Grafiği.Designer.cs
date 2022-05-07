
namespace KutuphaneProgrami
{
    partial class Kutuphane_Grafiği
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kutuphane_Grafiği));
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKTPHNANASAYFA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(33, 74);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(500, 375);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(191, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "KÜTÜPHANE GRAFİĞİ";
            // 
            // buttonKTPHNANASAYFA
            // 
            this.buttonKTPHNANASAYFA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHNANASAYFA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHNANASAYFA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHNANASAYFA.Location = new System.Drawing.Point(416, 455);
            this.buttonKTPHNANASAYFA.Name = "buttonKTPHNANASAYFA";
            this.buttonKTPHNANASAYFA.Size = new System.Drawing.Size(117, 48);
            this.buttonKTPHNANASAYFA.TabIndex = 25;
            this.buttonKTPHNANASAYFA.Text = "KÜTÜPHANEYE DÖN";
            this.buttonKTPHNANASAYFA.UseVisualStyleBackColor = false;
            this.buttonKTPHNANASAYFA.Click += new System.EventHandler(this.buttonKTPHNANASAYFA_Click);
            // 
            // Kutuphane_Grafiği
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(564, 506);
            this.Controls.Add(this.buttonKTPHNANASAYFA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Kutuphane_Grafiği";
            this.Text = "KÜTÜPHANE GRAFİĞİ";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKTPHNANASAYFA;
    }
}