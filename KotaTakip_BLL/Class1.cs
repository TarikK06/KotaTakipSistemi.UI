using KotaTakip_DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace KotaTakip_BLL
{
    public class AboneBLL
    {
        private AboneDAL aboneDal = new AboneDAL();

        public bool AboneEkleBLL(string ad, string soyad, string tckn, string telefon, string email)
        {
            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || tckn.Length != 11)
            {
                return false;
            }

            aboneDal.AboneEkleDAL(ad, soyad, tckn, telefon, email);
            return true;
        }

        public System.Data.DataTable AboneListeleBLL()
        {
            
            return aboneDal.AboneListeleDAL();
        }



        public bool AboneSilBLL(int aboneId)
        {
            
            if (aboneId <= 0)
            {
                return false;
            }

            
            aboneDal.AboneSilDAL(aboneId);
            return true;
        }
        public DataTable HatIcinAboneListeleBLL()
        {
            return aboneDal.HatIcinAboneListeleDAL();
        }

        public void HatTanimlaBLL(int aboneId, int paketId, string ipAdresi)
        {
            aboneDal.HatTanimlaDAL(aboneId, paketId, ipAdresi);
        }

        public void KullanimEkleBLL(int aboneId, int downloadMB, int uploadMB)
        {
            AboneDAL aboneDal = new AboneDAL();
            aboneDal.KullanimEkleDAL(aboneId, downloadMB, uploadMB);
        }
        public DataTable KullanimGecmisiListeleBLL()
        {
            AboneDAL aboneDal = new AboneDAL();
            return aboneDal.KullanimGecmisiListeleDAL();
        }
    }
}