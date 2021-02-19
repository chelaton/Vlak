using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class BusinessWagon : PersonalWagon
    {
        Person steward;

        public BusinessWagon(int numberOfChairs, Person person) : base(numberOfChairs)
        {
            Steward = person;
        }

        internal Person Steward { get => steward; set => steward = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} wagon a poctem sedadel {NumberOfChairs} a stewardem {steward.FirstName} {steward.Lastname} \r\n"; ;
        }
    }
}
