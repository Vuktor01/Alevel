public class ContactsCollection
{
    private Dictionary<string, List<Contact>> contactsDictionary;

    public ContactsCollection()
    {
        contactsDictionary = new Dictionary<string, List<Contact>>();
        InitializeAlphabetSections();
    }

    private void InitializeAlphabetSections()
    {

        string[] alphabets = { "English", "Ukrainian", "#", "Number" };

        foreach (var alphabet in alphabets)
        {
            contactsDictionary.Add(alphabet, new List<Contact>());
        }
    }

    public void AddContact(string name, string phoneNumber, string language = "English")
    {

        string sectionKey = GetAlphabetSectionKey(name, language);

 
        contactsDictionary[sectionKey].Add(new Contact(name, phoneNumber));
    }

    public void DisplayContacts()
    {
        foreach (var section in contactsDictionary)
        {
            Console.WriteLine($"{section.Key}:");

            foreach (var contact in section.Value)
            {
                Console.WriteLine($"- {contact.Name} ({contact.PhoneNumber})");
            }

            Console.WriteLine();
        }
    }

    private string GetAlphabetSectionKey(string name, string language)
    {
        char firstChar = name[0];

        if (char.IsDigit(firstChar))
        {
            return "Number";
        }

        if (language == "Ukrainian" && IsUkrainianLetter(firstChar))
        {
            return "Ukrainian";
        }

        if (IsEnglishLetter(firstChar))
        {
            return "English";
        }

        return "#";
    }

    private bool IsEnglishLetter(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }

    private bool IsUkrainianLetter(char c)
    {
        string ukrainianAlphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯабвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        return ukrainianAlphabet.Contains(c.ToString());
    }
}public class ContactsCollection
{
    private Dictionary<string, List<Contact>> contactsDictionary;

    public ContactsCollection()
    {
        contactsDictionary = new Dictionary<string, List<Contact>>();
        InitializeAlphabetSections();
    }

    private void InitializeAlphabetSections()
    {

        string[] alphabets = { "English", "Ukrainian", "#", "Number" };

        foreach (var alphabet in alphabets)
        {
            contactsDictionary.Add(alphabet, new List<Contact>());
        }
    }

    public void AddContact(string name, string phoneNumber, string language = "English")
    {

        string sectionKey = GetAlphabetSectionKey(name, language);

 
        contactsDictionary[sectionKey].Add(new Contact(name, phoneNumber));
    }

    public void DisplayContacts()
    {
        foreach (var section in contactsDictionary)
        {
            Console.WriteLine($"{section.Key}:");

            foreach (var contact in section.Value)
            {
                Console.WriteLine($"- {contact.Name} ({contact.PhoneNumber})");
            }

            Console.WriteLine();
        }
    }

    private string GetAlphabetSectionKey(string name, string language)
    {
        char firstChar = name[0];

        if (char.IsDigit(firstChar))
        {
            return "Number";
        }

        if (language == "Ukrainian" && IsUkrainianLetter(firstChar))
        {
            return "Ukrainian";
        }

        if (IsEnglishLetter(firstChar))
        {
            return "English";
        }

        return "#";
    }

    private bool IsEnglishLetter(char c)
    {
        return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
    }

    private bool IsUkrainianLetter(char c)
    {
        string ukrainianAlphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯабвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        return ukrainianAlphabet.Contains(c.ToString());
    }
}