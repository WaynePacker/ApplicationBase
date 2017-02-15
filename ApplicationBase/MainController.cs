using ApplicationBase.Commands;
using System;
using System.Windows.Input;

namespace ApplicationBase
{
    public class MainController
    {
        private MainController()
        {
            instance = this;
        }

        ICommand newCommand;
        ICommand openCommand;
        ICommand saveCommand;
        ICommand closeCommand;

        private static MainController instance;
        public static MainController Instance 
        {
            get {  return instance ?? new MainController(); }
        }

        public ICommand NewCommand
        {
            get
            {
                if(newCommand == null)
                    newCommand = new RelayCommand(p => OnNew());
                return newCommand;
            }
        }

        public ICommand OpenCommand
        {
            get
            {
                if (openCommand == null)
                    openCommand = new RelayCommand(p => OnOpen());
                return openCommand;
            }
        }

        public ICommand SaveCommand
        {
            get
            {
                if (saveCommand == null)
                    saveCommand = new RelayCommand(p => OnSave());
                return saveCommand;
            }
        }

        public ICommand SaveAsCommand
        {
            get
            {
                if (saveCommand == null)
                    saveCommand = new RelayCommand(p => OnSaveAs());
                return saveCommand;
            }
        }

        public ICommand CloseCommand
        {
            get
            {
                if (closeCommand == null)
                    closeCommand = new RelayCommand(p => OnClose());
                return closeCommand;
            }
        }

        private void OnNew()
        {
            throw new NotImplementedException();
        }

        private void OnOpen()
        {
            throw new NotImplementedException();
        }

        private void OnSave()
        {
            throw new NotImplementedException();
        }

        private void OnSaveAs()
        {
            throw new NotImplementedException();
        }

        private void OnClose()
        {
            throw new NotImplementedException();
        }
    }
}
