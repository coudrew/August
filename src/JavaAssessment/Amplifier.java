package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Amplifier extends AudioEquipment {
    private int wattage;

    public Amplifier(String id, Double price, Connector connector, int wattage){
        this.setId(id);
        this.setPrice(price);
        this.setConnections(connector);
        this.setWattage(wattage);
    }

    @Override
    public String retrieveSpecs() {
        super.retrieveSpecs();
        return String.format("ID: %s Price: %s Connection: %s Watts: %s", this.getId(),
                this.getPrice(), this.getConnections(), this.getWattage());
    }

    public int getWattage() {
        return wattage;
    }

    public void setWattage(int wattage) {
        this.wattage = wattage;
    }
}
