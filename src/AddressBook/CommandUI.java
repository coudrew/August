package AddressBook;

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

        List<Contact> tempData = new ArrayList<>();

        switch (choice){
            case 1:
                TaskProcessing.createContact(inputScreen());
                display();
            case 2:
            case 3:
            case 4:
                TaskProcessing.printAll();
                display();
            case 5:
                System.out.println("Enter First Name to search for:");
                String nameSearchParam;
                nameSearchParam = input.next();
                System.out.println(TaskProcessing.searchByFirst(nameSearchParam));
                display();
            case 6:
                break;
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

}
