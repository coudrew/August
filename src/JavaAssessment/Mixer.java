package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Mixer extends AudioEquipment {
    private int channels;
    private String onBoardFx;

    public Mixer(String id, Double price, Connector connector, int channels, String onBoardFx){
        this.setId(id);
        this.setPrice(price);
        this.setConnections(connector);
        this.setChannels(channels);
        this.setOnBoardFx(onBoardFx);
    }

    @Override
    public String retrieveSpecs() {
        return String.format("ID: %s Price: %s Connection: %s Number of channels: %s Onboard FX: %s ",
                this.getId(), this.getPrice(), this.getConnectionString(),this.getChannels(),this.getOnBoardFx());
    }

    public int getChannels() {
        return channels;
    }

    public void setChannels(int channels) {
        this.channels = channels;
    }

    public String getOnBoardFx() {
        return onBoardFx;
    }

    public void setOnBoardFx(String onBoardFx) {
        this.onBoardFx = onBoardFx;
    }
}
