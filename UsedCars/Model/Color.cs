namespace UsedCars.Model
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorName { get; set; }

        public Color()
        {
        }

        public Color(int id, string colorname)
        {
            this.Id = id;
            this.ColorName = colorname;
        }
    }
}