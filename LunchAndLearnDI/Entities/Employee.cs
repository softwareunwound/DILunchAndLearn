﻿namespace LunchAndLearnDI.Entities
{
    public class Employee
    {
        #region Properties
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string TitleOfCourtesy { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Notes { get; set; }

        public byte[] Photo { get; set; }
        #endregion
    }
}
