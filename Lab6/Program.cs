using System;
using System.Text;

namespace Lab6
{
    internal class Program
    {
        //Hàm phương trình bậc 2:

        public delegate double DeltaDelegate(float a, float b, float c);

        public delegate double TongDelegate(float a, float b, float c);

        public delegate double HieuDelegate(float a, float b, float c);

        public delegate double Nghiem1Delegate(float a, float b);

        public delegate double Nhamnghiem1Delegate(float a, float c);

        public delegate double Nhamnghiem2Delegate(float a, float c);

        public delegate double Nghiemx1Delegate(float a, float b, float c);

        public delegate double Nghiemx2Delegate(float a, float b, float c);

        public static double Delta(float a, float b, float c)
        {
            return ((b * b) - 4 * (a * c));
        }

        public static double Tong(float a, float b, float c)
        {
            return (a + b + c);
        }

        public static double Hieu(float a, float b, float c)
        {
            return (a - b + c);
        }

        public static double Nghiem1(float a, float b)
        {
            return (-b / (2 * a));
        }

        public static double NhamNghiem1(float a, float c)
        {
            return (c / a);
        }

        public static double NhamNghiem2(float a, float c)
        {
            return (-c / a);
        }

        public static double Nghiemx1(float a, float b, float c)
        {
            var d = Delta(a, b, c);
            return (-b + Math.Sqrt(d)) / (2 * a);
        }

        public static double Nghiemx2(float a, float b, float c)
        {
            var d = Delta(a, b, c);
            return (-b - Math.Sqrt(d)) / (2 * a);
        }


        // public delegate void Increment(ref int X);
        //
        // public static void Add2(ref int x)
        // {
        //     x += 2;
        // }
        //
        // public static void Add3(ref int x)
        // {
        //     x += 3;
        // }
        //--------------------------------------------------------






        public static void Main(string[] args)
        {
            //Giải phương trình bậc 2:
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập giá trị của a : ");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập giá trị của b : ");
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập giá trị của c : ");
                var c = Convert.ToInt32(Console.ReadLine());
                DeltaDelegate deltaDelegate = Delta;
                var delta = deltaDelegate(a, b, c);
                if (delta == 0)
                {
                    Nghiem1Delegate nghiem1Delegate = Nghiem1;
                    var nghiem1 = nghiem1Delegate(a, b);
                    Console.WriteLine($"Phương trình có 2 nghiệm: x1 , x2 = {nghiem1}");
                }
                TongDelegate tongDelegate = Tong;
                var tong = tongDelegate(a, b, c); 
                if (tong == 0)
                {
                    Nhamnghiem1Delegate nhamnghiem1Delegate = NhamNghiem1;
                    var nhamnghiem1 = nhamnghiem1Delegate(a, c);
                    Console.WriteLine($"Phương trình có 2 nghiệm: x1 = 1, x2 = {nhamnghiem1}");
                    return;
                }
                HieuDelegate hieuDelegate = Hieu;
                var hieu = hieuDelegate(a, b, c);
                if (hieu == 0)
                {
                    Nhamnghiem2Delegate nhamnghiem2Delegate = NhamNghiem2;
                    var nhamnghiem2 = nhamnghiem2Delegate(a, c);
                    Console.WriteLine($"Phương trình có 2 nghiệm: x1 = -1, x2 = {nhamnghiem2}");
                }
                else if (delta > 0)
                {
                    Nghiemx1Delegate nghiemx1Delegate = Nghiemx1;
                    var nghiemx1 = nghiemx1Delegate(a, b, c);
                    Nghiemx2Delegate nghiemx2Delegate = Nghiemx2;
                    var nghiemx2 = nghiemx2Delegate(a, b, c);
                    Console.WriteLine($"Phương trình có 2 nghiệm: x1 = {nghiemx1}, x2 = {nghiemx2}");
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
        }




            // Increment functionDelegate = Add2;
            // functionDelegate += Add3;
            // functionDelegate += Add2;
            // int x = 5;
            // functionDelegate(ref x);
            // Console.WriteLine(x);

            //-------------------------------------------------------
            //
            // Thermostat thermostat = new Thermostat();
            // Heater heater = new Heater(60);
            // thermostat.OnTemperatureChange +=
            //     heater.OnTemperatureChanged;
            // Heater heaterCuong = new Heater(100);
            // thermostat.OnTemperatureChange += 
            //     heaterCuong.OnTemperatureChanged;
            //
            // Cooler cooler = new Cooler(80);
            // thermostat.OnTemperatureChange += 
            //     cooler.OnTemperatureChanged;
            //
            // string temperature;
            // Console.Write("Enter temperature: ");
            // temperature = Console.ReadLine();
            // thermostat.CurrentTemperature = int.Parse(temperature);
            // Console.ReadLine();
            //---------------------------------------------------------------



        }
    }


