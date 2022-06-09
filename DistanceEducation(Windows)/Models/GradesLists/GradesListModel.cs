namespace DistanceEducation_Windows_.Models.GradesLists
{
    internal class GradesListModel
    {       
        public float AverageRateAll { get; set; }
        public int Year { get; set; }
        public int NumberOfSubject { get; set; }
        public int Semester { get; set; }
        public List<SubjectModel> GradesList { get; set; }


        //public GradesListModel(int year, int numberOfSubject, int semester, List<SubjectModel> gradesList , float average_rate_all)
        //{
        //    AverageRateAll = average_rate_all;
        //    Year = year;
        //    NumberOfSubject = numberOfSubject;
        //    Semester = semester;
        //    GradesList = gradesList;
        //}
    }
}
