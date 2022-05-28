namespace DistanceEducation_Windows_.Models.GradesLists
{
    public class SubjectModel
    {
        public float GPA; // average grade
        public string NameSubject;
        public List<GradesSubjectModel> ListGrades;

        public SubjectModel() { }
        public SubjectModel(float gPA, string nameSubject, List<GradesSubjectModel> listGrades)
        {
            GPA = gPA;
            NameSubject = nameSubject;
            ListGrades = listGrades;
        }
    }
}
