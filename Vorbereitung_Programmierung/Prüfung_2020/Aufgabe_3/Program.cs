using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_3
{
    public enum NorthSouth { North, South };

    public enum EastWest { East, West };

    public class Base6Coordinate
    {
        public int LatitudeAbsolute { get; }

        public NorthSouth LatitudeDirection { get; }

        public int LatitudeMinutes { get; }

        public double LatitudeSeconds { get; }

        public int LongitudeAbsolute { get; }

        public EastWest LongitudeDirection { get; }

        public int LongitudeMinutes { get; }

        public double LongitudeSeconds { get; }

        public Base6Coordinate(int latitudeAbsolute, NorthSouth latitudeDirection, int latitudeMinutes, double latitudeSeconds,
                int longitudeAbsolute, EastWest longitudeDirection, int longitudeMinutes, double longitudeSeconds)
        {
            LatitudeAbsolute = latitudeAbsolute;
            LatitudeDirection = latitudeDirection;
            LatitudeMinutes = latitudeMinutes;
            LatitudeSeconds = latitudeSeconds;
            LongitudeAbsolute = longitudeAbsolute;
            LongitudeDirection = longitudeDirection;
            LongitudeMinutes = longitudeMinutes;
            LongitudeSeconds = longitudeSeconds;
        }

        public override string ToString()
        {
            string latDir = LatitudeDirection == NorthSouth.North ? "N" : "S";

            string longDir = LongitudeDirection == EastWest.East ? "E" : "W";
            return $" {LatitudeAbsolute}°{latDir}  {LatitudeMinutes}' {LatitudeSeconds:0.00000}'', {LongitudeAbsolute}°{longDir} {LongitudeMinutes}' {LongitudeSeconds:0.00000}'' ";

        }
    }

    public class DecimalCoordinate
    {
        public double Latitude { get; }

        public double Longitude { get; }

        public DecimalCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public static class Convert
    {
        public static Base6Coordinate ConvertToBase6(DecimalCoordinate coord)
        {
            NorthSouth latDir = NorthSouth.North;
            double Latitude = coord.Latitude;
            if (Latitude < 0)
            {
                latDir = NorthSouth.South;
                Latitude = Math.Abs(Latitude);
            }
            int latAbs = (int)Latitude;
            double latMinutesDouble = (Latitude - latAbs) * 60.0;
            int latMin = (int)latMinutesDouble;
            double latSec = (latMinutesDouble - latMin) * 60;

            double Longitude = coord.Longitude;
            EastWest longDir = EastWest.East;

            if (Longitude < 0)
            {
                longDir = EastWest.West;
                Longitude = Math.Abs(Longitude);
            }
            int longAbs = (int)Longitude;
            double longMinutesDouble = (Longitude - longAbs) * 60.0;
            int longMin = (int)longMinutesDouble;
            double longSec = (longMinutesDouble - longMin) * 60;
            return new Base6Coordinate(latAbs, latDir, latMin, latSec, longAbs, longDir, longMin, longSec);
        }

        public static DecimalCoordinate ConvertToDecimal(Base6Coordinate coord)
        {
            double lat = coord.LatitudeAbsolute;
            double lon = coord.LongitudeAbsolute;

            lat = lat + coord.LatitudeMinutes / 60d +coord.LatitudeSeconds/3600d;
            lon = lon + coord.LongitudeMinutes / 60d + coord.LongitudeSeconds / 3600d;

            if (coord.LatitudeDirection == NorthSouth.South)
            {
                lat = lat * (-1);
            }
            if (coord.LongitudeDirection == EastWest.West)
            {
                lon = lon * (-1);
            }

            return new DecimalCoordinate(lat, lon);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base6Coordinate base6Coordinate = new Base6Coordinate(49, NorthSouth.North, 12, 23.4828, 7, EastWest.East, 2, 46.266);

            DecimalCoordinate decimalCoordinate = Convert.ConvertToDecimal(base6Coordinate);

            Console.WriteLine(decimalCoordinate.Latitude);
            Console.WriteLine(decimalCoordinate.Longitude);

            Console.ReadLine();
        }
    }
}
