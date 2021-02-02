using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Form MyFrom;//声明一个引用变量
            MyFrom = new Form();//实例化一个窗体对象并赋值引用变量
            MyFrom.Text = "Hello";//设置窗体对象的表头文本
            MyFrom.ShowDialog();//打开窗体
        }
    }
}
