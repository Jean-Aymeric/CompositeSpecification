using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSpecification.SpecString {
    abstract class StringSpecificationAbstractFactory {
        public string Name { get; }

        protected StringSpecificationAbstractFactory(string name) {
            Name = name;
        }

        public bool Is(string name) {
            return this.Name.Equals(name);
        }

        public abstract StringSpecification Make();

        virtual public StringSpecification Make(String Param) {
            return this.Make();
        }
    }
}
