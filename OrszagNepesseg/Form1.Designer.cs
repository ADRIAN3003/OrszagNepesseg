
namespace OrszagNepesseg
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFajl = new System.Windows.Forms.ToolStripMenuItem();
            this.mEuropaik = new System.Windows.Forms.ToolStripMenuItem();
            this.mKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTobb = new System.Windows.Forms.RadioButton();
            this.rbKevesebb = new System.Windows.Forms.RadioButton();
            this.btnMegszamol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMegszamol = new System.Windows.Forms.TextBox();
            this.cbKiiratas = new System.Windows.Forms.ComboBox();
            this.btnKiiratas = new System.Windows.Forms.Button();
            this.btnAtlag = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFajl,
            this.mEuropaik,
            this.mKilepes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFajl
            // 
            this.mFajl.Name = "mFajl";
            this.mFajl.Size = new System.Drawing.Size(37, 20);
            this.mFajl.Text = "Fájl";
            this.mFajl.Click += new System.EventHandler(this.mFajl_Click);
            // 
            // mEuropaik
            // 
            this.mEuropaik.Name = "mEuropaik";
            this.mEuropaik.Size = new System.Drawing.Size(71, 20);
            this.mEuropaik.Text = "Európaiak";
            // 
            // mKilepes
            // 
            this.mKilepes.Name = "mKilepes";
            this.mKilepes.Size = new System.Drawing.Size(56, 20);
            this.mKilepes.Text = "Kilépés";
            this.mKilepes.Click += new System.EventHandler(this.mKilepes_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.Filter = "Adatfájl|*txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(226, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORSZÁGOK NÉPESSÉGE";
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.HorizontalScrollbar = true;
            this.lbAdatok.ItemHeight = 20;
            this.lbAdatok.Location = new System.Drawing.Point(12, 54);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(358, 284);
            this.lbAdatok.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKevesebb);
            this.groupBox1.Controls.Add(this.rbTobb);
            this.groupBox1.Location = new System.Drawing.Point(395, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljak?";
            // 
            // rbTobb
            // 
            this.rbTobb.AutoSize = true;
            this.rbTobb.Location = new System.Drawing.Point(7, 26);
            this.rbTobb.Name = "rbTobb";
            this.rbTobb.Size = new System.Drawing.Size(140, 24);
            this.rbTobb.TabIndex = 0;
            this.rbTobb.TabStop = true;
            this.rbTobb.Text = "10 milliónál több";
            this.rbTobb.UseVisualStyleBackColor = true;
            // 
            // rbKevesebb
            // 
            this.rbKevesebb.AutoSize = true;
            this.rbKevesebb.Location = new System.Drawing.Point(7, 56);
            this.rbKevesebb.Name = "rbKevesebb";
            this.rbKevesebb.Size = new System.Drawing.Size(161, 24);
            this.rbKevesebb.TabIndex = 1;
            this.rbKevesebb.TabStop = true;
            this.rbKevesebb.Text = "Legfejlebb 10 millió";
            this.rbKevesebb.UseVisualStyleBackColor = true;
            // 
            // btnMegszamol
            // 
            this.btnMegszamol.Location = new System.Drawing.Point(395, 161);
            this.btnMegszamol.Name = "btnMegszamol";
            this.btnMegszamol.Size = new System.Drawing.Size(98, 29);
            this.btnMegszamol.TabIndex = 4;
            this.btnMegszamol.Text = "Megszámol";
            this.btnMegszamol.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Legnagyobb / Legkisebb népesség";
            // 
            // tbMegszamol
            // 
            this.tbMegszamol.Location = new System.Drawing.Point(499, 162);
            this.tbMegszamol.Name = "tbMegszamol";
            this.tbMegszamol.Size = new System.Drawing.Size(163, 26);
            this.tbMegszamol.TabIndex = 6;
            // 
            // cbKiiratas
            // 
            this.cbKiiratas.FormattingEnabled = true;
            this.cbKiiratas.Location = new System.Drawing.Point(395, 222);
            this.cbKiiratas.Name = "cbKiiratas";
            this.cbKiiratas.Size = new System.Drawing.Size(148, 28);
            this.cbKiiratas.TabIndex = 7;
            // 
            // btnKiiratas
            // 
            this.btnKiiratas.Location = new System.Drawing.Point(549, 221);
            this.btnKiiratas.Name = "btnKiiratas";
            this.btnKiiratas.Size = new System.Drawing.Size(113, 28);
            this.btnKiiratas.TabIndex = 4;
            this.btnKiiratas.Text = "Kiiratás";
            this.btnKiiratas.UseVisualStyleBackColor = true;
            // 
            // btnAtlag
            // 
            this.btnAtlag.Location = new System.Drawing.Point(395, 310);
            this.btnAtlag.Name = "btnAtlag";
            this.btnAtlag.Size = new System.Drawing.Size(147, 28);
            this.btnAtlag.TabIndex = 4;
            this.btnAtlag.Text = "Átlag népesség";
            this.btnAtlag.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(549, 310);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(113, 28);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 352);
            this.ControlBox = false;
            this.Controls.Add(this.cbKiiratas);
            this.Controls.Add(this.tbMegszamol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnAtlag);
            this.Controls.Add(this.btnKiiratas);
            this.Controls.Add(this.btnMegszamol);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Országok, népességek";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFajl;
        private System.Windows.Forms.ToolStripMenuItem mEuropaik;
        private System.Windows.Forms.ToolStripMenuItem mKilepes;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKevesebb;
        private System.Windows.Forms.RadioButton rbTobb;
        private System.Windows.Forms.Button btnMegszamol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMegszamol;
        private System.Windows.Forms.ComboBox cbKiiratas;
        private System.Windows.Forms.Button btnKiiratas;
        private System.Windows.Forms.Button btnAtlag;
        private System.Windows.Forms.Button btnKilepes;
    }
}

