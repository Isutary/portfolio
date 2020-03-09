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
