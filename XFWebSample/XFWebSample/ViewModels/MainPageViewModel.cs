using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XFWebSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        // 外部ブラウザで開くボタンにバインド
        private DelegateCommand _externalBrowserCommand;
        public DelegateCommand ExternalBrowserCommand
        {
            get
            {
                return this._externalBrowserCommand = this._externalBrowserCommand ?? new DelegateCommand(ExternalBrowserCommandExecute);
            }
        }

        public MainPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        // ExternalBrowserCommand実行部
        private void ExternalBrowserCommandExecute()
        {
            Device.OpenUri(new Uri("https://www.xamarin.com/"));
        }
    }
}

