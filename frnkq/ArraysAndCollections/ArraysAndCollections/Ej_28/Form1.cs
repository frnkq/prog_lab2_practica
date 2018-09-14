using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string[] words =  this.rtxtTextBox.Text.Split(' ');
            foreach (string word in words)
            {
                if (dic.ContainsKey(word))
                    dic[word] += 1;
                else
                    dic.Add(word, 1);
            }
            

            List<KeyValuePair<string,int>> myList = dic.ToList();
            myList.Sort(MySort);
            Dictionary<string, int> newDic = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int>kvp in myList)
            {
                newDic.Add(kvp.Key, kvp.Value);
            }

            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<string, int> kvp in newDic)
            {
                sb.AppendLine(string.Format("{0} {1}", kvp.Key, kvp.Value));
            }

            this.rtxtTextBox.Text = sb.ToString();
            this.lblCantPalabras.Text = "Cantidad de palabras: "+dic.Count.ToString();

            sb = new StringBuilder();
            int length = (myList.Count >=3) ? 3 : myList.Count;

            //
            for(int i = 0; i < length; i++)
            {
                sb.AppendLine(String.Format("{0}, {1}", myList.ElementAt(i).Key, myList.ElementAt(i).Value));
            }
                

            MessageBox.Show(sb.ToString(), "Top palabras");

            dic.Clear();
            newDic.Clear();
          
        }


        public static int MySort(KeyValuePair<string, int> kpv1, KeyValuePair<string, int> kpv2)
        {
            return -string.Compare(kpv1.Value.ToString(), kpv2.Value.ToString());
        }

        private void rtxtTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
