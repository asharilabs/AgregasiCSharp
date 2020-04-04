using System;

namespace Youtube_OOP_Agregasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region mendefinisikan objek-objek terkait: Buku dan AnggotaPerpus            
            // 1. Buku
            Buku buku1 = new Buku();
            buku1.kode = "0";
            buku1.judul = "Pemrograman";
            Buku buku2 = new Buku();
            buku2.kode = "1";
            buku2.judul = "Bercocok Tanam";
            Buku buku3 = new Buku();
            buku3.kode = "2";
            buku3.judul = "Menggambar";

            Buku[] pinjamanBukuBuku = new Buku[3];
            pinjamanBukuBuku[0] = buku1;
            pinjamanBukuBuku[1] = buku2;
            pinjamanBukuBuku[2] = buku3;
            // sudah terdapat file pinjamanBukuBuku


            // 2. AnggotaPerpus
            AnggotaPerpus anggota1 = new AnggotaPerpus();
            anggota1.kode = "AA";
            anggota1.nama = "Galih";
            anggota1.kelas = "MI 21 A";
            anggota1.bukuPinjam = pinjamanBukuBuku;
            #endregion

            for (int i = 0; i < anggota1.bukuPinjam.Length; i++)
            {
                Console.WriteLine("#" + (i + 1) + ". " + anggota1.bukuPinjam[i].judul);
            }

            Console.ReadKey();
        }
    }
}