using SQLite;
using ProiectMAUIFinal.Models;

namespace ProiectMAUIFinal;

public partial class CalEntryPage : ContentPage
{
	public CalEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetCaiAsync();
    }
    async void OnCalAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CalListPage
        {
            BindingContext = new Cal()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new CalListPage
            {
                BindingContext = e.SelectedItem as Cal
            });
        }
    }
}