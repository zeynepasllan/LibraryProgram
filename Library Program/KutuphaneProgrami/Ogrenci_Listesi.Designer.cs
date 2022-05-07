
namespace KutuphaneProgrami
{
    partial class Ogrenci_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Listesi));
            this.label1 = new System.Windows.Forms.Label();
            this.textograra = new System.Windows.Forms.TextBox();
            this.dgwogrlistele = new System.Windows.Forms.DataGridView();
            this.buttonKTPHNANASAYFA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwogrlistele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı ARA:";
            // 
            // textograra
            // 
            this.textograra.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textograra.Location = new System.Drawing.Point(187, 61);
            this.textograra.Name = "textograra";
            this.textograra.Size = new System.Drawing.Size(100, 26);
            this.textograra.TabIndex = 1;
            this.textograra.TextChanged += new System.EventHandler(this.textograra_TextChanged);
            // 
            // dgwogrlistele
            // 
            this.dgwogrlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwogrlistele.Location = new System.Drawing.Point(64, 102);
            this.dgwogrlistele.Name = "dgwogrlistele";
            this.dgwogrlistele.Size = new System.Drawing.Size(688, 282);
            this.dgwogrlistele.TabIndex = 3;
            // 
            // buttonKTPHNANASAYFA
            // 
            this.buttonKTPHNANASAYFA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHNANASAYFA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHNANASAYFA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHNANASAYFA.Location = new System.Drawing.Point(635, 390);
            this.buttonKTPHNANASAYFA.Name = "buttonKTPHNANASAYFA";
            this.buttonKTPHNANASAYFA.Size = new System.Drawing.Size(117, 48);
            this.buttonKTPHNANASAYFA.TabIndex = 32;
            this.buttonKTPHNANASAYFA.Text = "KÜTÜPHANEYE DÖN";
            this.buttonKTPHNANASAYFA.UseVisualStyleBackColor = false;
            this.buttonKTPHNANASAYFA.Click += new System.EventHandler(this.buttonKTPHNANASAYFA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(317, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // Ogrenci_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKTPHNANASAYFA);
            this.Controls.Add(this.dgwogrlistele);
            this.Controls.Add(this.textograra);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci_Listesi";
            this.Text = "ÖĞRENCİ LİSTESİ";
   
            ((System.ComponentModel.ISupportInitialize)(this.dgwogrlistele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textograra;
        private System.Windows.Forms.DataGridView dgwogrlistele;
        private System.Windows.Forms.Button buttonKTPHNANASAYFA;
        private System.Windows.Forms.Label label2;
    }
}