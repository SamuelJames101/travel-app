using SQLite;

namespace Travelapp.Model
{
    public class Post
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Experience { get; set; }
       
    }
}