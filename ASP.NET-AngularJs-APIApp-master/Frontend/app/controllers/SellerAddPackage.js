app.controller("SellerAddPackage", function ($scope, ajax, $rootScope) {
  
    $scope.addproduct = function () {
      console.log($scope.Name);
      if($scope.Name!=undefined||$scope.Price!=undefined||$scope.Category!=undefined||$scope.Details!=undefined||$scope.Discount!=undefined||$scope.Advertisement!=undefined||$scope.Location!=undefined){
      var d = {
        packagename: $scope.Name,
        price: $scope.Price,
        category: $scope.Category,
        details: $scope.Details,
        discount: $scope.Discount,
        advertisement: $scope.Advertisement,
        location: $scope.Location
      };
      console.log($rootScope.UserId);
      ajax.post("https://localhost:44336/api/Package/Add/"+$rootScope.UserId, d,
        function (response) {
          alert("Package added");
        },
        function (err) {
          console.log(err);
        });
      }
      else{
        alert("Fill up all fields");
      }
    };
  });