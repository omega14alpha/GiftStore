using GiftStore.Enums;
using GiftStore.Models;

namespace GiftStore.Infrastructure.SweetnessFactory
{
    public class ToffeeCreator : Factory
    {
        public override Toffee CreateSweetness()
        {
            Toffee[] toffees = new Toffee[]
                {
                    new Toffee() { Name = "Caramel Toffee", Weight = 12.4f, SugarContent = 7.1f, Taste = "Caramel", Consistency = Consistency.SemiSolid },
                    new Toffee() { Name = "Milk Toffee", Weight = 15.32f, SugarContent = 10.7f, Taste = "Milk Caramel", Consistency = Consistency.Replicated }
                };

            int index = _random.Next(0, toffees.Length);
            return toffees[index];
        }
    }
}
