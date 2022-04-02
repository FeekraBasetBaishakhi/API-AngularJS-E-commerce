var app = angular.module("myApp", ["ngRoute"]);

app.config([
  "$routeProvider",
  "$locationProvider",
  function ($routeProvider, $locationProvider) {
    $routeProvider
      .when("/", {
        templateUrl: "views/pages/home.html",
        controller: "home",
      })
      .when("/seller/package/edit/:id", {
        templateUrl: "views/pages/SellerPackageEdit.html",
        controller: "SellerPackageEdit",
      })
      .when("/SellerHome", {
        templateUrl: "views/pages/SellerHome.html",
        controller: "SellerHome",
      })
      .when("/seller/showpackages", {
        templateUrl: "views/pages/SellerShowPackages.html",
        controller: "SellerShowPackages",
      })
      .when("/seller/addpackage", {
        templateUrl: "views/pages/SellerAddPackage.html",
        controller: "SellerAddPackage",
      })
      .when("/seller/showorder", {
        templateUrl: "views/pages/SellerShowOrder.html",
        controller: "SellerShowOrder",
      })
      .when("/showorder/:id", {
        templateUrl: "views/pages/orderdetails.html",
        controller: "orderdetails",
      })
      .when("/seller/myprofile", {
        templateUrl: "views/pages/SellerProfile.html",
        controller: "SellerProfile",
      })
      .when("/seller/viewnotices", {
        templateUrl: "views/pages/sellerViewNotices.html",
        controller: "sellerViewNotices",
      })
      .when("/login", {
        templateUrl: "views/pages/login.html",
        controller: "login",
      })
      .when("/admin/viewusers", {
        templateUrl: "views/pages/adminViewUsers.html",
        controller: "adminViewUsers",
      })
      .when("/admin/createuser", {
        templateUrl: "views/pages/adminCreateUser.html",
        controller: "adminCreateUser",
      })
      .when("/admin/edituser/:id", {
        templateUrl: "views/pages/adminEditUser.html",
        controller: "adminEditUser",
      })
      .when("/admin/deleteuser/:id", {
        templateUrl: "views/pages/adminDeleteUser.html",
        controller: "adminDeleteUser",
      })
      .when("/admin/viewnotices", {
        templateUrl: "views/pages/adminViewNotices.html",
        controller: "adminViewNotices",
      })
      .when("/admin/createnotice", {
        templateUrl: "views/pages/adminCreateNotice.html",
        controller: "adminCreateNotice",
      })
      .when("/admin/editnotice/:id", {
        templateUrl: "views/pages/adminEditNotice.html",
        controller: "adminEditNotice",
      })
      .when("/admin/deletenotice/:id", {
        templateUrl: "views/pages/adminDeleteNotice.html",
        controller: "adminDeleteNotice",
      })
      .when("/admin/viewvouchers", {
        templateUrl: "views/pages/adminViewVouchers.html",
        controller: "adminViewVouchers",
      })
      .when("/admin/createvoucher", {
        templateUrl: "views/pages/adminCreateVoucher.html",
        controller: "adminCreateVoucher",
      })
      .when("/admin/editvoucher/:id", {
        templateUrl: "views/pages/adminEditVoucher.html",
        controller: "adminEditVoucher",
      })
      .when("/admin/deletevoucher/:id", {
        templateUrl: "views/pages/adminDeleteVoucher.html",
        controller: "adminDeleteVoucher",
      })
      .when("/admin/adminactions", {
        templateUrl: "views/pages/adminActions.html",
        controller: "adminActions",
      })
      .when("/admin/viewauditlog", {
        templateUrl: "views/pages/adminViewAuditLog.html",
        controller: "adminViewAuditLog",
      })
      .when("/admin/viewcomplains", {
        templateUrl: "views/pages/adminViewComplains.html",
        controller: "adminViewComplains",
      })
      .when("/admin/editcomplain/:id", {
        templateUrl: "views/pages/adminEditComplain.html",
        controller: "adminEditComplain",
      })
      .when("/admin/deletecomplain/:id", {
        templateUrl: "views/pages/adminDeleteComplain.html",
        controller: "adminDeleteComplain",
      })
      .when("/admin/", {
        templateUrl: "views/pages/adminHome.html",
        controller: "adminHome",
      })
      .when("/seller/dashboard", {
        templateUrl: "views/pages/SellerDashboard.html",
        controller: "SellerDashboard",
      })
      .when("/logout", {
        templateUrl: "views/pages/login.html",
        controller: "logout",
      })
      .when("/registration", {
        templateUrl: "views/pages/registration.html",
        controller: "registration",
      })
      .otherwise({
        redirectTo: "/",
      });
   
  },
]);

app.config(function($httpProvider){

  $httpProvider.interceptors.push("intercepror");
});






app.controller("myController", function ($rootScope) {
  $rootScope.isUserLoggedIn = false;
  $rootScope.PageType = "home";

  $rootScope.UserId = "";
  $rootScope.UserType = "";
  $rootScope.UserName = "";
  $rootScope.UserEmail = "";
  $rootScope.UserPhone = "";
  $rootScope.UserPassword = "";
  if (localStorage.getItem("user")) {
    var myUser = JSON.parse(localStorage.getItem("user"));
    $rootScope.UserId = myUser.userid;
    $rootScope.UserType = myUser.usertype;
    $rootScope.UserName = myUser.name;
    $rootScope.UserEmail = myUser.email;
    $rootScope.UserPhone = myUser.phone;
    $rootScope.UserPassword = myUser.password;

    $rootScope.isUserLoggedIn = true;
  }

});
