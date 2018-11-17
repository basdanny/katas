
function Car() {
    var  _odometer = 0;
    var _gas = 100;

    this.drive = function( miles ) {
      _odometer += Math.abs( miles );
    };
  
    
    Object.defineProperties( this, {
      "odometer": {
        "get": function() { return _odometer; }
      }
    } );
  }
  
  var subaru = new Car();
  subaru.drive( 500 );
  console.log(subaru.odometer);     // 500
  subaru.odometer = 0; // does nothing
  console.log(subaru.odometer);     // 500

  