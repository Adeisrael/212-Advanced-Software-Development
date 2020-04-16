//Personal Contact class inherits from Contact class
public class PersonalContact extends Contact {
//Encapsulation of attribute
	private String homeTel;//Personal Contact attribute
//inherited attributes
	public PersonalContact(String id, String firstName, String lastName, String email, String addr1, String addr2,
			String city, String postCode, String homeTel) {
		//attributes of super class
		super(id, firstName, lastName, email, addr1, addr2, city, postCode);
		this.homeTel = homeTel;
	}
//get method for HomeTel
	public String getHomeTel() {
		return homeTel;
	}
//set method for HomeTel
	public void setHomeTel(String homeTel) {
		this.homeTel = homeTel;
	}

//Polymorphism-overriding toString method inherited from the contact class to string 
	@Override
	public String toString() {
		return "PersonalContact [homeTel=" + homeTel + "]";
	}

}
