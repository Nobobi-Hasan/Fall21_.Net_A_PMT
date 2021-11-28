app.controller("SupervisorCompletedProjects",function($scope,$http,ajax,$routeParams){
    ajax.get("https://localhost:44336/api/Project/Completed",success,error);
    function success(response){
      $scope.CompletedProjects=response.data;
    }
    function error(error){
    }

    // if($routeParams!= null)
    // {
    //   ajax.post("https://localhost:44336/api/Member/Enroll/"+$routeParams.id,success,error);
    //   function success(response){
        
    //   }
    //   function error(error){
    //   }

    // }
});