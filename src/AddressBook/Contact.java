package AddressBook;

/**
 * Created by student on 23-Aug-16.
 */
public class Contact {
    //fields
    private Person person;
    private Address homeAddress;
    private Address workAddress;
    private String twitterHandle;
    private String mobilePhone;
    private String workPhone;
    private String primaryEmail;
    //properties

    public Person getPerson() {
        return person;
    }

    public void setPerson(Person person) {
        this.person = person;
    }

    public Address getHomeAddress() {
        return homeAddress;
    }

    public void setHomeAddress(Address homeAddress) {
        this.homeAddress = homeAddress;
    }

    public Address getWorkAddress() {
        return workAddress;
    }

    public void setWorkAddress(Address workAddress) {
        this.workAddress = workAddress;
    }

    public String getTwitterHandle() {
        return twitterHandle;
    }

    public void setTwitterHandle(String twitterHandle) {
        this.twitterHandle = twitterHandle;
    }

    public String getMobilePhone() {
        return mobilePhone;
    }

    public void setMobilePhone(String mobilePhone) {
        this.mobilePhone = mobilePhone;
    }

    public String getWorkPhone() {
        return workPhone;
    }

    public void setWorkPhone(String workPhone) {
        this.workPhone = workPhone;
    }

    public String getPrimaryEmail() {
        return primaryEmail;
    }

    public void setPrimaryEmail(String primaryEmail) {
        this.primaryEmail = primaryEmail;
    }

    //constructors

    public Contact(Person person) {
        this.person = person;
    }

    public Contact(Person person, String mobilePhone, Address homeAddress) {
        this.person = person;
        this.mobilePhone = mobilePhone;
        this.homeAddress = homeAddress;
    }
    //methods
    @Override
    public String toString(){
        return String.format("Contact: %s %s %s", this.person, this.mobilePhone, this.homeAddress);
    }
}
