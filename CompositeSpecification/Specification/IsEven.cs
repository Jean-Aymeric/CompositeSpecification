namespace CompositeSpecification.Specification
{
    class IsEven : IntSpecification
    {
        public override bool IsSatisfiedBy(int t)
        {
            return t % 2 == 0;
        }
    }
}
