using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Todolist;
using Todolist.Clase;
namespace Todolist.Clase;

public partial class TaskEditor : ContentPage
{
    private TaskItem Task { get; set; }
    private ObservableCollection<TaskItem> Tasks { get; set; }


    public TaskEditor(TaskItem task, ObservableCollection<TaskItem> tasks)
    {
        InitializeComponent();

        Task = task ?? new TaskItem(); 
        Tasks = tasks;

        BindingContext = Task; 
    }
     
    private void SaveTask(object sender, EventArgs e)
    {
        if (!Tasks.Contains(Task))
            Tasks.Add(Task);
        Navigation.PopAsync();
    }

    private void DeleteTask(object sender, EventArgs e)
    {
        if (Tasks.Contains(Task))
            Tasks.Remove(Task);
        Navigation.PopAsync();
    }
}