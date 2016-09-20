using System;

namespace _07_Timer
{
    internal class Timer
    {
        public int Seconds { get; set; }

        public override string ToString()
        {
            string sec = "";
            int minutes = Seconds / 60;
            int hour = minutes/60;
            
            if(Seconds > 60)
            {
                Seconds = Seconds - 60*minutes;
            }
            
            if(minutes > 60)
            {
                minutes = minutes - 60;
            }

            sec = Padded(Seconds);

            return "0" +hour + ":0" + minutes + ":" + sec;
        }

        internal string Padded(int v)
        {
            string returnValue = "";
            if (v < 10)
            {
                returnValue = "0" + v;
            }
            else
            {
                returnValue = v.ToString();
            }
            return returnValue;
        }
    }
}