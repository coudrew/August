package AddressBook;

import java.time.LocalDate;

/**
 * Created by student on 23-Aug-16.
 */
public class Person {
    //fields
    private String firstName;
    private String lastName;
    private LocalDate birthDate;

    //properties

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public LocalDate getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(LocalDate birthDate) {
        this.birthDate = birthDate;
    }

    //constructor

    public Person(String firstName, String lastName, LocalDate birthDate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public Person(String firstName, String lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    //methods
    @Override
    public String toString(){
        return String.format("Name: %s %s Dob: %s", this.firstName, this.lastName, this.getBirthDate());
    }
}
