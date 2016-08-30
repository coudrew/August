package JavaAssessment;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Order {

    private int orderNumber;
    private Customer customer;
    private Double totalCost;
    private RoomRequirements roomRequirements;
    private List<RentalItem> gearList = new ArrayList<>();

    public Order(int orderNumber, Customer customer, RoomRequirements roomRequirements){
        this.orderNumber = orderNumber;
        this.customer = customer;
        this.roomRequirements = roomRequirements;
    }

    public void addGear(RentalItem gear){
        gearList.add(gear);
    }

    public void calculateTotalCost(){
        for (RentalItem item : gearList){
            totalCost += item.getPrice();
        }
    }

    public void displayOrder(){
        for (RentalItem item : gearList){
            System.out.println(item.retrieveSpecs());
        }
    }

    public int getOrderNumber() {
        return orderNumber;
    }

    public void setOrderNumber(int orderNumber) {
        this.orderNumber = orderNumber;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
    }

    public Double getTotalCost() {
        return totalCost;
    }

    public void setTotalCost(Double totalCost) {
        this.totalCost = totalCost;
    }

    public RoomRequirements getRoomRequirements() {
        return roomRequirements;
    }

    public void setRoomRequirements(RoomRequirements roomRequirements) {
        this.roomRequirements = roomRequirements;
    }

    public List<RentalItem> getGearList() {
        return gearList;
    }

    public void setGearList(List<RentalItem> gearList) {
        this.gearList = gearList;
    }
}
