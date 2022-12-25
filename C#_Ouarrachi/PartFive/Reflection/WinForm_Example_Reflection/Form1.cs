using System.Reflection;
using System;

namespace WinForm_Example_Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDiscoverTypeInformation_Click(object sender, EventArgs e)
        {
            Type textType = null;
            string typeName = textBoxTypeName.Text;
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                textType = assembly.GetType(typeName);
                if (textType != null)
                    break;
            }
            if (textType != null)
            {
                Type type = Type.GetType(textType.AssemblyQualifiedName, true);
                PopulateMethods(type);
                PopulateProperties(type);
                PopulateConstructors(type);
            }
        }

        private void PopulateMethods(Type type)
        {
            listBoxMethods.Items.Clear();
            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                listBoxMethods.Items.Add($"{method.ReturnType.Name} {method.Name}");
            }
        }
        private void PopulateProperties(Type type)
        {
            listBoxProperties.Items.Clear();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                listBoxProperties.Items.Add($"{property.PropertyType.Name}");
            }
        }
        private void PopulateConstructors(Type type)
        {
            listBoxConstructors.Items.Clear();
            ConstructorInfo[] constructors = type.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                listBoxConstructors.Items.Add($"{constructor}");
            }
        }
    }
}