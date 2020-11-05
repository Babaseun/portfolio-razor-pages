// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("scroll", () => {
  const summary = document.querySelector(".personal-summary");

  const position = summary.getBoundingClientRect().top;
  if (position <= 500) {
    summary.classList.add("display");
  }
});
