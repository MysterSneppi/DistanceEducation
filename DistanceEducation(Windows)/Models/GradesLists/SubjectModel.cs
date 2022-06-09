namespace DistanceEducation_Windows_.Models.GradesLists
{
    internal class SubjectModel
    {
        public float AverageRate { get; set; }
        public string NameSubject { get; set; }
        public List<GradesSubjectModel> ListGrades { get; set; }

        //public SubjectModel(float average_rate, string nameSubject, List<GradesSubjectModel> listGrades)
        //{
        //    AverageRate = average_rate;
        //    NameSubject = nameSubject;
        //    ListGrades = listGrades;
        //}
    }
}
