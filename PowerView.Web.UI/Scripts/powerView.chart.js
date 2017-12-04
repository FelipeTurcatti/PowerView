var tv = 1000;

// instantiate our graph!
var graph = new Rickshaw.Graph({
	element: document.getElementById("chart"),
	width: 900,
	height: 500,
	renderer: 'line',
	series: new Rickshaw.Series.FixedDuration([{ name: 'one' }], undefined, {
		timeInterval: tv,
		maxDataPoints: 100,
		timeBase: new Date().getTime() / 1000
	})
});

var y_ticks = new Rickshaw.Graph.Axis.Y({
    graph: graph,
    orientation: 'left',
    tickFormat: Rickshaw.Fixtures.Number.formatKMBT,
    element: document.getElementById('y_axis')
});

graph.render();

// add some data every so often
var iv = setInterval(function () {

    $.post("/api/metricProvider/pull")
		.done(function (data) {
			var metricData = { one: data };
			graph.series.addData(metricData);
			graph.render();
	}).fail(function (error) {
  		alert(error);
	});
}, tv);