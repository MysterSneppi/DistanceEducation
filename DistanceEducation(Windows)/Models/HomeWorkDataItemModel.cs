namespace DistanceEducation_Windows_.Models
{
    internal class HomeWorkDataItemModel
    {
        public Image Status { get; set; }
        public string Date { get; set; }
        public string Exercise { get; set; }
        public string Subject { get; set; }
        public string Edit { get; set; }

        public HomeWorkDataItemModel(Image status, string date, string exercise, string subject, string edit)
        {
            Status = status;
            Date = date;
            Exercise = exercise;
            Subject = subject;
            Edit = edit;
        }

    }
}
