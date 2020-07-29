using System;
using System.Collections.Generic;
using System.Linq;

namespace Final_Pemrograman
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produk> listproduk = new List<Produk>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("==Sistem Informasi Produk==");
                Console.WriteLine("[1] Tambah Produk");
                Console.WriteLine("[2] Ubah Data Produk");
                Console.WriteLine("[3] Tampilkan Produk");
                Console.WriteLine("[4] Hapus Produk");
                Console.WriteLine("[5] Keluar");
                Console.Write("Pilihan:");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        CreateProduk(listproduk);
                        break;
                    case 2:
                        UpdateProduk(listproduk);
                        break;
                    case 3:
                        ReadProduk(listproduk);
                        break;
                    case 4:
                        DeleteProduk(listproduk);
                        break;
                }
                if (pilihan == 5)
                    break;
            }
        }

        private static void CreateProduk(List<Produk> listproduk)
        {
            Console.Clear();
            Console.WriteLine("==Menambah Produk==\n");
            Console.WriteLine("Kategori Produk:");
            Console.WriteLine("[1] Makanan");
            Console.WriteLine("[2] Minuman");
            Console.Write("Pilihan:");
            int kategori = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (kategori == 1)
                CreateProdukMakanan();
            else if (kategori == 2)
                CreateProdukMinuman();
            else
                Console.WriteLine("Pilihan Tidak Tersedia");

            void CreateProdukMakanan()
            {
                Makanan produkmakanan = new Makanan();
                Console.Write("ID Produk:");
                produkmakanan.id = Console.ReadLine();
                Console.Write("Nama Produk:");
                produkmakanan.nama = Console.ReadLine();
                Console.Write("Harga Beli:");
                produkmakanan.hargabeli = Convert.ToDouble(Console.ReadLine());
                Console.Write("Jumlah Beli:");
                produkmakanan.jumlah = Convert.ToInt32(Console.ReadLine());
                listproduk.Add(produkmakanan);
            }
            void CreateProdukMinuman()
            {
                Minuman produkminuman = new Minuman();
                Console.Write("ID Produk:");
                produkminuman.id = Console.ReadLine();
                Console.Write("Nama Produk:");
                produkminuman.nama = Console.ReadLine();
                Console.Write("Harga Beli:");
                produkminuman.hargabeli = Convert.ToDouble(Console.ReadLine());
                Console.Write("Jumlah Beli:");
                produkminuman.jumlah = Convert.ToInt32(Console.ReadLine());
                listproduk.Add(produkminuman);
            }

            Console.WriteLine("\n\nData Berhasil Ditambahkan");
            Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
            Console.ReadKey();
        }

        private static void UpdateProduk(List<Produk> listproduk)
        {
            bool ditemukan = false;
            Console.Clear();
            Console.WriteLine("==Update Data Produk==\n");
            Console.Write("Masukan ID Produk: ");
            String searchid = Console.ReadLine();
            foreach (Produk produk in listproduk)
            {
                if (produk.id == searchid)
                {
                    if (produk is Makanan)
                        UpdateProdukMakanan();
                    else if (produk is Minuman)
                        UpdateProdukMinuman();
                    ditemukan = true;
                    break;
                }
            }

            void UpdateProdukMakanan()
            {
                foreach (Makanan makanan in listproduk.Where(makanan
                => makanan.id == searchid))
                {

                    Console.WriteLine("[2] ID Produk  : " + makanan.id);
                    Console.WriteLine("[1] Nama Produk: " + makanan.nama);
                    Console.WriteLine("[3] Harga Beli : " + makanan.hargabeli);
                    Console.WriteLine("[4] Jumlah Produk : " + makanan.jumlah);
                    Console.Write("Pilih Data yang akan di update: ");
                    int pilih = Convert.ToInt32(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Console.Write("\nUpdate ID Produk: ");
                            makanan.id = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\nUpdate Nama Produk: ");
                            makanan.nama = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("\nUpdate Harga Beli: ");
                            makanan.hargabeli = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("\nUpdate Jumlah Produk: ");
                            makanan.jumlah = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }

            void UpdateProdukMinuman()
            {
                foreach (Minuman minuman in listproduk.Where(minuman
                => minuman.id == searchid))
                {

                    Console.WriteLine("[2] ID Produk  : " + minuman.id);
                    Console.WriteLine("[1] Nama Produk: " + minuman.nama);
                    Console.WriteLine("[3] Harga Beli : " + minuman.hargabeli);
                    Console.Write("Pilih Data yang akan di update: ");
                    int pilih = Convert.ToInt32(Console.ReadLine());
                    switch (pilih)
                    {
                        case 1:
                            Console.Write("\nUpdate ID Produk:");
                            minuman.id = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("\nUpdate Nama Produk:");
                            minuman.nama = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("\nUpdate Harga Beli:");
                            minuman.hargabeli = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 4:
                            Console.Write("\nUpdate Jumlah Produk: ");
                            minuman.jumlah = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
            }

            if (ditemukan == false)
                Console.WriteLine("\n\nID Tidak ditemukan");
            else
                Console.WriteLine("\n\nData Berhasil Diupdate");
            Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
            Console.ReadKey();
        }

        private static void ReadProduk(List<Produk> listproduk)
        {
            Console.Clear();
            Console.WriteLine("==Menampilkan Seluruh Produk==\n");
            int nourut = 1;
            Console.WriteLine("No  ID Produk\t Nama Produk\t Harga Produk\t Sisa Produk\t Jenis Produk");
            foreach (Produk produk in listproduk)
            {
                Console.Write("{0}   {1}\t\t {2}\t\t {3}\t\t {4}\t\t",
                    nourut, produk.id, produk.nama, produk.harga(), produk.jumlah);
                ShowValue(produk);
                nourut++;
            }

            void ShowValue(object produk)
            {
                if (produk is Makanan)
                {
                    Console.Write("Makanan\n");
                }
                else if (produk is Minuman)
                {
                    Console.Write("Minuman\n");
                }
            }
            Console.WriteLine("\n\nTekan ENTER untuk kembali ke Home");
            Console.ReadKey();
        }

        private static void DeleteProduk(List<Produk> listproduk)
        {
            bool ditemukan = false;
            Console.Clear();
            Console.WriteLine("==Hapus Data Produk==\n");
            Console.Write("Masukan ID Produk: ");
            String searchid = Console.ReadLine();
            int nourut = 0;
            foreach (Produk produk in listproduk)
            {
                if (produk.id == searchid)
                {
                    ditemukan = true;
                    break;
                }
                nourut++;
            }
            if (ditemukan == false)
                Console.WriteLine("\n\nNIK Tidak ditemukan");
            else
            {
                listproduk.RemoveAt(nourut);
                Console.WriteLine("\n\nData Berhasil di Hapus");
            }
            Console.WriteLine("Tekan ENTER untuk Kembali Ke Home");
            Console.ReadKey();
        }
    }
}
