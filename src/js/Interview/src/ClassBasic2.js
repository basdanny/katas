(function () {
    'use strict';

    var Car = function CarCtor(milage) {       
        var _milage = 0;

        Object.defineProperties(this, {
            'type': {writable: true, enumerable:true, value: 'Skoda'},
            'model': {writable: true, enumerable:true, value: 'Rapid'},
            'milage': {writable: false, enumerable:true, value: milage}
        });

    };

    var car = new Car(10000);
    console.log(car);

    car.type='bmw';
    car.model='m3';
    
    console.log(car);

})();