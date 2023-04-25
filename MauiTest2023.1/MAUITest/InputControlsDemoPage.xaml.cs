namespace MAUITest;

public partial class InputControlsDemoPage : ContentPage
{
	public InputControlsDemoPage()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        labelSlider.Text= slider.Value.ToString();
    }

    private void steeper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        labelSteeper.Text=steeper.Value.ToString();
    }
}