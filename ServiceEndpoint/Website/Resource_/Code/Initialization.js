var Initialization = {
    init: function() {
        txtGetPerson.observe('click', function() {
            Themelia.WCF.globalFaultHandler = function(ex) {
                alert('Failure: ' + ex);
            };
            //+
            var message = {
                personGuid: '72E0335A-2864-49d8-8060-12D6BEB01385'
            };
            Themelia.WCF.post({
                endpoint: Sample.Configuration.personServiceEndpoint,
                operation: 'GetPersonData',
                message: message,
                onSuccess: function(data) {
                    alert('Success: ' + data.FirstName + ' ' + data.LastName);
                }
            });
        });
    }
};