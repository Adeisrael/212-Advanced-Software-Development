import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.*;

import com.mysql.cj.jdbc.CallableStatement;

public class dbConn {
	//database connection credentials
	String connString = "jdbc:mysql://db212it.chmhkq40bexm.us-east-1.rds.amazonaws.com/HarrisContactDb";
	String username = "admin";
	String password = "migrate123";
	Connection con = null;
	
	public dbConn () {
		//exception handling with try and catch 
		try {
			con=DriverManager.getConnection(connString,username,password);
			System.out.println("Connected");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			System.out.println("Not Connected");
		}
	}
	//READ PERSONAL CONTACTS
	public ResultSet GetAllPersonal() 
	{	
		ResultSet rs= null;
		String sql="{call selectAllPersonal()}";
		try {
			java.sql.CallableStatement cst= con.prepareCall(sql);
			rs=cst.executeQuery();//executes sql query and returns value to rs 
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;
	}
	
	//READ BUSINESS CONTACTS
	public ResultSet GetAllBusiness() 
	{
		ResultSet rs= null;
		String sql="{call selectAllBusiness()}";
		try {
			java.sql.CallableStatement cst=con.prepareCall(sql);
			rs=cst.executeQuery();//executes sql query and returns value to rs
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return rs;
	}
	
	//UPDATEPERSONAL
	public void UpdatePersonal(String fname, String lname, String email, String hometel, String addr1, String addr2, String city, String postcode, String id ) 
	{
		
		ResultSet rs=null;
		String sql="{call updatePersonal(?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst=con.prepareCall(sql);
			
			cst.setString(1, id );
			cst.setString(2, fname);
			cst.setString(3, lname);
			cst.setString(4, email);
			cst.setString(5, hometel);
			cst.setString(6, addr1);
			cst.setString(7, addr2);
			cst.setString(8, city);
			cst.setString(9, postcode);
			
			rs=cst.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
	}
	
	//UPDATEBUSINESSS
	public void UpdateBusiness (String fname, String lname, String email, String bustel,String addr1, String addr2, String city, String postcode, String id) {
		
		ResultSet rs=null;
		String sql="{call updateBusiness(?,?,?,?,?,?,?,?,?)}";
		try {
			java.sql.CallableStatement cst=con.prepareCall(sql);
			
			cst.setString(1, id );
			cst.setString(2, fname);
			cst.setString(3, lname);
			cst.setString(4, email);
			cst.setString(5, bustel);
			cst.setString(6, addr1);
			cst.setString(7, addr2);
			cst.setString(8, city);
			cst.setString(9, postcode);
			
			rs=cst.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
	}
	
	//INSERT PERSONAL
	public void AddPersonal(String fname, String lname, String email, String hometel,String addr1, String addr2, String city, String postcode ) {
				
		String sql="{call insertPersonal(?,?,?,?,?,?,?,?)}";
	try {	
		java.sql.CallableStatement cst= con.prepareCall(sql);
		cst.setString(1, fname);
		cst.setString(2, lname);
		cst.setString(3, email);
		cst.setString(4, hometel);
		cst.setString(5, addr1);
		cst.setString(6, addr2);
		cst.setString(7, city);
		cst.setString(8, postcode);
		cst.executeQuery();
		
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}	
		
			
	}
	
	//INSERT BUSINESS 
	public void AddBusiness(String fname, String lname, String email, String bustel,String addr1, String addr2, String city, String postcode ) {
		
		String sql="{call insertBusiness(?,?,?,?,?,?,?,?)}";
	try {
		java.sql.CallableStatement cst= con.prepareCall(sql);
		cst.setString(1, fname);
		cst.setString(2, lname);
		cst.setString(3, email);
		cst.setString(4, bustel);
		cst.setString(5, addr1);
		cst.setString(6, addr2);
		cst.setString(7, city);
		cst.setString(8, postcode);
		cst.executeQuery();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	
	}
	
	
	//DELETE PERSONAL
	public void DeletePersonal(String id) {
		
		String sql="{call deletePersonal(?)}";
		try {
		java.sql.CallableStatement cst = con.prepareCall(sql);
		cst .setString(1,id);
		cst.executeQuery();
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}	
	}
	
	//DELETE BUSINESS
	public void DeleteBusiness(String id) {
		
		String sql="{call deleteBusiness(?)}";
	try {	
		java.sql.CallableStatement cst=con.prepareCall(sql);
		cst.setString(1, id);
		cst.executeQuery();
	} catch (SQLException e) {
		// TODO Auto-generated catch block
		e.printStackTrace();
	}
	}

}

