package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Main {

    public static boolean running = true;
    public static void main(String[] args){
        MasterList.generateMaster();
        while (running){
            CommandUI.showMenu();
        }
    }
}
