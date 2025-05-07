using System.Text;

namespace Demos_Assinments
{
    internal class Program
    {
        #region Funcition PrintShap
        public static void printShap(String Patttern, int count = 10)
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine(Patttern);
            }
        }
        #endregion

        #region Funcition Value Type Parameters
        public static void Swap(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        #endregion

        #region Funcition Parameters Referance
        public static int SumArray(int[] NumArr)
        {
            int sum = 0;
            NumArr[0] = 100;
            for (int i = 0; i < NumArr.Length; i++)
            {
                sum += NumArr[i];
            }
            return sum;
        }
        #endregion

        #region Funcition Out
        public static void DivMin(int x, int y, out int Div, out int Min)
        {
            Div = x / y;
            Min = x - y;
        }
        #endregion

        #region Funcition Params
        public static int SumArr1(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        #endregion



        static void Main(string[] args)
        {
            #region Imaplicit Casting
            int x = 12121;
            long y = x;
            Console.WriteLine(y);
            #endregion

            #region Explict Casting
            double a = 10.5;
            int b = (int)a;
            Console.WriteLine(b);
            #endregion

            #region Parse Casting
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Age is " + age);
            #endregion

            #region Convert
            double Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your Salary is " + Salary);
            #endregion

            #region Ternary Operator
            int My_age = int.Parse(Console.ReadLine());
            string Ternary = My_age > 18 ? "You Can get ID Card" : "You Can Not get ID Card";
            Console.WriteLine(Ternary);
            #endregion

            #region Composit Format
            int z = 5;
            int q = 5;
            int s = 10;
            Console.WriteLine("Equation = {0} + {1} = {2}", z, q, s);
            #endregion

            #region Interpolation Format
            Console.WriteLine($"Equation = {z} + {q} = {s}");
            #endregion

            Console.WriteLine("**********************************");
            #region if else
            Console.WriteLine("Enter Your Grade");
            Double Degree = Double.Parse(Console.ReadLine());
            if (Degree <= 100 && Degree >= 89)

                Console.WriteLine("Your Grade is A");

            else if (Degree <= 88 && Degree >= 76)

                Console.WriteLine("Your Grade is B");

            else if (Degree <= 75 && Degree >= 67)

                Console.WriteLine("Your Grade is C");

            else if (Degree <= 66 && Degree >= 60)

                Console.WriteLine("Your Grade is D");
            else if (Degree <= 59 && Degree >= 0)

                Console.WriteLine("Your Grade is F");
            else if (Degree > 100 || Degree < 0)
                Console.WriteLine("Error");
            #endregion

            #region Switch
            Console.WriteLine("Enter The Your Name");
            String Name = (Console.ReadLine());
            switch (Name)
            {
                case "Mostafa":
                    Console.WriteLine("Hello Mostafa");
                    break;
                case "Ali":
                    Console.WriteLine("Hello Ali");
                    break;
                case "Ahmed":
                    Console.WriteLine("Hello Ahmed");
                    break;
                default:
                    Console.WriteLine("Hello My Clint");
                    break;

            }
            #endregion

            #region GoTo
            Console.WriteLine("Enter Your Team");
            String Team = Console.ReadLine();
            switch (Team)
            {
                case "Real Madrid":
                    Console.Write(" Chamions League,");
                    goto case "Barcelona";
                    break;
                case "Barcelona":
                    Console.Write(" Super Cup,");
                    goto case "Atlitico Madrid";
                    break;
                case "Atlitico Madrid":
                    Console.Write(" LaLiga.");
                    break;
                default:
                    Console.WriteLine("Erorr");
                    break;
            }
            #endregion
            Console.WriteLine("**********************************");

            #region For Loop
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            Console.WriteLine("**********************************");

            #region For Each
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in Numbers)
            {
                Console.WriteLine(i + 10);
            }
            #endregion
            Console.WriteLine("**********************************");

            #region Breake and Continue
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    break;
                }
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("*****************************************");
            //Continue
            int[] MyArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < MyArr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    continue;
                }
                Console.WriteLine(arr[i]);
            }
            #endregion
            Console.WriteLine("**********************************");

            #region Do While , TryParse
            int n;
            do
            {
                Console.WriteLine("Enter Even Number");
                bool Flag;
                Flag = int.TryParse(Console.ReadLine(), out n);
            }
            while (n % 2 == 1);
            Console.WriteLine($"{n} is Even Number");
            #endregion
            Console.WriteLine("**********************************");

            #region String Builder
            StringBuilder Fname;
            Fname = new StringBuilder("Mostafa");
            //Fname.Append(" Hamed");
            //Console.WriteLine(Fname);
            Fname.AppendLine(" Hamed");
            Console.WriteLine(Fname);
            Fname.Remove(0, 1);
            Console.WriteLine(Fname);
            Fname.Insert(0, "M");
            Console.WriteLine(Fname);
            #endregion
            Console.WriteLine("**********************************");

            #region ِArray 1D
            int[] My_Numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < My_Numbers.Length; i++)
            {
                My_Numbers[i] = i + 1;
                Console.WriteLine(My_Numbers[i]);
            }
            Console.Write("Rank of Array is ");
            Console.WriteLine(My_Numbers.Rank);
            #endregion
            Console.WriteLine("**********************************");

            #region ِArray 2D Rectangle
            int[,] Marks = new int[3, 5];
            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                Console.WriteLine($"Enter Mark of Subject {i + 1}");

                for (int j = 0; j < Marks.GetLength(1);)
                {
                    bool Flag;
                    Flag = int.TryParse(Console.ReadLine(), out Marks[i, j]);
                    if (Flag && Marks[i, j] >= 0)
                    {
                        ++j;
                    }
                }
            }
            #endregion
            Console.WriteLine("**********************************");

            #region Casting [Boxing - UnBoxing]
            #region Boxing Safe Casting
            int p = 10;
            object c = new object();
            c = p;
            Console.WriteLine(c);
            #region UnBoxing UnSafe Casting
            object l = new object();
            int v = (int)l;
            #endregion
            #endregion
            #endregion
            Console.WriteLine("**********************************");

            #region Null
            //int h = null;
            int? h = null;
            int x5 = 10;
            int? y5 = x5;

            int? x6 = 10;
            //int y6 = x6; 
            int y6 = (int)x6;


            int? x7 = 10;
            if (x7.HasValue)
            {
                int y7 = x7.Value;
            }
            else
            {
                int y7 = 0;
            }
            int? x3 = 10;
            int y4 = x3.HasValue ? x3.Value : 0;

            int[] Numb = null;
            if (Numb != null)
            {
                for (int i = 0; i < Numb.Length; i++)
                {
                    Console.WriteLine(Numb[i]);
                }
            }
            else
            {
                Console.WriteLine("Is Null");
            }
            #endregion
            Console.WriteLine("**********************************");

            #region Funcition PrintShape
            printShap("++", 10);

            #endregion
            Console.WriteLine("**********************************");

            #region Funcition Value Type Parameters
            int A = 10;
            int B = 20;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Swap(ref A, ref B);
            Console.WriteLine(A);
            Console.WriteLine(B);
            #endregion
            Console.WriteLine("**********************************");

            #region Funcition Parameters Referance
            int[] NumberArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine(SumArray(NumberArr));
            #endregion
            Console.WriteLine("**********************************");

            #region Funcition Out
            int a_out = 10;
            int b_out = 5;
            int Div;
            int Min;
            DivMin(a_out, b_out, out Div, out Min);
            Console.WriteLine(Div);
            Console.WriteLine(Min);
            #endregion
            Console.WriteLine("**********************************");

            #region Funcition Params
            int[] Par_Num = { 1, 2, 3 };
            Console.WriteLine(SumArr1(Par_Num));
            #endregion
        }
    }
}

