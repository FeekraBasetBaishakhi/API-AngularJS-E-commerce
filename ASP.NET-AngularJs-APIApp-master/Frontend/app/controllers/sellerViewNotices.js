app.controller(
    "sellerViewNotices", function ($scope, ajax, $location, $rootScope) {
    $rootScope.PageType = "seller";
  
      if ($rootScope.UserType != "Seller") {
       $location.path("/");
        return;
      }
      ajax.get("https://localhost:44336/api/notices/all", success, error);
      function success(response) {
        $scope.notices = response.data;
        $scope.notices.forEach((element) => {
          var v = new Date(element.createdat);
          element.date = v.toDateString();
          element.time = v.toLocaleTimeString();
        });
      }
      function error(error) {}
  
      $scope.Search = function () {
        console.log("sellers");
        ajax.get("https://localhost:44336/api/notices/search/" + $scope.search+"/"+$rootScope.UserId,
          function success(response) {
            $scope.notices = response.data;
          },
          function (err) {
            console.log(err);
          }
        );
      }

      $scope.ShowAll = function () {
        ajax.get("https://localhost:44336/api/notices/all/"+$rootScope.UserId, success, error);
        function success(response) {
          $scope.notices = response.data;
        }
        function error(error) {
    
        }
      }

    
    }
  );
  