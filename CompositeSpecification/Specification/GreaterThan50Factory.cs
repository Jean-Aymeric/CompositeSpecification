namespace CompositeSpecification.Specification {
    class GreaterThan50Factory : IntSpecificationAbstractFactory {
        public GreaterThan50Factory() : base(">50") {
        }

        public override IntSpecification Make() {
            return new GreaterThan50();
        }
    }
}
