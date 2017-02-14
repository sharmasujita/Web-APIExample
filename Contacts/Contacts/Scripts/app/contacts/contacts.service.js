angular
    .module('ContactsApp')
    .factory('contact.service', ContactService);

ContactService.$inject = ['$http', '$q']

function ContactService($http, $q) {

    return {
        getAllContacts: getContacts
    };

    function getContacts() {
        return $http.get("api/person")
            .then(success, error);

        function success(response) {
            console.log(response)
            return response.data;
        };

        function error(error) {
            return $q.reject(error);
        };
    }
}