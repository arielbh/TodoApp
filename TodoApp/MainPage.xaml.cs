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
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            TodoService.Todos.CollectionChanged += _todo_CollectionChanged;
            DataContext = TodoService.Todos;

        }

        void _todo_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NoItemsText.Visibility = (TodoService.Todos.Count > 0) ? Visibility.Collapsed : Visibility.Visible;
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            TodoService.Todos.Add(new Todo { Id = TodoService.Todos.Count + 1 });
        }

        private void GoToCompletedClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CompletedPage.xaml", UriKind.Relative));
        }
    }
}