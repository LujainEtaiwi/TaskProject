using Contact.User.Models;

namespace Contact.User;

public static class ContactData
{
  private static readonly List<ContactModel> contacts = new()
  {
new ContactModel()
{
Id=1,
FirstName="lujain",
LastName="Etaiwi",
Email="lujainetaiwi02@gmail.com",
PhoneNumber="0790819148"
}
};

  public static ContactModel[] GetContacts()
  {
    return contacts.ToArray();
  }

  public static void Create(ContactModel contact)
  {
    contact.Id = contacts.Max(contact => contact.Id) + 1;
    contacts.Add(contact);
  }
  public static ContactModel GetContact(int id)
  {
    return contacts.Find(contacts => contacts.Id == id) ?? throw new Exception("Could Not Find A Contact!");
  }
  public static void Update(ContactModel contact)
  {
    ContactModel existingContact = GetContact(contact.Id);
    existingContact.FirstName = contact.FirstName;
    existingContact.LastName = contact.LastName;
    existingContact.Email = contact.Email;
    existingContact.PhoneNumber = contact.PhoneNumber;
  }
  public static void Delete(int id)
  {
    ContactModel contact = GetContact(id);
    contacts.Remove(contact);
  }


}
