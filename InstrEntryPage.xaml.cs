using SQLite;
using ProiectMAUIFinal.Models;

namespace ProiectMAUIFinal;

public partial class InstrEntryPage : ContentPage
{
	public InstrEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetInstructorAsync();
    }
    async void OnInstrAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InstrListPage
        {
            BindingContext = new Instructor()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new InstrListPage
            {
                BindingContext = e.SelectedItem as Instructor
            });
        }
    }
}