namespace FormsAssistControl.Model.Entities
{
    public class Student : ObservableBaseObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; base.OnPropertyChange(); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; base.OnPropertyChange(); }
        }

        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; base.OnPropertyChange(); }
        }

        private string studentNumber;

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; base.OnPropertyChange(); }
        }

        private double average;

        public double Average
        {
            get { return average; }
            set { average = value; base.OnPropertyChange(); }
        }
    }
}
