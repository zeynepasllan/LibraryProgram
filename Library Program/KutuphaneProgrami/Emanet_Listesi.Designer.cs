
namespace KutuphaneProgrami
{
    partial class Emanet_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emanet_Listesi));
            this.label1 = new System.Windows.Forms.Label();
            this.textEMNTARA = new System.Windows.Forms.TextBox();
            this.dgwemntliste = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonKTPHNANASAYFA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwemntliste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emanet ID ARA:";
            // 
            // textEMNTARA
            // 
            this.textEMNTARA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEMNTARA.Location = new System.Drawing.Point(171, 66);
            this.textEMNTARA.Name = "textEMNTARA";
            this.textEMNTARA.Size = new System.Drawing.Size(100, 26);
            this.textEMNTARA.TabIndex = 1;
            this.textEMNTARA.TextChanged += new System.EventHandler(this.textEMNTARA_TextChanged);
            // 
            // dgwemntliste
            // 
            this.dgwemntliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwemntliste.Location = new System.Drawing.Point(53, 102);
            this.dgwemntliste.Name = "dgwemntliste";
            this.dgwemntliste.Size = new System.Drawing.Size(719, 291);
            this.dgwemntliste.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlText;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(338, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "EMANET LİSTESİ";
            // 
            // buttonKTPHNANASAYFA
            // 
            this.buttonKTPHNANASAYFA.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonKTPHNANASAYFA.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKTPHNANASAYFA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKTPHNANASAYFA.Location = new System.Drawing.Point(655, 397);
            this.buttonKTPHNANASAYFA.Name = "buttonKTPHNANASAYFA";
            this.buttonKTPHNANASAYFA.Size = new System.Drawing.Size(117, 48);
            this.buttonKTPHNANASAYFA.TabIndex = 31;
            this.buttonKTPHNANASAYFA.Text = "KÜTÜPHANEYE DÖN";
            this.buttonKTPHNANASAYFA.UseVisualStyleBackColor = false;
            this.buttonKTPHNANASAYFA.Click += new System.EventHandler(this.buttonKTPHNANASAYFA_Click);
            // 
            // Emanet_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKTPHNANASAYFA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgwemntliste);
            this.Controls.Add(this.textEMNTARA);
            this.Controls.Add(this.label1);
            this.Name = "Emanet_Listesi";
            this.Text = "EMANET LİSTESİ";
            this.Load += new System.EventHandler(this.Emanet_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwemntliste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEMNTARA;
        private System.Windows.Forms.DataGridView dgwemntliste;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonKTPHNANASAYFA;
    }
}