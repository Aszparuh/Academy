namespace RefactorClassShef.Models
{
    public class Chef
    {
        public Bowl CookSalad()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(potato);
            bowl.Add(carrot);

            return bowl;
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.Cut();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel();
        }
    }
}