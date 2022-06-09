using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    class StringLessOrEqualThanXCharactersFactory : StringSpecificationAbstractFactory {
        public StringLessOrEqualThanXCharactersFactory() : base("<=") {
        }

        public override StringSpecification Make() {
            return new StringLessOrEqualThanXCharacters(5);
        }

        public override StringSpecification Make(String Param) {
            return new StringLessOrEqualThanXCharacters(Int32.Parse(Param));
        }
    }
}
