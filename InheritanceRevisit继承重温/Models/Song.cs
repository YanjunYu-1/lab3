using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRevisit继承重温.Models
{
    public class Song:IMedia//歌曲
    {
        public int Id { get; set; }
        public int Runtime { get; set; }
        public string Title { get; set; }

        //One-To-One
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        //One-To-Many 
        public ICollection<Customer> Customers { get; set; }

        public void Play()
        {
            Console.WriteLine($"Playing the song {Title} on your favourite music platform for {Runtime}."); 
        }
    }
}
