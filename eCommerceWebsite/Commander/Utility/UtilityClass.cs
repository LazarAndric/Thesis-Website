namespace Commander.Utility
{
    public static class UtilityClass
    {
        public static bool Check<T>(T forCheck)
        {
            if(forCheck==null)
                return true;
            return false;
        }
    }
}