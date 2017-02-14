angular
    .module('ContactsApp')
    .component('contact', {
        templateUrl: 'Scripts/app/contacts/contact.template.html',
        controller: ContactController
    });

ContactController.$inject = ['contact.service']

function ContactController(contactService) {

    var self = this;

    self.contacts = [];
    self.selectContact = '';

    self.$onInit = function () {
        self.getContacts();
    }

    self.getContacts = function () {
        contactService.getAllContacts()
            .then(function (response) {
                console.log(response);
                self.contacts = response;
            });
    }
    
}

