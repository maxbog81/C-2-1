using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Богатов Максим

//1. Добавить свои объекты в иерархию объектов, чтобы получился красивый задний фон, похожий на полёт в звёздном пространстве.
//2. *Заменить кружочки картинками, используя метод DrawImage.

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            Game.Init(form);
            form.Show();
            Game.Draw();
            Application.Run(form);

        }
    }
}
