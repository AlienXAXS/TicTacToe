namespace TicTacToe
{
    partial class FrmGame
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
            this.cboAISelection = new System.Windows.Forms.ComboBox();
            this.lblAIMode = new System.Windows.Forms.Label();
            this.gbPlayArea = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBR = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnTR = new System.Windows.Forms.Button();
            this.btnBM = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnML = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnTL = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.gbPlayArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAISelection
            // 
            this.cboAISelection.FormattingEnabled = true;
            this.cboAISelection.Items.AddRange(new object[] {
            "Random Selection",
            "Always Wins",
            "Never Wins"});
            this.cboAISelection.Location = new System.Drawing.Point(101, 12);
            this.cboAISelection.Name = "cboAISelection";
            this.cboAISelection.Size = new System.Drawing.Size(201, 21);
            this.cboAISelection.TabIndex = 1;
            this.cboAISelection.Text = "Random Selection";
            // 
            // lblAIMode
            // 
            this.lblAIMode.AutoSize = true;
            this.lblAIMode.Location = new System.Drawing.Point(31, 15);
            this.lblAIMode.Name = "lblAIMode";
            this.lblAIMode.Size = new System.Drawing.Size(64, 13);
            this.lblAIMode.TabIndex = 2;
            this.lblAIMode.Text = "AI Playstyle:";
            // 
            // gbPlayArea
            // 
            this.gbPlayArea.Controls.Add(this.groupBox4);
            this.gbPlayArea.Controls.Add(this.groupBox3);
            this.gbPlayArea.Controls.Add(this.groupBox2);
            this.gbPlayArea.Controls.Add(this.groupBox1);
            this.gbPlayArea.Controls.Add(this.btnBR);
            this.gbPlayArea.Controls.Add(this.btnMR);
            this.gbPlayArea.Controls.Add(this.btnTR);
            this.gbPlayArea.Controls.Add(this.btnBM);
            this.gbPlayArea.Controls.Add(this.btnBL);
            this.gbPlayArea.Controls.Add(this.btnMM);
            this.gbPlayArea.Controls.Add(this.btnML);
            this.gbPlayArea.Controls.Add(this.btnTM);
            this.gbPlayArea.Controls.Add(this.btnTL);
            this.gbPlayArea.Location = new System.Drawing.Point(12, 54);
            this.gbPlayArea.Name = "gbPlayArea";
            this.gbPlayArea.Size = new System.Drawing.Size(326, 320);
            this.gbPlayArea.TabIndex = 3;
            this.gbPlayArea.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 18);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(6, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 18);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(212, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(10, 290);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(101, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 290);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnBR
            // 
            this.btnBR.Location = new System.Drawing.Point(228, 231);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(89, 76);
            this.btnBR.TabIndex = 1;
            this.btnBR.Tag = "8";
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(228, 125);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(89, 76);
            this.btnMR.TabIndex = 2;
            this.btnMR.Tag = "5";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnClick);
            // 
            // btnTR
            // 
            this.btnTR.Location = new System.Drawing.Point(228, 19);
            this.btnTR.Name = "btnTR";
            this.btnTR.Size = new System.Drawing.Size(89, 76);
            this.btnTR.TabIndex = 3;
            this.btnTR.Tag = "2";
            this.btnTR.UseVisualStyleBackColor = true;
            this.btnTR.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBM
            // 
            this.btnBM.Location = new System.Drawing.Point(117, 231);
            this.btnBM.Name = "btnBM";
            this.btnBM.Size = new System.Drawing.Size(89, 76);
            this.btnBM.TabIndex = 4;
            this.btnBM.Tag = "7";
            this.btnBM.UseVisualStyleBackColor = true;
            this.btnBM.Click += new System.EventHandler(this.btnClick);
            // 
            // btnBL
            // 
            this.btnBL.Location = new System.Drawing.Point(6, 231);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(89, 76);
            this.btnBL.TabIndex = 5;
            this.btnBL.Tag = "6";
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.btnClick);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(117, 125);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(89, 76);
            this.btnMM.TabIndex = 6;
            this.btnMM.Tag = "4";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnClick);
            // 
            // btnML
            // 
            this.btnML.Location = new System.Drawing.Point(6, 125);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(89, 76);
            this.btnML.TabIndex = 7;
            this.btnML.Tag = "3";
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.btnClick);
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(117, 19);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(89, 76);
            this.btnTM.TabIndex = 8;
            this.btnTM.Tag = "1";
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.btnClick);
            // 
            // btnTL
            // 
            this.btnTL.Location = new System.Drawing.Point(6, 19);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(89, 76);
            this.btnTL.TabIndex = 9;
            this.btnTL.Tag = "0";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnClick);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(79, 38);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(188, 13);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "Player always goes first in this example";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 380);
            this.Controls.Add(this.gbPlayArea);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblAIMode);
            this.Controls.Add(this.cboAISelection);
            this.Name = "FrmGame";
            this.Text = "Mark\'s Shitty Game";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.gbPlayArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAISelection;
        private System.Windows.Forms.Label lblAIMode;
        private System.Windows.Forms.GroupBox gbPlayArea;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnTR;
        private System.Windows.Forms.Button btnBM;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNote;
    }
}

