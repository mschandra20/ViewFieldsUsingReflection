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
            listMethod.Items.Clear();
            listConstructor.Items.Clear();

            //To display properties
            Type T = Type.GetType(txtSearch.Text);
            PropertyInfo[] properties=T.GetProperties();
            
            foreach (PropertyInfo property  in properties)
            {
                listProperty.Items.Add(property.PropertyType.Name +" "+ property.Name);
            }

            //To display Methods
            MethodInfo[] methods= T.GetMethods();

            foreach (MethodInfo method in methods)
            {
                listMethod.Items.Add(method.ReturnType.Name+" "+ method.Name);
            }

            //To display Construtors
            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                listConstructor.Items.Add(constructor.ToString()); 
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
