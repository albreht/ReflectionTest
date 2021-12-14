using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows.Input;

namespace WpfCustomControlLibrary1
{
    public class UserControllModelcs:ViewModelBase
    {
        public UserControllModelcs()
        {
            Save = new RelayCommand(() =>
            {
                new WspolnaLib.WspolanLib().
                new Window1().Show();
            });
        }
        public ICommand Save { get; set; }
    }
}
