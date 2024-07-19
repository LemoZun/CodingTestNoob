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
        static int aolution(int num1, int num2)
        {
            int answer;
            if (num1 == num2) return answer = 1;
            else return answer = -1;
        }
        /*
        static int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int min = gcd(denom1, denom2);
            int max = (denom1 * denom2) / min;

            int[] answer = new int[2];
            if(denom1 != max)
            {
                denom1 = max;
                numer1 = numer1 * (max / denom1);
            }
            if (denom2 != max)
            {
                denom2 = max;
                numer2 = numer2 * (max/denom2);
            }
            answer = [ min * (numer1 + numer2),max];
            //{numer1 * denom2 + numer2 * denom1, denom1 * denom2};

            static int gcd(int x, int y)
            {
                return (x % y == 0 ? y : gcd(y, x % y));
            }


            return answer;
        }
        */


        public class Solution
        {
            public int[] solution(int numer1, int denom1, int numer2, int denom2)
            {
                
                int max = gcd(denom1, denom2);
                int min = (denom1 * denom2) / max;

                
                if (denom1 != min)
                {
                    denom1 = min;
                    numer1 = numer1 * (min / denom1);
                }

                if (denom2 != min)
                {
                    denom2 = min;
                    numer2 = numer2 * (min / denom2);
                }
                int[] answer = new int[2] { numer1 + numer2, max };
                //{numer1 * denom2 + numer2 * denom1, denom1 * denom2};

                return answer;


            }
            public int gcd(int num1, int num2)
            {
                if(num1 % num2 == 0)
                {
                    return num2;
                }
                else
                {
                    return gcd(num2, num1 % num2);
                }
            }
        }


        static void Main(string[] args)
        {


            Solution solution = new Solution();
            int[] answer = new int[2];
            answer = solution.solution(9, 2, 1, 3);

            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);
        }
    }
}
