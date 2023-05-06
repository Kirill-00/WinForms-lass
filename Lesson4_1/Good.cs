using System;

namespace Lesson4_1
{
    public class Good
    {
        string name;
        string made_in;
        double price;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Made_in
        {
            get { return made_in; }
            set { made_in = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                {
                    throw new Exception("Цена не может быть меньше нуля");
                }
                price = value;
            }
        }
        public Good()
        {
            Name = "Unknown";
            Made_in = "Unknown";
            Price = 0;
        }
        public Good(string name, string made_in, double price)
        {
            Name = name;
            Made_in = made_in;
            Price = price;
        }

        public override string ToString()
        {
            return $"Название: {Name}\tИзготовитель: {Made_in}\tЦена: {Price}";
        }
    }
}