//Business contact inherits from Contact
public class BusinessContact extends Contact {
//Encapsulation of BusinessTel attribute
	private String BusniessTel;
//inherited attributes from contact class
	public BusinessContact(String id, String firstName, String lastName, String email, String addr1, String addr2,
			String city, String postCode, String busniessTel) {
		//attributes of super class 
		super(id, firstName, lastName, email, addr1, addr2, city, postCode);
		BusniessTel = busniessTel;
	}
//get method for business tel
	public String getBusniessTel() {
		return BusniessTel;
	}
//set method for business tel
	public void setBusniessTel(String busniessTel) {
		BusniessTel = busniessTel;
	}

	// Polymorphism-overriding toString method inherited from the contact class to String 
	@Override
	public String toString() {
		return "BusinessContact [BusniessTel=" + BusniessTel + "]";
	}

}
