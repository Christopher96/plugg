var currentURL = window.location.origin+window.location.pathname;

var links = document.querySelectorAll("#menu li a");
for(var i=0; i<links.length; i++){
    if( links[i].href == currentURL ){
        links[i].parentNode.classList.add("current");
        break;
    }
}