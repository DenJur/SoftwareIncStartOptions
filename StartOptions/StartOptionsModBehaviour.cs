using System.Collections.Generic;

namespace StartOptions
{
    public class StartOptionsModBehaviour : ModBehaviour
    {

        public override void OnDeactivate()
        {
            ActorCustomization.StartYears = new[]
            {
                1980,
                1990,
                2000,
                2010
            };

            GameData.DifficultySettings = new string[]
            {
                "Easy",
                "Medium",
                "Hard"
            };

            ActorCustomization.MaxPoints = new float[]
            {
                2.5f,
                1.5f,
                1f
            };

            ActorCustomization.DefaultStartMoney = new[]
            {
                25000,
                10000,
                0
            };

            ActorCustomization.StartLoans = new int[]
            {
                0,
                10000,
                40000,
                90000
            };
        }

        public override void OnActivate()
        {
            List<int> dates = new List<int>();
            for (int i = 1970; i <= 2030; i+=5)
            {
                dates.Add(i);
            }

            ActorCustomization.StartYears = dates.ToArray();

            GameData.DifficultySettings = new []
            {
                "Super Easy",
                "Easy",
                "Medium",
                "Hard",
                "Super Hard",
            };

            ActorCustomization.MaxPoints = new []
            {
                4f,
                2.5f,
                1.5f,
                1f,
                0.05f
            };

            ActorCustomization.DefaultStartMoney = new[]
            {
                100000,
                25000,
                10000,
                0,
                -50000
            };

            List<int> loans = new List<int>();
            for (int i = 0; i <= 200; i+=2)
            {
                loans.Add((int) (i*LoanWindow.factor));
            }

            ActorCustomization.StartLoans = loans.ToArray();
        }
    }
}