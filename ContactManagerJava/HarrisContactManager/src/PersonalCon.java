import java.awt.BorderLayout;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import net.proteanit.sql.DbUtils;

import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.JLabel;
import javax.swing.JButton;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;

public class PersonalCon extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField textFname;
	private JTextField textHomTel;
	private JTextField textCity;
	private JTextField textLname;
	private JTextField textEmail;
	private JTextField textAddr1;
	private JTextField textAddr2;
	private JTextField textPostCode;
	private JButton btnUpdate;
	private JButton btnSave;
	private JButton btnDelete;
	private JButton btnAddNew;
	private JButton btnSaveNew;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					PersonalCon frame = new PersonalCon();
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
	public PersonalCon() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 785, 398);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		setContentPane(contentPane);
		
		JScrollPane scrollPane = new JScrollPane();
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {//display contents from rows in their respective textboxes
				textFname.setText(table.getValueAt(table.getSelectedRow(),1).toString());
				textLname.setText(table.getValueAt(table.getSelectedRow(),2).toString());
				textEmail.setText(table.getValueAt(table.getSelectedRow(),3).toString());
				textHomTel.setText(table.getValueAt(table.getSelectedRow(),4).toString());
				textAddr1.setText(table.getValueAt(table.getSelectedRow(),5).toString());
				textAddr2.setText(table.getValueAt(table.getSelectedRow(),6).toString());
				textCity.setText(table.getValueAt(table.getSelectedRow(),7).toString());
				textPostCode.setText(table.getValueAt(table.getSelectedRow(),8).toString());
			}
		});
		scrollPane.setViewportView(table);
		
		textFname = new JTextField();
		textFname.setColumns(10);
		
		textHomTel = new JTextField();
		textHomTel.setColumns(10);
		
		textCity = new JTextField();
		textCity.setColumns(10);
		
		JLabel lblNewLabel = new JLabel("First Name");
		
		JLabel lblNewLabel_1 = new JLabel("Last Name");
		
		JLabel lblNewLabel_2 = new JLabel("Email");
		
		textLname = new JTextField();
		textLname.setColumns(10);
		
		textEmail = new JTextField();
		textEmail.setColumns(10);
		
		textAddr1 = new JTextField();
		textAddr1.setColumns(10);
		
		textAddr2 = new JTextField();
		textAddr2.setColumns(10);
		
		textPostCode = new JTextField();
		textPostCode.setColumns(10);
		
		JLabel lblNewLabel_3 = new JLabel("Home Tel");
		
		JLabel lblNewLabel_4 = new JLabel("Address 1");
		
		JLabel lblNewLabel_5 = new JLabel("Address 2");
		
		JLabel lblNewLabel_6 = new JLabel("City");
		
		JLabel lblNewLabel_7 = new JLabel("PostCode");
		
		dbConn d=new dbConn();
		JButton btnRefresh = new JButton("Refresh");
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				btnUpdate.setEnabled(true);
				btnAddNew.setEnabled(true);
				btnDelete.setEnabled(true);
				btnSaveNew.setEnabled(false);
				btnSave.setEnabled(false);
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
			}
		});
		
		btnUpdate = new JButton("Update Selected");
		btnUpdate.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {//accessiblity of other buttons when Update button is clicked
				btnUpdate.setEnabled(false);
				btnAddNew.setEnabled(false);
				btnDelete.setEnabled(false);
				btnSaveNew.setEnabled(false);
				btnSave.setEnabled(true);
			}
		});
		
		btnSave = new JButton("Save Selected");
		btnSave.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				//update records in the database according to the data in textboxes when clicked
				String fname=textFname.getText();
				String lname=textLname.getText();
				String email=textEmail.getText();
				String hometel=textHomTel.getText();
				String addr1=textAddr1.getText();
				String addr2=textAddr2.getText();
				String city=textCity.getText();
				String postcode=textPostCode.getText();
				String id=table.getValueAt(table.getSelectedRow(), 0).toString();
				
				d.UpdatePersonal(fname, lname, email, hometel, addr1, addr2, city, postcode, id);
				
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllPersonal()));
				
			}
		});
		btnSave.setEnabled(false);//disable save selected button
		
		btnDelete = new JButton("Delete Seleceted");
		
		btnAddNew = new JButton("Add New");
		btnAddNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				btnUpdate.setEnabled(false);
				btnDelete.setEnabled(false);
				btnSaveNew.setEnabled(true);
				btnSave.setEnabled(false);
			}
		});
		
		btnSaveNew = new JButton("Save New");
		btnSaveNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
			}
		});
		btnSaveNew.setEnabled(false);//disable save new button
		
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(66)
							.addComponent(textFname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(lblNewLabel, GroupLayout.PREFERRED_SIZE, 75, GroupLayout.PREFERRED_SIZE))
					.addGap(10)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(61)
							.addComponent(textHomTel, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(lblNewLabel_3, GroupLayout.PREFERRED_SIZE, 69, GroupLayout.PREFERRED_SIZE))
					.addGap(6)
					.addComponent(lblNewLabel_6, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(textCity, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(14)
					.addComponent(btnUpdate, GroupLayout.PREFERRED_SIZE, 138, GroupLayout.PREFERRED_SIZE)
					.addGap(26)
					.addComponent(btnAddNew, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE))
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addComponent(lblNewLabel_1, GroupLayout.PREFERRED_SIZE, 75, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(66)
							.addComponent(textLname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
					.addGap(10)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addComponent(lblNewLabel_4, GroupLayout.PREFERRED_SIZE, 75, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(61)
							.addComponent(textAddr1, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
					.addGap(3)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addComponent(lblNewLabel_7, GroupLayout.PREFERRED_SIZE, 61, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(59)
							.addComponent(textPostCode, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
					.addGap(14)
					.addComponent(btnSave, GroupLayout.PREFERRED_SIZE, 138, GroupLayout.PREFERRED_SIZE)
					.addGap(26)
					.addComponent(btnSaveNew, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE))
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addComponent(lblNewLabel_2, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)
					.addGap(20)
					.addComponent(textEmail, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addComponent(lblNewLabel_5, GroupLayout.PREFERRED_SIZE, 75, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(61)
							.addComponent(textAddr2, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
					.addGap(162)
					.addComponent(btnDelete, GroupLayout.PREFERRED_SIZE, 138, GroupLayout.PREFERRED_SIZE)
					.addGap(26)
					.addComponent(btnRefresh, GroupLayout.PREFERRED_SIZE, 98, GroupLayout.PREFERRED_SIZE))
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(27)
					.addComponent(scrollPane, GroupLayout.DEFAULT_SIZE, 601, Short.MAX_VALUE)
					.addGap(131))
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(1)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addComponent(textFname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel))))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(1)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addComponent(textHomTel, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel_3))))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(4)
							.addComponent(lblNewLabel_6))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(1)
							.addComponent(textCity, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(btnUpdate)
						.addComponent(btnAddNew))
					.addGap(11)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(6)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel_1))
								.addComponent(textLname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(6)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel_4))
								.addComponent(textAddr1, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(6)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel_7))
								.addComponent(textPostCode, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
						.addComponent(btnSave)
						.addComponent(btnSaveNew))
					.addGap(8)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(18)
							.addComponent(lblNewLabel_2))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(15)
							.addComponent(textEmail, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(15)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel_5))
								.addComponent(textAddr2, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
						.addComponent(btnDelete)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(9)
							.addComponent(btnRefresh)))
					.addGap(8)
					.addComponent(scrollPane, GroupLayout.PREFERRED_SIZE, 227, GroupLayout.PREFERRED_SIZE))
		);
		contentPane.setLayout(gl_contentPane);
	}
}
