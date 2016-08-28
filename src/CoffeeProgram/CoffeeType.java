package CoffeeProgram;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public enum CoffeeType {
    Espresso(7, 0),
    Latte(7,230),
    Filter(10, 0);

    private final int requireBeans;
    private final int requireMilk;

    CoffeeType(int requireBeans, int requireMilk){
        this.requireBeans = requireBeans;
        this.requireMilk = requireMilk;
    }

    public int getRequireBeans() {
        return requireBeans;
    }

    public int getRequireMilk() {
        return requireMilk;
    }
}
