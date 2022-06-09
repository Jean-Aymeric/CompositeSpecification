namespace CompositeSpecification.Specification {
    abstract class IntSpecificationAbstractFactory {
        public string Name { get; }

        protected IntSpecificationAbstractFactory(string name) {
            Name = name;
        }

        public bool Is(string name) {
            return this.Name.Equals(name);
        }

        public abstract IntSpecification Make();
    }
}
