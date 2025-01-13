using SQLite;
using ProiectMAUIFinal.Models;


namespace ProiectMAUIFinal;

public partial class ReviewEntryPage : ContentPage
{
	public ReviewEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetReviewsAsync();
    }
    async void OnReviewAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReviewListPage
        {
            BindingContext = new Reviews()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ReviewListPage
            {
                BindingContext = e.SelectedItem as Reviews
            });
        }
    }

}