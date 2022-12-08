namespace Wypozyczalnia.Core
{
    public class VideoServices : IVideoServices
    {
        public List<Video> GetVideos()
        {
            return new List<Video>
            {
                new Video
                {
                    Title = "Test",
                    Genre = "Fantasy"
                }
            };
        }
    }
}