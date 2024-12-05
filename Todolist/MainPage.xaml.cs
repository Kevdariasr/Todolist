using System.Collections.ObjectModel;
using Todolist.Clase;
using Todolist;

namespace Todolist
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<TaskItem> Tasks { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Tasks = new ObservableCollection<TaskItem>();

            BindingContext = this;
        }

        private void AddTask(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TaskEditor(null, Tasks));
        }

        private void EditTask(object sender, EventArgs e)
        {
            var task = (sender as Button).BindingContext as TaskItem;
            Navigation.PushAsync(new TaskEditor(task, Tasks));
        }

        private void MarkCompleted(object sender, EventArgs e)
        {
            var task = (sender as Button).BindingContext as TaskItem;
            task.IsCompleted = true;
        }
        private void SortByPriority(object sender, EventArgs e)
        {
            var sorted = Tasks.OrderBy(t => t.Priority).ToList();
            Tasks.Clear();
            foreach (var task in sorted)
                Tasks.Add(task);
        }

        private void SortByObjective(object sender, EventArgs e)
        {
            var sorted = Tasks.OrderBy(t => t.Objective).ToList();
            Tasks.Clear();
            foreach (var task in sorted)
                Tasks.Add(task);
        }

    }

}
