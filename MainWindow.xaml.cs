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

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SzinKeveres()
    {
        rctTeglalap.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliPiros.Value), Convert.ToByte(sliZold.Value), Convert.ToByte(sliKek.Value)));
    }

    private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        pirosErtek.Content = "Piros értéke: " + (Convert.ToByte(sliPiros.Value));
        SzinKeveres();
    }
    private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        zoldErtek.Content = "Zöld értéke: " + (Convert.ToByte(sliZold.Value));
        SzinKeveres();

    }
    private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        kekErtek.Content = "Kék értéke: " + (Convert.ToByte(sliKek.Value));
        SzinKeveres();
    }

    private void btnRogzit_Click(object sender, RoutedEventArgs e)
    {
        List<string> felvettek = new List<string>();
        if (felvettek.Contains($"{Convert.ToByte(sliPiros.Value)} {Convert.ToByte(sliZold.Value)} {Convert.ToByte(sliKek.Value)}")){
            return;
        }
        else
        {
            lbSzinek.Items.Add($"{Convert.ToByte(sliPiros.Value)} {Convert.ToByte(sliZold.Value)} {Convert.ToByte(sliKek.Value)}");
            felvettek.Add($"{Convert.ToByte(sliPiros.Value)} {Convert.ToByte(sliZold.Value)} {Convert.ToByte(sliKek.Value)}");
        }
    }

    private void btnTorol_Click(object sender, RoutedEventArgs e)
    {
        if (lbSzinek.SelectedIndex != -1)
        {
            lbSzinek.Items.RemoveAt(lbSzinek.SelectedIndex);
        }
        else
            MessageBox.Show("Nincs semmi kiválasztva");
    }

    private void btnUrit_Click(object sender, RoutedEventArgs e)
    {
        lbSzinek.Items.Clear();
    }
}
