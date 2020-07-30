document.getElementById("mobile-menu-button").addEventListener("click", function()
{
    let element = document.getElementById("mobile-menu");
    if(element.classList.contains("open")){
        element.classList.remove("open");
    }else{
        element.classList.add("open");
    }
});
let element = document.getElementById("mobile-menu");
document.getElementById("menu-overlay").addEventListener("click", function(){
    element.classList.remove("open");
} );