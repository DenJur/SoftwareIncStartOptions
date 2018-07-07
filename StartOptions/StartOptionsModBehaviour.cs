using System.Collections.Generic;
using System.Reflection;
using Harmony;

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

            Employee.EducationDrain = new[]
            {
                0.002f,
                0.003f,
                0.004f
            };
        }

        public override void OnActivate()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("dnajur.startingoptions");
            harmony.PatchAll(Assembly.GetExecutingAssembly());

            List<int> dates = new List<int>();
            for (int i = 1970; i <= 2030; i += 5) dates.Add(i);

            ActorCustomization.StartYears = dates.ToArray();

            GameData.DifficultySettings = new[]
            {
                "Sandbox",
                "Super Easy",
                "Easy",
                "Medium",
                "Hard",
                "Super Hard"
            };

            SoftwareProduct.DifficultyRepFactor = new[]
            {
                0.1f,
                0.05f,
                0.02f,
                0.005f,
                0.001f,
                0.0005f
            };

            SoftwareProduct.DifficultyUserFactor = new[]
            {
                1.0f,
                0.7f,
                0.5f,
                0.1f,
                0.05f,
                0.02f
            };

            SoftwareAlpha.DifficultySpeed = new[]
            {
                1.5f,
                1.2f,
                1.1f,
                1.05f,
                1f,
                0.9f
            };

            ActorCustomization.MaxPoints = new[]
            {
                5f,
                4f,
                2.5f,
                1.5f,
                1f,
                0.05f
            };

            ActorCustomization.DefaultStartMoney = new[]
            {
                10000000,
                100000,
                25000,
                10000,
                0,
                -50000
            };

            Employee.EducationDrain = new[]
            {
                0.0001f,
                0.001f,
                0.002f,
                0.003f,
                0.004f,
                0.005f
            };

            List<int> loans = new List<int>();
            for (int i = 0; i <= 200; i += 2) loans.Add((int) (i * LoanWindow.factor));

            ActorCustomization.StartLoans = loans.ToArray();
        }
    }
}