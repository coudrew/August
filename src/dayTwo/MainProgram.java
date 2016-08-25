package dayTwo;
import AddressBook.*;

import static dayTwo.generatedPeople.people;
/**
 * Created by student on 23-Aug-16.
 */
public class MainProgram {
    static String[] arguments;
    public static void main(String[] args){
        arguments = args;
        generatedPeople.addPeople();
        //TaskProcessing.executeGUI();
        WelcomeWindow gui = new WelcomeWindow();
        //CommandGUI.display();
    }
}
