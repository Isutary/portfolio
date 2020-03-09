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

function removeSelfCenter() {
    var mainDiv = document.getElementById("mainDiv");
    if (query.matches) {
        mainDiv.classList.remove("align-self-center");
    } else {
        mainDiv.classList.add("align-self-center");
        
    }
}


var query = window.matchMedia("(max-width: 1150px)");
removeSelfCenter(); 
query.addListener(removeSelfCenter); 

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