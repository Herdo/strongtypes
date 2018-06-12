namespace Herdo.StrongTypes.DotNetStandard.StrongTypes
{
    public partial struct Year
    {
        private static bool IsValid(short value, out string validationError)
        {
            if (value < 1 || value > 9999)
            {
                validationError = "Value must be greater than 0 and less than 10000.";
                return false;
            }

            validationError = null;
            return true;
        }
    }
}