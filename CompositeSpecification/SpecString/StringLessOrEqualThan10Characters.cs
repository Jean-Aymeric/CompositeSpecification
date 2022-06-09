using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    class StringLessOrEqualThan10Characters : StringSpecification {
        public override bool IsSatisfiedBy(string t) {
            return t.Length <= 10;
        }
    }
}
