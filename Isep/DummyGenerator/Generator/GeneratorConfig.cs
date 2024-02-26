using Humanizer;
using Isep.Model.Dwh;
using NUnit.Framework.Constraints;

namespace DummyGenerator.Generator
{
    public static class GeneratorConfig
    {
        public static int DummyRecordAmount = 100;
        public static int YearInPast = 5;

        public static int MenInChiefPercent = 75;
        public static int[] DegreesRatio = new[] { 2, 1, 24, 11, 63 };
        private static int[] gr = new[] { 77, 23 };
        private static int genderRepetition = 0;
        public static int[] GenderRatio
        {
            get
            {
                //if (genderRepetition <= 30)
                //{
                //    genderRepetition++;
                //    return gr;
                //}
                Random rnd = new Random();
                var i = rnd.Next(0, 100);
                gr = new[] { 100 - i, i };
                return gr;
            }
        }

        public static string[] titulPred = new[] { "bc", "Mgr", "Ing", "Mga" };
        public static string[] titulZa = new[] { "MSc", "LL.M", "Phd", "Mba", string.Empty };
        public static string[] mena = new[] { "CZK", "EUR", "USD" };
        public static string[] pohlavi = new[] { "Muz", "Zena" };

        private static int generatedRecords = 0;
        private static DateTime date = DateTime.UtcNow.AddYears(-YearInPast);
        private static void ResetDate()
        {
            date = date.AddYears(-YearInPast);
        }
        public static DateTime GetDate
        {
            get
            {
                if ((DummyRecordAmount / 5) < generatedRecords)
                {
                    generatedRecords++;
                    return date;
                }

                generatedRecords = 0;
                date = date.AddYears(1);
                return date;
            }
        }

        public static char ManagerRole = 'H';
        public static List<char> Roles = new List<char>
            {
                'A', 'K', 'S'
            };
    }
}
