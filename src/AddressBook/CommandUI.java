package AddressBook;
import static AddressBook.generatedContacts.contacts;
import dayTwo.*;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by student on 23-Aug-16.
 */
public class CommandUI {
    static Scanner input = new Scanner(System.in);

    static void display(){
        int choice;
        do {
            System.out.println("Contacts Menu");
            System.out.println("1 Add Contact");
            System.out.println("2 Edit Contact");
            System.out.println("3 Remove Contact");
            System.out.println("4 View Contacts");
            System.out.println("5 Search by First Name");
            System.out.println("6 Exit");
            System.out.println();
            choice = input.nextInt();
        } while (choice < 1 || choice > 6);

        List<String> tempData = new ArrayList<>();
        int index;
        switch (choice){
            case 1:
                TaskProcessing.createContact(inputScreen());
                break;
            case 2:
                index = findFirstName();
                tempData = inputScreen();
                TaskProcessing.editDetails(index, tempData);
                break;
            case 3:
                System.out.println("Remove contact (CAN NOT BE UNDONE)");
                index = findFirstName();
                TaskProcessing.removeContact(index);
                break;
            case 4:
                TaskProcessing.printAll();
                break;
            case 5:
                index = findFirstName();
                System.out.println(contacts.get(index));
                break;
            case 6:
                Main.running = false;
                return;
        }
    }
    static List<String> inputScreen(){
        List<String> contactData = new ArrayList<>();
        input.nextLine();

        System.out.println("Enter First Name:");
        contactData.add(input.nextLine());

        System.out.println("Enter Last Name:");
        contactData.add(input.nextLine());

        System.out.println("Enter Mobile Phone:");
        contactData.add(input.nextLine());

        System.out.println("Enter Civic Address #:");
        contactData.add(input.nextLine());

        System.out.println("Enter Street:");
        contactData.add(input.nextLine());

        System.out.println("Enter Postal Code:");
        contactData.add(input.nextLine());

        return contactData;
    }
    static int findFirstName(){
        System.out.print("Enter First Name to search for:");
        String firstName = input.next();
        return TaskProcessing.searchByFirstName(firstName);
    }

}
