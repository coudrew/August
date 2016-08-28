package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class ContactInfo {
    private String civicNumber;
    private String buildingName;
    private String streetName;
    private String postalCode;

    public ContactInfo(String civicNumber, String buildingName, String streetName, String postalCode){
        this.civicNumber = civicNumber;
        this.buildingName = buildingName;
        this.streetName = streetName;
        this.postalCode = postalCode;
    }

    public String getContactInfo(){
        return String.format("%s %s %s %s", this.getCivicNumber(), this.getBuildingName(), this.getStreetName(), this.getPostalCode());
    }
    public String getCivicNumber() {
        return civicNumber;
    }

    public void setCivicNumber(String civicNumber) {
        this.civicNumber = civicNumber;
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
}
