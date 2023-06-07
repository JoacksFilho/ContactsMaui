using Contacts.Maui.Models;
using System.Collections.ObjectModel;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var contacts = new ObservableCollection<ContactModel>(ContactRepository.GetContacts());
        //ObservableCollection é capaz de notificar a view quando tem alguma alteração nos dados e atualiza-los. 

        listContacts.ItemsSource = contacts;
    }

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if(listContacts.SelectedItem != null)
        {
			//logic
			await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((ContactModel)listContacts.SelectedItem).ContactId}");		
		}	
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		listContacts.SelectedItem = null;
    }

    //private void btnEditContact_Cliked(object sender, EventArgs e)
    //{
    //	Shell.Current.GoToAsync(nameof(EditContactPage));
    //}

    //   private void btnAddContact_Clicked(object sender, EventArgs e)
    //   {
    //       Shell.Current.GoToAsync(nameof(AddContactPage));
    //   }
}