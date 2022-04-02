app.controller(
    "adminViewComplains",
    function ($scope, ajax) {
    
      ajax.get("https://localhost:44336/api/complains/all", success, error);
      function success(response) {
        $scope.complains = response.data;
        console.log(response.data);
      }
      function error(error) {}
    }
  );
  