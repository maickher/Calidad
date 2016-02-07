﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Date : IEquatable<Date>, IEquatable<DateTime>
    {
        private DateTime value;
        public Date(DateTime date)
        {
            value = date.Date;
        }
        public bool Equals(Date other)
        {
            return other != null && value.Equals(other.value);
        }
        public bool Equals(DateTime other)
        {
            return value.Equals(other);
        }
        public override string ToString()
        {
            return value.ToString();
        }
        public static implicit operator DateTime(Date date)
        {
            return date.value;
        }
        public static explicit operator Date(DateTime dateTime)
        {
            return new Date(dateTime);
        }
        
    }
}
