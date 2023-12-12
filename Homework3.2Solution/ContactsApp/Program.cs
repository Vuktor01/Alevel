
ContactsCollection contactsCollection = new ContactsCollection();

contactsCollection.AddContact("John Doe", "+123456789", "English");
contactsCollection.AddContact("Іван Іванов", "+987654321", "Ukrainian");
contactsCollection.AddContact("Alice Smith", "+111111111", "English");
contactsCollection.AddContact("Богдан Богданов", "+999999999", "Ukrainian");
contactsCollection.AddContact("123 Contact", "+555555555");

contactsCollection.DisplayContacts();