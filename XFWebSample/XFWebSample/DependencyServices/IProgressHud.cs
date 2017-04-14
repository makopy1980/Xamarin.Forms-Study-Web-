using System;

namespace XFWebSample.DependencyServices
{
    /// <summary>
    /// ProgressHud操作クラス
    /// </summary>
    public interface IProgressHud
    {
        /// <summary>
        /// HUDを表示する(メッセージなし)
        /// </summary>
        void Show();
        /// <summary>
        /// HUDを表示する(メッセージあり)
        /// </summary>
        /// <param name="message">メッセージ</param>
        void Show(string message);
        /// <summary>
        /// HUDを非表示にする
        /// </summary>
        void Dismiss();
    }
}
