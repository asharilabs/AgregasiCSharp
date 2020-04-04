using System;
using System.Collections.Generic;
using System.Text;

namespace Youtube_OOP_Agregasi
{
    class AnggotaPerpus
    {
        public string kode;
        public string nama;
        public string kelas;
        // anggota perpus meminjam buku                
        public Buku[] bukuPinjam = new Buku[3];
    }
}
