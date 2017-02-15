using ApplicationBase.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ApplicationBase
{
    public class MainViewModel : AViewModelBase
    {
        public MainViewModel()
        {

        }

        public ICommand NewCommand { get { return MainController.Instance.NewCommand; } }

        public ICommand OpenCommand { get { return MainController.Instance.OpenCommand; } }

        public ICommand SaveCommand { get { return MainController.Instance.SaveCommand; } }

        public ICommand SaveAsCommand { get { return MainController.Instance.SaveAsCommand; } }

        public ICommand CloseCommand { get { return MainController.Instance.CloseCommand; } }

    }
}
