namespace CompositeSpecification.CompositeSpecification
{
    class AndSpecification<T> : BinarySpecification<T>
    {
        public AndSpecification(Specification<T> specification1, Specification<T> specification2) : base(specification1, specification2)
        {
        }

        public override bool IsSatisfiedBy(T t)
        {
            return Specification1.IsSatisfiedBy(t) && Specification2.IsSatisfiedBy(t);
        }
    }
}
