namespace CSharpGames.Models;

public class AstroDroid : ITestable
{
    public string Name { get; set; } = "R2 Unit";
    public int BatteryLevel { get; set; } = 85;

    public string RunDiagnostics()
    {
        return $"[ASTRO] Beep boop! Nav computers calibrated with {BatteryLevel}% power.";
    }
}

public class MedicalDroid : ITestable
{
    public string Name { get; set; } = "2-1B";
    public int BatteryLevel { get; set; } = 98;

    public string RunDiagnostics()
    {
        return $"[MEDIC] Systems operational. Bacta tanks full. Battery at {BatteryLevel}%.";
    }
}

public class TacticalDroid : ITestable
{
    public string Name { get; set; } = "TX-20";
    public int BatteryLevel { get; set; } = 42;

    public string RunDiagnostics()
    {
        return $"[TACTICAL] ANALYSIS COMPLETE. PROBABILITY OF VICTORY: LOW. BATTERY CRITICAL: {BatteryLevel}%.";
    }
}
