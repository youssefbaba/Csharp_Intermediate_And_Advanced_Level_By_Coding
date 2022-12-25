namespace WinForm_Example_Reflection
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTypeName = new System.Windows.Forms.TextBox();
            this.btnDiscoverTypeInformation = new System.Windows.Forms.Button();
            this.labelMethods = new System.Windows.Forms.Label();
            this.labelProperties = new System.Windows.Forms.Label();
            this.labelConstructors = new System.Windows.Forms.Label();
            this.listBoxMethods = new System.Windows.Forms.ListBox();
            this.listBoxProperties = new System.Windows.Forms.ListBox();
            this.listBoxConstructors = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Name";
            // 
            // textBoxTypeName
            // 
            this.textBoxTypeName.Location = new System.Drawing.Point(100, 12);
            this.textBoxTypeName.Name = "textBoxTypeName";
            this.textBoxTypeName.Size = new System.Drawing.Size(313, 25);
            this.textBoxTypeName.TabIndex = 1;
            // 
            // btnDiscoverTypeInformation
            // 
            this.btnDiscoverTypeInformation.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiscoverTypeInformation.Location = new System.Drawing.Point(469, 14);
            this.btnDiscoverTypeInformation.Name = "btnDiscoverTypeInformation";
            this.btnDiscoverTypeInformation.Size = new System.Drawing.Size(290, 25);
            this.btnDiscoverTypeInformation.TabIndex = 2;
            this.btnDiscoverTypeInformation.Text = "Discover Type Information";
            this.btnDiscoverTypeInformation.UseVisualStyleBackColor = true;
            this.btnDiscoverTypeInformation.Click += new System.EventHandler(this.btnDiscoverTypeInformation_Click);
            // 
            // labelMethods
            // 
            this.labelMethods.AutoSize = true;
            this.labelMethods.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMethods.Location = new System.Drawing.Point(12, 108);
            this.labelMethods.Name = "labelMethods";
            this.labelMethods.Size = new System.Drawing.Size(62, 17);
            this.labelMethods.TabIndex = 3;
            this.labelMethods.Text = "Methods";
            // 
            // labelProperties
            // 
            this.labelProperties.AutoSize = true;
            this.labelProperties.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelProperties.Location = new System.Drawing.Point(293, 108);
            this.labelProperties.Name = "labelProperties";
            this.labelProperties.Size = new System.Drawing.Size(71, 17);
            this.labelProperties.TabIndex = 4;
            this.labelProperties.Text = "Properties";
            // 
            // labelConstructors
            // 
            this.labelConstructors.AutoSize = true;
            this.labelConstructors.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConstructors.Location = new System.Drawing.Point(577, 108);
            this.labelConstructors.Name = "labelConstructors";
            this.labelConstructors.Size = new System.Drawing.Size(86, 17);
            this.labelConstructors.TabIndex = 5;
            this.labelConstructors.Text = "Constructors";
            // 
            // listBoxMethods
            // 
            this.listBoxMethods.FormattingEnabled = true;
            this.listBoxMethods.ItemHeight = 17;
            this.listBoxMethods.Location = new System.Drawing.Point(14, 139);
            this.listBoxMethods.Name = "listBoxMethods";
            this.listBoxMethods.Size = new System.Drawing.Size(192, 293);
            this.listBoxMethods.TabIndex = 6;
            // 
            // listBoxProperties
            // 
            this.listBoxProperties.FormattingEnabled = true;
            this.listBoxProperties.ItemHeight = 17;
            this.listBoxProperties.Location = new System.Drawing.Point(293, 139);
            this.listBoxProperties.Name = "listBoxProperties";
            this.listBoxProperties.Size = new System.Drawing.Size(192, 293);
            this.listBoxProperties.TabIndex = 7;
            // 
            // listBoxConstructors
            // 
            this.listBoxConstructors.FormattingEnabled = true;
            this.listBoxConstructors.ItemHeight = 17;
            this.listBoxConstructors.Location = new System.Drawing.Point(577, 139);
            this.listBoxConstructors.Name = "listBoxConstructors";
            this.listBoxConstructors.Size = new System.Drawing.Size(192, 293);
            this.listBoxConstructors.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxConstructors);
            this.Controls.Add(this.listBoxProperties);
            this.Controls.Add(this.listBoxMethods);
            this.Controls.Add(this.labelConstructors);
            this.Controls.Add(this.labelProperties);
            this.Controls.Add(this.labelMethods);
            this.Controls.Add(this.btnDiscoverTypeInformation);
            this.Controls.Add(this.textBoxTypeName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxTypeName;
        private Button btnDiscoverTypeInformation;
        private Label labelMethods;
        private Label labelProperties;
        private Label labelConstructors;
        private ListBox listBoxMethods;
        private ListBox listBoxProperties;
        private ListBox listBoxConstructors;
    }
}