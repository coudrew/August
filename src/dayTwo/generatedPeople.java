package dayTwo;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */
public class generatedPeople {
    /*public static Person andrew = new Person("Andrew", "Couture", (short)70, 210, LocalDate.of(1979,5,13),SexType.MALE);
    public static Person three = new Person("Ryan", "Couture", (short)70, 210, LocalDate.of(1979,5,13),SexType.MALE);*/

    public static Employee empOne = new Employee("Andrew", "Couture", (short)70, 210, LocalDate.of(1979,5,13),SexType.MALE, "Driver", LocalDate.of(2005, 7, 1));
    public static List<Employee> people = new ArrayList<>();

    static void addPeople(){
        //people.add(andrew);
        //people.add(three);
        people.add(empOne);
    }
}
