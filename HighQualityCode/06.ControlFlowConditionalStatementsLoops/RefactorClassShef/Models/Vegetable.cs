namespace RefactorClassShef.Models
{
    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.isPeeled = false;
            this.isCut = false;
            this.isRotten = false;
            this.isCooked = false;
        }

        public bool isPeeled { get; set; }

        public bool isCut { get; set; }

        public bool isRotten { get; set; }

        public bool isCooked { get; set; }

        public void Peel()
        {
            this.isPeeled = true;
        }

        public void Cut()
        {
            this.isCut = true;
        }

        public void Rot()
        {
            this.isRotten = true;
        }

        public void Cook()
        {
            this.isCooked = true;
        }

        public override string ToString()
        {
            string typeVegetable = this.GetType().Name;
            string peeled = this.isPeeled.ToString();
            string cutState = this.isCut.ToString();
            return string.Format("{0} - Peeled:{1} - Cut:{2}", typeVegetable, peeled, cutState);
        }
    }
}