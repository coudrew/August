package JavaAssessment;

import dayTwo.*;

import java.util.Scanner;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class CommandUI {

    static Scanner input = new Scanner(System.in);
    static String action;
    static void showMenu(){
        while (action != "X") {
            System.out.println("****** Welcome to Coudrew A/V ******");
            System.out.println("* Please Choose From the Following *");
            System.out.println("************************************");
            System.out.println("N) Create a new Order");
            System.out.println("V) View available Equipment");
            System.out.println("C) Register as a customer");
            System.out.println("X) Exit");
            System.out.println("************************************");
            String action = input.nextLine();

            switch (action) {
                case "N":
                    showNewOrderMenu();
                    break;
                case "V":
                    showViewEquipMenu();
                    break;
                case "C":
                    showRegisterCustomerMenu();
                    break;
                case "X":
                    System.out.println("See you next time, guy!");
                    Main.running = false;
                    return;
            }
        }
    }

    static void showNewOrderMenu(){
        while (action != "X") {
            System.out.println("************ New Order *************");
            System.out.println("* Please Choose From the Following *");
            System.out.println("************************************");
            System.out.println("N) New Order");
            System.out.println("V) View Current");
            System.out.println("X) Go Back to Main Menu");

            String action = input.nextLine();

            switch (action) {
                case "N":
                    createNewOrder();
                    break;
                case "V":
                    TaskProcessing.currentOrder.displayOrder();
                    break;
                case "X":
                    return;

            }
        }
    }

    static void showViewEquipMenu(){
        while (action != "X") {
            System.out.println("***** View Available Equipment *****");
            System.out.println("* Please Choose From the Following *");
            System.out.println("************************************");
            System.out.println("L) List All");
            System.out.println("S) Search by tag");
            System.out.println("X) Go Back to Main Menu");

            String action = input.nextLine();

            switch (action) {
                case "L":
                    MasterList.showMaster();
                    break;
                case "S":
                    System.out.println("Enter ID to search for:");
                    String id = input.nextLine();
                    MasterList.searchById(id);
                    break;
                case "X":
                    return;

            }
        }
    }

    static void showRegisterCustomerMenu(){
        while (action != "X") {
            System.out.println("****** Create Customer Account *****");
            System.out.println("* Please Choose From the Following *");
            System.out.println("************************************");
            System.out.println("C) Create Account");
            System.out.println("S) Show Account");
            System.out.println("X) Go Back to Main Menu");

            String action = input.nextLine();

            switch (action) {
                case "C":
                    createNewCustomer();
                    break;
                case "S":
                    TaskProcessing.currentCustomer.showCustomerDetails();
                    break;
                case "X":
                    return;

            }
        }
    }

    static void createNewOrder(){
        Customer currentCustomer;
        if (TaskProcessing.currentCustomer != null){
            currentCustomer = TaskProcessing.currentCustomer;
        } else {
            createNewCustomer();
            currentCustomer = TaskProcessing.currentCustomer;
        }

        System.out.println("Enter number of inputs required");
        int inputs = Integer.parseInt(input.nextLine());

        System.out.println("Enter room width");
        int roomWidth = Integer.parseInt(input.nextLine());

        System.out.println("Enter room length");
        int roomLength = Integer.parseInt(input.nextLine());

        System.out.println("Enter number of expected attendees");
        int expectedCrowd = Integer.parseInt(input.nextLine());

        TaskProcessing.currentOrder = new Order(TaskProcessing.orderNum, TaskProcessing.currentCustomer,
                new RoomRequirements(roomLength,roomWidth,expectedCrowd,inputs));
        TaskProcessing.processOrderRequirements();
    }

    static void createNewCustomer(){
        String name;
        String insured;
        String civic;
        String building;
        String street;
        String postal;

        System.out.println("Enter customer name:");
        name = input.nextLine();

        System.out.println("Are you insured for theft/damage in excess of £2500? (Y/N)");
        insured = input.nextLine();

        System.out.println("Enter Civic Number of New Customer's address");
        civic = input.nextLine();

        System.out.println("Enter building name (enter 'none' if not applicable)");
        building = input.nextLine();

        System.out.println("Enter street");
        street = input.nextLine();

        System.out.println("Enter postal code");
        postal = input.nextLine();

        TaskProcessing.currentCustomer = new Customer(name, AccountStanding.PAID, insured,
                new ContactInfo(civic,building,street,postal));

    }
}
