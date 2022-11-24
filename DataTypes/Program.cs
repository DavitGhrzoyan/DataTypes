using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 0;         //8-bit unsigned integer	0 to 255
            byte b2 = 255;
            Console.WriteLine(b1 + b2);

            sbyte sb1 = -128;    //8-bit signed integer	-128 to 127
            sbyte sb2 = 127;
            Console.WriteLine(sb1 * sb2);

            short sh1 = 10525;     //16-bit unsigned integer	0 to 65,535
            short sh2 = 100;
            Console.WriteLine(sh1 / sh2);

            int i1 = 10000000;   //32-bit signed integer	-2,147,483,648 to 2,147,483,647
            int i2 = 20000000;
            int i3 = i1 + i2;
            Console.WriteLine(i3);

            uint ui1 = 1000000000;    //32-bit unsigned integer	0 to 4,294,967,295
            uint ui2 = 2000000000;
            uint usum = ui1 + ui2;
            Console.WriteLine(usum);

            long lg = 9999999999999;  //64-bit unsigned integer	0 to 18,446,744,073,709,551,615
            Console.WriteLine(lg);

            float fl = 10.245f;       //32-bit Single-precision floating point type	-3.402823e38 to 3.402823e38
            Console.WriteLine(fl);

            double d = 1.000000000000000000d; //64-bit double-precision floating point type	-1.79769313486232e308 to 1.79769313486232e308
            Console.WriteLine(d);

            decimal dec = 100000000000000000000000m;  //128-bit decimal type financial and monetary calculations (+ or -)1.0 x 10e-28 to 7.9 x 10e28
            Console.WriteLine(dec);

            char ch = 'd';             //16-bit single Unicode character
            Console.WriteLine(ch);

            bool bo = true;          //8-bit logical true/false value
            Console.WriteLine(bo);

            //object //???

            string str = " I love C# ";  //Unicode character set 
            Console.WriteLine(str);

            DateTime aDate = DateTime.Now;                  //Represents date and time	0:00:00am 1/1/01 to 11:59:59pm 12/31/9999
            Console.WriteLine(aDate.ToString("MM/dd/yyyy"));  



























        }
    }
}
