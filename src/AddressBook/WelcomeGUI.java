package AddressBook;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by andrewrcouture on 2016-08-25.
 */
public class WelcomeGUI extends JFrame {
    private JPanel contentPane;
    private JButton begin;
    private JLabel lblWelcome;

    public WelcomeGUI(){
        setTitle("Contact Manager");
        setSize(800, 400);
        setResizable(false);

        //center location
        Dimension dim = getToolkit().getScreenSize();
        setLocation(dim.width/2 - getWidth()/2, dim.height/2 - getHeight()/2);

        //set window close behaviour
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        //setup panel
        contentPane = new JPanel();
        contentPane.setBorder(new EmptyBorder(5,5,5,5));
        setContentPane(contentPane);
        contentPane.setLayout(null);

        //setup labels
        lblWelcome = new JLabel("Welcome");
        lblWelcome.setForeground(Color.DARK_GRAY);
        lblWelcome.setFont(new Font("Verdana", Font.BOLD, 36));
        lblWelcome.setBounds(300, 80, 400, 100);
        contentPane.add(lblWelcome);

        //setup buttons
        begin = new JButton("Begin");
        begin.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                MainGUI mainGUI = new MainGUI();
                setVisible(false);
            }
        });
        begin.setBounds(360, 200, 70, 25);
        contentPane.add(begin);

        setVisible(true);
    }
}
