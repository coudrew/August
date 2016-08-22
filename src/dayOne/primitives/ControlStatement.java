package dayOne.primitives;

import java.io.IOException;
import java.util.Scanner;

/**
 * Created by student on 22-Aug-16.
 */
public class ControlStatement {

    public static void main(String[] args){
        //seasonCheck();
        //numberCheck();
        //charCheck();
        //menu();
        //iceCream();
        //worstCalculatorEver();
        //whileInfinite();
        ForLoopTest();
    }

    static void seasonCheck(){
        int month = 4;
        String season;
        if (month == 12 || month == 1 || month == 2)
            season = "Winter";
        else if (month ==3 || month == 4 || month == 5)
            season = "Spring";
        else if (month == 6 || month == 7 || month ==8)
            season = "Summer";
        else if (month == 9 || month == 10 || month == 11)
            season = "Fall";
        else
            season = "Smarch";

        System.out.println("April is in the " + season);
    }
    static void numberCheck(){
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a number between 0-2000");
        long num = input.nextLong();
        if (num < 100)
            System.out.println("Your number is equal to 100");
        else if (num < 500)
            System.out.println("Your number equals 500");
        else if (num < 1000)
            System.out.println("Your number equals 1000");
        else if (num > 1000)
            System.out.println("I know I said 0-2000, but I can't actually do more than 1000. It's a mareketing " +
                    "thing, sorry");
    }
    static void charCheck(){
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a character");
        char userIn = input.next().charAt(0);
        if (Character.isUpperCase(userIn))
            System.out.println("Your character is uppercase.");
        else if (Character.isLowerCase(userIn))
            System.out.println("Your character is lowercase.");
        else if (Character.isDigit(userIn))
            System.out.println("Your character is a digit.");
        else
            System.out.println("Your character is neither a letter or number");
    }
    static void menu(){
        try {
            char choice;
            do {
                System.out.println("Helper Menu.");
                System.out.println("1. if");
                System.out.println("2. switch");
                System.out.println("3. while");
                System.out.println("4. do-while");
                choice = (char) System.in.read();
            }
            while (choice < '1' || choice > '4');

            switch (choice){
                case '1':
                    System.out.println("if statement use boolean condition to branch flow");
                    break;
                case '2':
                    System.out.println("switch use constant expressions to compare");
                    break;
                case '3':
                    System.out.println("while is a simple loop that runs until boolean condition is met");
                    break;
                case '4':
                    System.out.println("do, just keep doing it");
                    break;
                default:
                    System.out.println("good job on finding default");
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
            //System.out.println("This is not a character we needed!");
        }
    }
    static void iceCream(){
        try {
            char choice;
            do {
                System.out.println("What size ice cream you want?");
                System.out.println("1- small");
                System.out.println("2- medium");
                System.out.println("3- large");
                System.out.println("4- yuge");
                choice = (char) System.in.read();
            }
            while (choice < '1' || choice > '4');

            switch (choice){
                case '1':
                    System.out.println("One small ice cream for 1.25");
                    break;
                case '2':
                    System.out.println("One medium ice cream for 2.25");
                    break;
                case '3':
                    System.out.println("One large ice cream for 3.25");
                    break;
                case '4':
                    System.out.println("Gonna be yuge! great size, friend of mine. 4.00, mostly hard working, some, " +
                            "not so much");
            }
        }
        catch (IOException e){
            System.out.println(e.getMessage());
        }
    }
    static void worstCalculatorEver(){
            Scanner userInput = new Scanner(System.in);
            System.out.println("Enter two integers and an operator, comma seperated:");
            String input = userInput.nextLine();
            String[] inputArr = input.split(",");
            switch (inputArr[2]) {
                case "+":
                    System.out.println(Integer.parseInt(inputArr[0]) + Integer.parseInt(inputArr[1]));
                    break;
                case "-":
                    System.out.println(Integer.parseInt(inputArr[0]) - Integer.parseInt(inputArr[1]));
                    break;
                case "*":
                    System.out.println(Integer.parseInt(inputArr[0]) * Integer.parseInt(inputArr[1]));
                    break;
                case "/":
                    System.out.println(Integer.parseInt(inputArr[0]) / Integer.parseInt(inputArr[1]));
                    break;
            }

    }
    static void whileInfinite(){
        int index = 0;

        outer:
        while (true){
            int value = ++index;
            System.out.println(value);
            if (value == 5){
                System.out.println("Found it!");
                break outer;
            }
            if (value == 10) {
                break;
            }
        }
    }
    static void ForLoopTest(){
        String[] data = {"This", "is", "a", "string."};
        for (int i = 0; i < data.length; i++){
            System.out.println(data[i]);
        }
        String result = "";
        for (String s : data){
            result += String.format(s + "_");
        }
        System.out.println(result);
    }

}
