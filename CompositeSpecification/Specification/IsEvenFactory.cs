namespace CompositeSpecification.Specification {
    class IsEvenFactory : IntSpecificationAbstractFactory {
        public IsEvenFactory() : base("Even") {
        }

        public override IntSpecification Make() {
            return new IsEven();
        }
    }
}
