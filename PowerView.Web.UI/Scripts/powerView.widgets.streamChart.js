(function ($) {
    "use strict";
    // the widget definition, where "custom" is the namespace,
    // "colorize" the widget name
    $.widget("powerView.streamChart", {
        // default options
        options: {
            graphType: 'line',
            maxDataPoints: 100,
            updateInterval: 1000,
            controllerID: 'YY',
            metricName: 'XX'
        },

        // The constructor
        _create: function () {
            this.graph = new Rickshaw.Graph({
                element: this.element[0],
                renderer: this.options.graphType,
                series: new Rickshaw.Series.FixedDuration([{ name: 'one' }], undefined, {
                    timeInterval: this.options.updateInterval,
                    maxDataPoints: this.options.maxDataPoints,
                    timeBase: new Date().getTime() / 1000
                })
            });           

          
    
            this.yAxis = new Rickshaw.Graph.Axis.Y({
                graph: this.graph,
                tickFormat: Rickshaw.Fixtures.Number.formatKMBT,
            });

            this.graph.render();

                        
            this.interval = this._setIntervalWithContext(function () {
                var self = this;
                $.post("/api/metricProvider/pull/" + this.options.controllerID + "/" + this.options.metricName)
                    .done(function (data) {
                        var metricData = { one: data };
                        self.graph.series.addData(metricData);
                        self._refresh();
                    }).fail(function (error) {
                        alert(error);
                    });
            }, this.options.updateInterval, this);

            this._refresh();        
        },

        _setIntervalWithContext: function (code, delay, context) {
            return setInterval(function () {
                code.call(context);
            }, delay);
        },

        // Called when created, and later when changing options
        _refresh: function () {
            this.graph.update();            
        },

        // Events bound via _on are removed automatically
        // revert other modifications here
        _destroy: function () {           
            var clrInterval = clearInterval(this.interval);
        },
        
        // _setOptions is called with a hash of all options that are changing
        // always refresh when changing options
        _setOptions: function () {
            // _super and _superApply handle keeping the right this-context
            this._superApply(arguments);
            this._refresh();
        },

        // _setOption is called for each individual option that is changing
        _setOption: function (key, value) {            
            this._super(key, value);
        }
    });
}(jQuery));