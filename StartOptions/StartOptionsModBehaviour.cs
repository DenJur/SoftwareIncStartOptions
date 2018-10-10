using System.Collections.Generic;

namespace StartOptions
{
    public class StartOptionsModBehaviour : ModBehaviour
    {

        public override void OnDeactivate()
        {
            DifficultyValues.DefaultStartMoney = new int[]
            {
                50000,
                10000,
                0
            };

            DifficultyValues.FanGainBonus = new float[]
            {
                0.25f,
                0.125f,
                0f
            };

            DifficultyValues.DesignDocumentSpeedBonus = new float[]
            {
                4f,
                2.5f,
                1f
            };

            DifficultyValues.EducationDrain = new float[]
            {
                0.002f,
                0.003f,
                0.004f
            };

            DifficultyValues.EmployeeSkillGainBonus = new float[]
            {
                2f,
                1.5f,
                1f
            };

            DifficultyValues.PressReleaseHypeDeadline = new float[]
            {
                32f,
                24f,
                16f
            };

            DifficultyValues.UnitSalesBonus = new float[]
            {
                2f,
                1.5f,
                1f
            };

            DifficultyValues.AICompanyAverageSavy = new float[]
            {
                0.75f,
                0.875f,
                1f
            };

            DifficultyValues.AlphaSpeedBonus = new float[]
            {
                1.1f,
                1.05f,
                1f
            };

            DifficultyValues.ProductReputationFactor = new float[]
            {
                0.02f,
                0.005f,
                0.001f
            };
         
            DifficultyValues.ProductUserbaseFactor = new float[]
            {
                0.5f,
                0.1f,
                0.05f
            };

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

            ActorCustomization.StartLoans = new[]
            {
                0,
                10000,
                40000,
                90000
            };
        }

        public override void OnActivate()
        {
            DifficultyValues.DefaultStartMoney = new int[]
            {
                100000000,
                200000,
                50000,
                10000,
                0,
                -50000
            };

            DifficultyValues.FanGainBonus = new float[]
            {
                1.0f,
                0.5f,
                0.25f,
                0.125f,
                0f,
                0f
            };

            DifficultyValues.DesignDocumentSpeedBonus = new float[]
            {
                10f,
                8f,
                4f,
                2.5f,
                1f,
                0.8f
            };

            DifficultyValues.EducationDrain = new float[]
            {
                0.0001f,
                0.001f,
                0.002f,
                0.003f,
                0.004f,
                0.005f
            };

            DifficultyValues.EmployeeSkillGainBonus = new float[]
            {
                10f,
                4f,
                2f,
                1.5f,
                1f,
                0.8f
            };

            DifficultyValues.PressReleaseHypeDeadline = new float[]
            {
                128f,
                64f,
                32f,
                24f,
                16f,
                8f
            };

            DifficultyValues.UnitSalesBonus = new float[]
            {
                10f,
                4f,
                2f,
                1.5f,
                1f,
                0.8f
            };

            DifficultyValues.AICompanyAverageSavy = new float[]
            {
                0.3f,
                0.6f,
                0.75f,
                0.875f,
                1f,
                1.1f
            };

            DifficultyValues.AlphaSpeedBonus = new float[]
            {
                2f,
                1.2f,
                1.1f,
                1.05f,
                1f,
                0.95f
            };

            DifficultyValues.ProductReputationFactor = new float[]
            {
                0.1f,
                0.05f,
                0.02f,
                0.005f,
                0.001f,
                0.0005f
            };

            DifficultyValues.ProductUserbaseFactor = new float[]
            {
                10f,
                1.0f,
                0.5f,
                0.1f,
                0.05f,
                0.01f
            };

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
                "Impossible"
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

            List<int> loans = new List<int>();
            for (int i = 0; i <= 200; i += 2) loans.Add((int) (i * LoanWindow.factor));

            ActorCustomization.StartLoans = loans.ToArray();
        }
    }
}