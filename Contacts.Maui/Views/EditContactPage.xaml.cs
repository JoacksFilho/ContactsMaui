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
                entryAddress.Text = contact.Address;
            }
		

		}
	}

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {
		if (nameValidator.IsNotValid) 
		{
			DisplayAlert("Error", "Name is required.", "OK");
			return;
		}
		if(emailValidator.IsNotValid)
		{
			foreach (var error in emailValidator.Errors)
			{
				DisplayAlert("Error", error.ToString(), "Ok");
			}

			return;
		}

		contact.Name = entryName.Text;
		contact.Email = entryEmail.Text;
		contact.Address = entryAddress.Text;
		contact.Phone = entryPhone.Text;

		ContactRepository.UpdateContact(contact.ContactId, contact);
		Shell.Current.GoToAsync("..");
    }
}