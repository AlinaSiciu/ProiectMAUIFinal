using ProiectMAUIFinal.Models;

namespace ProiectMAUIFinal;

public partial class ReviewListPage : ContentPage
{
	public ReviewListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Reviews)BindingContext;
        slist.Date = DateTime.UtcNow;
        await App.Database.SaveReviewAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Reviews)BindingContext;
        await App.Database.DeleteReviewAsync(slist);
        await Navigation.PopAsync();
    }


}