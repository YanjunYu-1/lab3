using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRevisit继承重温.Models
{
    public abstract class User//abstract抽象
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //One-To-Many
        public ICollection<IMedia> Media { get; set; }

        public virtual void GenerateEmail() //生成电子邮件
        {
            Email = $"{Name}{Id}@napster.com";
        }
        public void Bing()
        {
            foreach(var media in Media)
            {
                media .Play();
            }
        }
    }
}
