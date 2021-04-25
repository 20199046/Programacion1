using System;
using System.Collections.Generic;
using System.Text;

namespace tarea1
{
    public class isoceles
    {
        public double height;
        public double basis;
        public double side;

        public double area()
        {
            double area = this.basis * this.height / 2;
            return area;
        }

        public double perimetro()
        {
            double perimer = 2 * this.side + this.basis;
            return perimer;
        }

        public void  Grow(double quantity)
        {
            this.basis = this.basis + quantity;
            this.height = this.height + quantity;
        }

        public double compare(isoceles isoc)
        {
            return this.area() - isoc.area();
        }
    }
}

