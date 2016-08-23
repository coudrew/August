package AddressBook;
import static AddressBook.generatedContacts.contacts;
//import java.time.LocalDate;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */
public class TaskProcessing {
    static void createContact(List<String> data){
        Contact temp = new Contact(
                new Person(data.get(0),data.get(1)),
                data.get(2),
                new Address(data.get(3), data.get(4), data.get(5))
        );
        generatedContacts.addContact(temp);
    }
    static void printAll(){
        for (Contact contact : contacts){
            System.out.println(contact);
        }
    }
    static String searchByFirst(String firstName){
        String foundName = "Not Found";
        for (Contact contact : contacts){
            String name = contact.getPerson().getFirstName();
            System.out.println(name);
            if (name == firstName){
                name =  contact.toString();
            }
        }
        return foundName;
    }
}
