function checkIsUserAuth() {
    const checkIsUserAuthUrl = `${window.location.origin}/account/IsLoggedIn`;

    fetch(checkIsUserAuthUrl)
        .then(function (responce) {
            return responce.json();
        }).then(function (result) {
            return result;
        }).catch(function () {
            console.error("somthing goes wrong.");
        });  
}

let isUserLoggedIn = checkIsUserAuth();

if (isUserLoggedIn) {

}
else {
    let navbar = document.getElementById("login-nav");

}