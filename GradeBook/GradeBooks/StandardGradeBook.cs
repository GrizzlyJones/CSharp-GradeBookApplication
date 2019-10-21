using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(global::System.String name) : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
