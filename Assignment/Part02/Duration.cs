using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part02
{
    class Duration
    {

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        #region Constructors
        public Duration()
        {

        }

        public Duration(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }

        public Duration(int Seconds)
        {
            Hours = Seconds / 3600;
            Minutes = (Seconds % 3600) / 60;
            this.Seconds = ((Seconds % 3600) % 60);
        }

        #endregion

        #region Operators
        public static Duration operator +(Duration Left, Duration Right)
        {
            return new Duration
            {
                Hours = (Left?.Hours ?? 0) + (Right?.Hours ?? 0),
                Minutes = (Left?.Minutes ?? 0) + (Right?.Minutes ?? 0),
                Seconds = (Left?.Seconds ?? 0) + (Right?.Seconds ?? 0)

            };
        }

        public static Duration operator -(Duration Left, Duration Right)
        {
            return new Duration
            {
                Hours = (Left?.Hours ?? 0) - (Right?.Hours ?? 0),
                Minutes = (Left?.Minutes ?? 0) - (Right?.Minutes ?? 0),
                Seconds = (Left?.Seconds ?? 0) - (Right?.Seconds ?? 0)

            };
        }


        public static Duration operator +(Duration duration, int Seconds)
        {
            return new Duration
            {
                Hours = (duration?.Hours ?? 0) + Seconds / 3600,
                Minutes = (duration?.Minutes ?? 0) + ((Seconds % 3600) / 60),
                Seconds = (duration?.Seconds ?? 0) + ((Seconds % 3600) % 60)
            };
        }

        public static Duration operator +(int Seconds, Duration duration)
        {
            return new Duration
            {
                Hours = (duration?.Hours ?? 0) + Seconds / 3600,
                Minutes = (duration?.Minutes ?? 0) + ((Seconds % 3600) / 60),
                Seconds = (duration?.Seconds ?? 0) + ((Seconds % 3600) % 60)
            };
        }

        public static Duration operator ++(Duration duration)
        {
            return new Duration
            {
                Hours = (duration?.Hours ?? 0) + 1,
                Minutes = (duration?.Minutes ?? 0),
                Seconds = (duration?.Seconds ?? 0)
            };
        }

        public static Duration operator --(Duration duration)
        {
            return new Duration
            {
                Hours = (duration?.Hours ?? 0) - 1,
                Minutes = (duration?.Minutes ?? 0),
                Seconds = (duration?.Seconds ?? 0)
            };
        }

        public static bool operator >(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds > right?.Seconds;
                else
                    return left?.Minutes > right?.Minutes;
            }
            else
                return left?.Hours > right?.Hours;
        }

        public static bool operator <(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds < right?.Seconds;
                else
                    return left?.Minutes < right?.Minutes;
            }
            else
                return left?.Hours < right?.Hours;
        }

        public static bool operator >=(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds >= right?.Seconds;
                else
                    return left?.Minutes >= right?.Minutes;
            }
            else
                return left?.Hours >= right?.Hours;
        }

        public static bool operator <=(Duration left, Duration right)
        {
            if (left?.Hours == right?.Hours)
            {
                if (left?.Minutes == right?.Minutes)
                    return left?.Seconds <= right?.Seconds;
                else
                    return left?.Minutes <= right?.Minutes;
            }
            else
                return left?.Hours <= right?.Hours;
        }

        public static bool operator true (Duration duration)
        {
            if(duration != null)
            return true;
            else return false;
        }
        public static bool operator false(Duration duration)
        {
            return duration == null;
        }

        public static explicit operator DateTime (Duration duration)
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, duration.Hours,duration.Minutes,duration.Seconds);
        }

        #endregion

        #region System Override
        public override string ToString()
        {
            if (Hours == 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes == 0)
                return $"Hours: {Hours}, Seconds: {Seconds}";
            else if (Seconds == 0)
                return $"Hours: {Hours}, Minutes: {Minutes}";
            else
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";



        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        #endregion
    }
}
