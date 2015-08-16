namespace Cooking
{
    public class Chef
    {
        public void Main()
        {
            Potato potato = new Potato();
            Carrot carrot = new Carrot();
            Peel(potato);
            Peel(carrot);
            Cut(potato);
            Cut(carrot);

            Bowl bowl = new Bowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Cut(IVegetable vegetable)
        {
            //...
        }

        private void Peel(IVegetable vegetable)
        {
            //...
        }
    }
}
