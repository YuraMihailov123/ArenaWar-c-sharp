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
        public static void IsCollide(Entity entity)
        {
            for (int j = entity.posX/MapController.cellSize; j < (entity.posX+MapController.cellSize)/MapController.cellSize; j++)
            {
                for (int i = entity.posY / MapController.cellSize; i < (entity.posY + MapController.cellSize) / MapController.cellSize; i++)
                {
                    if (MapController.map[i, j] != 0)
                    {
                        if (entity.dirY > 0)
                        {
                            entity.posY-=10;
                        }
                        if (entity.dirY < 0)
                        {
                            entity.posY += 10;
                        }
                        if (entity.dirX > 0)
                        {
                            entity.posX -= 10;
                        }
                        if (entity.dirX < 0)
                        {
                            entity.posX += 10;
                        }
                    }
                }
            }
        }
    }
}
