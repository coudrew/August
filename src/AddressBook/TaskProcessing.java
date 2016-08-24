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
    static int searchByFirstName(String firstName){
        for (Contact c : contacts){
            if (c.getPerson().getFirstName().contains(firstName)){
                return contacts.indexOf(c);
            }
        }
        return -1;
    }

    static void editDetails(int index, List<String> data){
        contacts.get(index).getPerson().setFirstName(data.get(0));
        contacts.get(index).getPerson().setLastName(data.get(1));
        contacts.get(index).setMobilePhone(data.get(2));
        contacts.get(index).setHomeAddress(new Address(data.get(3), data.get(4), data.get(5)));
    }

    static void removeContact(int index){
        contacts.remove(index);
    }
}
