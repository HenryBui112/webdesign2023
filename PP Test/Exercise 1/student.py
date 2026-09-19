#input the number of students
n = int(input("Enter the number of students: "))

#Store all students in a list
students = []

#Input student information
for i in range(n):
    print(f"n\---Student {i+1}---")

    student_id = input("Enter student ID: ")
    full_name = input("Enter full name: ")
    score = float(input("Enter score: "))

    #Store all student information in a dictionary
    student = {
        "id": student_id,
        "name": full_name,
        "score": score
    }

    #Store all student information in a list
    students.append(student)

#Display all student information
print("\n---Student Information---")
for student in students:
    print(f"ID: {student['id']}, Name: {student['name']}, Score: {student['score']}")

#Find the student with the highest score
highest_score = max(students, key=lambda x: x['score'])
print("\n---Student with the highest score---")
print(f"ID: {highest_score['id']}")
print(f"Name: {highest_score['name']}")
print(f"Score: {highest_score['score']}")

#Calculate the average score of all students
total_score = sum(student['score'] for student in students)
average_score = total_score / len(students)
print("\n---Average Score---")
print(f"Average Score: {average_score:.2f}")

#Student who passed (score >= 5)
print("\n---Students who passed---")
passed_students = [student for student in students if student['score'] >= 5]
if len(passed_students) == 0:
    print("No students passed.")
else:
    for student in passed_students:
        print(f"ID: {student['id']}, Name: {student['name']}, Score: {student['score']}")