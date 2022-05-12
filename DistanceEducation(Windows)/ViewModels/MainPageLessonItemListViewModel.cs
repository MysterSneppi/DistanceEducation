using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.ViewModels
{
    internal class MainPageLessonItemListViewModel : BaseViewModel
    {
       public List<MainPageLessonItemView> items { get; set; }

       public MainPageLessonItemListViewModel() 
        {
            items = new List<MainPageLessonItemView>();

            for (int i = 0;i<3;i++) {
                items.Add(new MainPageLessonItemView() { Subject = "Математика", NameTeacher = "Назаров Сергеевич", Image = @"\Resources\Icons\ScoolSubjectIcon\Mathematic.png" });
                items.Add(new MainPageLessonItemView() { Subject = "Биология", NameTeacher = "Алексей Навальний", Image = @"\Resources\Icons\ScoolSubjectIcon\Biology.png" });
                items.Add(new MainPageLessonItemView() { Subject = "Химия", NameTeacher = "Остап Вишня", Image = @"\Resources\Icons\ScoolSubjectIcon\Chemestry.png" });
                items.Add(new MainPageLessonItemView() { Subject = "Экономика", NameTeacher = "Александр Пушкин", Image = @"\Resources\Icons\ScoolSubjectIcon\Economic.png" });
                items.Add(new MainPageLessonItemView() { Subject = "Физика", NameTeacher = "Александр Вишневский", Image = @"\Resources\Icons\ScoolSubjectIcon\Physic.png" });
            }
        }

    }
}
