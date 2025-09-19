const toggleBtn = document.querySelector(".menu-toggle");
const navLinks = document.querySelector(".nav-links");

toggleBtn.addEventListener("click", () => {
    navLinks.classList.toggle("active");
});

const gifImg = document.querySelector(".gif-frame img");

function swapGif() {
    if (window.innerWidth <= 700) {
        gifImg.src = "assets/placeholder.png";
    } else {
        gifImg.src = "assets/placeholder.gif";
    }
}

window.addEventListener("resize", swapGif);
window.addEventListener("load", swapGif);
