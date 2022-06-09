using CompositeSpecification.CompositeSpecification;
using CompositeSpecification.Specification;
using CompositeSpecification.SpecString;
using System;

Specification<int> specification = (IntSpecification.Make(">50") & IntSpecification.Make("<100")) ^ (!IntSpecification.Make("Even"));

Console.WriteLine("33 : " + specification.IsSatisfiedBy(33));
Console.WriteLine("32 : " + specification.IsSatisfiedBy(32));
Console.WriteLine("56 : " + specification.IsSatisfiedBy(56));
Console.WriteLine("57 : " + specification.IsSatisfiedBy(57));
Console.WriteLine("102 : " + specification.IsSatisfiedBy(102));
Console.WriteLine("103 : " + specification.IsSatisfiedBy(103));

Specification<String> stringSpec = (StringSpecification.Make("<= 10") & StringSpecification.Make("3")) | StringSpecification.Make("<= 3");

Console.WriteLine(stringSpec.IsSatisfiedBy("1234567890123"));
Console.WriteLine(stringSpec.IsSatisfiedBy("123456789"));
Console.WriteLine(stringSpec.IsSatisfiedBy("1256789"));
Console.WriteLine(stringSpec.IsSatisfiedBy("12"));
