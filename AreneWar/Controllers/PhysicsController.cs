using AreneWar.Entites;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreneWar.Controllers
{
    public static class PhysicsController
    {
        public static bool IsCollide(Entity entity, Point dir)
        {
            for(int i = 0; i < MapController.mapObjects.Count; i++)
            {
                var currObject = MapController.mapObjects[i];
                PointF delta = new PointF();
                delta.X = (entity.posX + entity.size / 2) - (currObject.position.X + currObject.size.Width / 2);
                delta.Y = (entity.posY + entity.size / 2) - (currObject.position.Y + currObject.size.Height / 2);
                if (Math.Abs(delta.X) <= entity.size / 2 + currObject.size.Width/2)
                {
                    if (Math.Abs(delta.Y) <= entity.size / 2 + currObject.size.Height/2)
                    {
                        if (delta.X < 0 && dir.X==1 && currObject.position.Y > entity.posY && currObject.position.Y + currObject.size.Height < entity.posY + entity.size)
                        {
                            return true;
                        }
                        if (delta.X > 0 && dir.X == -1 && currObject.position.Y > entity.posY && currObject.position.Y + currObject.size.Height < entity.posY+entity.size)
                        {
                            return true;
                        }
                        if (delta.Y < 0 && dir.Y == 1 && currObject.position.X>entity.posX && currObject.position.X+currObject.size.Width<entity.posX+entity.size)
                        {
                            return true;
                        }
                        if (delta.Y > 0 && dir.Y == -1 && currObject.position.X > entity.posX && currObject.position.X + currObject.size.Width < entity.posX+entity.size)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
