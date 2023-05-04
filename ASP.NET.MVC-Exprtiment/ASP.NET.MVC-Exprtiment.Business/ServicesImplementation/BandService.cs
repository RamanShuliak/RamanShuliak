using ASP.NET.MVC_Exprtiment.Core;
using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using ASP.NET.MVC_Exprtiment.Core.DataTransferObjects;
using ASP.NET.MVC_Exprtiment.DataBase;
using ASP.NET.MVC_Exprtiment.DataBase.Entities;

namespace ASP.NET.MVC_Exprtiment.Business.ServicesImplementation
{
    public class BandService: IBandService
    {
        public readonly MusicBandsContext _musicBandsContext;

        public BandService(MusicBandsContext musicBandsContext)
        {
            _musicBandsContext = musicBandsContext;
        }

        public Task<int> PopulateDataBase()
        {
            var source = new Label
            {
                Id = new Guid(),
                Name = "Warner Music Group",
                Url = @"https://en.wikipedia.org/wiki/Warner_Music_Group"
            };

            var bandList = new List<Band>()
            {
                new Band()
                {
                    Id = new Guid(),
                    Name = "Metallica",
                    Country = CountryName.USA,
                    DateOfCreation = new DateTime(1981, 3, 10),
                    Description = "Metallica is an American heavy metal band. The band was formed in 1981 in Los Angeles by vocalist and guitarist James Hetfield and drummer Lars Ulrich, and has been based in San Francisco for most of its career.",
                    MainText = "The band's fast tempos, instrumentals and aggressive musicianship made them one of the founding \"big four\" bands of thrash metal, alongside Megadeth, Anthrax and Slayer. Metallica's current lineup comprises founding members and primary songwriters Hetfield and Ulrich, longtime lead guitarist Kirk Hammett, and bassist Robert Trujillo. Guitarist Dave Mustaine, who formed Megadeth after being fired from Metallica, and bassists Ron McGovney, Cliff Burton and Jason Newsted are former members of the band. Metallica first found commercial success with the release of its third album, Master of Puppets (1986), which is cited as one of the heaviest metal albums and the band's best work. The band's next album, ...And Justice for All (1988), gave Metallica its first Grammy Award nomination. Its fifth album, Metallica (1991), was the band's first not to root predominantly in thrash metal; it appealed to a more mainstream audience, achieving substantial commercial success and selling more than 16 million copies in the United States to date, making it the best-selling album of the SoundScan era. After experimenting with different genres and directions in subsequent releases, Metallica returned to its thrash metal roots with the release of its ninth album, Death Magnetic (2008), which drew similar praise to that of the band's earlier albums. The band's eleventh and most recent album, 72 Seasons, was released in 2023."
                },
                new Band()
                {
                    Id = new Guid(),
                    Name = "AC/DC",
                    Country = CountryName.USA,
                    DateOfCreation = new DateTime(1973, 11, 15),
                    Description = "An Australian rock band formed in Sydney in 1973 by Scottish-born brothers Malcolm (rhythm guitar) and Angus Young (lead guitar). Their music has been variously described as hard rock, blues rock, and heavy metal, but the band calls it simply \"rock and roll\".",
                    MainText = "AC/DC underwent several line-up changes before releasing their first album, High Voltage (1975). Membership subsequently stabilised around the Young brothers with Bon Scott (lead vocals), Mark Evans (bass) and Phil Rudd (drums). Evans was fired from the band in 1977 and replaced by Cliff Williams, who has since appeared on every album since Powerage (1978). Seven months after the release of the band's breakthrough album Highway to Hell (1979), Scott died of alcohol poisoning and the other members considered disbanding.[3] However, at the request of Scott's parents, they continued together and recruited English singer Brian Johnson as their new frontman.[4] Their first album with Johnson, Back in Black (1980), was dedicated to Scott's memory. It was a widespread success, launching the band to new heights and becoming the second best-selling album of all time."
                },
                new Band()
                {
                    Id = new Guid(),
                    Name = "Dream Theater",
                    Country = CountryName.USA,
                    DateOfCreation = new DateTime(1985),
                    Description = "An American progressive metal band formed in 1985 under the name Majesty by John Petrucci, John Myung and Mike Portnoy — all natives of Long Island, New York — while they attended Berklee College of Music in Boston, Massachusetts.",
                    MainText = "An American progressive metal band formed in 1985 under the name Majesty by John Petrucci, John Myung and Mike Portnoy — all natives of Long Island, New York — while they attended Berklee College of Music in Boston, Massachusetts. They subsequently dropped out of their studies to concentrate further on the band that would eventually become Dream Theater. Their current lineup consists of Petrucci, Myung, vocalist James LaBrie, keyboardist Jordan Rudess and drummer Mike Mangini.\r\n\r\nOver the course of various lineup changes, Petrucci and Myung have been the only two constant members. Portnoy remained with the band until 2010, when he was replaced by Mangini after deciding to leave to pursue other musical endeavors. After a brief stint with Chris Collins, followed by Charlie Dominici (who was dismissed from Dream Theater not long after the release of their first album), LaBrie was hired as the band's singer in 1991. Dream Theater's first keyboardist, Kevin Moore, left the band after three albums and was replaced by Derek Sherinian in 1995 after a period of touring. The band released one album with Sherinian, who was replaced by current keyboardist Jordan Rudess in 1999. "
                }
            };
        }

        public async Task<List<BandDto>> GetBandsByPageNumberAndPageSize(int pageNumber, int pageSize)
        {
            List<BandDto> list;

            list = _bandStorage.BandsList
                .Skip(pageNumber*pageSize)
                .Take(pageSize).ToList();

            return list;
        }

        public async Task<BandDto> GetBandById(Guid id)
        {
            var band = _bandStorage.BandsList.FirstOrDefault(b => b.Id.Equals(id));

            return band;
        }
    }
}
