using System;

static class PhysicInfo
{
	// Удельная теплоёмкость воды (Дж / (кг * K))
	public const double SpecificHeatWater = 4184.0;

	// Масса 1 литра воды в кг
	public const double MassOfOneLiterWaterKg = 1.0;

	// Перевод электронвольт -> джоуль
	public const double ElectronVoltJ = 1.602176634e-19;

	// Мегаэлектронвольт в джоулях
	public const double MeVtoJ = 1e6 * ElectronVoltJ;

	// Энергия реакции дейтерий-тритий в МэВ (примерно)
	public const double EnergyPerReaction_D_T_MeV = 17.6;

	// Энергия реакции D-T в джоулях
	public static double EnergyPerReaction_D_T_J => EnergyPerReaction_D_T_MeV * MeVtoJ;

	// Необходимая теплота для нагрева массы massKg с tInitialC до tFinalC
	public static double RequiredEnergyJ(double massKg, double tInitialC, double tFinalC)
		=> massKg * SpecificHeatWater * (tFinalC - tInitialC);

	// Число реакций, необходимое для обеспечения энергии Q
	public static double ReactionsRequired(double massKg, double tInitialC, double tFinalC, double energyPerReactionJ)
		=> RequiredEnergyJ(massKg, tInitialC, tFinalC) / energyPerReactionJ;
}

class Program
{
	static void Main()
	{
		// Параметры
		double massKg = PhysicInfo.MassOfOneLiterWaterKg; // 1 литр воды
		double tInitial = 20.0; // °C
		double tFinal = 100.0; // °C

		// Расчёты
		double requiredEnergy = PhysicInfo.RequiredEnergyJ(massKg, tInitial, tFinal);
		double energyPerReaction = PhysicInfo.EnergyPerReaction_D_T_J;
		double reactions = PhysicInfo.ReactionsRequired(massKg, tInitial, tFinal, energyPerReaction);

		// Вывод
		Console.WriteLine($"Необходимая энергия для нагрева {massKg} кг воды с {tInitial}°C до {tFinal}°C: {requiredEnergy} Дж.");
		Console.WriteLine($"Энергия одной D-T реакции: {energyPerReaction:E3} Дж ({PhysicInfo.EnergyPerReaction_D_T_MeV} MeV).");
		Console.WriteLine($"Требуемое число реакций: {reactions:E3} (~{Math.Ceiling(reactions):N0} реакций).");
	}
}
