app.controller('myCtrl', function ($scope, $interval, $http, $log) {
    $scope.load = function () {
        $http.get("/api/Pictures").then(function (pl) {
            $scope.Respond = pl.data;
        },
              function (errorPl) {
                  $log.error('failure loading', errorPl);
              });
    };
    $scope.load();

    $interval(function () {
        $http.get("/api/Random").then(function (pl) {
            $scope.Index = pl.data;
            console.log('hello');
        },
              function (errorPl) {
                  $log.error('failure loading', errorPl);
              });
    }, 2000);
});
