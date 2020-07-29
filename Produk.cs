namespace Final_Pemrograman
{
    abstract class Produk
    {
        public string id;
        public string nama;
        public int jumlah;
        public abstract double harga();
    }
}