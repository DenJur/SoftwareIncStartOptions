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

            GameData.DifficultySettings = new[]
            {
                "Easy",
                "Medium",
                "Hard"
            };

            ActorCustomization.MaxPoints = new[]
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

            ActorCustomization.StartLoans = new[]
            {
                0,
                10000,
                40000,
                90000
            };

            SoftwareProduct.DifficultyRepFactor = new[]
            {
                0.02f,
                0.005f,
                0.001f
            };

            SoftwareProduct.DifficultyUserFactor = new[]
            {
                0.5f,
                0.1f,
                0.05f
            };
        }

        public override void OnActivate()
        {
            List<int> dates = new List<int>();
            for (int i = 1970; i <= 2030; i += 5) dates.Add(i);

            ActorCustomization.StartYears = dates.ToArray();

            GameData.DifficultySettings = new[]
            {
                "Super Easy",
                "Easy",
                "Medium",
                "Hard",
                "Super Hard",
                "Sandbox"
            };

            SoftwareProduct.DifficultyRepFactor = new[]
            {
                0.05f,
                0.02f,
                0.005f,
                0.001f,
                0.0002f,
                0.05f
            };

            SoftwareProduct.DifficultyUserFactor = new[]
            {
                1.0f,
                0.5f,
                0.1f,
                0.05f,
                0.01f,
                1.0f
            };

            SoftwareAlpha.DifficultySpeed = new[]
            {
                1.2f,
                1.1f,
                1.05f,
                1f,
                0.9f,
                1.5f
            };

            ActorCustomization.MaxPoints = new[]
            {
                4f,
                2.5f,
                1.5f,
                1f,
                0.05f,
                5f
            };

            ActorCustomization.DefaultStartMoney = new[]
            {
                100000,
                25000,
                10000,
                0,
                -50000,
                10000000
            };

            List<int> loans = new List<int>();
            for (int i = 0; i <= 200; i += 2) loans.Add((int) (i * LoanWindow.factor));

            ActorCustomization.StartLoans = loans.ToArray();
        }
    }
}