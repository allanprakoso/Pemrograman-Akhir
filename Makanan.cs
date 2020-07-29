namespace Final_Pemrograman
{
    class Makanan : Produk
    {
        public double hargabeli;
        private const double keuntungan = 0.1;
        public override double harga()
        {
            return (hargabeli + (hargabeli * keuntungan));
        }
    }
}