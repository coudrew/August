package AddressBook;
import static AddressBook.generatedContacts.contacts;
/**
 * Created by student on 23-Aug-16.
 */
public class Main {
    public static void main(String[] args){
        generatedContacts.addContacts();

        for (Contact c : contacts){
            System.out.println(c);
        }
    }
}
