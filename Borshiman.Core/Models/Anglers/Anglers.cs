﻿using System;
using Adr = Borshiman.Core.Models.Address;

namespace Borshiman.Core.Models.Anglers
{
    public class Anglers
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PlayingHand { get; set; }
        public Adr.Address Address { get; set; }
        public long MobileNo { get; set; }
        public bool MobileVerified { get; set; }
        public string Email { get; set; }

    }
}
