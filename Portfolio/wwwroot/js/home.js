function removeSelfCenter(x) {
    if (query.matches) { // If media query matches
        mainDiv.classList.remove("align-self-center");
    } else {
        mainDiv.classList.add("align-self-center");
        
    }
}

var mainDiv = document.getElementById("mainDiv");
var query = window.matchMedia("(max-width: 1150px)")
removeSelfCenter(query) // Call listener function at run time
query.addListener(removeSelfCenter) // Attach listener function on state changes
