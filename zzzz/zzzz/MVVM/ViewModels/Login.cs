using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace zzzz.MVVM.ViewModels
{
    internal class Login
    {
        public ICommand LoginCommand => new RoutedCommand();
    }
}
