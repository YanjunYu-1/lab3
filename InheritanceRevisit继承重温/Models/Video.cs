using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRevisit继承重温.Models
{
    public class Video:IMedia
    {
        public string Title { get; set; }
        public int Runtime { get; set; }
        public void Play()
        {
            Console.WriteLine($"Watching {Title} on your best viewing screen for {Runtime}."); 
        }
    }
}
