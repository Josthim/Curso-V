using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Imp
    {
        double[] Ing = new double[10];
        double[] Il = new double[10];
        double[] Ip = new double[10];
        //double Ing[10];
        //double Il[10];
        //double Ip[10];

        public Imp() { }
        public Imp(double[] ing, double[] il, double[] ip)
        {

            Ing = ing;
            Il = il;
            Ip = ip;
        }
        public void setIng(double[] ing)
        {
            this.Ing = ing;
        }
        public int Validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.WriteLine(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception error)
                {
                    v = 0;
                    Console.WriteLine("NO SE ACEPTAN LETRAS", error.Message);
                }
            } while (v == 0);
            return num;
        }

    }
}
