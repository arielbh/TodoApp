using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TodoApp.Model;
using TodoApp.Resources;

namespace TodoApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        private ObservableCollection<Todo> _todo = new ObservableCollection<Todo>();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            _todo.CollectionChanged += _todo_CollectionChanged;
            DataContext = _todo;

        }

        void _todo_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NoItemsText.Visibility = (_todo.Count> 0)? Visibility.Collapsed : Visibility.Visible;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _todo.Add(new Todo { Id = 1, Title = "fff"});
            
        }
    }
}