namespace DisplayMembersUsingReflections
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
            this.listProperty = new System.Windows.Forms.ListBox();
            this.listMethod = new System.Windows.Forms.ListBox();
            this.listConstructor = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProperty
            // 
            this.listProperty.FormattingEnabled = true;
            this.listProperty.Location = new System.Drawing.Point(12, 53);
            this.listProperty.Name = "listProperty";
            this.listProperty.Size = new System.Drawing.Size(218, 355);
            this.listProperty.TabIndex = 0;
            // 
            // listMethod
            // 
            this.listMethod.FormattingEnabled = true;
            this.listMethod.Location = new System.Drawing.Point(301, 53);
            this.listMethod.Name = "listMethod";
            this.listMethod.Size = new System.Drawing.Size(218, 355);
            this.listMethod.TabIndex = 1;
            this.listMethod.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listConstructor
            // 
            this.listConstructor.FormattingEnabled = true;
            this.listConstructor.Location = new System.Drawing.Point(604, 53);
            this.listConstructor.Name = "listConstructor";
            this.listConstructor.Size = new System.Drawing.Size(218, 355);
            this.listConstructor.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(547, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(604, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(218, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 426);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listConstructor);
            this.Controls.Add(this.listMethod);
            this.Controls.Add(this.listProperty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProperty;
        private System.Windows.Forms.ListBox listMethod;
        private System.Windows.Forms.ListBox listConstructor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSubmit;
    }
}

