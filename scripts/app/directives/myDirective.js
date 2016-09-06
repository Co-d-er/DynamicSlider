'use strict';

app.directive('myDirective', function () {
    return {
        link: function (scope, element, attrs) {

        },
        templateUrl: 'scripts/app/directives/templates/mySlider.html',
        replace: false,
        scope: {
            path: "@"
        }
    }
});