﻿//Format correctly the following source code (given in Code-Formatting-Homework.zip):
//C# code given in the file events.cs.
//JavaScript code given in the file code.js.
//Use the official code conventions for C# / JavaScript / Java / PHP:
//Official C# Coding Conventions (MSDN)
//Google JavaScript Style Guide
//Official Java Code Conventions (by Oracle)
//Zend code convention for PHP

namespace CodeFormatting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    class Event : IComparable
    {
        private DateTime date;
        private String title;
        private String location;

        public Event(DateTime date, String title, String location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + title);

            if (location != null && location != "")
            {
                toString.Append(" | " + location);
            }

            return toString.ToString();
        }
    }
}
