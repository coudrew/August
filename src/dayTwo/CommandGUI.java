package dayTwo;

import static dayTwo.generatedPeople.people;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by student on 23-Aug-16.
 */
public class CommandGUI {
    static Scanner input = new Scanner(System.in);
    static void display(){
        int choice;
        do {
            System.out.println("Welcome to Employee Database");
            System.out.println("1. Add an Employee");
            System.out.println("2. Edit an Employee");
            System.out.println("3. Remove an Employee");
            System.out.println("4. List all Employee");
            System.out.println("5. Search by First Name");
            System.out.println("6. Exit");
            System.out.println();
            System.out.println("Enter between 1-6: ");
            //read input
            choice = input.nextInt();
        } while (choice < 1 || choice > 6);

        List<String> tempData = new ArrayList<>();
        int index;

        switch (choice) {
            case 1:
                TaskProcessing.createEmployee(inputScreen());
                display();
            case 2:
                index = findFirstName();
                tempData = inputScreen();
                TaskProcessing.editDetails(index, tempData);
                display();
            case 3:
                TaskProcessing.removeEmployee(requestIndex());
                display();
            case 4:
                TaskProcessing.printAll();
                display();
            case 5:
                index = findFirstName();
                System.out.println(people.get(index));
                display();
            case 6:
                break;
        }
    }

    static List<String> inputScreen(){
        List<String> employeeData = new ArrayList<>();

        input.nextLine();
        System.out.print("Enter First Name: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Last Name: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Height: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Weight: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter DOB (YYYY/MM/DD)): ");
        String dob = input.nextLine();
        String[] dobData = dob.split("/");
        //LocalDate dobDate = LocalDate.of(dobData[0],dobData[1],dobData[2]);
        for (int i=0; i<dobData.length; i++){
          employeeData.add(dobData[i]);
        }

        System.out.print("Enter Sex M/F: ");
        employeeData.add(input.nextLine());

        /*System.out.print("Enter Blood Type (A/B/AB/O/Rhesus Negative): ");
        employeeData.add(input.nextLine());*/

        System.out.print("Enter Position: ");
        employeeData.add(input.nextLine());

        System.out.print("Enter Hire Date (YYYY/MM/DD): ");
        String hireDate = input.nextLine();
        String[] hireDateData = hireDate.split("/");
        //LocalDate dobDate = LocalDate.of(dobData[0],dobData[1],dobData[2]);
        for (int i=0; i<hireDateData.length; i++){
            employeeData.add(hireDateData[i]);
        }

        return employeeData;
    }

    static int findFirstName(){
        System.out.print("Enter first name:");
        String firstName = input.next();
        return TaskProcessing.searchByFirstName(firstName);
    }
    static int requestIndex(){
        System.out.print("Enter Employee index to remove: ");
        return input.nextInt();
    }

}
