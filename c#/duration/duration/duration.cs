using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace duration
{
    internal class duration
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }
        public duration(int _hour, int _minute, int _second)
        {
            this.hour = _hour;
            this.minute = _minute;
            this.second = _second;  
        }
        public duration(int totalSeconds)
        {
            hour = totalSeconds / 3600;
            minute = (totalSeconds % 3600) / 60;
            second = totalSeconds % 60;
        }
        public override string ToString()
        {
            return $"hours: {hour}, minutes: {minute}, second: {second}";
        }

        public override bool Equals(object obj)
        {
            if (obj is duration other)
            {
                return hour == other.hour && minute == other.minute && second == other.second;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(hour, minute, second);
        }
      
        private void normalize()
        {
            if (second >= 60)
            {
                minute += second / 60;
                second %= 60;
            }

            if (minute >= 60)
            {
                hour += minute / 60;
                minute %= 60;
            }
        }

        public static duration operator +(duration d1, duration d2)
        {
            return new duration
                (
                d1.hour + d2.hour,
                d1.minute + d2.minute,
                d1.second + d2.second
                );
        }
        public static duration operator +(duration left, int seconds)
        {
            return new duration
                (
                left.hour,
                left.minute,
                left.second + seconds
                );
        }
        public static duration operator +(int seconds,duration right)
        {
            return new duration
                (
                right.hour,
                right.minute,
                right.second + seconds
                );
        }
        public static duration operator ++(duration d1)
        {
            return new duration
                (
                d1.hour,
                d1.minute + 1,
                d1.second
                );
        }
        public static duration operator --(duration d2)
        {
            return new duration
                (
                d2.hour,
                d2.minute - 1,
                d2.second
                );
        }
        public static duration operator -(duration d1)
        {
            return new duration
                (
                -d1.hour,
                -d1.minute,
                -d1.second
                );
        }
        public static bool operator >(duration left, duration right)
        {
            return (left.hour > right.hour) ||
                   (left.hour == right.hour && left.minute > right.minute) ||
                   (left.hour == right.hour && left.minute == right.minute && left.second > right.second);
        }

        public static bool operator <(duration left, duration right)
        {
            return (left.hour < right.hour) ||
                   (left.hour == right.hour && left.minute < right.minute) ||
                   (left.hour == right.hour && left.minute == right.minute && left.second < right.second);
        }

        public static bool operator >=(duration left, duration right)
        {
            return left > right || left == right;
        }

        public static bool operator <=(duration left, duration right)
        {
            return left < right || left == right;
        }

        public static implicit operator DateTime(duration d1)
        {
                return new DateTime(1,1,1, d1.hour, d1.minute, d1.second);
        }

    }
}
