package JavaAssessment;

import java.util.ArrayList;
import java.util.List;

/**
 * Created by andrewrcouture on 2016-08-26.
 */
public class MasterList {
    private static List<RentalItem> masterList = new ArrayList<>();

    static void addToMaster(RentalItem item){
        masterList.add(item);
    }

    static void showMaster(){
        for (RentalItem item : masterList){
            System.out.println(item.retrieveSpecs());
        }
    }

    static void searchById(String id){
        for (RentalItem item : masterList){
            if (item.getId().contains(id)){
                System.out.println(item.retrieveSpecs());
            }
        }
    }

    static void generateMaster(){
        Mixer mix1 = new Mixer("Smackie Mini", 50.00, Connector.PHONO_MINI, 8, "YES");
        Mixer mix2 = new Mixer("Soundscrap Mega", 75.00, Connector.PHONO, 16, "YES");
        Mixer mix3 = new Mixer("Yamahonk Ultra", 150.00, Connector.XLR, 24, "NO");
        Mixer mix4 = new Mixer("All in a Heap Classic", 50.00, Connector.XLR, 32, "NO");

        Amplifier amp1 = new Amplifier("Naive Poser", 75.00, Connector.XLR,45);
        Amplifier amp2 = new Amplifier("Naive Pro", 175.00, Connector.XLR,100);
        Amplifier amp3 = new Amplifier("ARSE System 1K", 155.00, Connector.NL4,1000);
        Amplifier amp4 = new Amplifier("Kustom BS", 300.00, Connector.NL4,1200);

        Speaker speak1 = new Speaker("Smackie lil' Bastards", 35.00, Connector.PHONO_MINI, 40, SpkrSupport.STANDS, 1);
        Speaker speak2 = new Speaker("Dorkville Junk Blasters", 45.00, Connector.PHONO, 40, SpkrSupport.STANDS, 1);
        Speaker speak3 = new Speaker("ARC Overkill System", 400.00, Connector.NL4, 600, SpkrSupport.FLOWN, 0);
        Speaker speak4 = new Speaker("Generec Stacks", 335.00, Connector.XLR, 200, SpkrSupport.WALL_MOUNT, 0);

        Cable xlr1 = new Cable("XLR 25'", 5.00, Connector.XLR, 25);
        Cable xlr2 = new Cable("XLR 50'", 10.00, Connector.XLR, 50);
        Cable xlr3 = new Cable("XLR 100'", 15.00, Connector.XLR, 100);
        Cable nl41 = new Cable("NL4 10'", 10.00, Connector.NL4, 10);
        Cable nl42 = new Cable("NL4 20'", 15.00, Connector.NL4, 20);
        Cable nl43 = new Cable("NL4 100'", 25.00, Connector.NL4, 100);
        Cable phono1 = new Cable("Phono-1/4\" 10'", 5.00, Connector.PHONO, 10);
        Cable phono2 = new Cable("Phono-1/4\" 15'", 7.00, Connector.PHONO, 15);
        Cable phono3 = new Cable("Phono-1/4\" 25'", 10.00, Connector.PHONO, 25);
        Cable mini1 = new Cable("Phono-1/8\" 5'", 5.00, Connector.PHONO_MINI, 5);
        Cable mini2 = new Cable("Phono-1/8\" 10'", 7.00, Connector.PHONO_MINI, 10);

        addToMaster(mix1);
        addToMaster(mix2);
        addToMaster(mix3);
        addToMaster(mix4);
        addToMaster(speak1);
        addToMaster(speak2);
        addToMaster(speak3);
        addToMaster(speak4);
        addToMaster(amp1);
        addToMaster(amp2);
        addToMaster(amp3);
        addToMaster(amp4);
        addToMaster(xlr1);
        addToMaster(xlr2);
        addToMaster(xlr3);
        addToMaster(nl41);
        addToMaster(nl42);
        addToMaster(nl43);
        addToMaster(phono1);
        addToMaster(phono2);
        addToMaster(phono3);
        addToMaster(mini1);
        addToMaster(mini2);
    }
}
