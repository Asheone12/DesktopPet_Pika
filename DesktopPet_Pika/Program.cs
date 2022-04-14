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
                "*修复了“动画演示”窗体关闭后任务栏仍然显示的问题\r" +
                "*优化了“动画演示”的宠物出现位置，现在新的宠物会出现在原先皮卡丘的位置。\r" +
                "*优化了“动画演示”窗体关闭后，皮卡丘出现的位置，现在皮卡丘会出现在原先宠物所在的位置。\r" ;
            MessageBox.Show(warningText);
        }
    
    }
}
