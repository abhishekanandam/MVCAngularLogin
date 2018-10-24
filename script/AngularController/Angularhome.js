var app = angular.module('homeapp', []);

app.controller("HomeController", function ($scope,$http) {
    $scope.btntext = "Login";
    $scope.login = function () {
        $scope.btntext = "Please wait..!";
        $http({
            method: "POST",
            url: '/Home/userlogin',
            data: $scope.user
        }).success(function (d) {
            $scope.btntext = 'Login';
            if (d==1) {
                window.location.href = '/Home/dashboard';
            }
            else {
                alert(d);
            }
            $scope.user = null;
        }).error(function () {
            alert('failed');
        })
    }

})