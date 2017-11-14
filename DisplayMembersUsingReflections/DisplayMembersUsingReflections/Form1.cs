using System;
using System.Reflection;
using System.Windows.Forms;

namespace DisplayMembersUsingReflections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            listProperty.Items.Clear();
            Type T = Type.GetType(txtSearch.Text);
            PropertyInfo[] properties=T.GetProperties();
            
            foreach (PropertyInfo property  in properties)
            {
                listProperty.Items.Add(property.Name);
            }
        }








        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMethods_Click(object sender, EventArgs e)
        {

        }
    }
}
