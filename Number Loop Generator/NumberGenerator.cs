namespace Number_Loop_Generator
{
    internal class NumberGenerator
    {
        private int min;
        private int max;
        private int current;

        public NumberGenerator(int min, int max)
        {
            this.min = min;
            this.max = max;
            this.current = min;
        }
        public int GetNumber()
        {
            int number = current;
            current = (current + 1) % (max + 1); // 循環取得數字
            return number;
        }
    }
}