(function() {
    //这里可以设置全局配置，比如window.mcs.echarts.settings.theme="macarons"; 
    window.mcs = window.mcs || {};
    window.mcs.echarts = window.mcs.echarts || {};
    window.mcs.echarts.settings = {};
    //图表组件
    //参数：
    //  ajaxUrl:Ajax加载路径
    //  isBlockUI:是否显示加载遮罩层
    //  theme:主题
    var instance = function (params, componentInfo) {
        var self = this;
        this.ajaxUrl = null;
        this.ajaxParams = null;

        if (typeof (echarts) == "undefined") {
            console.error("请引用echarts的相关脚本！");
            return;
        }
        //加载配置
        this.load = function () {
            self.myChart.showLoading();
            var ajaxOption = {
                url: self.ajaxUrl,
                isBlockUI: self.isBlockUI,
                success: function (data) {
                    self.myChart.hideLoading();
                    var option = data;
                    console.log("option", data);
                    if (option && typeof option === "object") {
                        self.myChart.setOption(option, true);
                    }
                },
                error: function () {
                    self.myChart.hideLoading();
                }
            };
            if (self.ajaxParams)
                ajaxOption.data = self.ajaxParams;

            if (typeof (mwc) !== "undefined")
                mwc.restApi.get(ajaxOption);
            else if (typeof (wc) !== "undefined")
                wc.restApi.get(ajaxOption);
            else
                $.ajax(ajaxOption);
        };
        //根据参数加载
        if (params) {
            this.isBlockUI = params.isBlockUI || false;
            //支持动态修改地址并触发图表刷新
            if ($.isFunction(params.ajaxUrl)) {
                self.ajaxUrl = params.ajaxUrl();
                //添加订阅
                params.ajaxUrl.subscribe(function (newValue) {
                    self.ajaxUrl = newValue;
                    self.load();
                });
            } else {
                this.ajaxUrl = params.ajaxUrl;
            }
            //允许使用全局设置
            var theme = window.mcs.echarts.settings.theme || params.theme;
            //初始化并使用主题
            self.myChart = typeof (theme) == 'undefined' ? echarts.init(componentInfo.element) : echarts.init(componentInfo.element, theme);
            self.load();
        }
    };
    var echartViewModelInstance = {
        createViewModel: function (params, componentInfo) {
            return new instance(params, componentInfo);
        }
    };
    //注册Echart组件
    ko.components.register("echart",
    {
        viewModel: echartViewModelInstance,
        template: "<div></div>"
    });
})();