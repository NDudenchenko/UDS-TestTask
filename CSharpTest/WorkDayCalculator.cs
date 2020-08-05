using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            if (dayCount <= 0)
            {
                throw new Exception("Day count must be positive integer");
            }

            DateTime preliminaryResultDate = startDate.AddDays(dayCount - 1);
            if (weekEnds != null)
            {
                for (int i = 0; i < weekEnds.Length; i++)
                {
                    if (DateTime.Compare(weekEnds[i].StartDate, preliminaryResultDate) <= 0 &&
                        DateTime.Compare(weekEnds[i].StartDate, startDate) >= 0)
                    {
                        int daysShift = weekEnds[i].EndDate.Day - weekEnds[i].StartDate.Day + 1;
                        preliminaryResultDate = preliminaryResultDate.AddDays(daysShift);
                    }
                }

                return preliminaryResultDate;
            }

            return preliminaryResultDate;
        }
    }
}
