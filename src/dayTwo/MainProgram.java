package dayTwo;
import AddressBook.*;

import static dayTwo.generatedPeople.people;
/**
 * Created by student on 23-Aug-16.
 */
public class MainProgram {
    public static void main(String[] args){
        generatedPeople.addPeople();
        TaskProcessing.executeGUI();

        //CommandGUI.display();
    }
}
