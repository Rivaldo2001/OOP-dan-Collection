using System;
using System.Collections;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawanHarian karyawan1 = new karyawanHarian();
            karyawanTetap karyawan2 = new karyawanTetap();
            sales karyawan3 = new sales();

            karyawan1.nik = "19112637";
            karyawan1.nama = "Rivaldo maulana santoso putra";
            karyawan1.upahPerJam = 50000;
            karyawan1.jumlahJamKerja = 20;
            karyawan2.nik = "43213454";
            karyawan2.nama = "Rusdi";
            karyawan2.gajiBulanan = 6000000;
            karyawan3.nik = "345678";
            karyawan3.nama = "Roger";
            karyawan3.jumlahPenjualan = 400;
            karyawan3.komisi =5000;
            List<karyawan> listKaryawan = new List<karyawan>();
            listKaryawan.Add(karyawan1);
            listKaryawan.Add(karyawan2);
            listKaryawan.Add(karyawan3);
            int counter =1;
            foreach (karyawan karyawan in listKaryawan){
                Console.WriteLine(counter+" NIK : "+karyawan.nik+", Nama : "+karyawan.nama+", Gaji : "+karyawan.gaji()+" \n ");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
