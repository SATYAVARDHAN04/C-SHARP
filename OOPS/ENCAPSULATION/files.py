import os

# Create 100 empty C# files from Q1.cs to Q10.cs
for i in range(1, 11):
    filename = f"Q{i}.cs"

    # Create an empty file
    with open(filename, "w") as file:
        pass

print("10 C# files created successfully!")