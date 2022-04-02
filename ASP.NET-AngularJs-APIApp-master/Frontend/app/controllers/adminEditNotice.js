app.controller(
    "adminEditNotice",
    function ($scope,  ajax, $location, $routeParams) {
   
      var id = $routeParams.id;
      $scope.statuses = ["Active", "Inactive"];
      $scope.usertypes = ["Admin", "Manager", "Seller", "Customer"];
    
      ajax.get("https://localhost:44336/api/notices/" + id, success, error);
      function success(response) {
        $scope.notice = response.data;
        console.log(response.data);
      }
      function error(error) {}
  
      $scope.editNotice = function (notice) {
        ajax.put(
          "https://localhost:44336/api/notices/edit",
          notice,
          function (response) {
            // console.log(response);
            $location.path("/admin/viewnotices");
          },
          function (err) {
            console.log(err);
          }
        );
      };
    }
  );
  