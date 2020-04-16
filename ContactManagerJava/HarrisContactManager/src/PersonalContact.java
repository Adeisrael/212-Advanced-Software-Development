//Personal Contact class inherits from Contact class
public class PersonalContact extends Contact {

	private String homeTel;

	public PersonalContact(String id, String firstName, String lastName, String email, String houseNo, String street,
			String city, String postCode, String personalTel) {
		super(id, firstName, lastName, email, houseNo, street, city, postCode);
		this.homeTel = personalTel;
	}

	public String getPersonalTel() {
		return homeTel;
	}

	public void setPersonalTel(String personalTel) {
		this.homeTel = personalTel;
	}

//here is the same
	@Override
	public String toString() {
		return "PersonalContact [personalTel=" + homeTel + "]";
	}

}
