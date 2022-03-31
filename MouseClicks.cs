using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PoeDG
{
    internal class MouseClicks
    {
        //設定滑鼠位置
        [DllImport("user32.dll")] //DllImpor針對非託管的。非託管指的是不利用.net 生成的DLL
                                  //宣告一個外部實現方法SetCursorPos()
        public static extern bool SetCursorPos(int X, int Y);
        //控制滑鼠動作
        [DllImport("user32.dll")]
        public static extern void mouse_event(MouseEventFlag flags, int dx, int dy, uint data, UIntPtr extraInfo);
        //在視窗列表中尋找與指定條件相符的第一個視窗,並返回控制程式碼值。這個函式不能查詢子視窗。
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        //該函式獲得一個視窗的控制程式碼，該視窗的類名和視窗名與給定的字串相匹配。這個函式查詢子視窗，從排在給定的子視窗後面的下一個子視窗開始。在查詢時不區分大小寫。
        [DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        #region 滑鼠操作
        //首先定義一個列舉，其繼承uint。這樣可以直觀的體現滑鼠的各類動作。
        //[Flags]位標誌屬性，從而使該列舉型別的例項可以儲存列舉列表中定義值的任意組合。可以用 與(&)、或(|)、異或(^)進行相應的運算。
        [Flags]
        public enum MouseEventFlag : uint //設定滑鼠動作的鍵值
        {
            Move = 0x0001,               //發生移動
            LeftDown = 0x0002,           //滑鼠按下左鍵
            LeftUp = 0x0004,             //滑鼠鬆開左鍵
            RightDown = 0x0008,          //滑鼠按下右鍵
            RightUp = 0x0010,            //滑鼠鬆開右鍵
            MiddleDown = 0x0020,         //滑鼠按下中鍵
            MiddleUp = 0x0040,           //滑鼠鬆開中鍵
            XDown = 0x0080,
            XUp = 0x0100,
            Wheel = 0x0800,              //滑鼠輪被移動
            VirtualDesk = 0x4000,        //虛擬桌面
            Absolute = 0x8000
        }
        public static void MouseLeftClickEvent(int dx, int dy, uint data)
        {
            SetCursorPos(dx, dy);
            mouse_event(MouseEventFlag.LeftDown | MouseEventFlag.LeftUp, dx, dy, data, UIntPtr.Zero);
            System.Threading.Thread.Sleep(2);
        }
        public static void MouseRightClickEvent(int dx, int dy, uint data)
        {
            SetCursorPos(dx, dy);
            mouse_event(MouseEventFlag.RightDown | MouseEventFlag.RightUp, dx, dy, data, UIntPtr.Zero);
            System.Threading.Thread.Sleep(2);
        }
        #endregion
    }
}
