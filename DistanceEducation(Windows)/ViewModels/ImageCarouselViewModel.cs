namespace DistanceEducation_Windows_.ViewModels
{
    internal class ImageCarouselViewModel
    {
        public ObservableCollection<ImageCarouselItemView> ImageCarouselItems { get; set; }
        public ObservableCollection<RadioButton> RadioButtons { get; set; }

        public  ImageCarouselViewModel() 
        {
            ImageCarouselItems = new ObservableCollection<ImageCarouselItemView>();
            RadioButtons = new ObservableCollection<RadioButton>();

            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Привет" , Text="Здесь могла быть ваша реклама"  });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет", Text = "Ещё какойто текс" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет2", Text = "Ещё какойто текс" });
            ImageCarouselItems.Add(new ImageCarouselItemView() { ImageSource = "/Resources/Images/ImageCarousel.png", Title = "Ещё раз привет3", Text = "Ещё какойто текс" });



            for (int i = 0; i < ImageCarouselItems.Count; i++) 
            {
                RadioButton radioButton = new RadioButton() { GroupName = "Items", TabIndex = i };
                radioButton.Checked += RadioButton_Checked1;
                RadioButtons.Add(radioButton);
            }

            RadioButtons[0].IsChecked = true;

           

        }
        private void RadioButton_Checked1(object sender, RoutedEventArgs e)
        {           
            
            ImageCarouselItems.Move(1, 0);
        }
  
        private void Carousel() 
        {

            int index = 0;
            while (true) 
            {
                if (index == RadioButtons.Count) 
                {
                    index = 0;
                }
                else 
                {
                    RadioButtons[index].IsChecked = true;
                    index++;
                }
                Thread.Sleep(5000);
            }
        }

       

    }
}
