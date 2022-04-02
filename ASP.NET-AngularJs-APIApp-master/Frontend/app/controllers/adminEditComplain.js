app.controller(
    "adminEditComplain",
    function ($scope, ajax, $location, $routeParams) {
   
      var id = $routeParams.id;
    
      ajax.get("https://localhost:44336/api/complains/" + id, success, error);
      function success(response) {
        $scope.complain = response.data;
        console.log(response.data);
      }
      function error(error) {}
  
      $scope.editComplain = function (complain) {
        ajax.put(
          "https://localhost:44336/api/complains/edit",
          complain,
          function (response) {
            // console.log(response);
            $location.path("/admin/viewcomplains");
          },
          function (err) {
            console.log(err);
          }
        );
      };
    }
  );
  