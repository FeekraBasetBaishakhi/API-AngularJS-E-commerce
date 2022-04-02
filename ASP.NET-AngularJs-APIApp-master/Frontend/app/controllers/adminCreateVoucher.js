app.controller("adminCreateVoucher", function ($scope, ajax, $location, $rootScope) {
   
    $scope.statuses = ["Active", "Inactive"];
  
    $scope.createVoucher = function (voucher) {
      voucher.userid = $rootScope.UserId;
      // console.log(voucher);
      ajax.post(
        "https://localhost:44336/api/vouchers/add",
        voucher,
        function (response) {
          console.log(response);
          $location.path("/admin/viewvouchers");
        },
        function (err) {
          console.log(err);
        }
      );
    };
  });
  