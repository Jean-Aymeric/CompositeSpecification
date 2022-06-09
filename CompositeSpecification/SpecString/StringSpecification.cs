using CompositeSpecification.CompositeSpecification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    abstract class StringSpecification : Specification<String> {
        private static readonly List<StringSpecificationAbstractFactory> factories = new();

        private static void InitializeFactories() {
            if (factories.Count == 0) {
                factories.Add(new StringLessOrEqualThan10CharactersFactory());
                factories.Add(new StringAtLeastOneCharacter3Factory());
                factories.Add(new StringLessOrEqualThanXCharactersFactory());
            }
        }

        public static StringSpecification Make(string name) {
            InitializeFactories();
            foreach (StringSpecificationAbstractFactory factory in factories) {
                if (factory.Is(name)) {
                    return factory.Make();
                }
            }
            
            foreach (StringSpecificationAbstractFactory factory in factories) {
                if (factory.Is(name.Split(' ')[0])) {
                    return factory.Make(name.Split(' ')[1]);
                }
            }
            return null;
        }
    }
}
