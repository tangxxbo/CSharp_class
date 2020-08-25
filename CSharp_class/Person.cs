using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_class
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public static string Sport { get; set; }

        public void Introduce(string name)
        {
            MessageBox.Show("我叫" + name);
        }
        public string Tops(int height)
        {
            return  "身高"+ height+"CM";
        }

        public string Eat(string name)
        {
            return name + "正在吃饭";
        }

        public string Run(string name)
        {
            return name + "正在跑步";
        }

        public static void Play(string name)
        {
            MessageBox.Show(name + "正在玩");
        }

    }
}
