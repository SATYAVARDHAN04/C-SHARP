import os

# Create 10 empty C# files from Q1.java to Q100.java
for i in range(10, 31):
    filename = f"Q{i}.cs"

    # Create an empty file
    with open(filename, "w") as file:
        pass

print("10 C# files created successfully!")