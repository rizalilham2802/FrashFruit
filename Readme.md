# Fresh Fruit
fresh fruit adalah aplikasi yang digunakan untuk menambahkan buah-buahan ke dalam sebuah keranjang dan dapat di batasi kapasitasnya, Pada Aplikasi ini juga terdapat konsep MVC (Model View Controller).

# SCOPE & FUNCTIONALITIES
- user dapat menekan tombol Add untuk menambahkan fruit yang di inginkan sesuai dengan kapasitas keranjang yang sudah di tentukan
- user dapat melihat list buah yang sesuai dengan pilihan sebelumnya(Listbox)


## HOW DOES IT WORKS?
pada class `BucketController.cs` merupakan logic view yang di gunakan untuk memberi tahu apakah keranjang sudah penuh atau belum dan untuk menambahkan buah kedalam listnya
```java
public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ops, Keranjang penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSuceed("yey berhasil ditambahkan");
            }
        }
```
pada class `MainWindow.xaml.cs` pada logic ini kita akan memberi kapasitas pada keranjang 14 jika kita memasukkan buah lebih dari 14 maka akan diberi peringatan bahwa keranjang sudah penuh dan pada logic ini kita memanggil class class yang lain
```
public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(14);
            BucketController bucketController = new BucketController(keranjangBuah, this);
            RizalIlham = new Seller("Rizal", bucketController);

            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }
```
Fungsi dari `BucketEventListener.cs`?

digunakan untuk mengelompokan beberapa fungsi yang dapat di implementasikan oleh suatu Class atau Struct.