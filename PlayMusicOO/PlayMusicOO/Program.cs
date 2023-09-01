Music music1 = new Music();

music1.Name = "Vertigo";
music1.ArtistName = "U2";
music1.Duration = 200;
music1.Available = true;

Music music2 = new Music();

music2.Name = "Morena";
music2.ArtistName = "Los Hermanos";
music2.Duration = 230;
music2.Available = false;


music1.ShowTechnicalFile();
music2.ShowTechnicalFile();