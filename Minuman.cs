namespace Final_Pemrograman
{
    class Minuman : Produk
    {
        public double hargabeli;
        private const double keuntungan = 0.05;
        public override double harga()
        {
            return (hargabeli + (hargabeli * keuntungan));
        }
    }
}