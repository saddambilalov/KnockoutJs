// This is a simple *viewmodel* - JavaScript that defines the data and behavior of your UI
function IndexViewModel() {
    this.firstName = ko.observable("");
    this.lastName = ko.observable("");
    this.isAdd = ko.observable(true);

    // observable arrays are update binding elements upon array changes
    this.students = ko.observableArray([]);

    this.addStudent = () => {
        this.isAdd(true);

        this.students.push({
            id: Date.now(),
            firstName: this.firstName(),
            lastName: this.lastName()
        });

        this.firstName("");
        this.lastName("");
    };

    this.editStudent = (student) => {
        this.isAdd(false);

        this.firstName(student.firstName);
        this.lastName(student.lastName);
    }

    this.saveStudent = () => {
        this.isAdd(true);

        this.students.push({
            id: Date.now(),
            firstName: this.firstName(),
            lastName: this.lastName()
        });

        this.firstName("");
        this.lastName("");
    };

    this.removeStudent = (student) => {
        this.students.remove(student);
    }
}

// Activates knockout.js
ko.applyBindings(new IndexViewModel());