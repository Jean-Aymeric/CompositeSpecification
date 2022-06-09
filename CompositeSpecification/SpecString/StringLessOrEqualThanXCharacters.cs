using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    class StringLessOrEqualThanXCharacters : StringSpecification {
        private int X { get; }

        public StringLessOrEqualThanXCharacters(int x) {
            X = x;
        }

        public override bool IsSatisfiedBy(string t) {
            return t.Length <= this.X;
        }
    }
}
