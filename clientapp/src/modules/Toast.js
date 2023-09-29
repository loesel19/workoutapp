export default {
    Info(message = ""){
        var x = document.getElementById("snackbar");
        x.innerHTML = message
        x.style.backgroundColor = "aliceblue"
        x.style.color = "black"
        // Add the "show" class to DIV
        x.className = "show";
      
        // After 3 seconds, remove the show class from DIV
        setTimeout(function(){ x.className = x.className.replace("show", ""); }, 3000);
    },
    Error(message = ""){
        var x = document.getElementById("snackbar");
        x.innerHTML = message
        x.style.backgroundColor = "red"
        x.style.color = "white"
        // Add the "show" class to DIV
        x.className = "show";
      
        // After 3 seconds, remove the show class from DIV
        setTimeout(function(){ x.className = x.className.replace("show", ""); }, 3000);
    },
    Success(message = ""){
        var x = document.getElementById("snackbar");
        x.innerHTML = message
        x.style.backgroundColor = "green"
        x.style.color = "white"
        // Add the "show" class to DIV
        x.className = "show";
      
        // After 3 seconds, remove the show class from DIV
        setTimeout(function(){ x.className = x.className.replace("show", ""); }, 3000);
    },
    Warning(message = ""){
        var x = document.getElementById("snackbar");
        x.innerHTML = message
        x.style.backgroundColor = "yellow"
        x.style.color = "black"
        // Add the "show" class to DIV
        x.className = "show";
      
        // After 3 seconds, remove the show class from DIV
        setTimeout(function(){ x.className = x.className.replace("show", ""); }, 3000);
    }


}