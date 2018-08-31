namespace Factorialize
{
    public static class Factor
    {
        public static int FactorNum(int num)
        {
            return num < 0 ? -1 :
                   num == 0 ? 1 : 
                   num * FactorNum(num - 1);
        }
    }
}
