namespace ContactDetailsApi.Models;

public class ContactDetails
{
    public ContactDetails(int contactId, string firstname, string lastname, string email, string gender, string title)
    {
        ContactId = contactId;
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
        Gender = gender;
        Title = title;
    }

    public int ContactId { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string Title { get; set; }
}