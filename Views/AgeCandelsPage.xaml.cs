using Microsoft.Maui.Graphics.Text;

namespace firstproject.Views;

public partial class AgeCandelsPage : ContentPage
{
	public AgeCandelsPage()
	{
		InitializeComponent();
	}

    private void CalcTenAge_Clicked(object sender, EventArgs e)
    {
        int age_10 = int.Parse(entryAge.Text) + 10;
        msg.Text = $"{entryName.Text} will be {age_10} in 10 years";
        for(int i =1; i<= age_10; i++)
        {
            Image candleImg = new Image {
                Source = "candle.png",
                WidthRequest = 10,
                HeightRequest = 40
            };
            CandleHolder.Children.Add(candleImg);


        }


    }
}