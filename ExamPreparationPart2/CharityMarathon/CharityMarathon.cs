namespace CharityMarathon
{
    using System;
    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonInDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());

            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var maximumRunners = trackCapacity * marathonInDays;
            var totalRunners = Math.Min(numberOfRunners, maximumRunners);

            var totalMeters = (long)totalRunners * (long)trackLength * (long)averageLaps;
            var totalKilometers = totalMeters / 1000;
            var money = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {money:F2}");

        }
    }
}
