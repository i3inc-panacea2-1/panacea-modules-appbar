using Panacea.Modularity.AppBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modules.AppBar
{
    public class AppBarPlugin : IAppBarPlugin
    {
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

        IAppBar _appbar;
        public IAppBar GetAppBar()
        {
            return _appbar ?? (_appbar = new AppBar());
        }

        public Task Shutdown()
        {
            return Task.CompletedTask;
        }
    }
}
