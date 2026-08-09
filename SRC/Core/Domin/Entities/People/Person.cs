using Domin.Entities.Base;
using Domin.Entities.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities.People
{
    public class Person:BaseEntity
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalCode { get; set; }
        public string MobilePhoneNumber { get; set; }
        public long BirthDate  { get; set; }
        public long ProvinceBirthDateOrIssuanceId { get; set; }
        public long CityBirthDateOrIssuanceId { get; set; }



        public virtual Province ProvinceBirthDateOrIssuance { get; set; }
        public virtual City CityBirthDateOrIssuance { get; set; }
        public virtual ICollection<JobPositionPerson> JobPositionPeople{ get; set; }
    }
}
