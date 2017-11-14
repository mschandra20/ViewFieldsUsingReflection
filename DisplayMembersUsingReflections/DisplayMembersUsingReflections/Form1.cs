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
            Type P = Type.GetType(txtSearch.Text);
            PropertyInfo[] properties=P.GetProperties();
            
            foreach (PropertyInfo property  in properties)
            {
                listProperty.Items.Add(property.PropertyType.Name +" "+ property.Name);
            }

            //To display Methods
            Type M = Type.GetType(txtSearch.Text);
            MethodInfo[] methods= M.GetMethods();

            foreach (MethodInfo method in methods)
            {
                listMethod.Items.Add(method.ReturnType.Name+" "+ method.Name);
            }

            //To display Methods
            Type C = Type.GetType(txtSearch.Text);
            ConstructorInfo[] constructors = C.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                listConstructor.Items.Add(constructor.MemberType + " "+ constructor.Name); 
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
