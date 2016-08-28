package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Speaker extends AudioEquipment {

    private int wattage;
    private SpkrSupport support;
    private int powerSource;

    public Speaker(String id, Double price, Connector connector, int wattage, SpkrSupport support, int powerSource){
        this.setId(id);
        this.setPrice(price);
        this.setWattage(wattage);
        this.setSupport(support);
        this.setPowerSource(powerSource);
    }

    @Override
    public String retrieveSpecs() {
        super.retrieveSpecs();
        return String.format("ID: %s Price: %s Connection: %s Watts: %s Support: %s Power Source: %s ",
                this.getId(),this.getPrice(),this.getConnectionString(),this.getWattage(), this.getSupportString(), this.getPowerSource());
    }

    public String getSupportString(){
        if(this.getSupport() == SpkrSupport.FLOWN){
            return "Flown";
        }else if(this.getSupport() == SpkrSupport.STANDS){
            return "Stands";
        }else if(this.getSupport() == SpkrSupport.WALL_MOUNT){
            return "Wall Mounted";
        }
        return "None";
    }
    public int getWattage() {
        return wattage;
    }

    public void setWattage(int wattage) {
        this.wattage = wattage;
    }

    public SpkrSupport getSupport() {
        return support;
    }

    public void setSupport(SpkrSupport support) {
        this.support = support;
    }

    public int getPowerSource() {
        return powerSource;
    }

    public void setPowerSource(int powerSource) {
        this.powerSource = powerSource;
    }
}
