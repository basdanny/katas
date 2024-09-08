using System;
using System.Diagnostics;

namespace Katas;

/// <summary>
/// Custom TraceListener to set console logs to be red. Used for failed assertions.
/// </summary>
public class CustomConsoleTraceListener : TraceListener
{
    public override void Write(string message)
    {
        // Change text color to red
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(message);
        Console.ResetColor(); // Reset to default color
    }

    public override void WriteLine(string message)
    {
        // Change text color to red
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor(); // Reset to default color
    }
}
