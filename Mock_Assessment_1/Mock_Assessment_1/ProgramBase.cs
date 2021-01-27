namespace Mock_Assessment_1
{
    internal class ProgramBase
    {

        public static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return num1 == num2;
            }
            else if (!(num1 == num2))
            {
                return (!(num1 == num2));
            }

            return true;
        }
    }
}