namespace Pr8
{
    class SumOfSquares
    {
        private int First;
        private int Second;

        public SumOfSquares(int first, int second)
        {
            this.Second = second;
            this.First = first;
        }

        public static bool operator >(SumOfSquares first, SumOfSquares second)
        {
            int sumOfSquares1 = first.First * first.First
                + first.Second * first.Second;

            int sumOfSquares2 = second.First * second.First
                + second.Second * second.Second;

            return (sumOfSquares1 > sumOfSquares2) ? true : false;
        }
        public static bool operator <(SumOfSquares first, SumOfSquares second)
        {
            int sumOfSquares1 = first.First * first.First
                + first.Second * first.Second;

            int sumOfSquares2 = second.First * second.First
                + second.Second * second.Second;

            return (sumOfSquares1 < sumOfSquares2) ? true : false;
        }
        
    }
}
