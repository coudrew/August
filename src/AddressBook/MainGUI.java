package AddressBook;

import javax.swing.*;
import javax.swing.border.EtchedBorder;
import javax.swing.border.TitledBorder;
import java.awt.*;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by andrewrcouture on 2016-08-25.
 */
public class MainGUI {

    //declare labels
    private JLabel lblFirstName;
    private JLabel lblLastName;
    private JLabel lblBirthDate;
    private JLabel lblHomeAddress;
    private JLabel lblWorkAddress;
    private JLabel lblTwitterHandle;
    private JLabel lblMobilePhone;
    private JLabel lblWorkPhone;
    private JLabel lblPrimaryEmail;
    private JLabel lblSecondaryEmail;

    //declare text fields
    private JTextField txtFirstName;
    private JTextField txtLastName;
    private JTextField txtBirthDate;
    private JTextField txtHomeAddress;
    private JTextField txtWorkAddress;
    private JTextField txtTwitterHandle;
    private JTextField txtMobilePhone;
    private JTextField txtWorkPhone;
    private JTextField txtPrimaryEmail;
    private JTextField txtSecondaryEmail;

    //declare buttons
    private JButton btnUpdate;
    private JButton btnRemove;

    //declare menu
    private JMenuBar menuBar;
    private JMenu fileMenu;
    private JMenu editMenu;

    private JMenuItem newMenuItem, exitMenuItem, searchMenuItem;

    //panels
    private JPanel content;
    private JPanel listPanel;
    private JPanel fieldPanel;
    private JPanel inputPanel;
    private JPanel btnPanel;

    //list
    private JList contactList;
    private int index;

    public MainGUI(){

        //setup frame
        JFrame mainFrame = new JFrame("Contacts");
        mainFrame.setSize(800, 400);
        mainFrame.setResizable(false);
        Dimension dim = mainFrame.getToolkit().getScreenSize();
        mainFrame.setLocation(dim.width/2 - mainFrame.getWidth()/2, dim.height/2 - mainFrame.getHeight()/2);
        mainFrame.setBackground(Color.DARK_GRAY);
        mainFrame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);

        WindowListener wL = new WindowAdapter() {
            @Override
            public void windowClosing(WindowEvent e) {
                super.windowClosing(e);
            }
        };

        mainFrame.setJMenuBar(createMenuBar());

        content = (JPanel) mainFrame.getContentPane();
        content.setLayout(new GridLayout(1, 2, 5, 5));

        //listPanel setup
        listPanel = new JPanel();
        listPanel.setBorder(new EtchedBorder(EtchedBorder.LOWERED));
        JScrollPane scrollPane = new JScrollPane(createContactList());
        listPanel.add(scrollPane);
        listPanel.setPreferredSize(new Dimension(380, 335));
        listPanel.setVisible(true);

        //fieldPanel setup
        fieldPanel = new JPanel();
        TitledBorder title;
        title = BorderFactory.createTitledBorder("Contact Details");
        fieldPanel.setBorder(title);
        fieldPanel.add(createInputPanel());
        fieldPanel.add(createButtonPanel());
        fieldPanel.setVisible(true);

        //attach panels
        content.add(listPanel);
        content.add(fieldPanel);

        mainFrame.setVisible(true);
    }

    public JMenuBar createMenuBar(){
        menuBar = new JMenuBar();
        return menuBar;
    }

    public JPanel createInputPanel(){
        inputPanel = new JPanel();

        return inputPanel;
    }

    public JPanel createButtonPanel(){
        btnPanel = new JPanel();

        return btnPanel;
    }

    public JList createContactList(){
        JList contactList = new JList();

        return contactList;
    }
}
