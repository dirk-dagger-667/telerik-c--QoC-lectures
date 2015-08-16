﻿namespace CodeFormatting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    static class Messages
    {
        public static void EventAdded(StringBuilder output)
        {
            output.Append("Event added\n");
        }

        public static void EventDeleted(int x, StringBuilder output)
        {
            if (x == 0)
            {
                NoEventsFound(output);
            }
            else
            {
                output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public static void NoEventsFound(StringBuilder output)
        {
            output.Append("No events found\n");
        }

        public static void PrintEvent(Event eventToPrint, StringBuilder output)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + "\n");
            }
        }
    }
}
