package dayTwo;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

/**
 * Created by andrewrcouture on 2016-08-24.
 */
public class WelcomeWindow extends JFrame {
    private JPanel contentPane;
    private JButton btnEnter;
    private JLabel lblWelcome;

    public WelcomeWindow(){
        setTitle("Welcome Frame");
        setSize(800, 400);
        setResizable(false);

        //center the frame
        //setLocationRelativeTo(null);
        Dimension dimension = getToolkit().getScreenSize();
        setLocation(dimension.width/2 - getWidth()/2, dimension.height/2 - getHeight()/2);
        //set window close operation
        setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);

        //setup panel
        contentPane = new JPanel();
        contentPane.setBorder(new EmptyBorder(5,5,5,5));
        setContentPane(contentPane);
        contentPane.setLayout(null);

        //create button
        btnEnter = new JButton("Start");
        btnEnter.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //load main frame
                MainWindow mainFrame = new MainWindow();
                setVisible(false);
            }
        });
        btnEnter.setBounds(360, 200, 70, 25);
        contentPane.add(btnEnter);

        //set welcome label
        lblWelcome = new JLabel("Welcome to Employee Program");
        lblWelcome.setForeground(Color.DARK_GRAY);
        lblWelcome.setFont(new Font("Verdana", Font.BOLD | Font.ITALIC, 18));
        lblWelcome.setBounds(240, 80, 400, 100);
        contentPane.add(lblWelcome);

        //set pane to be visible (defaults to invisible)
        setVisible(true);
    }
}
