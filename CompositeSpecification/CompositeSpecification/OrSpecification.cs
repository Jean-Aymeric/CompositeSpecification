namespace CompositeSpecification.CompositeSpecification
{
    class OrSpecification<T> : BinarySpecification<T>
    {
        public OrSpecification(Specification<T> specification1, Specification<T> specification2) : base(specification1, specification2)
        {
        }

        public override bool IsSatisfiedBy(T t)
        {
            return Specification1.IsSatisfiedBy(t) || Specification2.IsSatisfiedBy(t);
        }
    }
}
