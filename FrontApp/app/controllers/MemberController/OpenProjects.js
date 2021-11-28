app.controller("OpenProjects",function($scope,$http,ajax,$routeParams){
    ajax.get("https://localhost:44336/api/Member/OpenProjects",success,error);
    function success(response){
      $scope.OpenProjects=response.data;
    }
    function error(error){
    }

    if($routeParams!= null)
    {
      ajax.post("https://localhost:44336/api/Member/Enroll/"+$routeParams.id,success,error);
      function success(response){
        
      }
      function error(error){
      }

    }
});


// app.controller("OpenProjects",function($scope,ajax,$routeParams){
//   ajax.get("https://localhost:44336/api/Member/Project/"+$routeParams.status,success,error);
//   function success(response){
//     $scope.MemberProjects=response.data;
//     $scope.status = $routeParams.status;
//     //$scope.route = $routeParams.id;
//   }
//   function error(error){
//   }
// });
