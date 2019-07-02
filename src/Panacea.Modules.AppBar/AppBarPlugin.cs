using Panacea.Core;
using Panacea.Modularity.AppBar;
using Panacea.Modularity.UiManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.AppBar
{
    public class AppBarPlugin : IAppBarPlugin
    {
        public AppBarPlugin(PanaceaServices core)
        {
            _core = core;
        }

        public Task BeginInit()
        {
            return Task.CompletedTask;
        }

        public void Dispose()
        {

        }

        public Task EndInit()
        {
            return Task.CompletedTask;
        }

        AppBar _appbar;
        private readonly PanaceaServices _core;

        public IAppBar GetAppBar()
        {
            if (_appbar == null)
            {
                _appbar = new AppBar();
                _appbar.IsVisibleChanged += _appbar_IsVisibleChanged;
            }
            return _appbar;
        }

        private void _appbar_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (_core.TryGetUiManager(out IUiManager ui))
            {
                if ((bool)e.NewValue)
                {
                    ui.Pause();
                }
                else
                {
                    ui.Resume();
                }
            }
        }

        public Task Shutdown()
        {
            return Task.CompletedTask;
        }
    }
}
