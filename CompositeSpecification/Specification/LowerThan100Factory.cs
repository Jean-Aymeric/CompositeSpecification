namespace CompositeSpecification.Specification {
    class LowerThan100Factory : IntSpecificationAbstractFactory {
        public LowerThan100Factory() : base("<100") {
        }

        public override IntSpecification Make() {
            return new LowerThan100();
        }
    }
}
