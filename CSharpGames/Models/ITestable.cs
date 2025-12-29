namespace CSharpGames.Models;

public interface ITestable
{
    string RunDiagnostics();
    int BatteryLevel { get; }
}
