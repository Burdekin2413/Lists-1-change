using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists_1
{
    public partial class Form1 : Form
    {
        void printNums(List<int> ns)
        {
            foreach (int i in ns)
            {
                richTextBox1.AppendText(i + ",");
            }
        }

        int average(List<int> ns)
        {
            int t = 0;
            foreach(int i in ns)
            {
                t += i;
            }
            return t;
        }
        public Form1()
        {
            InitializeComponent();
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(5);
            nums.Add(3);
            printNums(nums);
            richTextBox1.AppendText("\n================\n");
            nums.Remove(3);
            printNums(nums);
            richTextBox1.AppendText("\n" + average(nums) + "\n");         
        }
    }
}
