using SQLite;
using ProiectMAUIFinal.Models;

namespace ProiectMAUIFinal;

public partial class InstrListPage : ContentPage
{
	public InstrListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var instr = (Instructor)BindingContext;
        await App.Database.SaveInstructorAsync(instr);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var instr = (Instructor)BindingContext;
        await App.Database.DeleteInstructorAsync(instr);
        await Navigation.PopAsync();
    }
}