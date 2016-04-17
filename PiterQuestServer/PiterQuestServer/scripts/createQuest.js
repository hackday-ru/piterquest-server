var map;
 
function initialize() {
    var mapProp = {
        center: new google.maps.LatLng(59.891434, 30.319433),
      zoom:12,
      mapTypeId:google.maps.MapTypeId.ROADMAP
    };
    var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);
	google.maps.event.addListener(map, 'click', function(event) {
    placeMarker(event.latLng);
	}); 
  }
  
function addMarker()
  {
     var nlat = parseFloat($("#inputCoor1").val());
	 var nlng = parseFloat($("#inputCoor2").val());
	 var myLatLng = {lat: nlat, lng: nlng};
	 var mapProp = {
	     center: new google.maps.LatLng(59.891434, 30.319433),
      zoom:12,
      mapTypeId:google.maps.MapTypeId.ROADMAP
    };
    var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);

   var marker = new google.maps.Marker({
    position: myLatLng,
    map: map,
  });
  google.maps.event.addListener(map, 'click', function(event) {
    placeMarker(event.latLng);
	}); 
  }
  
  function placeMarker(location) {
	  var mapProp = {
	      center: new google.maps.LatLng(59.891434, 30.319433),
      zoom:13,
      mapTypeId:google.maps.MapTypeId.ROADMAP
    };
    var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);
	
    var marker = new google.maps.Marker({
        position: location, 
        map: map
    });
	$("#inputCoor1").val((location.lat() + '').substr(0,9));
	
	$("#inputCoor2").val((location.lng() + '').substr(0,9));
	
	google.maps.event.addListener(map, 'click', function(event) {
    placeMarker(event.latLng);
	}); 
  }

function removeAllElems()
{
	
    $("#questList").html("");
    map = new google.maps.Map(document.getElementById("googleMap"), mapProp);

}
