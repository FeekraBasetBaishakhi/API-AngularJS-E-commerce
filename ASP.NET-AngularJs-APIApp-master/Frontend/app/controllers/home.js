app.controller(
    "home",
    function ($scope, $http,  $rootScope) {
      $rootScope.PageType = "home";
  
      console.log($rootScope.PageType);
      console.log($rootScope.UserType);
  
    }
  );
  