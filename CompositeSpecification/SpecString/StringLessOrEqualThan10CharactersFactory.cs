using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString{
    class StringLessOrEqualThan10CharactersFactory : StringSpecificationAbstractFactory {
        public StringLessOrEqualThan10CharactersFactory() : base("<=10") {
        }

        public override StringSpecification Make() {
            return new StringLessOrEqualThan10Characters();
        }
    }
}
