package JavaAssessment;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class RoomRequirements {

    private int roomLength;
    private int roomWidth;
    private int expectedAttendance;
    private int numberOfInputs;

    public RoomRequirements(int roomLength, int roomWidth, int expectedAttendance, int numberOfInputs){
        this.roomLength = roomLength;
        this.roomWidth = roomWidth;
        this.expectedAttendance = expectedAttendance;
        this.numberOfInputs = numberOfInputs;
    }


    @Override
    public String toString() {
        return String.format("Length: %s Width: %s Attendees: %s Ins Required: %s", this.getRoomLength(), this.getRoomWidth(), this.getExpectedAttendance(), this.getNumberOfInputs());
    }

    public int getRoomLength() {
        return roomLength;
    }

    public void setRoomLength(int roomLength) {
        this.roomLength = roomLength;
    }

    public int getRoomWidth() {
        return roomWidth;
    }

    public void setRoomWidth(int roomWidth) {
        this.roomWidth = roomWidth;
    }

    public int getExpectedAttendance() {
        return expectedAttendance;
    }

    public void setExpectedAttendance(int expectedAttendance) {
        this.expectedAttendance = expectedAttendance;
    }

    public int getNumberOfInputs() {
        return numberOfInputs;
    }

    public void setNumberOfInputs(int numberOfInputs) {
        this.numberOfInputs = numberOfInputs;
    }
}
