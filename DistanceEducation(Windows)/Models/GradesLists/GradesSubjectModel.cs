namespace DistanceEducation_Windows_.Models.GradesLists
{
    /// <summary>
    /// Properties grade
    /// </summary>
    public class GradesSubjectModel
    {
        public string Date;
        public int Grade;

        public GradesSubjectModel(string date, int grade)
        {
            Date = date;
            Grade = grade;
        }
    }
}
