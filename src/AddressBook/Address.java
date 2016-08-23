package AddressBook;

/**
 * Created by student on 23-Aug-16.
 */
public class Address {
    //fields
    private String civicNumber;
    private String suiteNumber;
    private String buildingName;
    private String streetName;
    private String postalCode;
    private String town;
    private String country;
    //properties

    public String getCivicNumber() {
        return civicNumber;
    }

    public void setCivicNumber(String civicNumber) {
        this.civicNumber = civicNumber;
    }

    public String getSuiteNumber() {
        return suiteNumber;
    }

    public void setSuiteNumber(String suiteNumber) {
        this.suiteNumber = suiteNumber;
    }

    public String getBuildingName() {
        return buildingName;
    }

    public void setBuildingName(String buildingName) {
        this.buildingName = buildingName;
    }

    public String getStreetName() {
        return streetName;
    }

    public void setStreetName(String streetName) {
        this.streetName = streetName;
    }

    public String getPostalCode() {
        return postalCode;
    }

    public void setPostalCode(String postalCode) {
        this.postalCode = postalCode;
    }

    public String getTown() {
        return town;
    }

    public void setTown(String town) {
        this.town = town;
    }

    public String getCountry() {
        return country;
    }

    public void setCountry(String country) {
        this.country = country;
    }

    //constructors

    public Address(String civicNumber, String streetName, String postalCode) {
        this.civicNumber = civicNumber;
        this.streetName = streetName;
        this.postalCode = postalCode;
    }

    public Address(String civicNumber, String suiteNumber, String buildingName, String streetName, String postalCode) {
        this.civicNumber = civicNumber;
        this.suiteNumber = suiteNumber;
        this.buildingName = buildingName;
        this.streetName = streetName;
        this.postalCode = postalCode;
    }
    //methods
    @Override
    public String toString(){
        return String.format("Address: %s %s %s", this.civicNumber, this.streetName, this.postalCode);
    }
}
