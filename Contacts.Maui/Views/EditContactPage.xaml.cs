using Contacts.Maui.Models;
using ContactModel = Contacts.Maui.Models.ContactModel;
namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
	private ContactModel contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

	private void btnCancel_Clicked(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync(".."); // .. - Navigate to the parent Page.
	}

	public string ContactId
	{
		set
		{
			contact = ContactRepository.GetContactById(int.Parse(value));
			//lblName.Text = contact.Name;
			if (contact != null)
			{
                entryName.Text = contact.Name;
                entryEmail.Text = contact.Email;
                entryPhone.Text = contact.Phone;
                entryAddress.Text = contact.Adress;
            }
		

		}
	}
}