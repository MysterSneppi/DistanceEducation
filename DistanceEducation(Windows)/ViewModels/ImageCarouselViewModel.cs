namespace DistanceEducation_Windows_.ViewModels
{
    internal class ImageCarouselViewModel
    {
        private ObservableCollection<ImageCarouselItemView> ImageCarouselItems { get; set; }
        public ObservableCollection<ImageCarouselItemView> ImageCarouselItemsCurrent { get; set; }
        public ObservableCollection<RadioButton> RadioButtons { get; set; }
        //Index radio buttons
        private int index = 0;
        public  ImageCarouselViewModel() 
        {
            ImageCarouselItemsCurrent = new ObservableCollection<ImageCarouselItemView>();
            ImageCarouselItems = new ObservableCollection<ImageCarouselItemView>();
            RadioButtons = new ObservableCollection<RadioButton>();
            AddItemsInCarousel();

            ImageCarouselItemsCurrent.Add(ImageCarouselItems[0]);
            RadioButtons[index].IsChecked = true;
        }
        private void AddItemsInCarousel() 
        {
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Advertising/Stud.png",ButtonText = "Узнать больше" ,Title = "Даты защиты дипломов", Text = "Для груп 18 ПР-1 и 18 ПР-2 даты следующие : 15.06 , 17.06 , 21.06 , 22.06  \n\nВсем удачной защиты! " });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Advertising/PR.png",ButtonText="Перейти на сайт" ,Title = "Вступительная компания",ImageWidth=100,ImageHeight=100 ,  Text = "Мечтаете стать программистом?\nНо не знаете с чего начат и где научиться?\nОФККТ раскажет и поможет вам с выбором.\nДля более детальной информацией переходите на наш сайт" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Advertising/csharp.png", Title = "Лёша настоящий пидорас-пидорасина", Text = "секс текст" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Advertising/GO.png",ButtonText = "", Title = "Fgyutr", Text = "Максим красавчик и он не хочет делать тебе мессенджер" });

            for (int i = 0; i < ImageCarouselItems.Count; i++)
            {
                RadioButton radioButton = new RadioButton() { GroupName = "Items", TabIndex = i };
                radioButton.Checked += RadioButton_Checked1;
                RadioButtons.Add(radioButton);
            }
        }

        private async void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            await Task.Delay(10000);
            index++;

            if (index != RadioButtons.Count) 
            {
                ImageCarouselItemsCurrent.Clear();
                ImageCarouselItemsCurrent.Add(ImageCarouselItems[RadioButtons[index].TabIndex]);
                RadioButtons[index].IsChecked = true;
            }
            else 
            {
                index = 0;
                ImageCarouselItemsCurrent.Clear();
                ImageCarouselItemsCurrent.Add(ImageCarouselItems[RadioButtons[index].TabIndex]);
                RadioButtons[index].IsChecked = true;
            }
        }
    }
}
