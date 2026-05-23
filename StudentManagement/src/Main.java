import java.io.*;
import java.util.*;

public class Main {
    private static ArrayList<Student> students = new ArrayList<>();
    private static final String File_Name = "students.dat";

    public static void menu(){
        System.out.println("\n=====STUDENT MANAGEMENT======");
        System.out.println("1. Add new student");
        System.out.println("2. Save");
        System.out.println("3. Display all students");
        System.out.println("4. Exit");
        System.out.print("Choose option: ");
    }

    public static void addStudent(Scanner sc){
        System.out.print("Enter EnrolID: ");
        String id = sc.nextLine();

        System.out.print("Enter First Name: ");
        String FirstName = sc.nextLine();

        System.out.print("Enter Last Name: ");
        String LastName = sc.nextLine();

        System.out.print("Enter Age: ");
        int Age = Integer.parseInt(sc.nextLine());

        Student s = new Student(id, FirstName, LastName, Age);
        students.add(s);

        System.out.println("Student add successfully!");
    }

    public static void saveStudent(){
        try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream(File_Name))){
            oos.writeObject(students);
            System.out.println("Save to file successfully!");
        } catch (IOException e) {
            System.out.println("Error saving file!");
        }
    }

    public static void displayStudent(){
        ArrayList<Student> list = null;

        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream(File_Name))){
            list = (ArrayList<Student>) ois.readObject();
        } catch (Exception e) {
            System.out.println("No data found");
            return;
        }

        System.out.println("\nEnrolID");
        System.out.println("------------");
        System.out.println("Full Name");
        System.out.println("---------------------------");
        System.out.println("Age");
        System.out.println("----------");

        for (Student s: list){
            System.out.printf("%-10s %-25s %d\n", s.getEnrolID(), s.getFullName(), s.getAge());
        }
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int choice;

        do {
            menu();
            choice = Integer.parseInt(sc.nextLine());

            switch (choice) {
                case 1:
                    addStudent(sc);
                    break;
                case 2:
                    saveStudent();
                    break;
                case 3:
                    displayStudent();
                    break;
                case 4:
                    System.out.println("Exiting program....");
                    break;
                default:
                    System.out.println("Invalid choice");
            }
        } while (choice != 4);

        sc.close();
    }

}
