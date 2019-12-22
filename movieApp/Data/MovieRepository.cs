using System.Collections.Generic;
using System.Linq;
using movieApp.Models;

namespace movieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id=1,
                    Name="Dunkirk",
                    Cast="Tom Hardy, Mark Rylance, Cillian Murphy, Harry Stayles",
                    Description="<p> Dunkirk Christopher Nolan'ın yönetmenliğini yaptığı psikolojik bir savaş filmidir. Film boyunca izleyinicin gerilimini en üst seviyede tutarak yansıtmak istediği hayatta kalma savaşını başarılı bir şekilde işlemiştir. Filmin oyuncu kadrosunda ise Tom Hardy, Cillian Murphy, Mark Rylance ve Harry Styles gibi isimler yer almaktadır. </p>",
                    ShortDescription="Christopher Nolan",
                    ImageUrl="Dunkirk.jpg",
                    Date=2017,
                    CategoryId=6
                },
                new Movie()
                {
                    Id=2,
                    Name="Joker",
                    Cast="Joaquin Phoneix", 
                    Description="<p> Başrolünü Jaoquin Phoneix'in üstlendiği, Yönetmenliğini Todd Phillips'in yaptığı Joker filmi 2019 yılında seyirciyle vizyonda buluşmuştur. Gotham'ın ücra sokaklarında bir gün komedyen olmanın hayalini kuran Arthur Fleck'in iç yapısını ve duygu dünyasını bizlere mükemmel bir şekilde aktaran Joker filmi 2019 yılının en iyi yapımları arasında yerini almıştır. </p> ",
                    ShortDescription="Todd Phillips",
                    ImageUrl="Joker.jpg",
                    Date=2019,
                    CategoryId=3
                },
                new Movie()
                {
                    Id=3,
                    Name="Bohemian Rhapsody",
                    Cast="Rami Malek",
                    ShortDescription="Bryan Singer",
                    Description="<p> Queen ismi geçince akıllara gelen ilk şarılardan biri olan Bohemian Rhapsody şarkısının ismini taşıyan film biyografi türündedir. Freddie Mercury karakterini canlandıran Rami Malek'e Oscar kazandıran film, Queen grubunun kuruluşundan itibaren yaşanan briçok olayın perde arkasını izleyicilerle buluşturmuştur. </p> ",
                    ImageUrl="Bohemian_Rhapsody.jpg",
                    Date=2018,
                    CategoryId=1
                },
                new Movie() 
                {
                    Id=4,
                    Name="Green Book",
                    Cast="Viggo Mortensen, Mahershala Ali",
                    Description="<p> Yönetmenliğini Peter Farrelly'nin yaptığı Green Book filmi konusunu yaşanmış bir olaydan almaktadır. 60'lı yılların Amerika'sını bize yansıtmayı amaçlayan Green Book filmi bu denemde yaşanan ırkçılık sorunlarına değinerek yaşanan sorunların başarılı bir şekilde dile getirilmesine vesile olmuştur. Oyuncu kadrosunu Viggo Mortensen, Mahershala Ali ve Linda Cardellini gibi usta oyuncuların paylaştığı film 2019 yılı en iyi yapım Oscar'ını kazanmıştır. <p/> ",
                    ShortDescription="Peter Farrelly",
                    ImageUrl="Green_Book.jpg",
                    Date=2018,
                    CategoryId=5
                },
                new Movie()
                 { 
                    Id=5,
                    Name="Roma",
                    Cast=" Yalitza Aparicio, Marina de Tavira",
                    Description="<p> Meksika'lı yönetmen Alfonso Cuaron'ın kaleminden çıkmış olup dünyada büyük yankı uyandıran Roma filmi, 2018 yılının aralık ayında izleyicilerle buluşmuştur. Yabancı film kategorisinden gelerek 3 Oscar alarak başarılı bir iş ortaya koyan yapım, 70'li yıllarda Meksika'da yaşayan bir ailesin başından geçen olayları anlatmaktadır. ",
                    ShortDescription="Alfonso Cuaron",
                    ImageUrl="Roma.jpg",
                    Date=2018,
                    CategoryId=3
                },
                new Movie()
                 { 
                    Id=6,
                    Name="Harry Potter and the Prisoner of Azkaban",
                    Cast=" Daniel Radcliffe, Emma Watson, Rupert Grint",
                    Description="<p> Alfonso Cuaron'un seride tek yönetmenliğini yaptığı film, sıradışı zaman çizgisiyle dikkat çekiyor. Ünlü sinema eliştirmeni Berna İkizoğlu film hakkında: \"Bu film benim en sevdiğim Harry Potter filmi. Bu filmi sevmeyenlerin amk. Gidip Can Yaman'ı izlesin vizyonsuz köpekler.\" diyor. </p> ",
                    ShortDescription="Alfonso Cuaron",
                    ImageUrl="Azkaban.jpg",
                    Date=2004,
                    CategoryId=2
                },
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }
    }
}