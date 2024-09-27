
namespace Wordchain.Lib
{
    public static class Checker
    {
        public static bool Check(string wort)
        {

            List<string> woerter = new List<string>();
            woerter.Add("dumm");
            woerter.Add("faul");
            woerter.Add("gemein");
            woerter.Add("blöd");

            if(woerter.Contains(wort))
            {
                return false;
            }


            return true;
        }
    }
}
