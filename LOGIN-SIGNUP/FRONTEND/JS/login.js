const loginForm = document.getElementById("loginForm");

loginForm.addEventListener("submit", async function (event) {

    event.preventDefault();

    const email = document.getElementById("email").value.trim();
    const password = document.getElementById("password").value;

    const message = document.getElementById("message");


    try {

        const response = await fetch(
            "http://localhost:5297/api/auth/login",
            {
                method: "POST",

                headers: {
                    "Content-Type": "application/json"
                },

                body: JSON.stringify({
                    email: email,
                    password: password
                })
            }
        );


        const data = await response.json();


        if (response.ok) {

            message.textContent = data.message;

            console.log("Login successful!");

        }
        else {

            message.textContent =
                data.message || "Invalid email or password.";

            console.log("Login failed.");

        }

    }
    catch (error) {

        console.error("Error:", error);

        message.textContent =
            "Could not connect to the server.";
    }

});