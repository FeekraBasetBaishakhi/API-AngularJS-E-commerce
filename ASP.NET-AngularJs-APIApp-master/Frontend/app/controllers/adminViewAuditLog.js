app.controller(
    "adminViewAuditLog",
    function ($scope, ajax) {
    
      ajax.get("https://localhost:44336/api/auditlogs/all", success, error);
      function success(response) {
        $scope.auditlogs = response.data;
        $scope.auditlogs.forEach((element) => {
          var v = new Date(element.createdat);
          element.date = v.toDateString();
          element.time = v.toLocaleTimeString();
        });
        // console.log(response.data);
      }
      function error(error) {}
  
      $scope.search = function () {
        if ($scope.searchText === "") {
          ajax.get("https://localhost:44336/api/auditlogs/all", success, error);
        } else {
          ajax.get(
            "https://localhost:44336/api/auditlogs/search/" + $scope.searchText,
            function success(response) {
              $scope.auditlogs = response.data;
            },
            function (err) {
              console.log(err);
            }
          );
        }
      };
    }
  );
  