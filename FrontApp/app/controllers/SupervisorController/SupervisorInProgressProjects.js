app.controller("SupervisorInProgressProjects",function($scope,$http,ajax,$routeParams){
    ajax.get("https://localhost:44336/api/Project/In Progress",success,error);
    function success(response){
      $scope.InProgressProjects=response.data;
    }
    function error(error){
    }

    if($routeParams!= null)
    {
      ajax.post("https://localhost:44336/api/Project/StateCompleted/"+$routeParams.id,success,error);
      function success(response){
        
      }
      function error(error){
      }

    }
});