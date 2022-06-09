using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    class StringAtLeastOneCharacter3Factory : StringSpecificationAbstractFactory {
        public StringAtLeastOneCharacter3Factory() : base("3") {
        }

        public override StringSpecification Make() {
            return new StringAtLeastOneCharacter3();
        }
    }
}
