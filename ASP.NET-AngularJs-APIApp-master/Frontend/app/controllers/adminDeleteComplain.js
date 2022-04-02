app.controller(
    "adminDeleteComplain",
    function ($scope, ajax, $location, $routeParams) {
   
      var id = $routeParams.id;
      ajax.get("https://localhost:44336/api/complains/" + id, success, error);
      function success(response) {
        $scope.complain = response.data;
        // console.log(response.data);
      }
      function error(error) {
        console.log(error);
      }
  
      $scope.deleteComplain = function (complain) {
        if(confirm('Are you sure your want to delete?')) {
          ajax.delete(
            "https://localhost:44336/api/complains/delete/" + complain.ratingid,
            complain,
            function (response) {
              // console.log(response);
              $location.path("/admin/viewcomplains");
            },
            function (err) {
              console.log(err);
            }
          );
        }
      };
    }
  );
  