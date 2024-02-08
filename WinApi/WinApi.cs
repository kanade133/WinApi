using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WinApi
{
    internal class WinApi
    {
        /// <summary>
        /// Find Window
        /// 查找窗体
        /// </summary>
        /// <param name="lpClassName">窗体的类名 例如对话框类是"#32770"</param>
        /// <param name="lpWindowName">窗体的标题 例如打开记事本 标题是"无标题 - 记事本" 注意 - 号两侧的空格</param>
        /// <returns>窗体的句柄</returns>
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        /// <summary>
        /// Find Window Ex
        /// 查找窗体的子窗体
        /// </summary>
        /// <param name="hWndParent">父窗体的句柄 如果为null，则函数以桌面窗口为父窗口，查找桌面窗口的所有子窗口</param>
        /// <param name="hWndChildAfter">子窗体的句柄 如果为null，从@para1的直接子窗口的第一个开始查找</param>
        /// <param name="lpClassName">子窗体的类名 为""表示所有类</param>
        /// <param name="lpWindowName">子窗体的标题 为""表示要查找的窗体无标题 如空白的textBox控件</param>
        /// <returns>子窗体的句柄</returns>
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpClassName, string lpWindowName);
        /// <summary>
        /// SendMessage
        /// 向窗体发送消息
        /// </summary>
        /// <param name="hWnd">窗体句柄</param>
        /// <param name="Msg">消息类型</param>
        /// <param name="wParam">附加的消息信息</param>
        /// <param name="lParam">附加的消息信息</param>
        /// <returns></returns>
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, StringBuilder lParam);

        /// <summary>
        /// 获得窗体文本 如获得对话框标题
        /// </summary>
        public const int WM_GETTEXT = 0x000D;
        /// <summary>
        /// 设置窗体文本 如设置文本框内容
        /// </summary>
        public const int WM_SETTEXT = 0x000C;
        /// <summary>
        /// 发送点击消息如调用该窗体（按钮）的"button1_Click();"
        /// </summary>
        public const int WM_CLICK = 0x00F5;
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_CLOSE = 0x0010;
        public const int CB_FINDSTRING = 0x014C;
        public const int CB_SELECTSTRING = 0x014D;

    }
}
