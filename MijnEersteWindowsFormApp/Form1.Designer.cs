namespace MijnEersteWindowsFormApp
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
            this.lblMijnLabel = new System.Windows.Forms.Label();
            this.btnMijnButton = new System.Windows.Forms.Button();
            this.cbLeerlingen = new System.Windows.Forms.ComboBox();
            this.lbLeerlingen = new System.Windows.Forms.ListBox();
            this.txtMijnText = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMijnLabel
            // 
            this.lblMijnLabel.AutoSize = true;
            this.lblMijnLabel.Location = new System.Drawing.Point(50, 22);
            this.lblMijnLabel.Name = "lblMijnLabel";
            this.lblMijnLabel.Size = new System.Drawing.Size(74, 20);
            this.lblMijnLabel.TabIndex = 0;
            this.lblMijnLabel.Text = "Mijn label";
            // 
            // btnMijnButton
            // 
            this.btnMijnButton.Location = new System.Drawing.Point(41, 57);
            this.btnMijnButton.Name = "btnMijnButton";
            this.btnMijnButton.Size = new System.Drawing.Size(185, 35);
            this.btnMijnButton.TabIndex = 1;
            this.btnMijnButton.Text = "Klick Mij!";
            this.btnMijnButton.UseVisualStyleBackColor = true;
            this.btnMijnButton.Click += new System.EventHandler(this.btnMijnButton_Click);
            // 
            // cbLeerlingen
            // 
            this.cbLeerlingen.FormattingEnabled = true;
            this.cbLeerlingen.Location = new System.Drawing.Point(41, 98);
            this.cbLeerlingen.Name = "cbLeerlingen";
            this.cbLeerlingen.Size = new System.Drawing.Size(198, 28);
            this.cbLeerlingen.TabIndex = 2;
            this.cbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.cbLeerlingen_SelectedIndexChanged);
            // 
            // lbLeerlingen
            // 
            this.lbLeerlingen.FormattingEnabled = true;
            this.lbLeerlingen.ItemHeight = 20;
            this.lbLeerlingen.Location = new System.Drawing.Point(41, 132);
            this.lbLeerlingen.Name = "lbLeerlingen";
            this.lbLeerlingen.Size = new System.Drawing.Size(198, 284);
            this.lbLeerlingen.TabIndex = 3;
            // 
            // txtMijnText
            // 
            this.txtMijnText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMijnText.Location = new System.Drawing.Point(41, 445);
            this.txtMijnText.Name = "txtMijnText";
            this.txtMijnText.Size = new System.Drawing.Size(198, 26);
            this.txtMijnText.TabIndex = 4;
            this.txtMijnText.Resize += new System.EventHandler(this.txtMijnText_Resize);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoegToe.Location = new System.Drawing.Point(272, 439);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(198, 39);
            this.btnVoegToe.TabIndex = 5;
            this.btnVoegToe.Text = "Toevoegen!";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 544);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.txtMijnText);
            this.Controls.Add(this.lbLeerlingen);
            this.Controls.Add(this.cbLeerlingen);
            this.Controls.Add(this.btnMijnButton);
            this.Controls.Add(this.lblMijnLabel);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mijn App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMijnLabel;
        private System.Windows.Forms.Button btnMijnButton;
        private System.Windows.Forms.ComboBox cbLeerlingen;
        private System.Windows.Forms.ListBox lbLeerlingen;
        private System.Windows.Forms.TextBox txtMijnText;
        private System.Windows.Forms.Button btnVoegToe;
    }
}

