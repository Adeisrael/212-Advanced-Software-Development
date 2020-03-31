import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.JLabel;

public class BusinessCon extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private JTextField textField_3;
	private JTextField textField_4;
	private JTextField textField_5;
	private JTextField textField_6;
	private JTextField textField_7;
	private JLabel lblNewLabel;
	private JLabel lblNewLabel_1;
	private JLabel lblNewLabel_2;
	private JLabel lblNewLabel_3;
	private JLabel lblNewLabel_4;
	private JLabel lblNewLabel_5;
	private JLabel lblNewLabel_6;
	private JLabel lblNewLabel_7;
	private JButton btnNewButton_1;
	private JButton btnNewButton_2;
	private JButton btnNewButton_3;
	private JButton btnNewButton_4;
	private JButton btnNewButton_5;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					BusinessCon frame = new BusinessCon();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the frame.
	 */
	public BusinessCon() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 798, 412);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		contentPane.setLayout(null);
		
		JScrollPane scrollPane = new JScrollPane();
		scrollPane.setBounds(25, 146, 669, 216);
		contentPane.add(scrollPane);
		
		table = new JTable();
		scrollPane.setViewportView(table);
		
		textField = new JTextField();
		textField.setBounds(77, 11, 86, 20);
		contentPane.add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.setBounds(77, 60, 86, 20);
		contentPane.add(textField_1);
		textField_1.setColumns(10);
		
		textField_2 = new JTextField();
		textField_2.setBounds(77, 104, 86, 20);
		contentPane.add(textField_2);
		textField_2.setColumns(10);
		
		textField_3 = new JTextField();
		textField_3.setBounds(255, 11, 86, 20);
		contentPane.add(textField_3);
		textField_3.setColumns(10);
		
		textField_4 = new JTextField();
		textField_4.setBounds(244, 60, 86, 20);
		contentPane.add(textField_4);
		textField_4.setColumns(10);
		
		textField_5 = new JTextField();
		textField_5.setBounds(244, 104, 86, 20);
		contentPane.add(textField_5);
		textField_5.setColumns(10);
		
		textField_6 = new JTextField();
		textField_6.setBounds(394, 11, 86, 20);
		contentPane.add(textField_6);
		textField_6.setColumns(10);
		
		textField_7 = new JTextField();
		textField_7.setBounds(394, 60, 86, 20);
		contentPane.add(textField_7);
		textField_7.setColumns(10);
		
		dbConn d=new dbConn();
		JButton btnNewButton = new JButton("Refresh");
		btnNewButton.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
				
			}
		});
		btnNewButton.setBounds(655, 112, 89, 23);
		contentPane.add(btnNewButton);
		
		lblNewLabel = new JLabel("First Name");
		lblNewLabel.setBounds(10, 14, 61, 14);
		contentPane.add(lblNewLabel);
		
		lblNewLabel_1 = new JLabel("Last Name");
		lblNewLabel_1.setBounds(10, 63, 61, 14);
		contentPane.add(lblNewLabel_1);
		
		lblNewLabel_2 = new JLabel("Email");
		lblNewLabel_2.setBounds(10, 107, 46, 14);
		contentPane.add(lblNewLabel_2);
		
		lblNewLabel_3 = new JLabel("Business Tel");
		lblNewLabel_3.setBounds(173, 14, 73, 14);
		contentPane.add(lblNewLabel_3);
		
		lblNewLabel_4 = new JLabel("Address 1");
		lblNewLabel_4.setBounds(173, 63, 61, 14);
		contentPane.add(lblNewLabel_4);
		
		lblNewLabel_5 = new JLabel("Address 2");
		lblNewLabel_5.setBounds(173, 107, 61, 14);
		contentPane.add(lblNewLabel_5);
		
		lblNewLabel_6 = new JLabel("City");
		lblNewLabel_6.setBounds(351, 14, 46, 14);
		contentPane.add(lblNewLabel_6);
		
		lblNewLabel_7 = new JLabel("PostCode");
		lblNewLabel_7.setBounds(338, 63, 59, 14);
		contentPane.add(lblNewLabel_7);
		
		btnNewButton_1 = new JButton("Update Selected");
		btnNewButton_1.setBounds(500, 10, 132, 23);
		contentPane.add(btnNewButton_1);
		
		btnNewButton_2 = new JButton("Save Selected");
		btnNewButton_2.setBounds(500, 44, 132, 23);
		contentPane.add(btnNewButton_2);
		
		btnNewButton_3 = new JButton("Delete Selected");
		btnNewButton_3.setBounds(500, 80, 132, 23);
		contentPane.add(btnNewButton_3);
		
		btnNewButton_4 = new JButton("Add New");
		btnNewButton_4.setBounds(655, 10, 101, 23);
		contentPane.add(btnNewButton_4);
		
		btnNewButton_5 = new JButton("Save New");
		btnNewButton_5.setBounds(655, 44, 101, 23);
		contentPane.add(btnNewButton_5);
	}
}
