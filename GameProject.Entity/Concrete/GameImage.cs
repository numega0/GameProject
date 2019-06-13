using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using Core.Entity;

namespace GameProject.Entity.Concrete
{
    public class GameImage : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public byte[] ImageContent { get; set; }


    }
}
