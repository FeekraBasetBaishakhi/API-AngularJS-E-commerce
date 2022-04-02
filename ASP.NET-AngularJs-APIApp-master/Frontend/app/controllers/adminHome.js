app.controller(
 "adminHome",
    function ($scope, $http, ajax, $location, $routeParams, $rootScope) {
        $rootScope.UserType = "Admin";
        $rootScope.PageType = "admin";
        
        console.log($rootScope.UserName);
        $scope.name = $rootScope.UserName;
        console.log($scope.name);
        $scope.id = $rootScope.UserId;
        $scope.type = $rootScope.UserType;
  
      
      ajax.get("https://localhost:44336/api/orders/all", success, (err) => console.log(err));
      function success(response) {
        // console.log(response.data);
        $scope.orders = response.data;
        // console.log($scope.orders);
        $scope.totalIncome = 0;
        $scope.currentMonthIncome = 0;
        $scope.previousMonthIncome = 0;
        $scope.currentMonth = new Date().getMonth();
        $scope.previousMonth = new Date().getMonth();
        if ($scope.previousMonth === 0) {
          $scope.previousMonth = 11;
        } else {
          $scope.previousMonth -= 1;
        }
        $scope.orders.forEach((order) => {
          var v = new Date(order.createdat);
          order.month = v.getMonth();
          if (order.status === "accepted") {
            $scope.totalIncome += order.totalprice;
          }
          if (order.month === $scope.currentMonth && order.status === "accepted") {
            $scope.currentMonthIncome += order.totalprice;
          }
          if (order.month === $scope.previousMonth && order.status === "accepted") {
            $scope.previousMonthIncome += order.totalprice;
          }
        });
  
        // console.log(totalIncome);
      }
    }
  );
  