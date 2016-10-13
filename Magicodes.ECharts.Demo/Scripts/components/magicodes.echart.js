//图表
//参数：
//  ajaxUrl:Ajax加载路径
//  isBlockUI:是否显示加载遮罩层
var instance = function(params, componentInfo) {
    var self = this;
    this.ajaxUrl = null;
    this.ajaxParams = null;
    if (typeof (echarts) == "undefined") {
        console.error("请引用echarts的相关脚本！");
        return;
    }
    //初始化并使用macarons主题
    self.myChart = echarts.init(componentInfo.element, "macarons");

    this.load = function() {
        self.myChart.showLoading();
        var ajaxOption = {
            url: self.ajaxUrl,
            isBlockUI: self.isBlockUI,
            success: function(data) {
                self.myChart.hideLoading();
                var option = data;
                console.log("option", data);
                if (option && typeof option === "object") {
                    self.myChart.setOption(option, true);
                }
            },
            error: function() {
                self.myChart.hideLoading();
            }
        };
        if (self.ajaxParams)
            ajaxOption.data = self.ajaxParams;
        if (mwc)
            mwc.restApi.get(ajaxOption);
        else
            wc.restApi.get(ajaxOption);
    };
    if (params) {
        this.isBlockUI = params.isBlockUI || false;
        if ($.isFunction(params.ajaxUrl)) {
            self.ajaxUrl = params.ajaxUrl();
            //添加订阅
            params.ajaxUrl.subscribe(function(newValue) {
                self.ajaxUrl = newValue;
                self.load();
            });
        } else {
            this.ajaxUrl = params.ajaxUrl;
        }
        self.load();
    }
};
var newschoiceViewModelInstance = {
    createViewModel: function(params, componentInfo) {
        return new instance(params, componentInfo);
    }
};
//按钮组选择组件
ko.components.register("echart",
{
    viewModel: newschoiceViewModelInstance,
    template: "<div></div>"
});