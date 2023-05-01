using System;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Vues;

namespace VueModele
{
    public class MainViewModel
    {
        public ICommand OpenNewArticleWindowCommand { get; private set; }

        public MainViewModel()
        {
            OpenNewArticleWindowCommand = new RelayCommand(OpenNewArticleWindow);
        }

        private void OpenNewArticleWindow()
        {
            throw new NotImplementedException();
        }

        private void OpenNewArticleWindow(object obj)
        {
            MainWindowNewArticle newArticleWindow = new MainWindowNewArticle();
            newArticleWindow.Show();
        }
    }
}
