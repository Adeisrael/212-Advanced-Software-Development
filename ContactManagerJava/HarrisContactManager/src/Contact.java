
public class Contact {

	private String id;
	private String firstName;
	private String lastName;
	private String email;
	private String addr1;
	private String addr2;
	private String city;
	private String postCode;

	public Contact(String id, String firstName, String lastName, String email, String addr1, String addr2,
			String city, String postCode) {
		super();
		this.id = id;
		this.firstName = firstName;
		this.lastName = lastName;
		this.email = email;
		this.addr1 = addr1;
		this.addr2 = addr2;
		this.city = city;
		this.postCode = postCode;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getFirstName() {
		return firstName;
	}

	public void setFirstName(String firstName) {
		this.firstName = firstName;
	}

	public String getLastName() {
		return lastName;
	}

	public void setLastName(String lastName) {
		this.lastName = lastName;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getAddr1() {
		return addr1;
	}

	public void setAddr1(String addr1) {
		this.addr1 = addr1;
	}

	public String getCity() {
		return city;
	}

	public void setCity(String city) {
		this.city = city;
	}

	public String getPostCode() {
		return postCode;
	}

	public void setPostCode(String postCode) {
		this.postCode = postCode;
	}

//this is your polimorphism to change ToString to return Strng value 
	// insted of memory RAM address. you can say it in report
	@Override
	public String toString() {
		return "Contact [id=" + id + ", firstName=" + firstName + ", lastName=" + lastName + ", email=" + email
				+ ", addr1=" + addr1 + ", addr2=" + addr2 + ", city=" + city + ", postCode=" + postCode + "]";
	}

}
