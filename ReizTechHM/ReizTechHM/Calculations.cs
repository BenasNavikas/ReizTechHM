namespace ReizTechHM
{
    public class Calculations
    {
        /// <summary>
        /// Hour hand moves 30 degrees per hour and per minute it moves 0.5 degrees. 
        /// Minute hand moves 6 degrees per 1 minute.
        /// </summary>
        /// <param name="hours">Hour hand position</param>
        /// <param name="minutes">Minute hand position</param>
        /// <returns>Angle from hour to minute hand</returns>
        public double FindAngle(int hours, int minutes)
        {
            double hourHandAngle = 0.5 * (hours * 60 + minutes);
            double minuteHandAngle = 6 * minutes;
            double angle = Math.Abs(hourHandAngle - minuteHandAngle);
            angle = 360 - angle;
            return angle;
        }
    }
}
