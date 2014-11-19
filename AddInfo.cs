using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PDATestCSharp
{
    class AddInfo
    {
        private string section;
        private string key;
        private string newvalue;
        private string prevalue;
        private string strpath;
        public AddInfo(string section,string key,string value)
        {
            this.section = section;
            this.key = key;
            this.newvalue = value;
            this.strpath = @"\Flash Disk\Scanner\config.ini";
            this.prevalue = IniOperator.GetINI(section, key, "", strpath);
        }
        /// <summary>
        /// 动态添加局部变量value
        /// </summary>
        public string Value
        {
            set
            {
                this.newvalue = value;
            }
        }
        /// <summary>
        /// 动态添加局部变量key
        /// </summary>
        public string Key
        {
            set
            {
                this.key = value;
            }
        }
        /// <summary>
        /// 合成新的变量
        /// </summary>
        /// <returns></returns>
        private string combine()
        {
            StringBuilder sb = new StringBuilder(prevalue);
            if (prevalue != "")
            {
                sb.Append(",");
            }
            sb.Append(newvalue);
            return sb.ToString();
        }
        /// <summary>
        /// 插入进入ini配置文件中
        /// </summary>
        public void add()
        {
            IniOperator.PutINI(section, key, combine(), strpath);
        }
        /// <summary>
        /// 将指定的值按照逗号分割
        /// </summary>
        /// <returns></returns>
        public string[] splitvalue()
        {
            string[] valuesplit;
            valuesplit=IniOperator.GetINI(section, key, "", strpath).Split(new char[]{','});
            return valuesplit;
        }
        

    }
}
