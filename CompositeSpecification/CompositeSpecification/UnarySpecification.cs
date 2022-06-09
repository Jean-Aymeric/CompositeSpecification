namespace CompositeSpecification.CompositeSpecification
{
    abstract class UnarySpecification<T> : Specification<T>
    {
        public Specification<T> Specification { get; set; }

        protected UnarySpecification(Specification<T> specification)
        {
            Specification = specification;
        }
    }
}
