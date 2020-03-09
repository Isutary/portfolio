function addMargin() {
    var target = document.getElementById("targetForMargin");
    if (!query.matches) { 
        target.classList.remove("targetForMargin");
    } else {
        target.classList.add("targetForMargin");
    }
}

var query = window.matchMedia("(max-width: 1150px)");
addMargin();
query.addListener(addMargin); 
