package JavaAssessment;

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

    }

}
