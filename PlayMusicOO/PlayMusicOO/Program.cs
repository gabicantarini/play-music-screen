Band u2 = new Band("U2");

Album u2Album = new Album("The Best of 1990-2000");

Music music1 = new Music(u2, "Beautiful Day");
music1.Duration = 243;

Music music2 = new Music(u2, "One");
music2.Duration = 261;

u2Album.AddMusic(music1);
u2Album.AddMusic(music2);
u2Album.ShowMusicOnAlbum();



u2.AddAlbum(u2Album);
u2.ShowDiscography();

