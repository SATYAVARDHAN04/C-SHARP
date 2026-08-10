const loginForm = document.getElementById("loginForm");

loginForm.addEventListener("submit", function (event) {

    event.preventDefault();

    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;

    // Get stored user
    const storedUser = localStorage.getItem("user");

    if (!storedUser) {
        console.log("No account found.");

        document.getElementById("message").textContent =
            "No account found. Please sign up first.";

        return;
    }

    // Convert JSON string back into JavaScript object
    const user = JSON.parse(storedUser);

    // Check credentials
    if (
        email === user.email &&
        password === user.password
    ) {
        console.log("Login successful!");

        document.getElementById("message").textContent =
            "Login successful!";
    }
    else {
        console.log("Invalid email or password.");

        document.getElementById("message").textContent =
            "Invalid email or password.";
    }
});