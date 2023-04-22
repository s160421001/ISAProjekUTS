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
        private DateTime tglBuat;
        private DateTime tglAcara;
        private string status;
        private Manager manager;
        private Artis artis;
        #endregion

        #region construct
        public Kontrak_kerja()
        {
            this.Id = 0;
            this.Judul = "";
            this.Pengaju = "";
            this.Lokasi = "";
            this.Deskripsi = "";
            this.TglBuat = DateTime.Now;
            this.TglAcara = DateTime.Now;
            this.Status = "";
            this.Manager = manager;
            this.Artis = artis;
        }

        public Kontrak_kerja(int id, string judul, string pengaju, string lokasi, string deskripsi, DateTime tglBuat, DateTime tglAcara, string status, Manager manager, Artis artis)
        {
            this.Id = id;
            this.Judul = judul;
            this.Pengaju = pengaju;
            this.Lokasi = lokasi;
            this.Deskripsi = deskripsi;
            this.TglBuat = tglBuat;
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
        public DateTime TglBuat { get => tglBuat; set => tglBuat = value; }
        public DateTime TglAcara { get => tglAcara; set => tglAcara = value; }
        public string Status { get => status; set => status = value; }
        public Manager Manager { get => manager; set => manager = value; }
        public Artis Artis { get => artis; set => artis = value; }
        #endregion

        #region METHODS        
        public static List<Kontrak_kerja> BacaData(string criteriaName, string criteriaValue)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status_artis, k.manajer_id, k.artis_id" +
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
                List<Artis> tmpArtis = Artis.BacaData("a.id", result.GetInt32("artis_id").ToString());
                List<Manager> tmpManajer = Manager.BacaData("id", result.GetInt32("manajer_id").ToString());

                //Artis tmpArtis = new Artis();
                //tmpArtis.Id = result.GetInt32("artis_id");
                //tmpArtis.Nama = result.GetString("nama");

                //Manager tmpMan = new Manager();
                //tmpMan.Id = result.GetInt32("manajer_id");
                //tmpMan.Nama = result.GetString("nama");

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status_artis"),
                    tmpManajer[0], tmpArtis[0]
                    );
                tmpList.Add(tmp);
            }

            return tmpList;
        }
        public static List<Kontrak_kerja> BacaDataSpesifikManajer(int id)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status_artis, k.manajer_id, k.artis_id" +
              " FROM kontrak_kerja k " +
              " INNER JOIN artis a ON a.id=k.artis_id " +
              " INNER JOIN manajer m ON m.id=k.manajer_id " +
              " WHERE k.manajer_id=" + id +
              " AND k.status_artis LIKE'%proses%';";

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                List<Artis> tmpArtis = Artis.BacaData("a.id", result.GetInt32("artis_id").ToString());
                List<Manager> tmpManajer = Manager.BacaData("id", result.GetInt32("manajer_id").ToString());

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status_artis"),
                    tmpManajer[0], tmpArtis[0]
                    );
                tmpList.Add(tmp);
            }

            return tmpList;
        }

        public static List<Kontrak_kerja> BacaDataSpesifikKontrakTertolakManajer(int id)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status_artis, k.manajer_id, k.artis_id" +
              " FROM kontrak_kerja k " +
              " INNER JOIN artis a ON a.id=k.artis_id " +
              " INNER JOIN manajer m ON m.id=k.manajer_id " +
              " WHERE k.manajer_id=" + id +
              " AND k.status_artis LIKE'%tolak%';";

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                List<Artis> tmpArtis = Artis.BacaData("a.id", result.GetInt32("artis_id").ToString());
                List<Manager> tmpManajer = Manager.BacaData("id", result.GetInt32("manajer_id").ToString());

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status_artis"),
                    tmpManajer[0], tmpArtis[0]
                    );
                tmpList.Add(tmp);
            }

            return tmpList;
        }

        public static List<Kontrak_kerja> BacaDataSpesifikArtis(int id)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status_artis, k.manajer_id, k.artis_id" +
               " FROM kontrak_kerja k " +
               " INNER JOIN artis a ON a.id=k.artis_id " +
               " INNER JOIN manajer m ON m.id=k.manajer_id " +
               " WHERE k.artis_id=" + id +
               " AND k.status_artis LIKE'%kosong%';" ;

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                List<Artis> tmpArtis = Artis.BacaData("a.id", result.GetInt32("artis_id").ToString());
                List<Manager> tmpManajer = Manager.BacaData("id", result.GetInt32("manajer_id").ToString());

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status_artis"),
                    tmpManajer[0], tmpArtis[0]
                    );

                tmpList.Add(tmp);
            }
            return tmpList;
        }

        public static List<Kontrak_kerja> BacaDataSpesifikKontrakTertolakArtis(int id)
        {
            string sql = "SELECT k.id, k.judul,k.pengaju,k.lokasi, k.deskripsi, k.tanggal_buat, k.tanggal_acara, k.status_artis, k.manajer_id, k.artis_id" +
               " FROM kontrak_kerja k " +
               " INNER JOIN artis a ON a.id=k.artis_id " +
               " INNER JOIN manajer m ON m.id=k.manajer_id " +
               " WHERE k.artis_id=" + id +
               " AND k.status_artis LIKE'%tolak%';";

            MySqlDataReader result = Koneksi.JalankanQuery(sql);

            List<Kontrak_kerja> tmpList = new List<Kontrak_kerja>();

            while (result.Read())
            {
                List<Artis> tmpArtis = Artis.BacaData("a.id", result.GetInt32("artis_id").ToString());
                List<Manager> tmpManajer = Manager.BacaData("id", result.GetInt32("manajer_id").ToString());

                Kontrak_kerja tmp = new Kontrak_kerja(result.GetInt32("id"),
                    result.GetString("judul"),
                    result.GetString("pengaju"),
                    result.GetString("lokasi"),
                    result.GetString("deskripsi"),
                    result.GetDateTime("tanggal_buat"),
                    result.GetDateTime("tanggal_acara"),
                    result.GetString("status_artis"),
                    tmpManajer[0], tmpArtis[0]
                    );

                tmpList.Add(tmp);
            }
            return tmpList;
        }

        public static bool TambahKontrak(Kontrak_kerja k)
        {
            string sql = "insert into kontrak_kerja(judul, pengaju, lokasi, deskripsi, tanggal_buat, tanggal_acara, status_artis, manajer_id, artis_id) " +
                "values ('" +
                k.Judul + "','" +
                k.Pengaju + "','" +
                k.Lokasi + "','" +
                k.Deskripsi + "','" +
                k.TglBuat.ToString("yyyy-MM-dd") + "','" +
                k.TglAcara.ToString("yyyy-MM-dd") + "','" +
                "kosong','" +
                k.Manager.Id + "','" +
                k.Artis.Id + "')";

            if (Koneksi.ExecuteDML(sql))
            {
                return true;
            }
            return false;
        }
        public static int EditData(Kontrak_kerja k)
        {
            string sql = "Update kontrak_kerja set deskripsi='" + k.Deskripsi + "' where id='" + k.Id + "'";

            int result = Koneksi.JalankanPerintahDML(sql);
            return result;
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
