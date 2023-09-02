Band u2 = new Band("U2");

Album u2Album = new Album("The Best of 1990-2000");

Music music1 = new Music(u2, "Beautiful Day")
{
    Duration = 243,
    Available = true,
};


Music music2 = new Music(u2, "One")
{
    Duration = 261,
    Available = true,
};


u2Album.AddMusic(music1);
u2Album.AddMusic(music2);
u2Album.ShowMusicOnAlbum();

music1.ShowTechnicalFile();
music2.ShowTechnicalFile();

u2.AddAlbum(u2Album);
u2.ShowDiscography();

