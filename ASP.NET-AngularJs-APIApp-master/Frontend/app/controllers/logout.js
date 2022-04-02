app.controller("logout", function ($http, $rootScope, $location) {
    if (localStorage.getItem("user")){
      localStorage.removeItem("user");
    }
  
    $rootScope.isUserLoggedIn = false;
  
    $rootScope.UserId="";
    $rootScope.UserType="";
    $rootScope.UserName="";
    $rootScope.UserEmail="";
    $rootScope.UserPhone="";
    $rootScope.UserPassword="";

    $http.get("https://localhost:44336/api/logout")
    .then(function(rsp){
        localStorage.removeItem("token");
    },function(err){
        console.log(err);
    });
    $location.path("/");
  });
  