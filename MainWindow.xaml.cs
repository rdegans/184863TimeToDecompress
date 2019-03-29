using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184863TimeToDecompress
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader sr = new System.IO.StreamReader("msg.txt", true);
            int Lines;
            int.TryParse(sr.ReadLine(), out Lines);
            int counter = 0;
            string newLine;
            string[] messages = new string[Lines];
            int n;
            while (!sr.EndOfStream)
            {
                messages[counter] = sr.ReadLine();
                counter++;
            }
            for (int i = 0; i<messages.Length; i++)
            {
                int.TryParse(messages[i].Substring(0, messages[i].IndexOf(' ')), out n);
                newLine = "";
                for (int x = 0; x< n; x++)
                {
                    newLine += messages[i].Substring(messages[i].IndexOf(' ') + 1);
                }
                messages[i] = newLine;
            }
            string output = "";
            for(int y = 0; y<messages.Length; y++)
            {
                output += messages[y] + Environment.NewLine;
            }
            MessageBox.Show(output);
        }
    }
}
