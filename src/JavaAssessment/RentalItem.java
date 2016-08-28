package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class RentalItem {
    private String id;
    private Double price;
    private String tag;

    public RentalItem(){

    }
    public RentalItem(String id, Double price){
        this.id = id;
        this.price = price;
    }

    public String retrieveSpecs(){

        return "";
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }
}
