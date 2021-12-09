using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronPlateFactor
{
    public class Coefficient
    {
        /// <summary>
        /// 厚度 屬性 欄位
        /// </summary>
        private double t;
        /// <summary>
        /// 溝數 屬性 欄位
        /// </summary>
        private int v;
        /// <summary>
        /// 角度 屬性 欄位
        /// </summary>
        private double a;

        public double T
        {
            get { return this.t; }
            set { this.t = value; }
        }
        public int V
        {
            get { return this.v; }
            set { this.v = value; }
        }
        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="t"></param>
        /// <param name="v"></param>
        /// <param name="a"></param>
        public Coefficient(double t, int v, double a)
        {
            this.t = t;
            this.v = v;
            this.a = a;
        }
        /// <summary>
        /// 取得一折 不同材質的字典變數
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double Get_CoefficientValue(string type)
        {
            double t = 1;
            var Dic = new Dictionary<string, double>();
            switch (type)
            {
                case "OT":
                    t = 1;
                    Dic = new Dictionary<string, double>()
                    {
                        { "1,10", 2 },
                        { "1.2,10", 2 },
                        { "2,16", 3.6 },
                        { "2.3,16", 4 },
                        { "3,25", 5.4 },
                        { "3.2,25", 5.8 },
                        { "4,32", 7 },
                        { "5,40", 9 },
                        { "6,50", 11 },
                        { "8,63", 15 },
                        { "9,70", 17 },
                        { "10,80", 19 },
                        { "12,100",23 },
                        { "16,120", 31 },
                    };
                    break;
                case "ST":
                    t = 0.75;
                    Dic = new Dictionary<string, double>()
                    {
                        { "1,10", 2 },
                        { "1.2,10", 2.4 },
                        { "1.5,12", 3 },
                        { "2,16", 4 },
                         { "2.5,20", 5 },
                        { "3,25", 6 },
                        { "4,32", 8 },
                        { "4.5,32",9 },
                        { "5,40", 10 },
                        { "6,50", 12 },
                        { "8,63", 16 },
                        { "9,70", 18 },
                        { "10,80", 20 },
                        { "12,100",24 },
                        { "15,120", 30 },
                    };
                    break;

                case "AL":
                    t = 1.25;
                    Dic = new Dictionary<string, double>()
                    {
                        { "2,12", 3.2 },
                        { "2.5,16", 4 },
                       { "3,16", 4.6 },
                    };
                    break;
            }

            var key = $"{T},{V}";
            if (Dic.ContainsKey(key))
            {
                return A == 90 ? Dic[key] : Math.Round(((Math.Abs(Dic[key]) / 2) / Math.Tan(((A / 180) * Math.PI) / 2) * 2), 2);
            }
            else
            {
                return Math.Round(((Math.Abs(((T * T) / (0.5 * V) * t) - (2 * T)) / 2) / Math.Tan(((A / 180) * Math.PI) / 2) * 2), 2);
            }

        }
        /// <summary>
        /// 取得一半 不同材質的字典變數
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public double Get_HelfCoefficient(string type)
        {
            double t = 1;
            var Dic = new Dictionary<string, double>();
            switch (type)
            {
                case "OT":
                    t = 1;
                    Dic = new Dictionary<string, double>()
                    {
                        { "1,10", 2 },
                        { "1.2,10", 2 },
                        { "2,16", 3.6 },
                        { "2.3,16", 4 },
                        { "3,25", 5.4 },
                        { "3.2,25", 5.8 },
                        { "4,32", 7 },
                        { "5,40", 9 },
                        { "6,50", 11 },
                        { "8,63", 15 },
                        { "9,70", 17 },
                        { "10,80", 19 },
                        { "12,100",23 },
                        { "16,120",31 },
                    };
                    break;
                case "ST":
                    t = 0.75;
                    Dic = new Dictionary<string, double>()
                    {
                        { "1,10", 2 },
                        { "1.2,10", 2.4 },
                        { "1.5,12", 3 },
                        { "2,16", 4 },
                        { "2.5,20", 5 },
                        { "3,25", 6 },
                        { "4,32", 8 },
                        { "5,40", 10 },
                        { "6,50", 12 },
                        { "8,63", 16 },
                        { "9,70", 18 },
                        { "10,80",20 },
                        { "12,100",24 },
                        { "15,120",30 },
                    };
                    break;

                case "AL":
                    t = 1.25;
                    Dic = new Dictionary<string, double>()
                    {
                        { "2,12", 3.2 },
                        { "2.5,16", 4 },
                       { "3,16", 4.6 },
                    };
                    break;
            }

            var key = $"{T},{V}";
            if (Dic.ContainsKey(key))
            {
                return A == 90 ? Dic[key]/2 : Math.Round((Math.Abs(Dic[key]) / 2) / Math.Tan(((A / 180) * Math.PI) / 2), 2);
            }
            else
            {
                return Math.Round((Math.Abs(((T * T) / (0.5 * V) * t) - (2 * T)) / 2) / Math.Tan(((A / 180) * Math.PI) / 2), 2);
            }


        }
    }
}
