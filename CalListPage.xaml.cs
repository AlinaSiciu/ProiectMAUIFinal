using ProiectMAUIFinal.Models;

namespace ProiectMAUIFinal;

public partial class CalListPage : ContentPage
{
	public CalListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var cal = (Cal)BindingContext;
        await App.Database.SaveCalAsync(cal);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var cal = (Cal)BindingContext;
        await App.Database.DeleteCalAsync(cal);
        await Navigation.PopAsync();
    }

}