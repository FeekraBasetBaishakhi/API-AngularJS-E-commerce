app.controller("adminActions", function ($scope, ajax,  $route, $rootScope) {
   
    ajax.get("https://localhost:44336/api/users/all", success, error);
    function success(response) {
      $scope.users = response.data;
  
      console.log(response.data);
    }
    function error(error) {}
    $scope.statuses = ["Valid", "Invalid", "Banned"];
  
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
    $scope.takeAction = function (user) {
      ajax.put(
        "https://localhost:44336/api/users/edit",
        user,
        function (response) {
         
          var actionType = "";
          if (response.data.status === "Valid") {
            actionType = 1;
          } else if (response.data.status === "Invalid") {
            actionType = 2;
          } else if (response.data.status === "Banned") {
            actionType = 3;
          }
          auditLog = {
            adminid: $rootScope.UserId,
            userid: user.userid,
            actiontypeid: actionType,
          };
          if (user.prevStatus != user.status) {
            ajax.post(
                "https://localhost:44336/api/auditlogs/add",
              auditLog,
              function (response) {
                console.log(response.data);
              },
              function (err) {
                console.log(err);
              }
            );
          }
          $route.reload();
          
        },
        function (err) {
          console.log(err);
        }
      );
    };
  });
  