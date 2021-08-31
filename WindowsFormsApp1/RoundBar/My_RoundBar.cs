using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundBar
{
    public  class My_RoundBar
    {
        /// <summary>
        /// 屬性 半徑
        /// </summary>
        private double radius;
        private double length1;
        private double length2;
        private double length3;
        public double Round
        {
            get {return this.radius; }
            set { this.radius = value; }
        }
        public double Length1
        {
            get { return this.length1; }
            set { this.length1 = value; }
        }
        public double Length2
        {
            get { return this.length2; }
            set { this.length2 = value; }
        }
        public double Length3
        {
            get { return this.length3; }
            set { this.length3 = value; }
        }
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="r"></param>
        public My_RoundBar(double r,double l1,double l2,double l3)
        {
            this.radius = r;
            this.length1 = l1;
            this.length2 = l2;
            this.length3 = l3;

        }
        public My_RoundBar(double r,double l2, double l3)
        {
            this.radius = r;
            this.length2 = l2;
            this.length3 = l3;

        }
        public double Calculation_ThreeSides_RoundBar()
        {

            //return Math.Round( (((length1 - (radius * 2)) + (length2 - (radius * 2) - (radius * 2)) + (length3 - (radius * 2))) + ((2 * 3.1415926 * (radius + (radius / 2))) / 2)),2);
            //return Math.Round((length1 - (radius * 2)) + (length2 - (radius * 2) - (radius * 2)) + (length3 - (radius * 2)));
            return Math.Round(((length1 - (radius * 2)) + (length2 - (radius * 2) - (radius * 2)) + (length3 - (radius * 2)))+(3.1415926 * (radius + (radius / 2))),2);
        }
        public double Calculation_TwoSides_RoundBar()
        {
            return Math.Round(((length2 - (radius * 2)) + (length3 - (radius * 2))) + ((2 * 3.1415926 * (radius + radius / 2)) / 4),2);
        }


    }
}
