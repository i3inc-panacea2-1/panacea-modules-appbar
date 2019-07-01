using Panacea.Modularity.AppBar;
using Panacea.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Native.Extensions;
using System.Windows.Shapes;

namespace Panacea.Modules.AppBar
{
    /// <summary>
    /// Interaction logic for AppBar.xaml
    /// </summary>
    public partial class AppBar : Window, IAppBar
    {
        public AppBar()
        {
            InitializeComponent();
        }

        public void AddButton(ViewModelBase vm)
        {

        }

        void IAppBar.Show()
        {
            this.ToAppBar(System.Windows.Native.ABEdge.Bottom);
            Show();
        }

        void IAppBar.Hide()
        {
            Hide();
        }

        public void RemoveButton(ViewModelBase vm)
        {

        }
    }
}
