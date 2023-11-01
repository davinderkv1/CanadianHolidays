using System;
using System.Collections.ObjectModel;

namespace CanadianHolidays.ViewModels
{
    public class HolidaysViewModel
    {
        public ObservableCollection<Holiday> Holidays { get; private set; }

        public HolidaysViewModel()
        {
            Holidays = new ObservableCollection<Holiday>
            {
                new Holiday { Name = "New Year's Day", Date = new DateTime(DateTime.Now.Year, 1, 1) },
                new Holiday { Name = "Good Friday", Date = new DateTime(DateTime.Now.Year, 4, 15) },
                new Holiday { Name = "Victoria Day", Date = new DateTime(DateTime.Now.Year, 5, 24) },
                new Holiday { Name = "Canada Day", Date = new DateTime(DateTime.Now.Year, 7, 1) },
                new Holiday { Name = "Civic Day", Date = new DateTime(DateTime.Now.Year, 8, 2) }
            };
        }
    }
}
