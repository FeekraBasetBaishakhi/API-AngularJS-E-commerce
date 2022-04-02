app.controller("SellerShowOrder", function ($scope, ajax,$rootScope) {
    ajax.get("https://localhost:44336/api/Order/GetAll/" + $rootScope.UserId, success, error);
    function success(response) {
      $scope.orders = response.data;
    }
    function error(error) {
  
    }
  
    $scope.Status = function (id, status) {
      console.log("sellers");
      console.log(id);
      console.log(status);
      ajax.get("https://localhost:44336/api/Order/Status/" + id + "/" + status,
        function success(response) {
          ajax.get("https://localhost:44336/api/Order/GetAll/" + $rootScope.UserId, success, error);
          function success(response) {
            $scope.orders = response.data;
          }
          function error(error) {
  
          }
        },
        function (err) {
          console.log(err);
        }
      );
    }
    $scope.Search = function () {
      console.log("sellers");
      ajax.get("https://localhost:44336/api/Order/Search/" + $scope.search+"/"+$rootScope.UserId,
        function success(response) {
          $scope.orders = response.data;
        },
        function (err) {
          console.log(err);
        }
      );
    }
  
    $scope.ShowAll = function () {
      ajax.get("https://localhost:44336/api/Order/GetAll/" + $rootScope.UserId, success, error);
      function success(response) {
        $scope.orders = response.data;
      }
      function error(error) {
    
      }
    }
  });