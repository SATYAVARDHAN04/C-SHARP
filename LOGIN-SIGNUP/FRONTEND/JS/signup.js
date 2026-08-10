const signupForm = document.getElementById("signupForm");

signupForm.addEventListener("submit", async function (event) {

    event.preventDefault();

    const name = document.getElementById("name").value.trim();
    const email = document.getElementById("email").value.trim();
    const password = document.getElementById("password").value;
    const confirmPassword =
        document.getElementById("confirmPassword").value;

    const message = document.getElementById("message");


    // Check passwords
    if (password !== confirmPassword) {

        message.textContent = "Passwords do not match.";

        return;
    }


    try {

        const response = await fetch(
            "http://localhost:5297/api/auth/signup",
            {
                method: "POST",

                headers: {
                    "Content-Type": "application/json"
                },

                body: JSON.stringify({
                    name: name,
                    email: email,
                    password: password
                })
            }
        );


        const data = await response.json();


        if (response.ok) {

            message.textContent = data.message;

            console.log("Signup successful.");

        }
        else {

            message.textContent =
                data.message || "Signup failed.";

            console.log("Signup failed.");

        }

    }
    catch (error) {

        console.error("Error:", error);

        message.textContent =
            "Could not connect to the server.";
    }

});