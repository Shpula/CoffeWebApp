namespace CoffeWebApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string SellerName { get; set; } 
        public string ContactPhone { get; set; } 
        public string Adress { get; set; } 
        public int Date { get; set; }
 
        public int CoffeMachineId { get; set; } 
        public CoffeeMachine CoffeMachine { get; set; }
    }
}