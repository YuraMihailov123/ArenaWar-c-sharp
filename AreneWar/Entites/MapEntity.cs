using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreneWar.Entites
{
    public class MapEntity
    {
        public PointF position;
        public Size size;

        public MapEntity(PointF pos, Size size)
        {
            this.position = pos;
            this.size = size;
        }
    }
}
