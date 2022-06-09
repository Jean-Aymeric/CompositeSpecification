namespace CompositeSpecification.Specification
{
     class GreaterThan50 : IntSpecification
    {
        public override bool IsSatisfiedBy(int t)
        {
            return t > 50;
        }
    }
}
