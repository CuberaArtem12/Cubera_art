using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9.MyStruct
{
    struct Birthday
    {
        public DateOnly birthDay { get; set; }
        private int afteryear;
        public int AfterYear
        {
            get { return afteryear; }
            set {
                if (value <= birthDay.Year) throw new ArgumentOutOfRangeException("value must be greater than year of birth");
                afteryear = value;
            }
        }
        public Birthday(DateOnly birthDay) {
            this.birthDay = birthDay;
        }
        public DayOfWeek GetBirthDayOfWeek()
        {
            return birthDay.DayOfWeek;
        }
        public DayOfWeek GetDayOfWeekInYear() {
            DateOnly DayOfWeekInYear = new DateOnly(AfterYear, birthDay.Month, birthDay.Day);
            return DayOfWeekInYear.DayOfWeek;
        }
        public int daysUntilBirthday(){
            DateOnly todaydate = DateOnly.FromDateTime(DateTime.Now);
            DateOnly BirthDayNext = new DateOnly(todaydate.Year, birthDay.Month, birthDay.Day);
            if (BirthDayNext <= todaydate) {
               BirthDayNext = new DateOnly(todaydate.Year+1, birthDay.Month, birthDay.Day);
            }
            return BirthDayNext.DayNumber - todaydate.DayNumber;
        }
    }
}
