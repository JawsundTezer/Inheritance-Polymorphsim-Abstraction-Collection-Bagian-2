using System;
using System.Collections.Generic;
using TugasOOP.Anak;
using TugasOOP.Induk;

namespace TugasOOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //deklarasi objek
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2701";
            karyawanTetap.Nama = "Akmal";
            karyawanTetap.GajiBulanan = 9000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "20.80.9658";
            karyawanHarian.Nama = "Hidayatullah";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 180000;

            Sales sales = new Sales();
            sales.Nik = "60.88.45";
            sales.Nama = "Jawsund";
            sales.JumlahPenjualan = 100;
            sales.Komisi = 2500;
            

            //object class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            

            //loop
            int nomor = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}.NIK: {1}\nNama: {2} \nGaji: {3:N0}\n",
                    nomor, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nomor++;
            }
            

           

        }
    }
}