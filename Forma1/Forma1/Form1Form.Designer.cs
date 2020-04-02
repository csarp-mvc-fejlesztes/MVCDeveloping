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
            this.components = new System.ComponentModel.Container();
            this.buttonInitializeData = new System.Windows.Forms.Button();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.buttonUpdateTeam = new System.Windows.Forms.Button();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.textBoxNewTeamName = new System.Windows.Forms.TextBox();
            this.labelTeam = new System.Windows.Forms.Label();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.buttonDeleteRacer = new System.Windows.Forms.Button();
            this.buttonUpdateRacer = new System.Windows.Forms.Button();
            this.buttonAddRacer = new System.Windows.Forms.Button();
            this.labelRecer = new System.Windows.Forms.Label();
            this.listBoxRacer = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearRacerTextBox = new System.Windows.Forms.Button();
            this.textBoxRacerSalary = new System.Windows.Forms.TextBox();
            this.textBoxRacerAge = new System.Windows.Forms.TextBox();
            this.textBoxRacerName = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelRacerAge = new System.Windows.Forms.Label();
            this.labelRacerName = new System.Windows.Forms.Label();
            this.comboBoxTeamMove = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonComputeTeamSalary = new System.Windows.Forms.Button();
            this.textBoxTeamSalary = new System.Windows.Forms.TextBox();
            this.buttonComputeF1Salary = new System.Windows.Forms.Button();
            this.textBoxF1Salary = new System.Windows.Forms.TextBox();
            this.errorProviderAddTeam = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUpdateTeam = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeleteTeam = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddRacer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUpdateRacer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeleteRacer = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonMoveToTeam = new System.Windows.Forms.Button();
            this.errorProviderMoveToTeam = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdateTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeleteTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddRacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdateRacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeleteRacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoveToTeam)).BeginInit();
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
            this.buttonInitializeData.Click += new System.EventHandler(this.buttonInitializeData_Click);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Location = new System.Drawing.Point(37, 564);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTeam.TabIndex = 14;
            this.buttonDeleteTeam.Text = "Töröl";
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            this.buttonDeleteTeam.Click += new System.EventHandler(this.buttonDeleteTeam_Click);
            // 
            // buttonUpdateTeam
            // 
            this.buttonUpdateTeam.Location = new System.Drawing.Point(37, 535);
            this.buttonUpdateTeam.Name = "buttonUpdateTeam";
            this.buttonUpdateTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTeam.TabIndex = 13;
            this.buttonUpdateTeam.Text = "Módosít";
            this.buttonUpdateTeam.UseVisualStyleBackColor = true;
            this.buttonUpdateTeam.Click += new System.EventHandler(this.buttonUpdateTeam_Click);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(37, 506);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeam.TabIndex = 12;
            this.buttonAddTeam.Text = "Hozzáad";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
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
            // textBoxNewTeamName
            // 
            this.textBoxNewTeamName.Location = new System.Drawing.Point(37, 458);
            this.textBoxNewTeamName.Name = "textBoxNewTeamName";
            this.textBoxNewTeamName.Size = new System.Drawing.Size(155, 20);
            this.textBoxNewTeamName.TabIndex = 10;
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
            this.listBoxTeam.SelectedIndexChanged += new System.EventHandler(this.listBoxTeam_SelectedIndexChanged);
            // 
            // buttonDeleteRacer
            // 
            this.buttonDeleteRacer.Location = new System.Drawing.Point(246, 192);
            this.buttonDeleteRacer.Name = "buttonDeleteRacer";
            this.buttonDeleteRacer.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRacer.TabIndex = 22;
            this.buttonDeleteRacer.Text = "Töröl";
            this.buttonDeleteRacer.UseVisualStyleBackColor = true;
            this.buttonDeleteRacer.Click += new System.EventHandler(this.buttonDeleteRacer_Click);
            // 
            // buttonUpdateRacer
            // 
            this.buttonUpdateRacer.Location = new System.Drawing.Point(135, 192);
            this.buttonUpdateRacer.Name = "buttonUpdateRacer";
            this.buttonUpdateRacer.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateRacer.TabIndex = 21;
            this.buttonUpdateRacer.Text = "Módosít";
            this.buttonUpdateRacer.UseVisualStyleBackColor = true;
            this.buttonUpdateRacer.Click += new System.EventHandler(this.buttonUpdateRacer_Click);
            // 
            // buttonAddRacer
            // 
            this.buttonAddRacer.Location = new System.Drawing.Point(18, 192);
            this.buttonAddRacer.Name = "buttonAddRacer";
            this.buttonAddRacer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRacer.TabIndex = 20;
            this.buttonAddRacer.Text = "Hozzáad";
            this.buttonAddRacer.UseVisualStyleBackColor = true;
            this.buttonAddRacer.Click += new System.EventHandler(this.buttonAddRacer_Click);
            // 
            // labelRecer
            // 
            this.labelRecer.AutoSize = true;
            this.labelRecer.Location = new System.Drawing.Point(264, 59);
            this.labelRecer.Name = "labelRecer";
            this.labelRecer.Size = new System.Drawing.Size(114, 13);
            this.labelRecer.TabIndex = 17;
            this.labelRecer.Text = "Forma 1. csapat tagjai:";
            // 
            // listBoxRacer
            // 
            this.listBoxRacer.FormattingEnabled = true;
            this.listBoxRacer.Location = new System.Drawing.Point(267, 87);
            this.listBoxRacer.Name = "listBoxRacer";
            this.listBoxRacer.Size = new System.Drawing.Size(297, 329);
            this.listBoxRacer.TabIndex = 16;
            this.listBoxRacer.SelectedIndexChanged += new System.EventHandler(this.listBoxRacer_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClearRacerTextBox);
            this.panel1.Controls.Add(this.textBoxRacerSalary);
            this.panel1.Controls.Add(this.textBoxRacerAge);
            this.panel1.Controls.Add(this.textBoxRacerName);
            this.panel1.Controls.Add(this.labelSalary);
            this.panel1.Controls.Add(this.labelRacerAge);
            this.panel1.Controls.Add(this.labelRacerName);
            this.panel1.Controls.Add(this.buttonDeleteRacer);
            this.panel1.Controls.Add(this.buttonAddRacer);
            this.panel1.Controls.Add(this.buttonUpdateRacer);
            this.panel1.Location = new System.Drawing.Point(609, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 240);
            this.panel1.TabIndex = 23;
            // 
            // buttonClearRacerTextBox
            // 
            this.buttonClearRacerTextBox.Location = new System.Drawing.Point(18, 23);
            this.buttonClearRacerTextBox.Name = "buttonClearRacerTextBox";
            this.buttonClearRacerTextBox.Size = new System.Drawing.Size(303, 23);
            this.buttonClearRacerTextBox.TabIndex = 29;
            this.buttonClearRacerTextBox.Text = "Töröl versenyző adatokat";
            this.buttonClearRacerTextBox.UseVisualStyleBackColor = true;
            this.buttonClearRacerTextBox.Click += new System.EventHandler(this.buttonClearRacerTextBox_Click);
            // 
            // textBoxRacerSalary
            // 
            this.textBoxRacerSalary.Location = new System.Drawing.Point(86, 148);
            this.textBoxRacerSalary.Name = "textBoxRacerSalary";
            this.textBoxRacerSalary.Size = new System.Drawing.Size(235, 20);
            this.textBoxRacerSalary.TabIndex = 28;
            // 
            // textBoxRacerAge
            // 
            this.textBoxRacerAge.Location = new System.Drawing.Point(86, 112);
            this.textBoxRacerAge.Name = "textBoxRacerAge";
            this.textBoxRacerAge.Size = new System.Drawing.Size(235, 20);
            this.textBoxRacerAge.TabIndex = 27;
            // 
            // textBoxRacerName
            // 
            this.textBoxRacerName.Location = new System.Drawing.Point(51, 74);
            this.textBoxRacerName.Name = "textBoxRacerName";
            this.textBoxRacerName.Size = new System.Drawing.Size(270, 20);
            this.textBoxRacerName.TabIndex = 26;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(15, 151);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(43, 13);
            this.labelSalary.TabIndex = 26;
            this.labelSalary.Text = "Fizetés:";
            // 
            // labelRacerAge
            // 
            this.labelRacerAge.AutoSize = true;
            this.labelRacerAge.Location = new System.Drawing.Point(15, 119);
            this.labelRacerAge.Name = "labelRacerAge";
            this.labelRacerAge.Size = new System.Drawing.Size(43, 13);
            this.labelRacerAge.TabIndex = 25;
            this.labelRacerAge.Text = "Életkor:";
            // 
            // labelRacerName
            // 
            this.labelRacerName.AutoSize = true;
            this.labelRacerName.Location = new System.Drawing.Point(15, 81);
            this.labelRacerName.Name = "labelRacerName";
            this.labelRacerName.Size = new System.Drawing.Size(30, 13);
            this.labelRacerName.TabIndex = 24;
            this.labelRacerName.Text = "Név:";
            // 
            // comboBoxTeamMove
            // 
            this.comboBoxTeamMove.FormattingEnabled = true;
            this.comboBoxTeamMove.Location = new System.Drawing.Point(267, 457);
            this.comboBoxTeamMove.Name = "comboBoxTeamMove";
            this.comboBoxTeamMove.Size = new System.Drawing.Size(197, 21);
            this.comboBoxTeamMove.TabIndex = 24;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(883, 564);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonComputeTeamSalary
            // 
            this.buttonComputeTeamSalary.Location = new System.Drawing.Point(267, 526);
            this.buttonComputeTeamSalary.Name = "buttonComputeTeamSalary";
            this.buttonComputeTeamSalary.Size = new System.Drawing.Size(297, 23);
            this.buttonComputeTeamSalary.TabIndex = 30;
            this.buttonComputeTeamSalary.Text = "Csapat össz bérkifeizetése:";
            this.buttonComputeTeamSalary.UseVisualStyleBackColor = true;
            this.buttonComputeTeamSalary.Click += new System.EventHandler(this.buttonComputeTeamSalary_Click);
            // 
            // textBoxTeamSalary
            // 
            this.textBoxTeamSalary.Location = new System.Drawing.Point(267, 567);
            this.textBoxTeamSalary.Name = "textBoxTeamSalary";
            this.textBoxTeamSalary.ReadOnly = true;
            this.textBoxTeamSalary.Size = new System.Drawing.Size(297, 20);
            this.textBoxTeamSalary.TabIndex = 31;
            // 
            // buttonComputeF1Salary
            // 
            this.buttonComputeF1Salary.Location = new System.Drawing.Point(37, 618);
            this.buttonComputeF1Salary.Name = "buttonComputeF1Salary";
            this.buttonComputeF1Salary.Size = new System.Drawing.Size(155, 23);
            this.buttonComputeF1Salary.TabIndex = 32;
            this.buttonComputeF1Salary.Text = "F1 össz bérkifeizetése:";
            this.buttonComputeF1Salary.UseVisualStyleBackColor = true;
            this.buttonComputeF1Salary.Click += new System.EventHandler(this.buttonComputeF1Salary_Click);
            // 
            // textBoxF1Salary
            // 
            this.textBoxF1Salary.Location = new System.Drawing.Point(37, 664);
            this.textBoxF1Salary.Name = "textBoxF1Salary";
            this.textBoxF1Salary.ReadOnly = true;
            this.textBoxF1Salary.Size = new System.Drawing.Size(155, 20);
            this.textBoxF1Salary.TabIndex = 33;
            // 
            // errorProviderAddTeam
            // 
            this.errorProviderAddTeam.ContainerControl = this;
            // 
            // errorProviderUpdateTeam
            // 
            this.errorProviderUpdateTeam.ContainerControl = this;
            // 
            // errorProviderDeleteTeam
            // 
            this.errorProviderDeleteTeam.ContainerControl = this;
            // 
            // errorProviderAddRacer
            // 
            this.errorProviderAddRacer.ContainerControl = this;
            // 
            // errorProviderUpdateRacer
            // 
            this.errorProviderUpdateRacer.ContainerControl = this;
            // 
            // errorProviderDeleteRacer
            // 
            this.errorProviderDeleteRacer.ContainerControl = this;
            // 
            // buttonMoveToTeam
            // 
            this.buttonMoveToTeam.Location = new System.Drawing.Point(470, 457);
            this.buttonMoveToTeam.Name = "buttonMoveToTeam";
            this.buttonMoveToTeam.Size = new System.Drawing.Size(94, 23);
            this.buttonMoveToTeam.TabIndex = 34;
            this.buttonMoveToTeam.Text = "csapatba átrak.";
            this.buttonMoveToTeam.UseVisualStyleBackColor = true;
            this.buttonMoveToTeam.Click += new System.EventHandler(this.buttonMoveToTeam_Click);
            // 
            // errorProviderMoveToTeam
            // 
            this.errorProviderMoveToTeam.ContainerControl = this;
            // 
            // Form1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonMoveToTeam);
            this.Controls.Add(this.textBoxF1Salary);
            this.Controls.Add(this.buttonComputeF1Salary);
            this.Controls.Add(this.textBoxTeamSalary);
            this.Controls.Add(this.buttonComputeTeamSalary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxTeamMove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelRecer);
            this.Controls.Add(this.listBoxRacer);
            this.Controls.Add(this.buttonInitializeData);
            this.Controls.Add(this.buttonDeleteTeam);
            this.Controls.Add(this.buttonUpdateTeam);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.textBoxNewTeamName);
            this.Controls.Add(this.labelTeam);
            this.Controls.Add(this.listBoxTeam);
            this.Name = "Form1Form";
            this.Text = "Forma 1.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdateTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeleteTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddRacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUpdateRacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeleteRacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMoveToTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInitializeData;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Button buttonUpdateTeam;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.TextBox textBoxNewTeamName;
        private System.Windows.Forms.Label labelTeam;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.Button buttonDeleteRacer;
        private System.Windows.Forms.Button buttonUpdateRacer;
        private System.Windows.Forms.Button buttonAddRacer;
        private System.Windows.Forms.Label labelRecer;
        private System.Windows.Forms.ListBox listBoxRacer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelRacerAge;
        private System.Windows.Forms.Label labelRacerName;
        private System.Windows.Forms.ComboBox comboBoxTeamMove;
        private System.Windows.Forms.TextBox textBoxRacerSalary;
        private System.Windows.Forms.TextBox textBoxRacerAge;
        private System.Windows.Forms.TextBox textBoxRacerName;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonComputeTeamSalary;
        private System.Windows.Forms.TextBox textBoxTeamSalary;
        private System.Windows.Forms.Button buttonComputeF1Salary;
        private System.Windows.Forms.TextBox textBoxF1Salary;
        private System.Windows.Forms.ErrorProvider errorProviderAddTeam;
        private System.Windows.Forms.ErrorProvider errorProviderUpdateTeam;
        private System.Windows.Forms.ErrorProvider errorProviderDeleteTeam;
        private System.Windows.Forms.ErrorProvider errorProviderAddRacer;
        private System.Windows.Forms.ErrorProvider errorProviderUpdateRacer;
        private System.Windows.Forms.ErrorProvider errorProviderDeleteRacer;
        private System.Windows.Forms.Button buttonMoveToTeam;
        private System.Windows.Forms.ErrorProvider errorProviderMoveToTeam;
        private System.Windows.Forms.Button buttonClearRacerTextBox;
    }
}

