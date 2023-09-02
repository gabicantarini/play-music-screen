Album u2Album = new Album();

u2Album.Name = "The Best of 1990-2000";

Music music1 = new Music();
music1.Name = "Beautiful Day";
music1.Duration = 243;

Music music2 = new Music();
music2.Name = "One";
music2.Duration = 261;

u2Album.AddMusic(music1);
u2Album.AddMusic(music2);
u2Album.ShowMusicOnAlbum();

Band u2 = new Band();
u2.Name = "U2";
u2.AddAlbum(u2Album);
u2.ShowDiscography();

