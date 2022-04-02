app.controller(
    "adminEditVoucher",
    function ($scope,  ajax, $location, $routeParams) {
    
      var id = $routeParams.id;
      $scope.statuses = ["Active", "Inactive"];
    
      ajax.get("https://localhost:44336/api/vouchers/" + id, success, error);
      function success(response) {
        $scope.voucher = response.data;
        console.log(response.data);
      }
      function error(error) {}
  
      $scope.editVoucher = function (voucher) {
        ajax.put(
          "https://localhost:44336/api/vouchers/edit",
          voucher,
          function (response) {
            // console.log(response);
            $location.path("/admin/viewvouchers");
          },
          function (err) {
            console.log(err);
          }
        );
      };
    }
  );
  