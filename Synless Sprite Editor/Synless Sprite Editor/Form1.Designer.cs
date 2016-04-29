namespace Synless_Sprite_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMod = new System.Windows.Forms.TextBox();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.pictureBoxMod = new System.Windows.Forms.PictureBox();
            this.useBtn = new System.Windows.Forms.Button();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.labelRed16 = new System.Windows.Forms.Label();
            this.labelGreen16 = new System.Windows.Forms.Label();
            this.labelBlue16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRed24 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelGreen24 = new System.Windows.Forms.Label();
            this.labelBlue24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMod)).BeginInit();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(16, 14);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(166, 44);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open..";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 320);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(247, 149);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(810, 320);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Location = new System.Drawing.Point(284, 18);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.ReadOnly = true;
            this.textBoxCurrent.Size = new System.Drawing.Size(64, 20);
            this.textBoxCurrent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current color :";
            // 
            // trackBarRed
            // 
            this.trackBarRed.LargeChange = 1;
            this.trackBarRed.Location = new System.Drawing.Point(769, 12);
            this.trackBarRed.Maximum = 31;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(164, 45);
            this.trackBarRed.TabIndex = 5;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(769, 53);
            this.trackBarGreen.Maximum = 63;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(164, 45);
            this.trackBarGreen.TabIndex = 6;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(769, 98);
            this.trackBarBlue.Maximum = 31;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(165, 45);
            this.trackBarBlue.TabIndex = 7;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Red :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(725, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Green :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Blue :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Modded color :";
            // 
            // textBoxMod
            // 
            this.textBoxMod.Location = new System.Drawing.Point(610, 18);
            this.textBoxMod.Name = "textBoxMod";
            this.textBoxMod.ReadOnly = true;
            this.textBoxMod.Size = new System.Drawing.Size(64, 20);
            this.textBoxMod.TabIndex = 12;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.Location = new System.Drawing.Point(284, 53);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxCurrent.TabIndex = 13;
            this.pictureBoxCurrent.TabStop = false;
            // 
            // pictureBoxMod
            // 
            this.pictureBoxMod.Location = new System.Drawing.Point(610, 53);
            this.pictureBoxMod.Name = "pictureBoxMod";
            this.pictureBoxMod.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxMod.TabIndex = 14;
            this.pictureBoxMod.TabStop = false;
            // 
            // useBtn
            // 
            this.useBtn.Enabled = false;
            this.useBtn.Location = new System.Drawing.Point(380, 36);
            this.useBtn.Name = "useBtn";
            this.useBtn.Size = new System.Drawing.Size(123, 35);
            this.useBtn.TabIndex = 15;
            this.useBtn.Text = " → Use →";
            this.useBtn.UseVisualStyleBackColor = true;
            this.useBtn.Click += new System.EventHandler(this.useBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Enabled = false;
            this.replaceBtn.Location = new System.Drawing.Point(381, 83);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(123, 33);
            this.replaceBtn.TabIndex = 16;
            this.replaceBtn.Text = "← Replace ←";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(16, 73);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(166, 44);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save bmp";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // labelRed16
            // 
            this.labelRed16.AutoSize = true;
            this.labelRed16.Location = new System.Drawing.Point(939, 18);
            this.labelRed16.Name = "labelRed16";
            this.labelRed16.Size = new System.Drawing.Size(13, 13);
            this.labelRed16.TabIndex = 18;
            this.labelRed16.Text = "0";
            // 
            // labelGreen16
            // 
            this.labelGreen16.AutoSize = true;
            this.labelGreen16.Location = new System.Drawing.Point(939, 60);
            this.labelGreen16.Name = "labelGreen16";
            this.labelGreen16.Size = new System.Drawing.Size(13, 13);
            this.labelGreen16.TabIndex = 19;
            this.labelGreen16.Text = "0";
            // 
            // labelBlue16
            // 
            this.labelBlue16.AutoSize = true;
            this.labelBlue16.Location = new System.Drawing.Point(939, 104);
            this.labelBlue16.Name = "labelBlue16";
            this.labelBlue16.Size = new System.Drawing.Size(13, 13);
            this.labelBlue16.TabIndex = 20;
            this.labelBlue16.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(979, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "<<2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(979, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "<<3";
            // 
            // labelRed24
            // 
            this.labelRed24.AutoSize = true;
            this.labelRed24.Location = new System.Drawing.Point(1022, 18);
            this.labelRed24.Name = "labelRed24";
            this.labelRed24.Size = new System.Drawing.Size(13, 13);
            this.labelRed24.TabIndex = 24;
            this.labelRed24.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(979, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "<<3";
            // 
            // labelGreen24
            // 
            this.labelGreen24.AutoSize = true;
            this.labelGreen24.Location = new System.Drawing.Point(1022, 60);
            this.labelGreen24.Name = "labelGreen24";
            this.labelGreen24.Size = new System.Drawing.Size(13, 13);
            this.labelGreen24.TabIndex = 25;
            this.labelGreen24.Text = "0";
            // 
            // labelBlue24
            // 
            this.labelBlue24.AutoSize = true;
            this.labelBlue24.Location = new System.Drawing.Point(1022, 104);
            this.labelBlue24.Name = "labelBlue24";
            this.labelBlue24.Size = new System.Drawing.Size(13, 13);
            this.labelBlue24.TabIndex = 26;
            this.labelBlue24.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 481);
            this.Controls.Add(this.labelBlue24);
            this.Controls.Add(this.labelGreen24);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelRed24);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelBlue16);
            this.Controls.Add(this.labelGreen16);
            this.Controls.Add(this.labelRed16);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.useBtn);
            this.Controls.Add(this.pictureBoxMod);
            this.Controls.Add(this.pictureBoxCurrent);
            this.Controls.Add(this.textBoxMod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCurrent);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synless Sprite Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMod;
        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.PictureBox pictureBoxMod;
        private System.Windows.Forms.Button useBtn;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label labelRed16;
        private System.Windows.Forms.Label labelGreen16;
        private System.Windows.Forms.Label labelBlue16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRed24;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelGreen24;
        private System.Windows.Forms.Label labelBlue24;
    }
}

