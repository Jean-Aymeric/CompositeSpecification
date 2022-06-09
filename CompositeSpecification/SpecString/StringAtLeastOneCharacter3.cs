using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    class StringAtLeastOneCharacter3 : StringSpecification {
        public override bool IsSatisfiedBy(string t) {
            return t.Contains('3');
        }
    }
}
