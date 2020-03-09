function addPadding() {
    var target = document.getElementById("targetForPadding");
    if (query.matches) { 
        target.classList.remove("targetForPadding");
    } else {
        target.classList.add("targetForPadding");
    }
}

var query = window.matchMedia("(max-width: 1150px)");
removeSelfCenter(); 
query.addListener(removeSelfCenter); 
