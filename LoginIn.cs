using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace PDATestCSharp
{
    class LoginIn
    {
        /// <summary>
        /// 检测输入的密码正确与否
        /// </summary>
        /// <returns>检测结果</returns>

        public string login(string password)
        {
            string passwordreal = string.Empty;
            passwordreal = IniOperator.GetINI("admin", "password", "", "\\Flash Disk\\Scanner\\config.ini");
            if (password.Equals(""))
            {
                MessageBox.Show("请输入密码！");
                return Message.NoUserOrPassword;
            }
            
            if (passwordreal==password)

            {
                
                return Message.LoginSuccess;
            }
            else
            {
                MessageBox.Show("密码错误，请重新输入");
                
                return Message.Wrong;
            }
            
        }
    }
    class Message
    {
        public static string NoUserOrPassword = "用户名或者密码不能为空";
        public static string LoginSuccess = "登录成功！";
        public static string Wrong = "用户名或者密码不符，登录失败";
    }
}
