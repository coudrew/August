package dayOne.primitives;


import java.util.Scanner;

/**
 * Created by student on 22-Aug-16.
 */
public class BinaryApplication {
    public static void main(String[] args){
        Scanner userInput = new Scanner(System.in);
        System.out.println("Enter a number in binary format to convert to decimal:");
        String input = userInput.nextLine();
        int result = 0;
        int multi = 1;
        for (int i = input.length() - 1; i >= 0; i--){
            if (input.charAt(i) == '1'){
                result += multi;
            }
            multi *= 2;
        }

        System.out.println(result);

    }

}
