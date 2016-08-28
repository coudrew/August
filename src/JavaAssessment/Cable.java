package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Cable extends AudioEquipment {

    private int length;

    public Cable(String id, Double price, Connector connector, int length){
        this.setId(id);
        this.setPrice(price);
        this.setConnections(connector);
        this.setLength(length);
    }

    @Override
    public String retrieveSpecs() {
        return String.format("ID: %s Price: %s Length: %s ft ",this.getId(),this.getPrice(),this.length);
    }

    public int getLength() {
        return length;
    }

    public void setLength(int length) {
        this.length = length;
    }
}

