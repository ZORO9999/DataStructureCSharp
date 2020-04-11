using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZqDS.ClassFolder;

namespace ZqDS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SequenceLinearList<int> sList = new SequenceLinearList<int>(10);
            sList.AppendElement(10);
            sList.AppendElement(20);
            sList.AppendElement(30);
            sList.AppendElement(40);
            sList.ShowListData();
            Console.WriteLine("ListSize = " + sList.ListSize);
            Console.WriteLine("DataLength = " + sList.DataLength);

            sList.AppendElement(50);
            sList.AppendElement(60);
            Console.WriteLine(sList.ListSize);
            Console.WriteLine(sList.DataLength);
            sList.ShowListData();

            int temp = 0;
            sList.ShowListData();
            sList.GetElement(2, ref temp);
            Console.WriteLine(temp);

            sList.ShowListData();
            sList.StoreElement(2, 1000);
            sList.GetElement(2, ref temp);
            Console.WriteLine(temp);
            sList.ShowListData();

            sList.ShowListData();
            sList.InsertElement(3, 888);
            sList.ShowListData();
            Console.WriteLine("ListSize = " + sList.ListSize);
            Console.WriteLine("DataLength = " + sList.DataLength);

            sList.ShowListData();
            sList.DeleteElement(4, ref temp);
            Console.WriteLine(temp);
            sList.ShowListData();
            Console.WriteLine("ListSize = " + sList.ListSize);
            Console.WriteLine("DataLength = " + sList.DataLength);

            sList.ReverseElement();
            sList.ShowListData();

            sList.AppendElement(5555);
            sList.ShowListData();
            sList.ReverseElement();
            sList.ShowListData();
        }
    }
}
