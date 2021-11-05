namespace SalesCart.Utilities
{
    public static class CommonUtilities
    {
        public static bool IsAddAnotherProduct()
        {
            Console.WriteLine("Do you want to add another Product?(Y/N)");

            var input = Console.ReadLine().ToUpperInvariant();
            while (!(input == "Y" || input == "N"))
            {
                Console.WriteLine("Invalid input. Enter (Y/N)");
            }

            bool addAnotherProduct = ParseBooleanInput(Convert.ToChar(input));
            return addAnotherProduct;
        }
        private static bool ParseBooleanInput(char value)
        {
            bool flag = true;
            bool boolValue = false;

            while (flag)
            {
                if (value == 'Y' || value == 'y')
                {
                    boolValue = true;
                    flag = false;
                }

                else if (value == 'N' || value == 'n')
                {
                    boolValue = false;
                    flag = false;
                }
                else
                {

                }

            }

            return boolValue;
        }
    }
}
