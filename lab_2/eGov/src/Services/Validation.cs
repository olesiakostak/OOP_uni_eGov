namespace eGov.Services
{
    public static class Vadidator
    {
        public static bool IfValidAge(int age)
        {
            if (age >= 0 && age <= 130) return true;
            else return false;
        }

        public static bool IfValidName(string name)
        {
            if (name.Length > 0 && name.Length <= 100) return true;
            else return false;
        }
    }
}