using AndroidHUD;
using ProgressHud;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProgressHud_Droid))]

namespace ProgressHud
{
    /// <summary>
    /// ProgressHUD操作クラス
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
