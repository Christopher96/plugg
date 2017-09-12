
window.addEventListener("DOMContentLoaded", onReady);

var wtxt, htxt;

function onReady(e) {
    var div = document.createElement("div");
    div.setAttribute("id", "resize-window");
    div.innerHTML = "Width: <span id='resize-width'></span> px<br/>Height: <span id='resize-height'></span> px";
    document.body.appendChild(div);
    wtxt = document.querySelector("#resize-width");
    htxt = document.querySelector("#resize-height");
    window.addEventListener("resize", onResize);
}

function onResize(e) {
    wtxt.innerHTML = e.target.outerWidth;
    htxt.innerHTML = e.target.outerHeight;
}