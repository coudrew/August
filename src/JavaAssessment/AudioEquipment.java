package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class AudioEquipment extends RentalItem {
    private Connector connections;

    public AudioEquipment(){

    }
    public AudioEquipment(String id, Double price, Connector connector){
        this.connections = connector;
    }

    @Override
    public String retrieveSpecs() {
        return super.retrieveSpecs();
    }

    public Connector getConnections() {
        return connections;
    }

    public void setConnections(Connector connections) {
        this.connections = connections;
    }
    public String getConnectionString(){
        if(this.getConnections() == Connector.XLR){
            return "XLR";
        } else if(this.getConnections() == Connector.NL4){
            return "NL4";
        }else if(this.getConnections() == Connector.PHONO){
            return "Phono";
        }else if(this.getConnections() == Connector.PHONO_MINI){
            return "Phono Mini";
        }
        return "None";
    }
}
