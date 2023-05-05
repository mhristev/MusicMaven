using Business_Logic.Services;
using Data_Access_Layer.Repositories;

namespace Desktop_Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // Application.Run(new LoginForm());
            ArtistRepository artistRepository = new ArtistRepository();
            ArtistService artistService = new ArtistService(artistRepository);

            AlbumRepository albumRepository = new AlbumRepository(artistRepository);
            AlbumService albumService = new AlbumService(albumRepository);

            SongRepository songRepository = new SongRepository(albumRepository);
            SongService songService = new SongService(songRepository);

            MusicUnitRepository musicUnitRepository = new MusicUnitRepository(albumRepository, artistRepository);
            MusicUnitService musicUnitService = new MusicUnitService(albumService, songService, artistService, musicUnitRepository);




            Application.Run(new MainForm(musicUnitService));
        }
    }
}