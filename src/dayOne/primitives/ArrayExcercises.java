package dayOne.primitives;

/**
 * Created by student on 22-Aug-16.
 */
public class ArrayExcercises {

    public static void main(String[] args){
        int[] data1 = {6,2,3,4,5,6};
        int[] data2 = {6,2,3,4,5,1};
        int[] data3 = maxEnd3(data2);
        int[] data4 = {2,2,2,13,2,13,2};
        System.out.println(firstLast6(data1));
        System.out.println(sameFirstLast(data1));
        System.out.println(commonEnd(data1, data2));
        for (int j=0; j<data3.length; j++){
            System.out.println(data3[j]);
        }
        System.out.println(has23(data2));
        System.out.println(has23(data3));
        System.out.println(evenInts(data1));
        System.out.println(bigDiff(data1));
        System.out.println(sum13(data4));
    }

    static boolean firstLast6(int[] data){
        return (data[0] == 6) || (data[data.length - 1] == 6);
    }
    static boolean sameFirstLast(int[] data){
        return (data.length > 1) && (data[0] == data[data.length-1]);
    }
    static boolean commonEnd(int[] data1, int[] data2){
        return ((data1[0] == data2[0]) || (data1[data1.length-1] == data2[data2.length-1])) && (data1.length > 1 &&
                data2.length >1);
    }
    static int[] maxEnd3(int[] data){

        if (data[0] > data[data.length-1]){

            int[] alteredArr = {data[0], data[0], data[0]};
            return alteredArr;
        } else {
            int[] alteredArr = {data[data.length - 1], data[data.length - 1], data[data.length - 1]};
            return alteredArr;
        }

    }
    static boolean has23(int[] data){
        for (int i=0; i<data.length; i++){
            if (data[i] == 2 || data[i] == 3){
                return true;
            }
        }
        return false;
    }
    static int evenInts(int[] data){
        int totalInts = 0;
        for (int i=0; i<data.length; i++){
            if (data[i] % 2 == 0){
                totalInts++;
            }
        }
        return totalInts;
    }
    static int bigDiff(int[] data){
        int currentMax = data[0];
        int currentMin = data[0];
        for (int i=1; i<data.length; i++){
            currentMax = data[i] >= currentMax ? data[i] : currentMax;
            currentMin = data[i] <= currentMin ? data[i] : currentMin;
        }
        return currentMax - currentMin;
    }
    static int sum13(int[] data){
        int total = 0;
        for (int i=0; i<data.length;){
            if (data[i] == 13){
                if (i + 2 > data.length-1){
                    break;
                }
                i += 2;
            } else {
                total += data[i];
                i++;
            }
        }
        return total;
    }
}
