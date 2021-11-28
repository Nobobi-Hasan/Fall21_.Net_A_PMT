var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/Member/OpenProjects", {
        templateUrl : "views/pages/OpenProjects.html",
        controller: 'OpenProjects'
    })
    .when("/Member/AppliedProjects", {
        templateUrl : "views/pages/AppliedProjects.html",
        controller: 'AppliedProjects'
    })
    .when("/Member/Projects/:status", {
        templateUrl : "views/pages/MemberProjects.html",
        controller: 'MemberProjects'
    })

    .when("/Member/Project/Enroll/:id", {
        templateUrl : "views/pages/OpenProjects.html",
        controller: 'OpenProjects'
    })


// ////////////////////////////////////////////////////////////////////////////
    
    .when("/Supervisor/AddProject", {
        templateUrl : "views/pages/Supervisor/AddProjects.html",
        controller: 'AddProjects'
    })




    .when("/Supervisor/Enrollments", {
        templateUrl : "views/pages/Supervisor/Enrollments.html",
        controller: 'Enrollments'
    })

    .when("/Supervisor/Enrollments/Confirm/:id", {
        templateUrl : "views/pages/Supervisor/Enrollments.html",
        controller: 'Enrollments'
    })

    .when("/Supervisor/Enrollments/Decline/:id", {
        templateUrl : "views/pages/Supervisor/Enrollments.html",
        controller: 'EnrollmentDecline'
    })




    .when("/Supervisor/Projects/Open", {
        templateUrl : "views/pages/Supervisor/OpenProjects.html",
        controller: 'SupervisorOpenProjects'
    }) 
    .when("/Supervisor/Projects/Open/:id", {
        templateUrl : "views/pages/Supervisor/OpenProjects.html",
        controller: 'SupervisorOpenProjects'
    })




    .when("/Supervisor/Projects/In Progress", {
        templateUrl : "views/pages/Supervisor/InProgressProjects.html",
        controller: 'SupervisorInProgressProjects'
    })
    .when("/Supervisor/Projects/In Progress/:id", {
        templateUrl : "views/pages/Supervisor/InProgressProjects.html",
        controller: 'SupervisorInProgressProjects'
    })




    .when("/Supervisor/Projects/Completed", {
        templateUrl : "views/pages/Supervisor/CompletedProjects.html",
        controller: 'SupervisorCompletedProjects'
    })




    




////////////////////////////////////////////////////////////////////
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
