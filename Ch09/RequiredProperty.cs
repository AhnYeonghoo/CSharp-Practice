using System;

namespace RequiredProperty
{
    class BirthdayInfo
    {
        public required string Name { get; set; }
        public required DateTime Birthday { get; set; }

        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
}