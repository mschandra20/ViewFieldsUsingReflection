using System;
using System.Reflection;
using System.Windows.Forms;

namespace DisplayMembersUsingReflections
{
    public partial class GetMembers : Form
    {
        public GetMembers()
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClearLists();
            Type T = Type.GetType(txtSearch.Text);

            GetAllProperties(T);
            GetAllMethods(T);
            GetAllConstructors(T);

        }


        //TO clear the list everytime the button is pressed
        private void ClearLists()
        {
            listProperty.Items.Clear();
            listMethod.Items.Clear();
            listConstructor.Items.Clear();
        }


        //To display Constructors
        private void GetAllConstructors(Type T)
        {
            ConstructorInfo[] constructors = T.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                listConstructor.Items.Add(constructor.ToString());
            }
        }


        //To display Methods
        private void GetAllMethods(Type T)
        {
            MethodInfo[] methods = T.GetMethods();

            foreach (MethodInfo method in methods)
            {
                listMethod.Items.Add(method.ReturnType.Name + " " + method.Name);
            }
        }


        //To display properties
        private void GetAllProperties(Type T)
        {
             
            PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                listProperty.Items.Add(property.PropertyType.Name + " " + property.Name);
            }

        }



        //Unused methods
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMethods_Click(object sender, EventArgs e)
        {

        }
    }
}
