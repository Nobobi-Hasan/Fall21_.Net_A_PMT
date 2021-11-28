// app.controller("InProgressProjects",function($scope,$http){
//   $scope.name = "abc";
  
//   $http.get("https://jsonplaceholder.typicode.com/posts/1");
//   then(function(resp){
//     $scope.InProgressProjects=resp.data.slice(0,5);
    
//   });
// });


app.controller("MemberProjects",function($scope,ajax,$routeParams){
  ajax.get("https://localhost:44336/api/Member/Project/"+$routeParams.status,success,error);
  function success(response){
    $scope.MemberProjects=response.data;
    $scope.status = $routeParams.status;
    //$scope.route = $routeParams.id;
  }
  function error(error){
  }
});

// app.controller("InProgressProjects",function($scope,ajax,$routeParams){
//   ajax.get("https://jsonplaceholder.typicode.com/posts/"+$routeParams.id,success,error);
//   function success(response){
//     $scope.InProgressProjects=response.data;
//     $scope.name = "abc";
//     $scope.route = $routeParams.id;
//   }
//   function error(error){

//   }

// });