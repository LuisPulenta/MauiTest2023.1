using MAUITest.BindingDemo;

namespace MAUITest;

public partial class BindingDemoPage : ContentPage
{
	public BindingDemoPage()
	{
		InitializeComponent();
	}

    private void btnOk_Clicked(object sender, EventArgs e)
    {
		var person = new Person
		{
			Name = "Luis Núñez",
			Phone = "351 6 814 963",
			Address = "Espora 2052"
		};

		BindingContext = person;




		//lblName.SetBinding(Label.TextProperty, "Name");

		//var personBinding = new Binding();
		//      personBinding.Source = person;
		//personBinding.Path = "Name";

		//lblName.SetBinding(Label.TextProperty,personBinding);


	}
}