using System;
using System.Reflection;
using System.Windows.Forms;

namespace DisplayMembersUsingReflections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Type T = Type.GetType(txtSearch.Text);
            PropertyInfo[] properties=T.GetProperties();

            foreach (PropertyInfo property  in properties)
            {
                listProperty = property.ToString();
            }
        }








        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
