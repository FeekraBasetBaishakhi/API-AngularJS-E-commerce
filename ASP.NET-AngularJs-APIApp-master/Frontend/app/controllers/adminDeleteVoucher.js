app.controller(
    "adminDeleteVoucher",
    function ($scope, ajax, $location, $routeParams) {
   
      var id = $routeParams.id;
      ajax.get("https://localhost:44336/api/vouchers/" + id, success, error);
      function success(response) {
        $scope.voucher = response.data;
        // console.log(response.data);
      }
      function error(error) {
        console.log(error);
      }
  
      $scope.deleteVoucher = function (voucher) {
        if (confirm("Are you sure your want to delete?")) {
          ajax.delete(
            "https://localhost:44336/api/vouchers/delete/" + voucher.voucherid,
            voucher,
            function (response) {
              // console.log(response);
              $location.path("/admin/viewvouchers");
            },
            function (err) {
              console.log(err);
            }
          );
        }
      };
    }
  );
  