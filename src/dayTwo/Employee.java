package dayTwo;

import java.time.LocalDate;

/**
 * Created by student on 23-Aug-16.
 */
public class Employee extends Person{
    private String position;
    private LocalDate hireDate;



    Employee(String firstName, String lastName, short height, double weight, LocalDate birthDate, SexType sex,
             BloodType bloodType, String pos, LocalDate hireDate){
        super(firstName, lastName, height, weight, birthDate, sex, bloodType);
        this.position = pos;
        this.hireDate = hireDate;
    }

    @Override
    public String toString(){
        return String.format("Employee Name: %s %s %s", super.toString(), this.position, this.hireDate);
    }
}
