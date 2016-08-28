package dayTwo;

import static dayTwo.generatedPeople.people;
/**
 * Created by student on 23-Aug-16.
 */
public class MainProgram {
    static String[] arguments;
    public static void main(String[] args) throws Exception {
        arguments = args;
        //generatedPeople.addPeople();
        //TaskProcessing.executeGUI();
        TaskProcessing.prepareDb();
        WelcomeWindow gui = new WelcomeWindow();
        //CommandGUI.display();
    }
}
