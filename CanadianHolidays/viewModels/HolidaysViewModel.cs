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
                new Holiday { Name = "Family Day", Date = new DateTime(2023, 2, 20) }, // Observed in several provinces
new Holiday { Name = "Islander Day", Date = new DateTime(2023, 2, 20) }, // Prince Edward Island
new Holiday { Name = "Louis Riel Day", Date = new DateTime(2023, 2, 20) }, // Manitoba
new Holiday { Name = "Heritage Day", Date = new DateTime(2023, 2, 20) }, // Nova Scotia
new Holiday { Name = "Discovery Day", Date = new DateTime(2023, 2, 20) }, // Yukon
new Holiday { Name = "St. Patrick's Day", Date = new DateTime(2023, 3, 17) }, // Newfoundland and Labrador (not statutory)
new Holiday { Name = "St. George's Day", Date = new DateTime(2023, 4, 23) }, // Newfoundland and Labrador (not statutory)
new Holiday { Name = "National Patriots' Day", Date = new DateTime(2023, 5, 22) }, // Quebec
new Holiday { Name = "National Indigenous Peoples Day", Date = new DateTime(2023, 6, 21) }, // Not a statutory holiday
new Holiday { Name = "Discovery Day", Date = new DateTime(2023, 6, 24) }, // Newfoundland and Labrador
new Holiday { Name = "Orangemen's Day", Date = new DateTime(2023, 7, 12) }, // Newfoundland and Labrador (not statutory)
new Holiday { Name = "Regatta Day", Date = new DateTime(2023, 8, 2) }, // St. John's, Newfoundland and Labrador
new Holiday { Name = "Gold Cup Parade Day", Date = new DateTime(2023, 8, 18) }, // Prince Edward Island (not statutory)
new Holiday { Name = "Discovery Day", Date = new DateTime(2023, 8, 21) }, // Yukon
new Holiday { Name = "Labour Day", Date = new DateTime(2023, 9, 4) },
new Holiday { Name = "Thanksgiving Day", Date = new DateTime(2023, 10, 9) }

            };
        }
    }
}
