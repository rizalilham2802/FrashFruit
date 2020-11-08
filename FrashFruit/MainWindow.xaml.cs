using FrashFruit.controller;
using FrashFruit.model;
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

namespace FrashFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller RizalIlham;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(14);
            BucketController bucketController = new BucketController(keranjangBuah, this);
            RizalIlham = new Seller("Rizal", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSuceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            RizalIlham.addFruit(anggur);
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit apple = new Fruit("Apple");
            RizalIlham.addFruit(apple);
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit banana = new Fruit("Banana");
            RizalIlham.addFruit(banana);
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit orange = new Fruit("Orange");
            RizalIlham.addFruit(orange);
        }
    }
}
