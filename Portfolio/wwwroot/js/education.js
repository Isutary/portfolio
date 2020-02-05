function removeSelfCenter(x) {
    if (query.matches) { // If media query matches
        target.classList.remove("target");
    } else {
        target.classList.add("target");
    }
}

var target = document.getElementById("target");
var query = window.matchMedia("(max-width: 1150px)")
removeSelfCenter(query) // Call listener function at run time
query.addListener(removeSelfCenter) // Attach listener function on state changes
