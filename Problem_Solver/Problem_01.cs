namespace Project_Euler.Problem_Solver
{
    class Problem_01
    {
        public int Multiples(int to, params int[] numbers)
        {
            int result = 0;
            for(int i = 0; i < to; i++)
            {
                foreach(int number in numbers)
                {
                    if(i % number == 0)
                    {
                        result += i;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
