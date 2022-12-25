using Linq_For_Lists_Sorting_Filtering_And_Aggregating_Lists_Easily;


namespace Linq_Form_App
{
    public partial class Form1 : Form
    {
        List<Person> peoples = ListManager.LoadSampleData();
        public Form1()
        {
            InitializeComponent();
            initializeBiding();
        }

        private void initializeBiding()
        {
            comboBoxAllPeople.DataSource = peoples;
            comboBoxAllPeople.DisplayMember = "FullName";
            PopulateFiltredList();
        }

        private void PopulateFiltredList()
        {
            listBoxFiltredList.Items.Clear();
            List<Person> persons = peoples.Where(person => person.YearsExperience >= 5).OrderBy(person => person.FirstName).OrderByDescending(person => person.LastName).ToList();
            if (persons.Count > 0)
            {
                listBoxFiltredList.BeginUpdate();
                foreach (Person person in persons)
                {
                    listBoxFiltredList.Items.Add($"{person.FirstName} - {person.LastName} - {person.BirthDay.ToShortDateString()} - {person.YearsExperience}");
                }
                listBoxFiltredList.EndUpdate();
            }
        }
        private void comboBoxAllPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)comboBoxAllPeople.SelectedItem;
            numericUpDownYearsExperience.Value = selectedPerson.YearsExperience;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)comboBoxAllPeople.SelectedItem;
            selectedPerson.YearsExperience = (int)numericUpDownYearsExperience.Value;
            PopulateFiltredList();

        }
    }
}