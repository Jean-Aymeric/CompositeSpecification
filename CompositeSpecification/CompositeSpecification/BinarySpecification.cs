namespace CompositeSpecification.CompositeSpecification
{
    abstract class BinarySpecification<T>: Specification<T>
    {
        public Specification<T> Specification1 { get; set; }
        public Specification<T> Specification2 { get; set; }

        protected BinarySpecification(Specification<T> specification1, Specification<T> specification2)
        {
            Specification1 = specification1;
            Specification2 = specification2;
        }

    }
}
