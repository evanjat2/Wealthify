using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wealthify
{
    internal class Artikel
    {
        private int articleId;
        private string judul;
        private string isi;
        private DateTime tanggal;
        private string urlArticle;
        private static int index = 0;

        public int ArticleId { get => articleId; }

        public string Judul { get => judul; set => judul = value; }

        public string Isi { get => isi; set => isi = value; }   

        public string UrlArticle { get => urlArticle; set => urlArticle = value; }

        public static int Index { get => index; set => index = value; }

        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        
        public Boolean SignUp(string username, string password, string name)
        {
            return false;
        }
    }
}
