using CompositeSpecification.CompositeSpecification;
using System.Collections.Generic;

namespace CompositeSpecification.Specification
{
    abstract class IntSpecification : Specification<int> {
        private static readonly List<IntSpecificationAbstractFactory> factories = new();

        private static void InitializeFactories() {
            if (factories.Count == 0) {
                factories.Add(new IsEvenFactory());
                factories.Add(new LowerThan100Factory());
                factories.Add(new GreaterThan50Factory());
            }
        }
        
        public static IntSpecification Make(string name) {
            InitializeFactories();
            foreach (IntSpecificationAbstractFactory factory in factories) {
                if (factory.Is(name)) {
                    return factory.Make();
                }
            }
            return null;
        }
    }
}
