namespace SampleCSharp
{
    public class Kucing
    {
        private static int instances = 0;
        public Kucing()
        {
            instances++;
        }

        public static void BanyakKucing()
        {
            Console.WriteLine("Banyak Kucing : {0}", instances);
        }
    }

    public class Time
    {
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Date
        {
            get { return date; }
            set { date = value; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        // constructor
        public Time()
        {
            this.year = 2021;
            this.month = 2;
            this.date = 12;
            this.hour = 5;
            this.minute = 30;
            this.second = 12;
        }

        public Time(int year, int month, int date, int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public Time(DateTime dt)
        {
            year = dt.Year;
            month = dt.Month;
            date = dt.Day;
            hour = dt.Hour;
            minute = dt.Minute;
            second = dt.Second;
        }
    }
}
