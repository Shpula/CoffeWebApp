using System.Linq;

namespace CoffeWebApp
{
    public static class SampleData
    {
        public static void Initialize(Models.CoffeMachineContext context)
        {
            if (!context.CoffeeMachines.Any())
            {
                context.CoffeeMachines.AddRange(
                    new CoffeWebApp.Models.CoffeeMachine
                    {
                        Price = 10000,
                        Brand = "Samsung",
                        Material = "Алюминий",
                        Capacity = 3.0,
                        Weight = 3000,
                        IsCapsule = false
                    },
                    new CoffeWebApp.Models.CoffeeMachine
                    {
                        Price = 11000,
                        Brand = "Xiaomi",
                        Material = "Пластик",
                        Capacity = 3.5,
                        Weight = 1500,
                        IsCapsule = true
                    },
                    new CoffeWebApp.Models.CoffeeMachine
                    {
                        Price = 15000,
                        Brand = "Miezu",
                        Material = "Сталь",
                        Capacity = 5.0,
                        Weight = 5300,
                        IsCapsule = false
                    },
                    new CoffeWebApp.Models.CoffeeMachine
                    {
                        Price = 133000,
                        Brand = "Apple",
                        Material = "Титан",
                        Capacity = 1.0,
                        Weight = 500,
                        IsCapsule = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
