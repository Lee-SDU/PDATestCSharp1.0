using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PDATestCSharp
{
    public partial class Form1 : Form
    {
        public static string strpath = @"\Flash Disk\Scanner\config.ini";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region modify password
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.tbx_prepwd.Text == "" || this.tbx_newpwd.Text == "")
            {
                MessageBox.Show("请输入内容");
                return;
            }
            string prepwd = IniOperator.GetINI("admin", "password", "", strpath);
            if (this.tbx_prepwd.Text == prepwd)
            {
                IniOperator.PutINI("admin", "password", this.tbx_newpwd.Text, strpath);
                MessageBox.Show("密码修改成功："+this.tbx_newpwd.Text);
            }

        }
        #endregion




        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //AddInfo addinfo = new AddInfo("basicinfo", "productid", null);
                //string[] splitvalue = addinfo.splitvalue();

                //for (int i = 0; i < splitvalue.Length; i++)
                //{
                //    this.listBox1.Items.Add(splitvalue[i]);
                //}
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                //AddInfo addinfo = new AddInfo("basicinfo", "productspec", null);
                //string[] splitvalue = addinfo.splitvalue();
                //this.listBox1.Items.Clear();
                //for (int i = 0; i < splitvalue.Length; i++)
                //{
                //    this.listBox1.Items.Add(splitvalue[i]);
                //}
                panel1.Enabled = false;
                panel2.Enabled = true;

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AddInfo addinfo = new AddInfo("basicinfo", "productid", "");
            if (radioButton1.Checked == true)
            {
                addinfo.Key = "productid";
                addinfo.Value = this.tbx_productid.Text;
                addinfo.add();
                MessageBox.Show("添加产品编号成功:"+this.tbx_productid.Text);
            }
            else if (radioButton2.Checked == true)
            {
                addinfo.Key = "productspec";
                StringBuilder sb=new StringBuilder(this.tbx_productspec.Text);
                sb.Append("每");
                sb.Append(this.cbb_per.SelectedText);
                addinfo.Value = sb.ToString();
                addinfo.add();
                MessageBox.Show("添加产品规格成功:" + sb.ToString());
            }
            else
            {
                MessageBox.Show("请选择要添加的类别");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

 


    }
}