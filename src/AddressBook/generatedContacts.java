package AddressBook;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */
public class generatedContacts {
    public static List<Contact> contacts = new ArrayList<>();
    public static Contact contact1 = new Contact(new Person("Andrew","Couture", LocalDate.of(1979,5,13)),
            "07932428727",new Address("26 Orwell Court","Jerrard St.","SE137TA"));
    public static Contact contact2 = new Contact(new Person("Cletus","Couture", LocalDate.of(1948,10,3)),
            "9027366685", new Address("57", "Beachview Dr.","B1Y 1V6"));

    static void addContacts(){
        contacts.add(contact1);
        contacts.add(contact2);
    }
}
