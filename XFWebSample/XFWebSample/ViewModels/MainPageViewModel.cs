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
        
        /// <summary>
        /// "Webブラウザで開く"ボタンにバインド
        /// </summary>
        private DelegateCommand _externalBrowserCommand;
        public DelegateCommand ExternalBrowserCommand
        {
            get
            {
                return this._externalBrowserCommand = this._externalBrowserCommand ?? new DelegateCommand(ExternalBrowserCommandExecute);
            }
        }

        /// <summary>
        /// "WebView遷移サンプル1"ボタンにバインド
        /// </summary>
        private DelegateCommand _webViewNavigationSample1Command;
        public DelegateCommand WebViewNavigationSample1Command
        {
            get
            {
                return this._webViewNavigationSample1Command = this._webViewNavigationSample1Command ?? new DelegateCommand(WebViewNavigationSample1CommandExecute);
            }
        }

        /// <summary>
        /// NavigationService
        /// </summary>
        private readonly INavigationService _navigationService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        private MainPageViewModel()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        /// <summary>
        /// 別画面へ遷移するタイミング
        /// </summary>
        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        /// <summary>
        /// 画面へ遷移してきたタイミング
        /// </summary>
        /// <param name="parameters">Parameters.</param>
        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }

        /// <summary>
        /// ExternalBrowserCommand実行
        /// </summary>
        private void ExternalBrowserCommandExecute()
        {
            // Webブラウザで開く
            Device.OpenUri(new Uri("https://www.xamarin.com/"));
        }

        /// <summary>
        /// WebViewNavigationSample1Command実行
        /// </summary>
        private void WebViewNavigationSample1CommandExecute()
        {
            var parameters = new NavigationParameters();
            _navigationService.NavigateAsync("WebNavSamplePage1", parameters, false, true);
        }
    }
}

