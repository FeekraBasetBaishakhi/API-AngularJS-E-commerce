app.controller(
    "adminViewUsers",
    function ($scope, ajax) {
  
      ajax.get("https://localhost:44336/api/users/all", success, error);
      function success(response) {
        $scope.users = response.data;
        $scope.users.forEach((element) => {
          var v = new Date(element.createdat);
          element.date = v.toDateString();
          element.time = v.toLocaleTimeString();
        });
        console.log($scope.users);
      }
      function error(error) {}
  
      $scope.delete = function (id) {
        if (confirm('Are you sure your want to delete?')) {
          //do stuff
    
          ajax.post("https://localhost:44336/api/users/delete/" + id,
            function (response) {
              console.log(response);
              // alert("deleted");
            },
            function (err) {
              console.log(err);
              alert("deleted");
              ajax.get("https://localhost:44336/api/users/all"+$rootScope.UserId, success, error);
              function success(response) {
                $scope.users = response.data;
              }
              function error(error) {
            
              }
    
            }
          );
        }
      }
      $scope.search = function () {
        if ($scope.searchText === "") {
          ajax.get("https://localhost:44336/api/users/all", success, error);
        } else {
          ajax.get(
            "https://localhost:44336/api/users/search/" + $scope.searchText,
            function success(response) {
              $scope.users = response.data;
            },
            function (err) {
              console.log(err);
            }
          );
        }
      };
    }
  );
  