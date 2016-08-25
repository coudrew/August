package dayTwo;

import static dayTwo.generatedPeople.people;
import javax.swing.*;
import javax.swing.border.EtchedBorder;
import javax.swing.border.TitledBorder;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import java.awt.*;
import java.awt.event.*;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by andrewrcouture on 2016-08-24.
 */
public class MainWindow implements ActionListener{
    //labels
    private JLabel lblFirstName;
    private JLabel lblLastName;
    private JLabel lblWeight;
    private JLabel lblHeight;
    private JLabel lblBirthdate;
    private JLabel lblSex;
    private JLabel lblPosition;
    private JLabel lblHireDate;

    //text fields
    private JTextField txtFirstName;
    private JTextField txtLastName;
    private JTextField txtWeight;
    private JTextField txtHeight;
    private JTextField txtBirthdate;
    private JTextField txtSex;
    private JTextField txtPosition;
    private JTextField txtHireDate;

    //buttons
    private JButton btnUpdate;
    private JButton btnRemove;

    //menu
    private JMenuBar menuBar;
    private JMenu fileMenu;
    private JMenu editMenu;
    private JMenuItem newMenuItem, exitMenuItem, indexMenuItem;

    //panels
    private JPanel content;
    private JPanel listPanel;
    private JPanel fieldPanel;
    private JPanel inputPanel;
    private JPanel btnPanel;

    //list
    private JList employeeList;
    private int employeeIndex;

    private boolean createNew;
    public MainWindow() {
        JFrame mainFrame = new JFrame("Employee DB");
        mainFrame.setSize(800, 400);
        mainFrame.setResizable(false);
        Dimension dimension = mainFrame.getToolkit().getScreenSize();
        mainFrame.setLocation(dimension.width/2 - mainFrame.getWidth()/2, dimension.height/2 - mainFrame.getHeight()/2);
        mainFrame.setBackground(Color.gray);
        mainFrame.setDefaultCloseOperation(WindowConstants.DO_NOTHING_ON_CLOSE);

        WindowListener l = new WindowAdapter() {
            public void windowClosing(WindowEvent e){
                int confirm = JOptionPane.showOptionDialog(mainFrame, "Are you sure?", "Exit Confirmation",
                        JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE,null,null,null);

                if(confirm == 0){
                    mainFrame.dispose();
                    System.exit(0);
                }
            }
        };


        //show this frame, attach closing listener

        mainFrame.setJMenuBar(createMenu());

        content = (JPanel) mainFrame.getContentPane();
        content.setLayout(new GridLayout(1, 2, 5, 5));

        prepareJList();

        //add list panel
        listPanel = new JPanel();
        listPanel.setBorder(new EtchedBorder(EtchedBorder.LOWERED));
        JScrollPane scrollPane = new JScrollPane(createEmployeeList());
        scrollPane.setPreferredSize(new Dimension(380, 335));
        listPanel.add(scrollPane);
        listPanel.setVisible(true);

        content.add(listPanel);

        //add field panel
        fieldPanel = new JPanel();
        TitledBorder title;
        title = BorderFactory.createTitledBorder("Employee Details");
        fieldPanel.setBorder(title);
        fieldPanel.add(createFieldsPanel(), BorderLayout.CENTER);
        fieldPanel.add(createButtonPanel(), BorderLayout.SOUTH);
        fieldPanel.setVisible(false);

        content.add(fieldPanel);

        mainFrame.addWindowListener(l);
        mainFrame.setVisible(true);
    }

    private JMenuBar createMenu(){
        //create menubar
        menuBar = new JMenuBar();

        //create file menu
        fileMenu = new JMenu("File");
        fileMenu.setMnemonic(KeyEvent.VK_F);

        newMenuItem = new JMenuItem("New");
        newMenuItem.setMnemonic(KeyEvent.VK_N);
        newMenuItem.addActionListener(this);

        exitMenuItem = new JMenuItem("Exit");
        exitMenuItem.setMnemonic(KeyEvent.VK_E);
        exitMenuItem.addActionListener(this);

        fileMenu.add(newMenuItem);
        fileMenu.add(exitMenuItem);
        menuBar.add(fileMenu);

        //create edit menu
        editMenu = new JMenu("Edit");
        editMenu.setMnemonic(KeyEvent.VK_D);

        indexMenuItem = new JMenuItem("Search");
        indexMenuItem.setMnemonic(KeyEvent.VK_S);
        indexMenuItem.addActionListener(this);

        editMenu.add(indexMenuItem);
        menuBar.add(editMenu);
        //
        return menuBar;
    }

    private void prepareJList(){
        employeeList = new JList();
        employeeList.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        employeeList.addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent e) {
                employeeIndex = employeeList.getSelectedIndex();
                if (people.size() > 0 && employeeIndex != -1){
                    fieldPanel.setVisible(true);
                    createNew = false;
                    btnUpdate.setText("Update");
                    loadEmployeeFields(employeeIndex);
                } else {
                    createNew = true;
                    btnUpdate.setText("New");
                    clearTextFields();
                }
            }
        });
    }

    private JList createEmployeeList(){
        DefaultListModel listModel = new DefaultListModel();
        if(people.size() > 0){
            for (Employee e : people){
                listModel.addElement(e);
            }
        }
        employeeList.setModel(listModel);
        return employeeList;
    }

    private JPanel createFieldsPanel(){
        inputPanel = new JPanel();
        inputPanel.setLayout(new GridLayout(0, 2, 5, 5));

        lblFirstName = new JLabel("First Name:");
        txtFirstName = new JTextField();
        inputPanel.add(lblFirstName);
        inputPanel.add(txtFirstName);

        lblLastName = new JLabel("Last Name:");
        txtLastName = new JTextField();
        inputPanel.add(lblLastName);
        inputPanel.add(txtLastName);

        lblHeight = new JLabel("Height:");
        txtHeight = new JTextField();
        inputPanel.add(lblHeight);
        inputPanel.add(txtHeight);

        lblWeight = new JLabel("Weight:");
        txtWeight = new JTextField();
        inputPanel.add(lblWeight);
        inputPanel.add(txtWeight);

        lblBirthdate = new JLabel("Birthdate (YYYY-MM-DD):");
        txtBirthdate = new JTextField();
        inputPanel.add(lblBirthdate);
        inputPanel.add(txtBirthdate);

        lblSex = new JLabel("Sex:");
        txtSex = new JTextField();
        inputPanel.add(lblSex);
        inputPanel.add(txtSex);

        lblPosition = new JLabel("Position:");
        txtPosition = new JTextField();
        inputPanel.add(lblPosition);
        inputPanel.add(txtPosition);

        lblHireDate = new JLabel("Hire Date (YYYY-MM-DD):");
        txtHireDate = new JTextField();
        inputPanel.add(lblHireDate);
        inputPanel.add(txtHireDate);

        return inputPanel;
    }

    private JPanel createButtonPanel(){
        btnPanel = new JPanel();
        btnPanel.setLayout(new FlowLayout(FlowLayout.RIGHT));

        btnUpdate = new JButton("Update");
        btnUpdate.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (people.size() < 1){
                    createNew = true;
                }
                if(createNew) {
                    TaskProcessing.createEmployee(getFieldsInfo());
                    createEmployeeList();
                    createNew = false;
                    //btnUpdate.setText("Update");
                    clearTextFields();
                }
                else {
                    TaskProcessing.editDetails(employeeIndex, getFieldsInfo());
                    createEmployeeList();
                    //btnUpdate.setText("New");
                }
            }
        });

        btnPanel.add(btnUpdate);

        btnRemove = new JButton("Remove");
        btnRemove.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                TaskProcessing.removeEmployee(employeeIndex);
                clearTextFields();
                createEmployeeList();
            }
        });
        btnPanel.add(btnRemove);

        return btnPanel;
    }
    @Override
    public void actionPerformed(ActionEvent e) {
        String action = e.getActionCommand();
        if ("New" == action){
            clearTextFields();
            createNew = true;
            btnUpdate.setText("New");
            listPanel.setVisible(true);
            fieldPanel.setVisible(true);
        } else if("Exit" == action){
            System.exit(0);
        } else if("Search" == action){
            String fnSearch = JOptionPane.showInputDialog("Enter First Name");
            employeeIndex = TaskProcessing.searchByFirstName(fnSearch);
            createNew = false;
            if (employeeIndex != -1) {
                fieldPanel.setVisible(true);
                loadEmployeeFields(employeeIndex);
            } else {
                JOptionPane.showMessageDialog(null, "Not Found");
            }
        }

    }

    private void clearTextFields(){
        txtFirstName.setText("");
        txtLastName.setText("");
        txtHeight.setText("");
        txtWeight.setText("");
        txtBirthdate.setText("");
        txtSex.setText("");
        txtPosition.setText("");
        txtHireDate.setText("");
    }

    private void loadEmployeeFields(int index){
        if (index >= 0) {
            txtFirstName.setText(people.get(index).getFirstName());
            txtLastName.setText(people.get(index).getLastName());
            txtHeight.setText(Short.toString(people.get(index).getHeight()));
            txtWeight.setText(Double.toString(people.get(index).getWeight()));
            txtBirthdate.setText(people.get(index).getBirthDate().toString());
            txtSex.setText(people.get(index).getSex().toString());
            txtPosition.setText(people.get(index).getPosition());
            txtHireDate.setText(people.get(index).getHireDate().toString());
        }
    }

    private List<String> getFieldsInfo(){
        List<String> data = new ArrayList<>();

        data.add(txtFirstName.getText());
        data.add(txtLastName.getText());
        data.add(txtHeight.getText());
        data.add(txtWeight.getText());

        String[] dob = txtBirthdate.getText().split("-");
        data.add(dob[0]);
        data.add(dob[1]);
        data.add(dob[2]);

        data.add(txtSex.getText());
        data.add(txtPosition.getText());

        String[] hireDate = txtHireDate.getText().split("-");
        data.add(hireDate[0]);
        data.add(hireDate[1]);
        data.add(hireDate[2]);

        return data;
    }

    public JTextField getTxtFirstName() {
        return txtFirstName;
    }

    public void setTxtFirstName(JTextField txtFirstName) {
        this.txtFirstName = txtFirstName;
    }

    public JTextField getTxtLastName() {
        return txtLastName;
    }

    public void setTxtLastName(JTextField txtLastName) {
        this.txtLastName = txtLastName;
    }

    public JTextField getTxtWeight() {
        return txtWeight;
    }

    public void setTxtWeight(JTextField txtWeight) {
        this.txtWeight = txtWeight;
    }

    public JTextField getTxtHeight() {
        return txtHeight;
    }

    public void setTxtHeight(JTextField txtHeight) {
        this.txtHeight = txtHeight;
    }

    public JTextField getTxtBirthdate() {
        return txtBirthdate;
    }

    public void setTxtBirthdate(JTextField txtBirthdate) {
        this.txtBirthdate = txtBirthdate;
    }

    public JTextField getTxtSex() {
        return txtSex;
    }

    public void setTxtSex(JTextField txtSex) {
        this.txtSex = txtSex;
    }

    public JTextField getTxtPosition() {
        return txtPosition;
    }

    public void setTxtPosition(JTextField txtPosition) {
        this.txtPosition = txtPosition;
    }

    public JTextField getTxtHireDate() {
        return txtHireDate;
    }

    public void setTxtHireDate(JTextField txtHireDate) {
        this.txtHireDate = txtHireDate;
    }


}
