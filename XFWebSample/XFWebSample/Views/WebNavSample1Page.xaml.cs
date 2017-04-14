using System;
using Xamarin.Forms;
using XFWebSample.DependencyServices;

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
        private void webviewOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            // HUDを表示する
            DependencyService.Get<IProgressHud>().Show("Loading...");

            // ボタン無効
            this.DisableWebButtons();
        }

        /// <summary>
        /// WebView遷移完了時処理
        /// </summary>
        private void webviewOnNavigated(object sender, WebNavigatedEventArgs e)
        {
            // ボタンの有効/無効を設定
            this.SetWebButtonsEnable();

            // HUDを非表示にする
            DependencyService.Get<IProgressHud>().Dismiss();
        }

        /// <summary>
        /// ボタンの有効/無効を設定する
        /// </summary>
        private void SetWebButtonsEnable()
        {
            this.WebBackButton.IsEnabled = this.WebView.CanGoBack;
            this.WebForwardButton.IsEnabled = this.WebView.CanGoForward;
        }

        /// <summary>
        /// ボタンを無効にする
        /// </summary>
        private void DisableWebButtons()
        {
            this.WebBackButton.IsEnabled = false;
            this.WebForwardButton.IsEnabled = false;
        }
    }
}

