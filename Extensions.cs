﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2Azure
{
    internal static class Extensions
    {
        public static string FromBase64String(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }

        public static string ToBase64String(this string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return s;
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
        }
    }
}
