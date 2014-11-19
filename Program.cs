using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PDATestCSharp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            if (validateResult())
            {
            Application.Run(new Form1());asdfasdf
            }
        }
        /// <summary>
        /// 判断登录的密码正确与否
        /// </summary>
        /// <returns></returns>
        static bool validateResult()
        {
            bool result = false;
            Login form = new Login();
            if (form.ShowDialog() == DialogResult.OK)
            {
                result = true;


            }
            form.Dispose();
            GC.Collect();
            return result;

        }
    }
}sdfs