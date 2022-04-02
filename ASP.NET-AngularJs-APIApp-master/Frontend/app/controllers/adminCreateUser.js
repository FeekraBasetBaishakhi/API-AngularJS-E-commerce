app.controller("adminCreateUser", function ($scope, ajax, $location) {
   
  
    $scope.statuses = ["Valid", "Invalid", "Banned"];
  
    $scope.createUser = function (user) {
      if (user.password != user.cpassword){
        $scope.passError = "Passwords Dont Match";
      }
      else {
        ajax.post("https://localhost:44336/api/users/add",user,
        function(response){
          console.log(response);
          $location.path("/admin/viewusers")
        },
        function(err){
          console.log(err);
        });
      }
    };
  });
  