using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace CW2.Data
{
    class StudentComparator : IEqualityComparer<Student>
    {
        public bool Equals([DisallowNull] Student x, [DisallowNull] Student y)
        {
            return x.firstname.Equals(y.firstname) && x.surname.Equals(y.surname) && x.index.Equals(y.index);
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.GetHashCode();
        }
    }
}
