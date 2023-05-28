namespace CoffeWebApp.Models
{
    public class CoffeeMachine
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public double Capacity { get; set; }
        public double Weight { get; set; }
        public bool IsCapsule { get; set; }
        
    }
}