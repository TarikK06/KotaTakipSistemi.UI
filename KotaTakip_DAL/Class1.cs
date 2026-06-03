using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace KotaTakip_DAL
{
    public class AboneDAL
    {
        private string baglantiCumlesi = "Server=localhost;Database=KotaTakipDB;Uid=root;Pwd=147852369Tarik.;";

        public void AboneEkleDAL(string ad, string soyad, string tckn, string telefon, string email)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                MySqlCommand cmd = new MySqlCommand("sp_AboneEkle", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_Ad", ad);
                cmd.Parameters.AddWithValue("@p_Soyad", soyad);
                cmd.Parameters.AddWithValue("@p_TCKN", tckn);
                cmd.Parameters.AddWithValue("@p_Telefon", telefon);
                cmd.Parameters.AddWithValue("@p_Email", email);

                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }
            
            public DataTable AboneListeleDAL()
        {
            DataTable tablo = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
              
                MySqlCommand cmd = new MySqlCommand("sp_AboneListele", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                baglanti.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tablo);
                }
            }
             return tablo;
             }
        public void AboneSilDAL(int aboneId)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {

                MySqlCommand cmd = new MySqlCommand("sp_AboneSil", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_AboneID", aboneId);

                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable HatIcinAboneListeleDAL()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                MySqlCommand cmd = new MySqlCommand("sp_AboneListele", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                baglanti.Open();
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd)) { da.Fill(dt); }
            }
            return dt;
        }

        public void HatTanimlaDAL(int aboneId, int paketId, string ipAdresi)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                MySqlCommand cmd = new MySqlCommand("sp_HatTanimla", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_AboneID", aboneId);
                cmd.Parameters.AddWithValue("@p_PaketID", paketId);
                cmd.Parameters.AddWithValue("@p_IPAdresi", ipAdresi);
                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void KullanimEkleDAL(int aboneId, int downloadMB, int uploadMB)
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                MySqlCommand cmd = new MySqlCommand("sp_KullanimEkle", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_AboneID", aboneId);
                cmd.Parameters.AddWithValue("@p_DownloadMB", downloadMB);
                cmd.Parameters.AddWithValue("@p_UploadMB", uploadMB);

                baglanti.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable KullanimGecmisiListeleDAL()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
            {
                MySqlCommand cmd = new MySqlCommand("sp_KullanimGecmisiListele", baglanti);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

    }


    }
