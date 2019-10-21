using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(global::System.String name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
