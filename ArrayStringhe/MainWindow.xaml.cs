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
using System.IO;

namespace ArrayStringhe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string file = "prova.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        string[] a = new string[5];
        int c = 0;
        private void BtnInserisci_Click(object sender, RoutedEventArgs e)
        {
            a[c] = TxtStringa.Text;
            c++;
            TxtStringa.Clear();
            TxtStringa.Focus();
            if (c >= 5)
            {
                BtnStampa.IsEnabled = true;
                BtnPubblica.IsEnabled = true;
                BtnInserisci.IsEnabled = false;
            }
        }

        private void BtnStampa_Click(object sender, RoutedEventArgs e)
        {
            for (c = 0; c < a.Length; c++)
            {
                LblStringa.Content += $"Posizione {c} : {a[c]} \n";
            }
        }

        private void BtnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writerfile = new StreamWriter(file, false, Encoding.UTF8);
            for (c = 0; c < a.Length; c++)
            {
                writerfile.WriteLine($" Posizione {c} : {a[c]} \n");
            }
            writerfile.Flush();
            writerfile.Close();
        }
    }
}
