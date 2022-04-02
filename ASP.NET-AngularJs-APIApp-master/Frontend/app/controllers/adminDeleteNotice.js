app.controller(
    "adminDeleteNotice",
    function ($scope, ajax, $location, $routeParams) {
   
      var id = $routeParams.id;
      ajax.get("https://localhost:44336/api/notices/" + id, success, error);
      function success(response) {
        $scope.notice = response.data;
        // console.log(response.data);
      }
      function error(error) {
        console.log(error);
      }
  
      $scope.deleteNotice = function (notice) {
        if(confirm('Are you sure your want to delete?')) {
          ajax.delete(
            "https://localhost:44336/api/notices/delete/" + notice.noticeid,
            notice,
            function (response) {
              // console.log(response);
              $location.path("/admin/viewnotices");
            },
            function (err) {
              console.log(err);
            }
          );
        }
      };
    }
  );
  