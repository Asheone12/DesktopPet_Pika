using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using System.Threading;

namespace DesktopPet_Pika
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Thread(new ThreadStart(Warning)).Start();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 主窗体());

        }
        static void Warning()
        {
            string warningText = "*B站关注“随枫飞舞”，扣扣：1933208662\r" +
                "*解决了对话框偶尔会出现空白文字的问题\r" +
                "*解决了听音乐功能点击随机播放后无法列表循环的问题\r" +
                "*新添加了“动画测试”按钮，目前只是照搬其他项目的效果，仅用于测试动画效果\r" +
                "*单击“动画测试”按钮后，皮卡丘暂时隐藏，新出现的宠物可以换装和眨眼，单击退出后皮卡丘出现\r" +
                "*新增了启动后的更新提示窗口";
            MessageBox.Show(warningText);
        }
    
    }
}
