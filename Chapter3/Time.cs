namespace SampleCSharp
{
    public class Time
    {
        private int Year;
        private int Month;
        private int Date;
        private int Hour;
        private int Minute;
        private int Second;

        // constructor
        public Time()
        {
            Year = 2019;
            Month = 1;
            Date = 1;
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public Time(int year, int month, int date, int hour, int minute, int second)
        {
            Year = year;
            Month = month;
            Date = date;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public Time(DateTime dt)
        {
            Year = dt.Year;
            Month = dt.Month;
            Date = dt.Day;
            Hour = dt.Hour;
            Minute = dt.Minute;
            Second = dt.Second;
        }
    }
}
