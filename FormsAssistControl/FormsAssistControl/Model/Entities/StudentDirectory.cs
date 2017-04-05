using System.Collections.ObjectModel;

namespace FormsAssistControl.Model.Entities
{
    public class StudentDirectory : ObservableBaseObject
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();

        public ObservableCollection<Student> Students
        {
            get { return students; }
            set { students = value; base.OnPropertyChange(); }
        }
    }
}
