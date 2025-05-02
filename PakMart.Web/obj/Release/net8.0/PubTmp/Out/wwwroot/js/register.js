document.addEventListener('DOMContentLoaded', function () {

    // Toggle show/hide password
    document.querySelectorAll('.toggle-password').forEach(function (button) {
        button.addEventListener('click', function () {
            const targetInput = document.querySelector(this.getAttribute('data-target'));
            const icon = this.querySelector('i');
            if (targetInput.type === 'password') {
                targetInput.type = 'text';
                icon.classList.remove('fa-eye');
                icon.classList.add('fa-eye-slash');
            } else {
                targetInput.type = 'password';
                icon.classList.remove('fa-eye-slash');
                icon.classList.add('fa-eye');
            }
        });
    });

    // ✅ Validate password confirmation on input change (only if the element exists)
    const confirmPasswordInput = document.getElementById('confirmPassword');
    if (confirmPasswordInput) {
        confirmPasswordInput.addEventListener('input', function () {
            const password = document.getElementById('password').value;
            const confirmPassword = this.value;
            const confirmPasswordError = document.getElementById('confirmPasswordError');

            if (confirmPassword === '') {
                confirmPasswordError.textContent = 'Please confirm your password.';
            } else if (password !== confirmPassword) {
                confirmPasswordError.textContent = 'Passwords do not match.';
            } else {
                confirmPasswordError.textContent = ''; // Clear error if passwords match
            }
        });
    }

    //hide success Message Automatically
    window.addEventListener('DOMContentLoaded', (event) => {
        const alert = document.getElementById('successMessage');
        if (alert) {
            setTimeout(function () {
                alert.classList.remove('show');
                alert.classList.add('fade');
                setTimeout(() => alert.remove(), 500); // Remove from DOM after fade
            }, 2000); // Hide after 2 seconds
        }
    });

});
