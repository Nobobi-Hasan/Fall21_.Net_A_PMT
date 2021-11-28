app.controller("AddProjects",function($scope,$http,ajax){

    $scope.submit = function(){
       

        var data = {
            Title: $scope.Title,
            Description: $scope.Description,
            CategoryId: $scope.CategoryId,
            SupervisorId: $scope.SupervisorId,
        }

        ajax.post("https://localhost:44336/api/Project/Create", data, success, error)
        function success(response){
            alert("Added new Project");
        }
        function error(error){
            alert("Project not added!!!!");
        }
    }
});
