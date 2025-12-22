/*4. Extend or Create a UnitConvertor utility class similar to the one shown in the notes to
do the following. Please define static methods for all the UnitConvertor class methods. E.g.
public static double ConvertKmToMiles(double km) =>
a. Method To convert kilometers to miles and return the value. Use the following
code double km2miles = 0.621371;
b. Method to convert miles to kilometers and return the value. Use the following
code double miles2km = 1.60934;
c. Method to convert meters to feet and return the value. Use the following code
to convert double meters2feet = 3.28084;
d. Method to convert feet to meters and return the value. Use the following code
to convert double feet2meters = 0.3048;*/using System;internal static class UnitConverter{    private const double KmToMilesFactor = 0.621371;    private const double MilesToKmFactor = 1.60934;    private const double MetersToFeetFactor = 3.28084;    private const double FeetToMetersFactor = 0.3048;      public static double ConvertKmToMiles(double km)    {        return km * KmToMilesFactor;    }    public static double ConvertMilesToKm(double miles)    {        return miles * MilesToKmFactor;    }    public static double ConvertMetersToFeet(double meters)    {        return meters * MetersToFeetFactor;    }    public static double ConvertFeetToMeters(double feet)    {        return feet * FeetToMetersFactor;    }}