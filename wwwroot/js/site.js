// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", () => {
    const page = document.querySelector(".page");
    if (page) {
        requestAnimationFrame(() => {
            page.classList.add("page-visible");
        });
    }

    const links = document.querySelectorAll(".sidebar .nav-link");
    const path = window.location.pathname.toLowerCase();

    links.forEach(link => {
        const href = link.getAttribute("href").toLowerCase();
        if (href !== "/" && path.startsWith(href)) {
            link.classList.add("nav-link-active");
        }
    });
});