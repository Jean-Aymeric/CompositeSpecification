namespace CompositeSpecification.Specification
{
    class LowerThan100 : IntSpecification
    {
        public override bool IsSatisfiedBy(int t)
        {
            return t < 100;
        }
    }
}
