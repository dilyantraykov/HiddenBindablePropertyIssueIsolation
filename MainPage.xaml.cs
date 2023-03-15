using System.Reflection;

namespace NewIsChecked;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		// Issue can also be reproduced by invoking the following method
		// this.checkBox.GetType().GetRuntimeProperty("IsChecked");
	}
}
