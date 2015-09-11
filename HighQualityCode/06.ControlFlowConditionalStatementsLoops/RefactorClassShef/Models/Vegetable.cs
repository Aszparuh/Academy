namespace RefactorClassShef.Models
{
    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsPeeled = false;
            this.IsCut = false;
            this.IsRotten = false;
            this.IsCooked = false;
        }

        public bool IsPeeled { get; set; }

        public bool IsCut { get; set; }

        public bool IsRotten { get; set; }

        public bool IsCooked { get; set; }

        public void Peel()
        {
            this.IsPeeled = true;
        }

        public void Cut()
        {
            this.IsCut = true;
        }

        public void Rot()
        {
            this.IsRotten = true;
        }

        public void Cook()
        {
            this.IsCooked = true;
        }

        public override string ToString()
        {
            string typeVegetable = this.GetType().Name;
            string peeled = this.IsPeeled.ToString();
            string cutState = this.IsCut.ToString();
            return string.Format("{0} - Peeled:{1} - Cut:{2}", typeVegetable, peeled, cutState);
        }
    }
}