namespace ASP.NET.Exprtiments.EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var band = new Band()
            {
                BandName = "Metallica",
                Label = "NapalmRecords"
            };

            using (var db = new SongsDbContext())
            {
                //db.Bands.Add(band);

                var metBand =
                    db.Bands.FirstOrDefault(b => b.BandName.Equals("Metallica"));

                if(metBand != null)
                {
                    var metBandId = metBand.Id;

                    var songs = new List<Song>()
                    {
                        new Song()
                        {
                            SongName = "Fuel",
                            ReleaseDate = new DateTime(1997, 11, 18),
                            BandId = metBandId
                        },

                        new Song()
                        {
                                SongName = "Master of Puppets",
                                ReleaseDate = new DateTime(1986, 3, 3),
                                BandId = metBandId
                        }
                    };

                    db.Songs.AddRange(songs);
                    db.SaveChanges();

                    var songsList =
                        db.Songs.Where(s => s.BandId.Equals(metBandId)).ToList();

                    foreach(var song in songsList)
                    {
                        Console.WriteLine($"{song.SongName} - {song.ReleaseDate}");
                    }
                }
            }
        }
    }
}