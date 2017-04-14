using System;
using AndroidHUD;
using Xamarin.Forms;
using XFWebSample.DependencyServices;
using XFWebSample.Droid.DependencyServices;

[assembly: Dependency(typeof(ProgressHud_Droid))]

namespace XFWebSample.Droid.DependencyServices
{
    /// <summary>
    /// ProgressHud操作クラス
    /// </summary>
    public class ProgressHud_Droid : IProgressHud
    {
        /// <summary>
        /// HUDを表示する(メッセージなし)
        /// </summary>
        public void Show()
        {
            AndHUD.Shared.Show(Forms.Context, "", -1, AndroidHUD.MaskType.Black);
        }

        /// <summary>
        /// HUDを表示する(メッセージあり)
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Show(string message)
        {
            AndHUD.Shared.Show(Forms.Context, message, -1, AndroidHUD.MaskType.Black);
        }

        /// <summary>
        /// HUDを非表示にする
        /// </summary>
        public void Dismiss()
        {
            AndHUD.Shared.Dismiss();
        }
    }
}
