namespace DistanceEducation_Windows_.ViewModels
{
    internal class ImageCarouselViewModel
    {
        public ObservableCollection<ImageCarouselItemView> ImageCarouselItems { get; set; }
        public ObservableCollection<RadioButton> RadioButtons { get; set; }
        //Index
        private int index = 0;
        public  ImageCarouselViewModel() 
        {
            ImageCarouselItems = new ObservableCollection<ImageCarouselItemView>();
            RadioButtons = new ObservableCollection<RadioButton>();

            AddItemsInCarousel();

            AddRadioButton();

            RadioButtons[index].IsChecked = true;


            ImageCarouselItems.Move(1, 0);

        }
        private void AddItemsInCarousel() 
        {
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Даты защиты дипломов", Text = "Для груп 18 ПР-1 и 18 ПР-2 даты следующие : 15.06 , 17.06 , 21.06 , 22.06  \n\nВсем удачной защиты! " });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/img.png", Title = "Ещё раз привет", Text = "Ещё какойто текс" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет2", Text = "Ещё какойто текс" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет3", Text = "Ещё какойто текс" });
        }


        private void AddRadioButton() 
        {
            for (int i = 0; i < ImageCarouselItems.Count; i++)
            {
                RadioButton radioButton = new RadioButton() { GroupName = "Items", TabIndex = i };
                radioButton.Checked += RadioButton_Checked1;
                RadioButtons.Add(radioButton);
            }
        }

        private async void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {
            while (true) 
            {
                if (index == RadioButtons.Count) 
                {
                     index = 0;
                }
                else 
                {
                    await Task.Delay(2000);
                    RadioButtons[index].IsChecked = true;

                    if(index != 0) 
                    {
                        ImageCarouselItems.Move(index, 0);
                        index++;
                    }                    
                }
            }
        }
    }
}
