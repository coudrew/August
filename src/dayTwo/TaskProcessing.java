package dayTwo;


import java.sql.SQLException;
import java.time.LocalDate;
import java.util.List;
import static dayTwo.generatedPeople.people;
/**
 * Created by student on 23-Aug-16.
 */
public class TaskProcessing {
    static MainWindow guiMain;

    static EmployeeDB db;

    static void prepareDb() throws Exception {
        db = new EmployeeDB();
        db.queryAll();
    }
    static void executeGUI(){
        WelcomeWindow gui = new WelcomeWindow();
    }

    static void loadData() throws SQLException{
        people.clear();
        db.queryAll();
    }

    static void newEmployee(List<String> data) throws SQLException {

        db.addEmployee(data);
        loadData();
    }
    static void createEmployee(List<String> data){

        String[] dob = data.get(4).split("-");
        String[] hireDate = data.get(7).split("-");

        Employee temp = new Employee(
                data.get(0),
                data.get(1),
                Short.parseShort(data.get(2)),
                Double.parseDouble(data.get(3)),
                LocalDate.of(Integer.parseInt(dob[0]), Integer.parseInt(dob[1]), Integer.parseInt(dob[2])),
                checkSex(data.get(5)),
                data.get(6),
                LocalDate.of(Integer.parseInt(hireDate[0]), Integer.parseInt(hireDate[1]), Integer.parseInt(hireDate[2])));
        people.add(temp);
    }
    static void printAll(){
        for(Person e : people){
            System.out.println(String.format("[%s] " + e, + people.indexOf(e)));
        }
    }
    static int searchByFirstName(String firstName){
        for (Person p : people){
            if (p.getFirstName().contains(firstName)){
                return people.indexOf(p);
            }
        }
        return -1;
    }

    static void editDetails(int index, List<String> data){
        if (index >= 0) {
            people.get(index).setFirstName(data.get(0));
            people.get(index).setLastName(data.get(1));
            people.get(index).setHeight(Short.parseShort(data.get(2)));
            people.get(index).setWeight(Double.parseDouble(data.get(3)));
            people.get(index).setBirthDate(LocalDate.of(
                    Integer.parseInt(data.get(4)),
                    Integer.parseInt(data.get(5)),
                    Integer.parseInt(data.get(6))));
            people.get(index).setSex(checkSex(data.get(7)));
            people.get(index).getEmployee().setPosition(data.get(8));
            people.get(index).getEmployee().setHireDate(
                    LocalDate.of(
                            Integer.parseInt(data.get(9)),
                            Integer.parseInt(data.get(10)),
                            Integer.parseInt(data.get(11)))
            );
        }
    }
    static SexType checkSex(String data){
        SexType sex;
        //System.out.println(data.get(7));
        if (data.charAt(0) == 'M'){
            sex = SexType.MALE;
        }else {
            sex = SexType.FEMALE;
        }
        return sex;
    }
    static void removeEmployee(int index){
        people.remove(index);
    }
}
