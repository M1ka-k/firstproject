using Microsoft.Maui.Graphics.Text;

namespace firstproject.Views;

public partial class AgePage : ContentPage
{
	public AgePage()
	{
		InitializeComponent();
        
    }

    private void CalcTenAge_Clicked(object sender, EventArgs e)
    {
        int age = int.Parse(entryAge.Text);
        msg.Text = $"{entryName.Text} will be {age + 10} in 10 years";
        
        
    }
}