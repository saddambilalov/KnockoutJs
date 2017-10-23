// This is a simple *viewmodel* - JavaScript that defines the data and behavior of your UI
function IndexViewModel() {
    this.firstName = ko.observable("");
    this.lastName = ko.observable("");

    // observable arrays are update binding elements upon array changes
    this.students = ko.observableArray([]);

    this.addStudent = () => {
        this.students.push({
            firstName: this.firstName(),
            lastName: this.lastName()
        });

        this.firstName("");
        this.lastName("");
    };


}

// Activates knockout.js
ko.applyBindings(new IndexViewModel());