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
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Даты защиты дипломов", Text = "Для груп 18 ПР-1 и 18 ПР-2 даты следующие : 15.06 , 17.06 , 21.06 , 22.06  \n\nВсем удачной защиты! " });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/img.png", Title = "Ещё раз привет", Text = "Ещё какойто текс" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет2", Text = "Ещё какойто текс" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет3", Text = "Ещё какойто текс" });

            for (int i = 0; i < ImageCarouselItems.Count; i++)
            {
                RadioButton radioButton = new RadioButton() { GroupName = "Items", TabIndex = i };
                radioButton.Checked += RadioButton_Checked1;
                RadioButtons.Add(radioButton);
            }
        }

        private async void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            await Task.Delay(5000);
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
