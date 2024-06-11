using System.Collections.Generic;
namespace Algoritm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;
            while (addElement() || count==100)
            {
                count++;
            }
            MessageBox.Show(string.Join(", ", nums));
        }
        private bool addElement()
        {
            int rnd = new Random().Next(10);
            MessageBox.Show(rnd.ToString());
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == rnd)
                    {
                        return true;
                    }
                }
                nums.Add(rnd);
                return false;
        }
    }
}