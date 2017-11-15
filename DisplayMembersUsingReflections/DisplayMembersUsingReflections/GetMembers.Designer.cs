namespace DisplayMembersUsingReflections
{
    partial class GetMembers
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
            this.lblProperties = new System.Windows.Forms.Label();
            this.lblMethods = new System.Windows.Forms.Label();
            this.lblConstructor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listProperty
            // 
            this.listProperty.FormattingEnabled = true;
            this.listProperty.ItemHeight = 16;
            this.listProperty.Location = new System.Drawing.Point(16, 65);
            this.listProperty.Margin = new System.Windows.Forms.Padding(4);
            this.listProperty.Name = "listProperty";
            this.listProperty.ScrollAlwaysVisible = true;
            this.listProperty.Size = new System.Drawing.Size(289, 436);
            this.listProperty.TabIndex = 0;
            // 
            // listMethod
            // 
            this.listMethod.FormattingEnabled = true;
            this.listMethod.ItemHeight = 16;
            this.listMethod.Location = new System.Drawing.Point(342, 65);
            this.listMethod.Margin = new System.Windows.Forms.Padding(4);
            this.listMethod.Name = "listMethod";
            this.listMethod.Size = new System.Drawing.Size(289, 436);
            this.listMethod.TabIndex = 1;
            this.listMethod.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listConstructor
            // 
            this.listConstructor.FormattingEnabled = true;
            this.listConstructor.ItemHeight = 16;
            this.listConstructor.Location = new System.Drawing.Point(668, 65);
            this.listConstructor.Margin = new System.Windows.Forms.Padding(4);
            this.listConstructor.Name = "listConstructor";
            this.listConstructor.Size = new System.Drawing.Size(289, 436);
            this.listConstructor.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(615, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(667, 13);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(291, 28);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblProperties
            // 
            this.lblProperties.AutoSize = true;
            this.lblProperties.Location = new System.Drawing.Point(16, 43);
            this.lblProperties.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProperties.Name = "lblProperties";
            this.lblProperties.Size = new System.Drawing.Size(70, 16);
            this.lblProperties.TabIndex = 5;
            this.lblProperties.Text = "Properties";
            // 
            // lblMethods
            // 
            this.lblMethods.AutoSize = true;
            this.lblMethods.Location = new System.Drawing.Point(339, 43);
            this.lblMethods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMethods.Name = "lblMethods";
            this.lblMethods.Size = new System.Drawing.Size(60, 16);
            this.lblMethods.TabIndex = 6;
            this.lblMethods.Text = "Methods";
            this.lblMethods.Click += new System.EventHandler(this.lblMethods_Click);
            // 
            // lblConstructor
            // 
            this.lblConstructor.AutoSize = true;
            this.lblConstructor.Location = new System.Drawing.Point(665, 43);
            this.lblConstructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConstructor.Name = "lblConstructor";
            this.lblConstructor.Size = new System.Drawing.Size(82, 16);
            this.lblConstructor.TabIndex = 7;
            this.lblConstructor.Text = "Constructors";
            // 
            // GetMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 524);
            this.Controls.Add(this.lblConstructor);
            this.Controls.Add(this.lblMethods);
            this.Controls.Add(this.lblProperties);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.listConstructor);
            this.Controls.Add(this.listMethod);
            this.Controls.Add(this.listProperty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GetMembers";
            this.Text = "Get Members From The Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProperty;
        private System.Windows.Forms.ListBox listMethod;
        private System.Windows.Forms.ListBox listConstructor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblProperties;
        private System.Windows.Forms.Label lblMethods;
        private System.Windows.Forms.Label lblConstructor;
    }
}

