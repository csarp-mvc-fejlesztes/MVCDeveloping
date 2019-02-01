namespace Forma1
{
    partial class Form1Form
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
            this.buttonInitializeData = new System.Windows.Forms.Button();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.buttonUpdateTeam = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonInitializeData
            // 
            this.buttonInitializeData.Location = new System.Drawing.Point(12, 22);
            this.buttonInitializeData.Name = "buttonInitializeData";
            this.buttonInitializeData.Size = new System.Drawing.Size(180, 23);
            this.buttonInitializeData.TabIndex = 15;
            this.buttonInitializeData.Text = "Teszt adatok betöltése";
            this.buttonInitializeData.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Location = new System.Drawing.Point(37, 564);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTeam.TabIndex = 14;
            this.buttonDeleteTeam.Text = "Töröl";
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateTeam
            // 
            this.buttonUpdateTeam.Location = new System.Drawing.Point(37, 535);
            this.buttonUpdateTeam.Name = "buttonUpdateTeam";
            this.buttonUpdateTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTeam.TabIndex = 13;
            this.buttonUpdateTeam.Text = "Módosít";
            this.buttonUpdateTeam.UseVisualStyleBackColor = true;
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(37, 506);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeam.TabIndex = 12;
            this.buttonAddTeam.Text = "Hozzáad";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.Location = new System.Drawing.Point(34, 442);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(70, 13);
            this.labelTeamName.TabIndex = 11;
            this.labelTeamName.Text = "Csapat neve:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(37, 458);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(155, 20);
            this.textBox.TabIndex = 10;
            // 
            // labelTeam
            // 
            this.labelTeam.AutoSize = true;
            this.labelTeam.Location = new System.Drawing.Point(34, 59);
            this.labelTeam.Name = "labelTeam";
            this.labelTeam.Size = new System.Drawing.Size(98, 13);
            this.labelTeam.TabIndex = 9;
            this.labelTeam.Text = "Forma 1. csapatok:";
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.Location = new System.Drawing.Point(37, 87);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(155, 329);
            this.listBoxTeam.TabIndex = 8;
            // 
            // Form1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonInitializeData);
            this.Controls.Add(this.buttonDeleteTeam);
            this.Controls.Add(this.buttonUpdateTeam);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.listBoxTeam);
            this.Name = "Form1Form";
            this.Text = "Forma 1.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitializeData;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Button buttonUpdateTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.ListBox listBoxTeam;
    }
}

