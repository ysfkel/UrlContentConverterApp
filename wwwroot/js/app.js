(function () {

    angular.module('app', [])
        .controller('ctr', function ($http) {
            var vm = this;
            vm.actions = {};
            //declares model to be used on form
            vm.model = {};

            //makes a rest call to get md5 hash for the 
            //content of the url provided
            vm.actions.getHash = function (e) {
                e.preventDefault();
                $http
                    .post('/api/hash', vm.model)
                    .then(respnseHandler, respnseHandler);
            }

            //response handler
            function respnseHandler(response) {
                console.log(response)
                switch (response.status) {
                    case 200:
                        {
                            vm.resultTitle="MD5 Hash";
                            vm.result = response.data.hash;
                            break;
                        }
                    case 400:
                        {
                            vm.result = response.data.Url[0];
                            vm.resultTitle="Error";
                            break;
                        }
                    case 500:
                        {
                            vm.result = "a server side error occured! Please try a url in the format http://www.example.com";
                            break;
                        }
                    default:{
                        vm.result="No result to display";
                        break;
                    }
                }
            }
        })



})();