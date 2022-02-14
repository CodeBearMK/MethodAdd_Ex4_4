namespace MethodAdd_Ex4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AMath a = new AMath();
            BMath b = new BMath();
            int n1 = 20, n2 = 30;
            int[] numAry = { 10, 20, 30, 40, 50 };
            Console.WriteLine("{0}+{1}={2}", n1, n2, a.Add(n1, n2));
            Console.WriteLine("{0}+{1}+{2}+{3}+{4}={5}",
                               numAry[0], numAry[1], numAry[2], numAry[3], numAry[4], b.Add(numAry));
            Console.Read();
        }
    }
}