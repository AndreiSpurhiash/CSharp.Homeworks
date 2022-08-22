using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw08.House_space
{
    class House
    {

        protected int area { get; set; } = 200;
        protected Door door;

        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {area} m2");
        }
    }

    internal class Door
    {
        protected string color { get; set; } = "Brown";

        public void ShowDataDoor()
        {
            Console.WriteLine($"I am a door, my color is {color}");
        }
    }
}