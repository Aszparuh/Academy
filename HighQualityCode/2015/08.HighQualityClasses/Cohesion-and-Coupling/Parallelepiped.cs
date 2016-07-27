namespace CohesionAndCoupling
{
    using System;

    public class Parallelepiped
    {
        private const string InvalidMessage = "Parameter cannot be negative or zero.";

        private double width;
        private double height;
        private double depth;

        public Parallelepiped(double widht, double height, double depth)
        {
            this.Widht = widht;
            this.Height = height;
            this.Depth = depth;
        }

        public double Widht
        {
            get
            {
                return this.width;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidMessage, "Widht");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidMessage, "Height");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(InvalidMessage, "Depth");
                }

                this.depth = value;
            }
        }

        public double GetVolume()
        {
            return this.Widht * this.Height * this.Depth;
        }

        public double GetDiagonalXYZ()
        {
            var distanceCalculator = new DistanceCalculator();
            double diagonal = distanceCalculator.Calculate3D(0, 0, 0, this.Widht, this.Height, this.Depth);
            return diagonal;
        }

        public double GetDiagonalXY()
        {
            var distanceCalculator = new DistanceCalculator();
            double diagonal = distanceCalculator.Calculate2D(0, 0, this.Widht, this.Height);
            return diagonal;
        }

        public double GetDiagonalXZ()
        {
            var distanceCalculator = new DistanceCalculator();
            double diagonal = distanceCalculator.Calculate2D(0, 0, this.Widht, this.Depth);
            return diagonal;
        }

        public double GetDiagonalYZ()
        {
            var distanceCalculator = new DistanceCalculator();
            double diagonal = distanceCalculator.Calculate2D(0, 0, this.Height, this.Depth);
            return diagonal;
        }
    }
}