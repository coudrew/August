(function(aDate){
    var day = (function(val){
    switch(val){
        case 0:
            return "Sunday";
            break;
        case 1:
            return "Monday";
            break;
        case 2:
            return "Tuesday";
            break;
        case 3:
            return "Wednesday";
            break;
        case 4:
            return "Thursday";
            break;
        case 5:
            return "Friday";
            break;
        case 6:
            return "Saturday";
            break;
        default:
            return "Today";
        };})(aDate.getDay())
    var hour = aDate.getHours();
    var minutes = aDate.getMinutes();
    document.getElementById('demo').innerHTML = `${day}, ${hour}:${minutes}`;
})(new Date());