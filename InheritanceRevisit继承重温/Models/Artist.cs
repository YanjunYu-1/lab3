using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRevisit继承重温.Models
{
    public class Artist:User//艺术家
    {
        public override void GenerateEmail()//重写此方法
        {
            Email = $"A{Name}{Id}@napster.com";
        }
    }
}
