namespace UsedCars.Model
{
    public class Car
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }

        public Car()
        {
        }

        public Car(int id, string name, int price, string color, int year, int kilometers)
        {
            this.Id = id;
            Name = name;
            Price = price;
            Color = color;
            Year = year;
            Kilometers = kilometers;
        }
    }
}