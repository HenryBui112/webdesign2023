import pandas as pd

# Create a DataFrame
data = {
    "id": [1, 2, 3, 4],
    "Name": ['Khanh', 'An', 'Hoang', 'Chi'],
    "Age": [20, 19, 22, 21],
    "Score": [8.5, 9.0, 4.5, 7.0]
}

df = pd.DataFrame(data)

# Save to CSV
df.to_csv('students.csv', index=False)

# Read from CSV
df = pd.read_csv('students.csv')

# Display all students
print("\n====List of Students====")
print(df)

# Student with score above 8.0
print("\n====Students with Score > 8.0====")
print(df[df["Score"] >= 8])

# Average score
avg_score = df["Score"].mean()
print("\nAverage Score:", avg_score)

# Add result column
df["Result"] = df["Score"].apply(lambda x: "Pass" if x >= 5 else "Fail")
print("\n====Students with Result====")
print(df)