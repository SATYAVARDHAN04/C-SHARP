import os

# Create 10 empty C# files from Q1.cs to Q100.cs
for i in range(1, 100):
    filename = f"Q{i}.cs"

    # Create an empty file
    with open(filename, "w") as file:
        pass

print("C# files created successfully!")