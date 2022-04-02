app.controller("registration", function ($scope, ajax, $location, $rootScope) {
    $rootScope.PageType = "admin";
    $scope.usertypes = ["Seller", "Customer"];
  
    // $rootScope.UserType = "Admin";
    $scope.createUser = function (user) {
  
        console.log(user);
        if (user.password != user.cpassword) {
            $scope.passError = "Passwords Dont Match";
        }
        else {
            ajax.post("https://localhost:44336/api/registration", user,
                function (response) {
                    console.log(response);
                    alert("Welcome to the web Application!")
                    $location.path("/login");
                },
                function (err) {
                    console.log(err);
                });
        }
    };
  });