package JavaAssessment;

import javax.sound.sampled.*;
import java.util.List;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class TaskProcessing {
    static int orderNum = 0;
    static Order currentOrder;
    static Customer currentCustomer;

    static String getStanding(AccountStanding status){
        if (status == AccountStanding.PAID){
            return "Paid in full";
        } else if (status == AccountStanding.IN_ARREARS){
            return "This account is in arrears, payment due before order can be processed";
        } else if (status == AccountStanding.SUSPENDED){
            return "This account has been suspended, please contact our accounting department";
        }
        return "Account status not found, please contact Systems Administrator";
    }

    static void processOrderRequirements(){
        int powerNeeded = currentOrder.getRoomRequirements().getRoomLength() * currentOrder.getRoomRequirements().getRoomWidth();
        int ampNeeded = 0;
        System.out.println(currentOrder.getRoomRequirements());
        for (RentalItem item : MasterList.masterList){
           if (item.getClass() == Mixer.class) {
               Mixer mix = (Mixer)item;
               if (mix.getChannels() >= currentOrder.getRoomRequirements().getNumberOfInputs()) {
                   currentOrder.addGear(mix);
                   break;
               }
           }
        }
        for (RentalItem item : MasterList.masterList){
            if (item.getClass() == Speaker.class){
                Speaker speaker = (Speaker) item;
                if (speaker.getWattage() >= powerNeeded/2){
                    currentOrder.addGear(speaker);
                    ampNeeded += 1;
                    break;
                }
            }
        }

        if (ampNeeded == 0){
            for (RentalItem item : MasterList.masterList){
                if (item.getClass() == Amplifier.class){
                    Amplifier amplifier = (Amplifier)item;
                    if (amplifier.getWattage() >= powerNeeded){
                        currentOrder.addGear(amplifier);
                        ampNeeded += 1;
                        break;
                    }
                }
            }
        }
        for (RentalItem gear : currentOrder.getGearList()) {
            System.out.println(gear.retrieveSpecs());
        }
    }

    /*private static Amplifier getAmp() {

    }

    private static List<Cable> getCableList(RoomRequirements roomRequirements) {
    }

    private static Mixer getMixer(RoomRequirements roomRequirements) {
    }

    private static List<Speaker> getSpeakers(RoomRequirements roomRequirements) {

    }*/

}
