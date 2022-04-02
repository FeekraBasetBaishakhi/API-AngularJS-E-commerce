app.controller(
    "adminDeleteUser",
    function ($scope, ajax, $location, $routeParams) {
  
      var id = $routeParams.id;
      ajax.get("https://localhost:44336/api/users/" + id, success, error);
      function success(response) {
        $scope.user = response.data;
        // console.log(response.data);
      }
      function error(error) {
        console.log(error);
      }
  
      $scope.deleteUser = function (user) {
        if(confirm('Are you sure your want to delete?')) {
          ajax.delete(
            "https://localhost:44336/api/users/delete/" + user.userid,
            user,
            function (response) {
              // console.log(response);
              $location.path("/admin/viewusers");
            },
            function (err) {
              console.log(err);
            }
          );
        }
  
      };
    }
  );
  