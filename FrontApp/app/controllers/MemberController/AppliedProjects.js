app.controller("AppliedProjects",function($scope,$http,ajax){
    ajax.get("https://localhost:44336/api/Member/Project/Applied",success,error);
    function success(response){
      $scope.AppliedProjects=response.data;
    }
    function error(error){

    }

});
