app.factory("ajax",function($http,$q){
  var resp=undefined;
  return{
    say:function(){
      return "Hello ajax";
    },
    get:function(url,success,error){
        $http.get(url).then(success,error);
    },
    post:function(url,data,success,error){
        $http.post(url,data).then(success,error);
    },
    put: function (url, data, success, error) {
      $http.put(url, data).then(success, error);
    },
    delete: function (url, data, success, error) {
      $http.delete(url, data).then(success, error);
    },
  };
});