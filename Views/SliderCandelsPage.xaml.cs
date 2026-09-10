namespace firstproject.Views;

public partial class SliderCandelsPage : ContentPage
{
	public SliderCandelsPage()
	{
		InitializeComponent();
	}

	private void ShowAge(object sender, EventArgs e)
	{
        CandleHolder.Clear();
        var sliderAge = sender as Slider;
		int age= (int)sliderAge.Value;
        TextAge.Text = age.ToString();
        for (int i = 1; i <= age; i++)
        {
            Image candleImg = new Image
            {
                Source = "candle.png",
                WidthRequest = 10,
                HeightRequest = 40
            };
            CandleHolder.Children.Add(candleImg);


        }


    }
}