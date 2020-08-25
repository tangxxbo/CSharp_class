using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ArrayList arrayList = new ArrayList();
            arrayList.Add(123);
            arrayList.Add("wc");
            arrayList.Insert(1, "fk");
            arrayList.RemoveAt(0);
            arrayList.Remove("wc");*/
            /*Person person = new Person()
            {
                Name = "李四",
                Age = 16,
                Height = 180
            };

            person.Age = 18;
            person.Height = 175;
            person.Name = "王五";

            string sports = Person.Sport = "篮球";
            Person.Play(sports);*/

            List<Person> people = new List<Person>();
            Person person = new Person();
            person.Age = 18;
            person.Height = 175;
            person.Name = "王五";
            Person.Sport = "basketball";
            people.Add(person);

            Dictionary<int, string> dicts1 = new Dictionary<int, string>();
            dicts1.Add(1,"DFP");
            dicts1.Add(2, "TXX");
            dicts1.Add(3, "XQ");
            dicts1[1] = "DLB";
            dicts1[4] = "HXW";

            Dictionary<string, string> dicts2 = new Dictionary<string, string>() {
                { "湘大", "DFP"},
                { "中南", "TXX"},
                { "湖大", "XQ"},
                {"师范", "HXW" },
                { "科大", "DK"}
            };
            Dictionary<string, string> dicts3 = new Dictionary<string, string>();
            dicts3.Add("湘大", "DFP");
            dicts3.Add("中南", "TXX");
            dicts3.Add("湖大", "XQ");
            dicts3.Add("师范", "HXW");
            dicts3.Add("科大", "DK");

            foreach (KeyValuePair<string,string> item in dicts3)
            {
                string key = item.Key;
                string value = item.Value;
                MessageBox.Show(key + ":" + value);
            }

        }
    }
}
