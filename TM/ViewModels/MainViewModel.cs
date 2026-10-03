using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TM.Models;

namespace TM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _newTaskTitle;

        public string NewTaskTitle
        {
            get => _newTaskTitle;
            set
            {
                _newTaskTitle = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<TaskItem> Tasks { get; } = new ObservableCollection<TaskItem>();

        public Command AddTaskCommand { get; }
        public Command<TaskItem> DeleteTaskCommand { get; }
        public Command<TaskItem> ToggleTaskCommand { get; }

        public MainViewModel()
        {
            AddTaskCommand = new Command(AddTask);
            DeleteTaskCommand = new Command<TaskItem>(DeleteTask);
            ToggleTaskCommand = new Command<TaskItem>(ToggleTask);
        }

        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskTitle))
            {
                Tasks.Add(new TaskItem { Title = NewTaskTitle.Trim() });
                NewTaskTitle = string.Empty;
            }
        }

        private void DeleteTask(TaskItem task)
        {
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }

        private void ToggleTask(TaskItem task)
        {
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}