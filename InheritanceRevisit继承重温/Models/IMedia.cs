using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRevisit继承重温.Models
{
    public interface IMedia//接口 I媒体==>需要有 public
    {
        string Title { get; set; }
        int Runtime { get; set; }
        void Play();
    }
}
