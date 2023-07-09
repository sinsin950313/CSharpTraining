using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artist[] famousArtists =
            {
                new Artist("레오나르도 다빈치", "이탈리아", 1452, 1519),
                new Artist("빈센트 반 고흐", "네덜란드", 1853, 1890),
                new Artist("클로드 모네", "프랑스", 1840, 1926),
                new Artist("파블로 피카소", "스페인", 1881, 1973),
                new Artist("베르메르", "네덜란드", 1632, 1675),
                new Artist("르노아르", "프랑스", 1841, 1919)
            };

            List<Artist> artists19C = new List<Artist>();
            foreach(var artist in famousArtists)
            {
                if(artist.Birth > 1800 && artist.Birth <= 1900)
                {
                    artists19C.Add(artist);
                }
            }

            artists19C.Sort();
            Console.WriteLine("19세기 미술가를 탄생 순 정렬 : IComparable");
            foreach(var artist in artists19C)
            {
                Console.WriteLine(artist.ToString());
            }
        }
    }

    class Artist : IComparable
    {
        public string Name { get; set; }
        public string Country {  get; set; }
        public int Birth { get; set; }
        public int Die { get; set; }

        public Artist(string name, string country, int birth, int die)
        {
            Name = name;
            Country = country;
            Birth = birth;
            Die = die;
        }

        public int CompareTo(object obj)
        {
            Artist a = (Artist)obj;
            return this.Birth.CompareTo(a.Birth);
        }

        public override string ToString()
        {
            return string.Format(" {0}, {1}, {2}, {3}", Name, Country, Birth, Die);
        }
    }
}
