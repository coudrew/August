package dayTwo;


import java.time.LocalDate;
import java.util.List;
import static dayTwo.generatedPeople.people;
/**
 * Created by student on 23-Aug-16.
 */
public class TaskProcessing {
    static MainWindow guiMain;

    static void executeGUI(){
        WelcomeWindow gui = new WelcomeWindow();
    }
    static void createEmployee(){

        String[] bDay = guiMain.getTxtBirthdate().toString().split("/");
        String[] hDay = guiMain.getTxtHireDate().toString().split("/");

        Employee temp = new Employee(
                guiMain.getTxtFirstName().toString(),
                guiMain.getTxtLastName().toString(),
                Short.parseShort(guiMain.getTxtHeight().toString()),
                Double.parseDouble(guiMain.getTxtWeight().toString()),
                LocalDate.of(Integer.parseInt(bDay[0]), Integer.parseInt(bDay[1]), Integer.parseInt(bDay[2])),
                checkSex(guiMain.getTxtSex().toString()),
                guiMain.getTxtPosition().toString(),
                LocalDate.of(Integer.parseInt(hDay[0]), Integer.parseInt(hDay[1]), Integer.parseInt(hDay[2])));
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
