using System;

namespace CompositeSpecification.CompositeSpecification
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T t);
        public Specification<T> And(Specification<T> specification) {
            return new AndSpecification<T>(this, specification);
        }

        public Specification<T> Not() {
            return new NotSpecification<T>(this);
        }

        public Specification<T> Or(Specification<T> specification) {
            return new OrSpecification<T>(this, specification);
        }

        public Specification<T> AndNot(Specification<T> specification) {
            return new OrSpecification<T>(this.Not(), specification.Not());
        }

        public Specification<T> OrNot(Specification<T> specification) {
            return new AndSpecification<T>(this.Not(), specification.Not());
        }

        public Specification<T> XOr(Specification<T> specification) {
            return new OrSpecification<T>(this.And(specification.Not()), specification.And(this.Not()));
        }

        public static Specification<T> operator &(Specification<T> specification1, Specification<T> specification2) {
            return specification1.And(specification2);
        }

        public static Specification<T> operator |(Specification<T> specification1, Specification<T> specification2) {
            return specification1.Or(specification2);
        }

        public static Specification<T> operator ^(Specification<T> specification1, Specification<T> specification2) {
            return specification1.XOr(specification2);
        }

        public static Specification<T> operator !(Specification<T> specification1) {
            return specification1.Not();
        }
    }
}
