package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Customer {

    private String name;
    private AccountStanding accountStanding;
    private String hasInsuranceBond;
    private ContactInfo contactInfo;

    public Customer(String name, AccountStanding accountStanding, String hasInsuranceBond, ContactInfo contactInfo){
        this.name = name;
        this.accountStanding = accountStanding;
        this.hasInsuranceBond = hasInsuranceBond;
        this.contactInfo = contactInfo;
    }

    public String getName() {
        return name;
    }

    public void showCustomerDetails(){
        System.out.println("Name: " + this.name);
        System.out.println("Account status: " + TaskProcessing.getStanding(this.accountStanding));
        System.out.println("Insurance: " + this.hasInsuranceBond);
        System.out.println("Contact: " + this.contactInfo.getContactInfo());
    }

    public void setName(String name) {
        this.name = name;
    }

    public AccountStanding getAccountStanding() {
        return accountStanding;
    }

    public void setAccountStanding(AccountStanding accountStanding) {
        this.accountStanding = accountStanding;
    }

    public String getHasInsuranceBond() {
        return hasInsuranceBond;
    }

    public void setHasInsuranceBond(String hasInsuranceBond) {
        this.hasInsuranceBond = hasInsuranceBond;
    }

    public ContactInfo getContactInfo() {
        return contactInfo;
    }

    public void setContactInfo(ContactInfo contactInfo) {
        this.contactInfo = contactInfo;
    }
}
