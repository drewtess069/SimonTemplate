﻿namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Location = new System.Drawing.Point(35, 234);
            this.yellowButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(185, 189);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.Tag = "2";
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Location = new System.Drawing.Point(233, 234);
            this.blueButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(185, 189);
            this.blueButton.TabIndex = 3;
            this.blueButton.Tag = "3";
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.DarkRed;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(233, 32);
            this.redButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(185, 189);
            this.redButton.TabIndex = 1;
            this.redButton.Tag = "1";
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(35, 32);
            this.greenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(185, 189);
            this.greenButton.TabIndex = 0;
            this.greenButton.Tag = "0";
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.levelLabel.Location = new System.Drawing.Point(176, 181);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(100, 100);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "1";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(452, 462);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Label levelLabel;
    }
}
