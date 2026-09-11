namespace Laboratoire01
{
    partial class frmLab
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_Courriel = new Label();
            label_DateNaissance = new Label();
            label_CodeValidation = new Label();
            label_Identifiant = new Label();
            label_MDP = new Label();
            label_ValidationMDP = new Label();
            button_Creer = new Button();
            button_Quitter = new Button();
            textBox_Courriel = new TextBox();
            textBox_Identifiant = new TextBox();
            textBox_MDP = new TextBox();
            textBox_ValidationMDP = new TextBox();
            dateTimePicker_Naissance = new DateTimePicker();
            numericUpDown_Code = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Code).BeginInit();
            SuspendLayout();
            // 
            // label_Courriel
            // 
            label_Courriel.AutoSize = true;
            label_Courriel.Location = new Point(140, 99);
            label_Courriel.Name = "label_Courriel";
            label_Courriel.Size = new Size(49, 15);
            label_Courriel.TabIndex = 0;
            label_Courriel.Text = "Courriel";
            // 
            // label_DateNaissance
            // 
            label_DateNaissance.AutoSize = true;
            label_DateNaissance.Location = new Point(121, 153);
            label_DateNaissance.Name = "label_DateNaissance";
            label_DateNaissance.Size = new Size(101, 15);
            label_DateNaissance.TabIndex = 1;
            label_DateNaissance.Text = "Date de naissance";
            // 
            // label_CodeValidation
            // 
            label_CodeValidation.AutoSize = true;
            label_CodeValidation.Location = new Point(116, 202);
            label_CodeValidation.Name = "label_CodeValidation";
            label_CodeValidation.Size = new Size(106, 15);
            label_CodeValidation.TabIndex = 2;
            label_CodeValidation.Text = "Code de validation";
            // 
            // label_Identifiant
            // 
            label_Identifiant.AutoSize = true;
            label_Identifiant.Location = new Point(476, 102);
            label_Identifiant.Name = "label_Identifiant";
            label_Identifiant.Size = new Size(61, 15);
            label_Identifiant.TabIndex = 3;
            label_Identifiant.Text = "Identifiant";
            // 
            // label_MDP
            // 
            label_MDP.AutoSize = true;
            label_MDP.Location = new Point(475, 153);
            label_MDP.Name = "label_MDP";
            label_MDP.Size = new Size(77, 15);
            label_MDP.TabIndex = 4;
            label_MDP.Text = "Mot de passe";
            // 
            // label_ValidationMDP
            // 
            label_ValidationMDP.AutoSize = true;
            label_ValidationMDP.Location = new Point(399, 202);
            label_ValidationMDP.Name = "label_ValidationMDP";
            label_ValidationMDP.Size = new Size(148, 15);
            label_ValidationMDP.TabIndex = 5;
            label_ValidationMDP.Text = "Validation de mot de passe";
            // 
            // button_Creer
            // 
            button_Creer.Location = new Point(464, 386);
            button_Creer.Name = "button_Creer";
            button_Creer.Size = new Size(75, 23);
            button_Creer.TabIndex = 6;
            button_Creer.Text = "Créer";
            button_Creer.UseVisualStyleBackColor = true;
            // 
            // button_Quitter
            // 
            button_Quitter.Location = new Point(578, 384);
            button_Quitter.Name = "button_Quitter";
            button_Quitter.Size = new Size(75, 23);
            button_Quitter.TabIndex = 7;
            button_Quitter.Text = "Quitter";
            button_Quitter.UseVisualStyleBackColor = true;
            // 
            // textBox_Courriel
            // 
            textBox_Courriel.Location = new Point(227, 89);
            textBox_Courriel.MaxLength = 320;
            textBox_Courriel.Name = "textBox_Courriel";
            textBox_Courriel.Size = new Size(100, 23);
            textBox_Courriel.TabIndex = 8;
            // 
            // textBox_Identifiant
            // 
            textBox_Identifiant.Location = new Point(563, 96);
            textBox_Identifiant.MaxLength = 20;
            textBox_Identifiant.Name = "textBox_Identifiant";
            textBox_Identifiant.Size = new Size(100, 23);
            textBox_Identifiant.TabIndex = 9;
            // 
            // textBox_MDP
            // 
            textBox_MDP.Location = new Point(553, 145);
            textBox_MDP.MaxLength = 15;
            textBox_MDP.Name = "textBox_MDP";
            textBox_MDP.Size = new Size(100, 23);
            textBox_MDP.TabIndex = 10;
            textBox_MDP.UseSystemPasswordChar = true;
            // 
            // textBox_ValidationMDP
            // 
            textBox_ValidationMDP.Location = new Point(553, 182);
            textBox_ValidationMDP.MaxLength = 15;
            textBox_ValidationMDP.Name = "textBox_ValidationMDP";
            textBox_ValidationMDP.Size = new Size(100, 23);
            textBox_ValidationMDP.TabIndex = 11;
            textBox_ValidationMDP.UseSystemPasswordChar = true;
            // 
            // dateTimePicker_Naissance
            // 
            dateTimePicker_Naissance.CustomFormat = "yyyy-MM-dd";
            dateTimePicker_Naissance.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Naissance.Location = new Point(228, 147);
            dateTimePicker_Naissance.Name = "dateTimePicker_Naissance";
            dateTimePicker_Naissance.Size = new Size(200, 23);
            dateTimePicker_Naissance.TabIndex = 12;
            dateTimePicker_Naissance.Value = new DateTime(2026, 9, 11, 16, 6, 26, 0);
            // 
            // numericUpDown_Code
            // 
            numericUpDown_Code.Location = new Point(230, 202);
            numericUpDown_Code.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericUpDown_Code.Name = "numericUpDown_Code";
            numericUpDown_Code.Size = new Size(120, 23);
            numericUpDown_Code.TabIndex = 13;
            // 
            // frmLab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown_Code);
            Controls.Add(dateTimePicker_Naissance);
            Controls.Add(textBox_ValidationMDP);
            Controls.Add(textBox_MDP);
            Controls.Add(textBox_Identifiant);
            Controls.Add(textBox_Courriel);
            Controls.Add(button_Quitter);
            Controls.Add(button_Creer);
            Controls.Add(label_ValidationMDP);
            Controls.Add(label_MDP);
            Controls.Add(label_Identifiant);
            Controls.Add(label_CodeValidation);
            Controls.Add(label_DateNaissance);
            Controls.Add(label_Courriel);
            Name = "frmLab";
            Text = "Laboratoire semaine 2 - Charles Guernon";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Code).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Courriel;
        private Label label_DateNaissance;
        private Label label_CodeValidation;
        private Label label_Identifiant;
        private Label label_MDP;
        private Label label_ValidationMDP;
        private Button button_Creer;
        private Button button_Quitter;
        private TextBox textBox_Courriel;
        private TextBox textBox_Identifiant;
        private TextBox textBox_MDP;
        private TextBox textBox_ValidationMDP;
        private DateTimePicker dateTimePicker_Naissance;
        private NumericUpDown numericUpDown_Code;
    }
}
