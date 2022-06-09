namespace CompositeSpecification.CompositeSpecification
{
    class NotSpecification<T> : UnarySpecification<T>
    {
        public NotSpecification(Specification<T> specification) : base(specification)
        {
        }

        public override bool IsSatisfiedBy(T t)
        {
            return !Specification.IsSatisfiedBy(t);
        }
    }
}
