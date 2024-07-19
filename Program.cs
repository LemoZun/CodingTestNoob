namespace CodingTestNoob
{
    internal class Program
    {
        static int Solution1(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }
        static int Solution2(int num1, int num2)
        {
            int answer = num1 - num2;
            return answer;
        }
        static int Solution3(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }
        static int Solution4(int num1, int num2)
        {
            int answer = num1 / num2;
            return answer;
        }
        static decimal Solution5(int num1, int num2)
        {
            return (int)((float)num1 / num2 * 1000);
            //return 1000*num1/num2;
        }
        static int Solution(int num1, int num2)
        {
            int answer;
            if (num1 == num2) return answer = 1;
            else return answer = -1;            
        }


        static void Main(string[] args)
        {
            
        }
    }
}
