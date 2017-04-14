using FormsAssistControl.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsAssistControl.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedStudentDetailPage : ContentPage
    {
        public Student SelectedStudent { get; set; }
        
        public SelectedStudentDetailPage(Student selectedStudent)
        {
            InitializeComponent();
            SelectedStudent = selectedStudent;
            this.BindingContext = SelectedStudent;
        }
    }
}
