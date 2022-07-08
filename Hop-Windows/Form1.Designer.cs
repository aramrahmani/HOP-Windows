
namespace Hop_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlayerNumber = new System.Windows.Forms.TextBox();
            this.btnShowPlayers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepeateCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStopGame = new System.Windows.Forms.Button();
            this.lblRefereeNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chIsRandomGameN = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(771, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = ":Number of players";
            // 
            // txtPlayerNumber
            // 
            this.txtPlayerNumber.Location = new System.Drawing.Point(930, 5);
            this.txtPlayerNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayerNumber.Name = "txtPlayerNumber";
            this.txtPlayerNumber.Size = new System.Drawing.Size(115, 26);
            this.txtPlayerNumber.TabIndex = 1;
            // 
            // btnShowPlayers
            // 
            this.btnShowPlayers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShowPlayers.Location = new System.Drawing.Point(771, 105);
            this.btnShowPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowPlayers.Name = "btnShowPlayers";
            this.btnShowPlayers.Size = new System.Drawing.Size(274, 45);
            this.btnShowPlayers.TabIndex = 3;
            this.btnShowPlayers.Text = "Show Players";
            this.btnShowPlayers.UseVisualStyleBackColor = true;
            this.btnShowPlayers.Click += new System.EventHandler(this.btnShowPlayers_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chIsRandomGameN);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRepeateCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStopGame);
            this.panel1.Controls.Add(this.lblRefereeNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.btnShowPlayers);
            this.panel1.Controls.Add(this.txtPlayerNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 157);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 73);
            this.label4.TabIndex = 9;
            this.label4.Text = "HOP";
            // 
            // txtRepeateCount
            // 
            this.txtRepeateCount.Location = new System.Drawing.Point(930, 41);
            this.txtRepeateCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepeateCount.Name = "txtRepeateCount";
            this.txtRepeateCount.Size = new System.Drawing.Size(115, 26);
            this.txtRepeateCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(771, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = ":Game Round";
            // 
            // btnStopGame
            // 
            this.btnStopGame.BackColor = System.Drawing.Color.Tomato;
            this.btnStopGame.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStopGame.Location = new System.Drawing.Point(575, 85);
            this.btnStopGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStopGame.Name = "btnStopGame";
            this.btnStopGame.Size = new System.Drawing.Size(188, 65);
            this.btnStopGame.TabIndex = 5;
            this.btnStopGame.Text = "Stop(New Game)";
            this.btnStopGame.UseVisualStyleBackColor = false;
            this.btnStopGame.Visible = false;
            this.btnStopGame.Click += new System.EventHandler(this.btnStopGame_Click);
            // 
            // lblRefereeNumber
            // 
            this.lblRefereeNumber.AutoSize = true;
            this.lblRefereeNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRefereeNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRefereeNumber.Location = new System.Drawing.Point(135, 10);
            this.lblRefereeNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefereeNumber.Name = "lblRefereeNumber";
            this.lblRefereeNumber.Size = new System.Drawing.Size(0, 28);
            this.lblRefereeNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = ": GameNumber";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStartGame.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnStartGame.Location = new System.Drawing.Point(575, 5);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(188, 70);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Visible = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = ": Round";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRound.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblRound.Location = new System.Drawing.Point(88, 65);
            this.lblRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(0, 28);
            this.lblRound.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // chIsRandomGameN
            // 
            this.chIsRandomGameN.AutoSize = true;
            this.chIsRandomGameN.Location = new System.Drawing.Point(825, 75);
            this.chIsRandomGameN.Name = "chIsRandomGameN";
            this.chIsRandomGameN.Size = new System.Drawing.Size(220, 24);
            this.chIsRandomGameN.TabIndex = 13;
            this.chIsRandomGameN.Text = "IS Random GameNumber";
            this.chIsRandomGameN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1059, 864);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "HOP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlayerNumber;
        private System.Windows.Forms.Button btnShowPlayers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblRefereeNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStopGame;
        private System.Windows.Forms.TextBox txtRepeateCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chIsRandomGameN;
    }
}

