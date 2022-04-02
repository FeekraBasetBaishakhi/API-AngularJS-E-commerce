app.controller("SellerHome", function ($scope, $rootScope) {
    $rootScope.UserType = "Seller";
    $rootScope.PageType = "seller";
    
    console.log($rootScope.UserName);
    $scope.name = $rootScope.UserName;
     console.log($scope.name);
    $scope.id = $rootScope.UserId;
    $scope.type = $rootScope.UserType;
});