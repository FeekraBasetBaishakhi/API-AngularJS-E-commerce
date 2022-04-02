app.controller(
  "adminViewVouchers",
  function ($scope, ajax) {
 
    ajax.get("https://localhost:44336/api/vouchers/all", success, error);
    function success(response) {
      $scope.vouchers = response.data;
      console.log(response.data);
    }
    function error(error) {}

    $scope.search = function () {
      if ($scope.searchText === "") {
        ajax.get("https://localhost:44336/api/vouchers/all", success, error);
      } else {
        ajax.get(
          "https://localhost:44336/api/vouchers/search/" + $scope.searchText,
          function success(response) {
            $scope.vouchers = response.data;
          },
          function (err) {
            console.log(err);
          }
        );
      }
    };
  }
);