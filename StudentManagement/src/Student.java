import java.io.Serializable;

public class Student implements Serializable{
    private String EnrolID;
    private String FirstName;
    private String LastName;
    private int Age;

    public Student(String EnrolID, String FirstName, String LastName, int Age){
        this.EnrolID = EnrolID;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
    }

    public String getEnrolID() {
        return EnrolID;
    }

    public String getFirstName() {
        return FirstName;
    }

    public String getLastName() {
        return LastName;
    }

    public int getAge() {
        return Age;
    }

    public void setAge(int age) {
        this.Age = age;
    }

    public String getFullName(){
        return FirstName +" "+ LastName;
    }
}
