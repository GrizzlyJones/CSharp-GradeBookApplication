using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(global::System.String name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
