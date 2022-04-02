app.controller("SellerDashboard", function ($scope, ajax, $rootScope) {
    ajax.get("https://localhost:44336/api/Order/GetAll/" + $rootScope.UserId, success, error);
    function success(response) {
      $scope.orders = response.data;
      console.log($scope.orders);
      $scope.totalIncome = 0;
      $scope.currentMonthIncome = 0;
      $scope.previousMonthIncome = 0;
      $scope.currentMonth = new Date().getMonth();
      console.log($scope.currentMonth);
      $scope.OrderCount = 0;
  
      if ($scope.previousMonth === 0) {
        $scope.previousMonth = 11;
      } else {
        $scope.previousMonth -= 1;
      }
      console.log($scope.previousMonth);
      $scope.orders.forEach((order) => {
        var v = new Date(order.createdat);
        order.month = v.getMonth();
        console.log(order.month);
        if (order.status === "accepted") {
          $scope.totalIncome += order.totalprice;
          $scope.OrderCount += 1;
          console.log($scope.OrderCount);
        }
        if (order.month === $scope.currentMonth && order.status === "accepted") {
          $scope.currentMonthIncome += order.totalprice;
        }
        if (order.month === $scope.previousMonth && order.status === "accepted") {
          $scope.previousMonthIncome += order.totalprice;
        }
      });
      console.log($scope.totalIncome);
      console.log($scope.currentMonthIncome);
      console.log($scope.previousMonthIncome);
      console.log($scope.OrderCount);
  
    }
    function error(error) {
  
    }
  });