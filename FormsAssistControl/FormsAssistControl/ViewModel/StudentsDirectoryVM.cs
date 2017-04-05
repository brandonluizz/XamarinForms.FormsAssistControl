using FormsAssistControl.Model.Entities;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using FormsAssistControl.Model.Services;

namespace FormsAssistControl.ViewModel
{
    public class StudentsDirectoryVM : ObservableBaseObject
    {
        public ObservableCollection<Student> Students { get; set; }

        private bool isBusy = false;

        public bool IsBusy
        {
            get { return this.isBusy; }
            set { this.isBusy = value; base.OnPropertyChange(); }
        }

        public Command LoadDirectoryCommand { get; set; }

        public Command ClearDirectoryCommand { get; set; }

        public StudentsDirectoryVM()
        {
            this.Students = new ObservableCollection<Student>();
            this.IsBusy = false;
            this.LoadDirectoryCommand = new Command((obj) => LoadDirectory());
            this.ClearDirectoryCommand = new Command((obj) => ClearDirectory());
        }

        async void ClearDirectory()
        {
            if (this.IsBusy == false)
            {
                this.IsBusy = true;

                await Task.Delay(2000);

                this.Students.Clear();

                this.IsBusy = false;
            }
        }

        async void LoadDirectory()
        {
            if (this.IsBusy == false)
            {
                this.IsBusy = true;

                await Task.Delay(3000);

                var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();

                foreach (var student in loadedDirectory.Students)
                {
                    this.Students.Add(student);
                }

                this.IsBusy = false;
            }
        }
    }
}
