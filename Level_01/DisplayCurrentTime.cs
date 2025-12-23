/*1. Problem 1: Time Zones and DateTimeOffset
Write a program that displays the current time in different time zones:
 GMT (Greenwich Mean Time)
 IST (Indian Standard Time)
 PST (Pacific Standard Time)
Hint: Use DateTimeOffset and TimeZoneInfo to work with different time zones*/

using System;
internal class DisplayCurrentTime
{
 

    internal static void Main()
    {
        // Get the current UTC time
        DateTimeOffset utcNow = DateTimeOffset.UtcNow;
        // Define the time zones
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        // Convert UTC time to different time zones
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcNow, gmtZone);
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcNow, istZone);
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcNow, pstZone);
        // Display the current time in different time zones
        Console.WriteLine("Current Time in Different Time Zones:");
        Console.WriteLine($"GMT: {gmtTime}");
        Console.WriteLine($"IST: {istTime}");
        Console.WriteLine($"PST: {pstTime}");
    }
}
