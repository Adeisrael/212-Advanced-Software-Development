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
import javax.swing.JOptionPane;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.LayoutStyle.ComponentPlacement;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

public class BusinessCon extends JFrame {

	private JPanel contentPane;
	private JTable table;
	private JTextField textFname;
	private JTextField textLname;
	private JTextField textEmail;
	private JTextField textBusTel;
	private JTextField textAddr1;
	private JTextField textAddr2;
	private JTextField textCity;
	private JTextField textPostCode;
	private JLabel lblNewLabel;
	private JLabel lblNewLabel_1;
	private JLabel lblNewLabel_2;
	private JLabel lblNewLabel_3;
	private JLabel lblNewLabel_4;
	private JLabel lblNewLabel_5;
	private JLabel lblNewLabel_6;
	private JLabel lblNewLabel_7;
	private JButton btnUpdate;
	private JButton btnSave;
	private JButton btnDelete;
	private JButton btnAdd;
	private JButton btnSaveNew;

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
		
		JScrollPane scrollPane = new JScrollPane();
		
		table = new JTable();
		table.addMouseListener(new MouseAdapter() {
			@Override
			public void mousePressed(MouseEvent e) {//display contents from rows in their respective textboxes 
				textFname.setText(table.getValueAt(table.getSelectedRow(),1).toString());
				textLname.setText(table.getValueAt(table.getSelectedRow(),2).toString());
				textEmail.setText(table.getValueAt(table.getSelectedRow(),3).toString());
				textBusTel.setText(table.getValueAt(table.getSelectedRow(),4).toString());
				textAddr1.setText(table.getValueAt(table.getSelectedRow(),5).toString());
				textAddr2.setText(table.getValueAt(table.getSelectedRow(),6).toString());
				textCity.setText(table.getValueAt(table.getSelectedRow(),7).toString());
				textPostCode.setText(table.getValueAt(table.getSelectedRow(),8).toString());
			}
		});
		scrollPane.setViewportView(table);
		
		textFname = new JTextField();
		textFname.setColumns(10);
		textFname.setEnabled(false);
		
		textLname = new JTextField();
		textLname.setColumns(10);
		textLname.setEnabled(false);
		
		textEmail = new JTextField();
		textEmail.setColumns(10);
		textEmail.setEnabled(false);
		
		textBusTel = new JTextField();
		textBusTel.setColumns(10);
		textBusTel.setEnabled(false);
		
		
		textAddr1 = new JTextField();
		textAddr1.setColumns(10);
		textAddr1.setEnabled(false);
		
		textAddr2 = new JTextField();
		textAddr2.setColumns(10);
		textAddr2.setEnabled(false);
		
		textCity = new JTextField();
		textCity.setColumns(10);
		textCity.setEnabled(false);
		
		textPostCode = new JTextField();
		textPostCode.setColumns(10);
		textPostCode.setEnabled(false);
		
		dbConn d=new dbConn();
		JButton btnRefresh = new JButton("Refresh");
		btnRefresh.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				btnUpdate.setEnabled(true);
				btnAdd.setEnabled(true);
				btnDelete.setEnabled(true);
				btnSaveNew.setEnabled(false);
				btnSave.setEnabled(false);
				//displays records in the business contacts table
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));
								
				//Clear textboxes after Save New is clicked
				textFname.setText("");
				textLname.setText("");
				textEmail.setText("");
				textBusTel.setText("");
				textAddr1.setText("");
				textAddr2.setText("");
				textCity.setText("");
				textPostCode.setText("");
				
				//Disable text boxes
				textFname.setEnabled(false);
				textLname.setEnabled(false);
				textEmail.setEnabled(false);
				textBusTel.setEnabled(false);
				textAddr1.setEnabled(false);
				textAddr2.setEnabled(false);
				textCity.setEnabled(false);
				textPostCode.setEnabled(false);
				
			}
		});
		
		lblNewLabel = new JLabel("First Name");
		
		lblNewLabel_1 = new JLabel("Last Name");
		
		lblNewLabel_2 = new JLabel("Email");
		
		lblNewLabel_3 = new JLabel("Business Tel");
		
		lblNewLabel_4 = new JLabel("Address 1");
		
		lblNewLabel_5 = new JLabel("Address 2");
		
		lblNewLabel_6 = new JLabel("City");
		
		lblNewLabel_7 = new JLabel("PostCode");
		
		btnUpdate = new JButton("Update Selected");
		btnUpdate.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				//accessiblity of buttons when update selected is clicked
				btnUpdate.setEnabled(false);
				btnAdd.setEnabled(false);
				btnDelete.setEnabled(false);
				btnSaveNew.setEnabled(false);
				btnSave.setEnabled(true);
				
				//ENABLE TEXTBOXES
				textFname.setEnabled(true);
				textLname.setEnabled(true);
				textEmail.setEnabled(true);
				textBusTel.setEnabled(true);
				textAddr1.setEnabled(true);
				textAddr2.setEnabled(true);
				textCity.setEnabled(true);
				textPostCode.setEnabled(true);
			}
		});
		
		btnSave = new JButton("Save Selected");
		btnSave.setEnabled(false);
		btnSave.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				//update records in the database according to the data in textboxes when clicked
				String fname=textFname.getText();
				String lname=textLname.getText();
				String email=textEmail.getText();
				String bustel=textBusTel.getText();
				String addr1=textAddr1.getText();
				String addr2=textAddr2.getText();
				String city=textCity.getText();
				String postcode=textPostCode.getText();
				String id=table.getValueAt(table.getSelectedRow(), 0).toString();
				
				d.UpdateBusiness(fname, lname, email, bustel, addr1, addr2, city, postcode, id);//parameters to be updated
				
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));//displays table with records
			}
						
		});
		
		btnDelete = new JButton("Delete Selected");
		btnDelete.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {//Delete Records 
				String id=table.getValueAt(table.getSelectedRow(), 0).toString();
				d.DeleteBusiness(id);//delete record through business id 
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));//show business table 
			}
		});
		
		btnAdd = new JButton("Add New");
		btnAdd.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				btnUpdate.setEnabled(false);
				btnDelete.setEnabled(false);
				btnSaveNew.setEnabled(true);
				btnSave.setEnabled(false);
				
				textFname.setEnabled(true);//enable text boxes
				textLname.setEnabled(true);
				textEmail.setEnabled(true);
				textBusTel.setEnabled(true);
				textAddr1.setEnabled(true);
				textAddr2.setEnabled(true);
				textCity.setEnabled(true);
				textPostCode.setEnabled(true);
			}
		});
		
		btnSaveNew = new JButton("Save New");
		btnSaveNew.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				
				if(textFname.getText() == "") {//if else condition for data in empty textboxes
				
				//Add new records when add new button is clicked
				String fname=textFname.getText();
				String lname=textLname.getText();
				String email=textEmail.getText();
				String bustel=textBusTel.getText();
				String addr1=textAddr1.getText();
				String addr2=textAddr2.getText();
				String city=textCity.getText();
				String postcode=textPostCode.getText();
				d.AddBusiness(fname, lname, email, bustel, addr1, addr2, city, postcode);
				table.setModel(DbUtils.resultSetToTableModel(d.GetAllBusiness()));//show business table
				
				//Clear textboxes after Save New is clicked
				textFname.setText("");
				textLname.setText("");
				textEmail.setText("");
				textBusTel.setText("");
				textAddr1.setText("");
				textAddr2.setText("");
				textCity.setText("");
				textPostCode.setText("");
				}
				
				else JOptionPane.showMessageDialog(null, "Please Insert Records");//Error message for empty firstname textbox
			}
		});
		btnSaveNew.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				 
			}
		});
		btnSaveNew.setEnabled(false);
		GroupLayout gl_contentPane = new GroupLayout(contentPane);
		gl_contentPane.setHorizontalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addComponent(lblNewLabel, GroupLayout.PREFERRED_SIZE, 61, GroupLayout.PREFERRED_SIZE)
					.addGap(6)
					.addComponent(textFname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblNewLabel_3, GroupLayout.PREFERRED_SIZE, 73, GroupLayout.PREFERRED_SIZE)
					.addGap(9)
					.addComponent(textBusTel, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(43)
							.addComponent(textCity, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addComponent(lblNewLabel_6, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE))
					.addGap(36)
					.addComponent(btnUpdate, GroupLayout.PREFERRED_SIZE, 132, GroupLayout.PREFERRED_SIZE)
					.addGap(18)
					.addComponent(btnAdd, GroupLayout.PREFERRED_SIZE, 101, GroupLayout.PREFERRED_SIZE)
					.addContainerGap())
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addComponent(lblNewLabel_1, GroupLayout.PREFERRED_SIZE, 61, GroupLayout.PREFERRED_SIZE)
					.addGap(6)
					.addComponent(textLname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblNewLabel_4, GroupLayout.PREFERRED_SIZE, 61, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(textAddr1, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(8)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addComponent(lblNewLabel_7, GroupLayout.PREFERRED_SIZE, 59, GroupLayout.PREFERRED_SIZE)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(56)
							.addComponent(textPostCode, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)))
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(36)
							.addComponent(btnSave, GroupLayout.PREFERRED_SIZE, 132, GroupLayout.PREFERRED_SIZE)
							.addGap(18)
							.addComponent(btnSaveNew, GroupLayout.PREFERRED_SIZE, 101, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(38)
							.addComponent(btnDelete, GroupLayout.PREFERRED_SIZE, 132, GroupLayout.PREFERRED_SIZE)))
					.addContainerGap())
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addComponent(lblNewLabel_2, GroupLayout.PREFERRED_SIZE, 46, GroupLayout.PREFERRED_SIZE)
					.addGap(21)
					.addComponent(textEmail, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(lblNewLabel_5, GroupLayout.PREFERRED_SIZE, 61, GroupLayout.PREFERRED_SIZE)
					.addGap(10)
					.addComponent(textAddr2, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
					.addGap(348)
					.addComponent(btnRefresh, GroupLayout.PREFERRED_SIZE, 89, GroupLayout.PREFERRED_SIZE)
					.addContainerGap())
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(20)
					.addComponent(scrollPane, GroupLayout.DEFAULT_SIZE, 669, Short.MAX_VALUE)
					.addGap(83))
		);
		gl_contentPane.setVerticalGroup(
			gl_contentPane.createParallelGroup(Alignment.LEADING)
				.addGroup(gl_contentPane.createSequentialGroup()
					.addGap(5)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(4)
							.addComponent(lblNewLabel))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(1)
							.addComponent(textFname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(4)
							.addComponent(lblNewLabel_3))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(1)
							.addComponent(textBusTel, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(1)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addComponent(textCity, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(3)
									.addComponent(lblNewLabel_6))))
						.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
							.addComponent(btnAdd)
							.addComponent(btnUpdate)))
					.addGap(11)
					.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
								.addGroup(gl_contentPane.createParallelGroup(Alignment.BASELINE)
									.addComponent(btnSaveNew)
									.addComponent(btnSave))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(19)
									.addComponent(lblNewLabel_1))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(16)
									.addComponent(textLname, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(19)
									.addComponent(lblNewLabel_4))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(16)
									.addComponent(textAddr1, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGap(16)
									.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
										.addGroup(gl_contentPane.createSequentialGroup()
											.addGap(3)
											.addComponent(lblNewLabel_7))
										.addComponent(textPostCode, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))))
							.addGap(21)
							.addGroup(gl_contentPane.createParallelGroup(Alignment.TRAILING)
								.addGroup(gl_contentPane.createSequentialGroup()
									.addGroup(gl_contentPane.createParallelGroup(Alignment.LEADING)
										.addGroup(gl_contentPane.createSequentialGroup()
											.addGap(3)
											.addComponent(lblNewLabel_2))
										.addComponent(textEmail, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE)
										.addGroup(gl_contentPane.createSequentialGroup()
											.addGap(3)
											.addComponent(lblNewLabel_5))
										.addComponent(textAddr2, GroupLayout.PREFERRED_SIZE, GroupLayout.DEFAULT_SIZE, GroupLayout.PREFERRED_SIZE))
									.addGap(11))
								.addGroup(gl_contentPane.createSequentialGroup()
									.addComponent(btnRefresh)
									.addPreferredGap(ComponentPlacement.UNRELATED))))
						.addGroup(gl_contentPane.createSequentialGroup()
							.addGap(34)
							.addComponent(btnDelete)))
					.addGap(11)
					.addComponent(scrollPane, GroupLayout.PREFERRED_SIZE, 216, GroupLayout.PREFERRED_SIZE))
		);
		contentPane.setLayout(gl_contentPane);
	}
}
