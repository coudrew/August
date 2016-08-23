package AddressBook;

import java.awt.*;
import java.time.LocalDate;

/**
 * Created by student on 23-Aug-16.
 */
public class AddressBook {
    //fields
    public static List contacts;
    //properties

    //main
    public static void main(String[] args){

    }
    //methods
    public static void addContact(){
        Person person = new Person("Andrew","Couture", LocalDate.of(1979,5,13));
        //Address homeAddress = new Address();
        Contact contact = new Contact(person);
    }
}
