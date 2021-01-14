using System.Diagnostics.CodeAnalysis;

namespace Matematica.negocio
{
    public class Complejo
    {
        internal int real;
        internal int imaginaria;
        private double x;
        private double y;

        public Complejo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX()
        {
            return this.x;
        }
        public double getY()
        {
            return this.y;
        }
        public object X { get; set; }
        public object Y { get; set; }
        //permite saber si un objeto de tipo complejo es igual a otro tipo complejo
        public bool Equal([AllowNull] Complejo other)
        {
            if(x == other.x && y == other.y){
                return true;
            }
                return false;
        }
    }

}