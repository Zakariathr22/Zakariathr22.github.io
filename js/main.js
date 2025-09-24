const toggleBtn = document.querySelector(".menu-toggle");
const navLinks = document.querySelector(".nav-links");

toggleBtn.addEventListener("click", () => {
    navLinks.classList.toggle("active");
});

const gifImg = document.querySelector(".gif-frame img");

function swapGif() {
    if (window.innerWidth <= 400) {
        gifImg.src = "assets/placeholder.png";
    } else {
        gifImg.src = "assets/placeholder.gif";
    }
}

window.addEventListener("resize", swapGif);
window.addEventListener("load", swapGif);

// Handle show more tags
document.querySelectorAll(".tags").forEach(tagContainer => {
    const tags = Array.from(tagContainer.querySelectorAll(".blog-tag"));
    const moreBtn = tagContainer.querySelector(".show-more");

    let visibleCount = 4;
    tags.forEach((tag, i) => {
        if (i >= visibleCount) tag.style.display = "none";
    });

    if (tags.length <= visibleCount) {
        if (moreBtn) moreBtn.style.display = "none";
    }

    if (moreBtn) {
        moreBtn.addEventListener("click", () => {
            const hiddenTags = tags.slice(visibleCount, visibleCount + 4);
            hiddenTags.forEach(tag => tag.style.display = "inline-block");
            visibleCount += 4;
            if (visibleCount >= tags.length) moreBtn.style.display = "none";
        });
    }
});