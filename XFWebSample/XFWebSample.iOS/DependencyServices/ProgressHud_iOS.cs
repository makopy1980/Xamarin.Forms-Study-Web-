using System;
using BigTed;
using Xamarin.Forms;
using XFWebSample.DependencyServices;
using XFWebSample.iOS.DependencyServices;

[assembly: Dependency(typeof(ProgressHud_iOS))]

namespace XFWebSample.iOS.DependencyServices
{
    /// <summary>
    /// ProgressHud操作クラス
    /// </summary>
    public class ProgressHud_iOS : IProgressHud
    {
        /// <summary>
        /// HUDを表示する(メッセージなし)
        /// </summary>
        public void Show()
        {
            BTProgressHUD.Show("", -1, ProgressHUD.MaskType.Black);
        }

        /// <summary>
        /// HUDを表示する(メッセージあり)
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Show(string message)
        {
            BTProgressHUD.Show(message, -1, ProgressHUD.MaskType.Black);
        }

        /// <summary>
        /// HUDを非表示にする
        /// </summary>
        public void Dismiss()
        {
        	BTProgressHUD.Dismiss();
        }
    }
}
