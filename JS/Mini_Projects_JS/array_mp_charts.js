
var chartData = {}, chartVis;

document.getElementById('titleSetButton').addEventListener('click', setTitle, false);
function setTitle(){
    var title = document.getElementById('titleInput').value;
    //set title obj
    chartData.title = {text: title};
}

document.getElementById('dataPointSetButton').addEventListener('click', setDataPoint, false);
function setDataPoint(){
    var dataSetIndex = parseInt(document.getElementById('dataSetSelectInput').value);
    var dataPointLabel = document.getElementById('dataPointLabelInput').value;
    var dataPointValue = parseFloat(document.getElementById('dataPointValueInput').value);
   
    //check for data property before assigning to it, generate if necessary
    if (!chartData.data){
        chartData.data = [];
    }
    //check if data index is null, assign 'blank' canvasjs data obj if so
    if (!chartData.data[dataSetIndex]){
        chartData.data[dataSetIndex] = {type: 'column', dataPoints: []};
    }
    //push new datapoint obj to datapoints array
    chartData.data[dataSetIndex].dataPoints.push({label: dataPointLabel, y: dataPointValue});
}
document.getElementById('drawChartButton').addEventListener('click', drawChart, false);
function drawChart(){
    var chartContainer = document.getElementById('chartContainer');
    chartData.height = 260;
    //hide chart to reset height
    chartContainer.style.display = 'none';
    //generate and render chart
    chartVis = new CanvasJS.Chart('chartContainer', chartData);
    chartVis.render();
    //show chart
    chartContainer.style.display = 'block';
}