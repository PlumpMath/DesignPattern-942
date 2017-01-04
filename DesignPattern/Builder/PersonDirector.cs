using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PersonDirector
    {
        private PersonBuilder pb;
        public PersonDirector(PersonBuilder pb)
        {
            this.pb = pb;
        }

        public void CreatePerson()
        {
            pb.BuilderHead();
            pb.BuilderBody();
            pb.BuilderArmLeft();
            pb.BuilderArmRight();
            pb.BuilderLegLeft();
            pb.BuilderLegRight();
        }
    }
}
