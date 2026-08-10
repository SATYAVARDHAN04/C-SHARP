const signupForm = document.getElementById("signupForm");

signupForm.addEventListener("submit", function (event) {

    event.preventDefault();

    const name = document.getElementById("name").value;
    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;
    const confirmPassword =
        document.getElementById("confirmPassword").value;

    // Check passwords
    if (password !== confirmPassword) {
        document.getElementById("message").textContent =
            "Passwords do not match.";

        return;
    }

    // Create user object
    const user = {
        name: name,
        email: email,
        password: password
    };

    // Store user in browser
    localStorage.setItem("user", JSON.stringify(user));

    document.getElementById("message").textContent =
        "Account created successfully!";

    console.log("User stored:", user);
});