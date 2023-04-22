using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
namespace ManajemenArtis_Lib
{
    public class Kontrak_kerja
    {
       

        #region data member
        private int id;
        private string judul;
        private string pengaju;
        private string lokasi;
        private string deskripsi;
        private DateTime tblBuat;
        private DateTime tglAcara;
        private string status;
        private Manager manager;
        private Artis artis;
        #endregion

        #region construct
        public Kontrak_kerja(int id, string judul, string pengaju, string lokasi, string deskripsi, DateTime tblBuat, DateTime tglAcara, string status, Manager manager, Artis artis)
        {
            this.Id = id;
            this.Judul = judul;
            this.Pengaju = pengaju;
            this.Lokasi = lokasi;
            this.Deskripsi = deskripsi;
            this.TblBuat = tblBuat;
            this.TglAcara = tglAcara;
            this.Status = status;
            this.Manager = manager;
            this.Artis = artis;
        }
        #endregion

        #region props
        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Pengaju { get => pengaju; set => pengaju = value; }
        public string Lokasi { get => lokasi; set => lokasi = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public DateTime TblBuat { get => tblBuat; set => tblBuat = value; }
        public DateTime TglAcara { get => tglAcara; set => tglAcara = value; }
        public string Status { get => status; set => status = value; }
        public Manager Manager { get => manager; set => manager = value; }
        public Artis Artis { get => artis; set => artis = value; }
        #endregion

        #region METHODS        
        public static List<Kontrak_kerja> BacaData(string criteriaName, string criteriaValue)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status,  " +
               " FROM kontrak_kerja k " +
               " INNER JOIN artis a ON a.id=k.artis_id " +
               " INNER JOIN manajer m ON m.id=k.manajer_id ";

            if (criteriaName == "")
            {
                sql += ";";
            }
            else
            {
                sql += " WHERE " + criteriaName + " LIKE '%" + criteriaValue + "%';";
            }

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                Artis tmpArtis = new Artis();
                tmpArtis.Id = result.GetInt32("artis_id");
                tmpArtis.Nama = result.GetString("nama");

                Manager tmpMan = new Manager();
                tmpMan.Id = result.GetInt32("manajer_id");
                tmpMan.Nama = result.GetString("nama");

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status"),
                    tmpMan, tmpArtis
                    );

                tmpList.Add(tmp);
            }

            return tmpList;
        }
        public static List<Kontrak_kerja> BacaDataSpesifikManajer(int id)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status,  " +
              " FROM kontrak_kerja k " +
              " INNER JOIN artis a ON a.id=k.artis_id " +
              " INNER JOIN manajer m ON m.id=k.manajer_id " +
              " WHERE k.manajer_id=" + id +
              " AND k.status LIKE'%proses%';";

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                Artis tmpArtis = new Artis();
                tmpArtis.Id = result.GetInt32("artis_id");
                tmpArtis.Nama = result.GetString("nama");

                Manager tmpMan = new Manager();
                tmpMan.Id = result.GetInt32("manajer_id");
                tmpMan.Nama = result.GetString("nama");

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status"),
                    tmpMan, tmpArtis
                    );

                tmpList.Add(tmp);
            }

            return tmpList;
        }
        public static List<Kontrak_kerja> BacaDataSpesifikArtis(int id)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status,  " +
               " FROM kontrak_kerja k " +
               " INNER JOIN artis a ON a.id=k.artis_id " +
               " INNER JOIN manajer m ON m.id=k.manajer_id " +
               " WHERE k.artis_id=" + id +
               " AND k.status LIKE'%kosong%';" ;

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                Artis tmpArtis = new Artis();
                tmpArtis.Id = result.GetInt32("artis_id");
                tmpArtis.Nama = result.GetString("nama");

                Manager tmpMan = new Manager();
                tmpMan.Id = result.GetInt32("manajer_id");
                tmpMan.Nama = result.GetString("nama");

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status"),
                    tmpMan, tmpArtis
                    );

                tmpList.Add(tmp);
            }

            return tmpList;
        }

        public static bool TambahKontrak(Kontrak_kerja kontrak)
        {
            string sql = $"INSERT INTO kontrak_kerja(judul, pengaju, lokasi, deskripsi, tanggal_buat, tanggal_acara, status, manajer_id, artis_id) " +
                $" VALUES ({kontrak.Judul},{kontrak.Pengaju},{kontrak.Lokasi},{kontrak.Deskripsi},{kontrak.TblBuat},{kontrak.TglAcara},'kosong',{kontrak.Manager.Id},{kontrak.Artis.Id});";
            if (Koneksi.ExecuteDML(sql))
            {
                return true;
            }
            return false;
        }


        public static bool UpdateStatusKontrak(Kontrak_kerja kontrak, string status)
        {
            string sql = "UPDATE kontrak_kerja " +
                " SET status_artis='"+ status +"' " +
                " WHERE id=" + kontrak.Id + ";";

            if (Koneksi.ExecuteDML(sql))
            {
                return true;
            }

            return false;
        }

        public static void PrintKontrak(Kontrak_kerja kontrak, string AlamatFile, Font tipeFont)
        {
            //step 2 siapkan filetext yang akan ditulisi
            StreamWriter printFile = new StreamWriter(AlamatFile);

            //step 3 menulis ke filetext
            printFile.WriteLine("===================================================");
            printFile.WriteLine("------------------ Kontrak Kerja ------------------");
            printFile.WriteLine("===================================================");
            printFile.WriteLine("Judul          : " + kontrak.Judul);
            printFile.WriteLine("Pengaju        : " + kontrak.Pengaju);
            printFile.WriteLine("Lokasi         : " + kontrak.Lokasi);
            printFile.WriteLine("Tanggal Acara  : " + kontrak.TglAcara.ToString("dd-MM-yyyy"));
            printFile.WriteLine("Deskripsi      : " + kontrak.Deskripsi);
            printFile.WriteLine("===================================================");
            printFile.WriteLine("Artis          : " + kontrak.Artis.Nama);
            printFile.WriteLine("===================================================");
            printFile.Close();

            //kirim ke printer
            Print p = new Print(tipeFont, AlamatFile, 20, 10, 10, 10);
            p.SendToPrinter();

        }
        #endregion
    }
}
