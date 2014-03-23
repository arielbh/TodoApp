using System.Collections.ObjectModel;
using TodoApp.Model;

namespace TodoApp
{
    public static class TodoService
    {
        private static ObservableCollection<Todo> _todos = new ObservableCollection<Todo>();

        public static ObservableCollection<Todo> Todos
        {
            get { return _todos; }
            set { _todos = value; }
        }
    }
}