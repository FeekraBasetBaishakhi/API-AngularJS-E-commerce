app.controller(
    "adminEditUser",
    function ($scope,  ajax, $location, $routeParams) {

      var id = $routeParams.id;
      $scope.statuses = ["Valid", "Invalid", "Banned"];
      ajax.get("https://localhost:44336/api/users/" + id, success, error);
      function success(response) {
        $scope.user = response.data;
        console.log(response.data);
      }
      function error(error) {}
  
      $scope.editUser = function (user) {
        ajax.put(
          "https://localhost:44336/api/users/edit",
          user,
          function (response) {
            console.log(response);
            $location.path("/admin/viewusers");
          },
          function (err) {
            console.log(err);
          }
        );
      };
    }
  );
  