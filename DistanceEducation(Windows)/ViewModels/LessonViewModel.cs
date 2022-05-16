namespace DistanceEducation_Windows_.ViewModels
{
    internal class LessonViewModel : BaseViewModel
    {
        public List<LessonUserWindowView> list { get; set; }



        public LessonViewModel()
        {
            list = new List<LessonUserWindowView>();

            for (int i = 0; i < 12; i++)
            {
                list.Add(new LessonUserWindowView());
            }
        }


    }
}
