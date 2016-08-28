package CoffeeProgram;

import org.junit.*;
import org.hamcrest.*;
/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class CafeTest {

    public static final int NO_MILK = 0;
    public static final int NO_BEANS = 0;

    public static final int ESPRESSO_BEANS = CoffeeType.Espresso.getRequireBeans();

    private Cafe cafe;

    @Before
    public void before(){
        cafe = new Cafe();
    }

    @Test
    public void canBrewEspresso(){
        //Given
        withBeans();

        //when
        Coffee coffee = cafe.brew(CoffeeType.Espresso);

        //then
        //1- is it an espresso
        Assert.assertEquals("Wrong Coffee type", CoffeeType.Espresso, coffee.getType());



    }

    public void withBeans(){
        cafe.restockBeans(ESPRESSO_BEANS);
    }

}
