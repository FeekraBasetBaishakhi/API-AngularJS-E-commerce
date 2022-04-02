app.controller(
    "adminViewNotices",
    function ($scope, ajax) {
    
      ajax.get("https://localhost:44336/api/notices/all", success, error);
      function success(response) {
        $scope.notices = response.data;
        $scope.notices.forEach((element) => {
          var v = new Date(element.createdat);
          element.date = v.toDateString();
          element.time = v.toLocaleTimeString();
        });
        // console.log(response.data);
      }
      function error(error) {}
  
      $scope.search = function () {
        if ($scope.searchText === "") {
          ajax.get("https://localhost:44336/api/notices/all", success, error);
        } else {
          ajax.get(
            "https://localhost:44336/api/notices/search/" + $scope.searchText,
            function success(response) {
              $scope.notices = response.data;
            },
            function (err) {
              console.log(err);
            }
          );
        }
      };
    }
  );
  