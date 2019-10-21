using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(global::System.String name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
