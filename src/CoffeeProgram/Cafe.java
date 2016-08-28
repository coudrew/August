package CoffeeProgram;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class Cafe {
    private int beansInStock = 0;
    private int milkInStock = 0;

    //method overloading
    public Coffee brew(CoffeeType coffeeType){
        return brew(coffeeType, 1);
    }

    public Coffee brew(CoffeeType coffeeType, int quantity){
        requirePositive(quantity);

        int requiredBeans = coffeeType.getRequireBeans() * quantity;
        int requiredMilk = coffeeType.getRequireMilk() * quantity;

        if(requiredBeans > beansInStock || requiredMilk > milkInStock){
            throw new IllegalStateException("Insufficient beans or milk");
        }

        beansInStock -= requiredBeans;
        milkInStock -= requiredMilk;

        return new Coffee(coffeeType, requiredBeans, requiredMilk);
    }

    public void requirePositive(int value){
        if(value < 1){
            throw new IllegalArgumentException();
        }
    }

    public void restockBeans(int weightInGrams){
        requirePositive(weightInGrams);
        beansInStock += weightInGrams;
    }

    public void restockMilk(int weightInGrams){
        requirePositive(weightInGrams);
        milkInStock += weightInGrams;
    }
}
