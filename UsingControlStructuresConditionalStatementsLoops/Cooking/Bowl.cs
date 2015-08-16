namespace Cooking
{
    using System.Collections.Generic;

    class Bowl
    {
        private IList<IVegetable> vegetables;

        public void Add(IVegetable vegetable)
        {
            this.vegetables.Add(vegetable);
        }
    }
}
