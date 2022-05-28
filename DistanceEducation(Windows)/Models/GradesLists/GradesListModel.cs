namespace DistanceEducation_Windows_.Models.GradesLists
{
    public class GradesListModel
    {
        public string Year;
        public int NumberOfSubject;
        public int Semester;
        public List<SubjectModel> GradesList;

        public GradesListModel(string year, int numberOfSubject, int semester, List<SubjectModel> gradesList)
        {
            Year = year;
            NumberOfSubject = numberOfSubject;
            Semester = semester;
            GradesList = gradesList;
        }
    }
}
