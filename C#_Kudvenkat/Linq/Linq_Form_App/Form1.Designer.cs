namespace Linq_Form_App
{
    partial class Form1
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
            this.listBoxFiltredList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownYearsExperience = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAllPeople = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearsExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFiltredList
            // 
            this.listBoxFiltredList.FormattingEnabled = true;
            this.listBoxFiltredList.ItemHeight = 17;
            this.listBoxFiltredList.Location = new System.Drawing.Point(351, 146);
            this.listBoxFiltredList.Name = "listBoxFiltredList";
            this.listBoxFiltredList.Size = new System.Drawing.Size(437, 208);
            this.listBoxFiltredList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "All People";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtred List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Years Experience";
            // 
            // numericUpDownYearsExperience
            // 
            this.numericUpDownYearsExperience.Location = new System.Drawing.Point(51, 251);
            this.numericUpDownYearsExperience.Name = "numericUpDownYearsExperience";
            this.numericUpDownYearsExperience.Size = new System.Drawing.Size(166, 25);
            this.numericUpDownYearsExperience.TabIndex = 5;
            // 
            // comboBoxAllPeople
            // 
            this.comboBoxAllPeople.FormattingEnabled = true;
            this.comboBoxAllPeople.Location = new System.Drawing.Point(55, 86);
            this.comboBoxAllPeople.Name = "comboBoxAllPeople";
            this.comboBoxAllPeople.Size = new System.Drawing.Size(217, 25);
            this.comboBoxAllPeople.TabIndex = 6;
            this.comboBoxAllPeople.SelectedIndexChanged += new System.EventHandler(this.comboBoxAllPeople_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(73, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 41);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboBoxAllPeople);
            this.Controls.Add(this.numericUpDownYearsExperience);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxFiltredList);
            this.Name = "Form1";
            this.Text = "Form App For Testing Linq";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearsExperience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listBoxFiltredList;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownYearsExperience;
        private ComboBox comboBoxAllPeople;
        private Button btnUpdate;
    }
}