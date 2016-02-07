﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    class ProperCase
    {
        /// <summary>
        /// ToProperCase
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String ToProperCase(String s)
        {
            if (s == null) return s;

            String[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0) continue;

                Char firstChar = Char.ToUpper(words[i][0]);
                String rest = "";
                if (words[i].Length > 1)
                {
                    rest = words[i].Substring(1).ToLower();
                }
                words[i] = firstChar + rest;
            }
            return String.Join(" ", words);
        }
    }
}