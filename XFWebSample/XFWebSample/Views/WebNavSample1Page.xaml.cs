using System;
using Xamarin.Forms;

namespace XFWebSample.Views
{
    public partial class WebNavSamplePage1 : ContentPage
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WebNavSamplePage1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Backボタンタップ時処理
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnWebBackButtonTapped(object sender, EventArgs e)
        {
            if (this.WebView.CanGoBack)
            {
                // 戻る
                this.WebView.GoBack();
            }
        }

        /// <summary>
        /// Forwardボタンタップ時処理
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        private void OnWebForwardButtonTapped(object sender, EventArgs e)
        {
            if (this.WebView.CanGoForward)
            {
                // 進む
                this.WebView.GoForward();
            }
        }

        /// <summary>
        /// WebView遷移中処理
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void webviewOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            // Backボタン無効化
            this.WebBackButton.IsEnabled = false;
            // Forwardボタン無効化
            this.WebForwardButton.IsEnabled = false;
        }

        /// <summary>
        /// WebView遷移完了時処理
        /// </summary>
        void webviewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            var webView = sender as WebView;

            this.WebBackButton.IsEnabled = webView.CanGoBack;
            this.WebForwardButton.IsEnabled = webView.CanGoForward;
        }
    }
}

