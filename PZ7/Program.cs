namespace PZ7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task #2


            // Task #3
            Administrator administrator = new Administrator("Tomas");
            Site site = new Site(0.99);
            site.AddObserver(administrator);
            for (int i = 0; i < 1000; i++)
            {
                site.DoSite();
            }
        }
    }
}

