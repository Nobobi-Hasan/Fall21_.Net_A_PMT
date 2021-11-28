app.controller("EnrollmentDecline",function($scope,$http,ajax,$routeParams){
    ajax.get("https://localhost:44336/api/Project/Enrollment/All",success,error);
    function success(response){
        $scope.route=$routeParams.id;
      $scope.Enrollments=response.data;
    }
    function error(error){
    }

    if($routeParams!= null)
    {
        
      ajax.post("https://localhost:44336/api/Project/Enroll/Decline/"+$routeParams.id,success,error);
      function success(response){
        
      }
      function error(error){
      }

    }
});