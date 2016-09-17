// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :ToolBoxFeature.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:15
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

namespace Magicodes.ECharts.CommonDefinitions
{
    public class ToolBoxFeature
    {
        public ToolBoxFeature()
        {
            Mark = new FeatureMark();
            DataZoom = new FeatureDataZoom();
            MagicType = new FeatureMagicType();
            Restore = new FeatureRestore();
            SaveAsImage = new FeatureSaveAsImage();
        }

        /// <summary>
        ///     辅助线标志
        /// </summary>
        public FeatureMark Mark { get; set; }

        /// <summary>
        ///     框选区域缩放
        /// </summary>
        public FeatureDataZoom DataZoom { get; set; }

        /// <summary>
        ///     数据视图
        /// </summary>
        public FeatureDataView DataView { get; set; }

        /// <summary>
        ///     动态类型切换
        /// </summary>
        public FeatureMagicType MagicType { get; set; }

        /// <summary>
        ///     还原 复位原始图表
        /// </summary>
        public FeatureRestore Restore { get; set; }

        /// <summary>
        ///     保存图片（IE8-不支持）
        /// </summary>
        public FeatureSaveAsImage SaveAsImage { get; set; }

        /// <summary>
        ///     辅助线标志
        /// </summary>
        public class FeatureMark
        {
            public FeatureMark()
            {
                Show = true;
            }

            public bool Show { get; set; }

            public MarkTitle Title { get; set; }

            public MarkLineStyle LineStyle { get; set; }

            public class MarkTitle
            {
                public string Mark = "辅助线开关";
                public string MarkClear = "清空辅助线";
                public string MarkUndo = "删除辅助线";
            }

            public class MarkLineStyle
            {
                public string Color = "#1e90ff";
                public string Type = "dashed";
                public int Width = 2;
            }
        }

        /// <summary>
        ///     框选区域缩放
        /// </summary>
        public class FeatureDataZoom
        {
            public FeatureDataZoom()
            {
                Show = true;
            }

            public bool Show { get; set; }

            public class DataZoomTitle
            {
                public string DataZoom = "区域缩放";
                public string DataZoomReset = "区域缩放-后退";
            }
        }

        /// <summary>
        ///     数据视图
        /// </summary>
        public class FeatureDataView
        {
            public string[] Lang = {"数据视图", "关闭", "刷新"};
            public bool ReadOnly = true;
            public string Title = "数据视图";

            public FeatureDataView()
            {
                Show = true;
            }

            public bool Show { get; set; }
        }

        /// <summary>
        ///     动态类型切换
        /// </summary>
        public class FeatureMagicType
        {
            public string[] Type = {"line", "bar", "stack", "tiled"};

            public FeatureMagicType()
            {
                show = true;
            }

            public bool show { get; set; }

            public class MagicTypeTitle
            {
                public string Bar = "动态类型切换-柱形图";
                public string Line = "动态类型切换-折线图";
                public string Stack = "动态类型切换-堆积";
                public string Tiled = "动态类型切换-平铺";
            }
        }

        /// <summary>
        ///     还原 复位原始图表
        /// </summary>
        public class FeatureRestore
        {
            public FeatureRestore()
            {
                Show = true;
                Title = "还原";
                Color = "black";
            }

            public bool Show { get; set; }
            public string Title { get; set; }
            public string Color { get; set; }
        }

        /// <summary>
        ///     保存图片（IE8-不支持）
        /// </summary>
        public class FeatureSaveAsImage
        {
            public string[] Lang = {"点击本地保存"};

            public string Type = "jpeg";

            public FeatureSaveAsImage()
            {
                Show = true;
                Title = "保存为图片";
            }

            public bool Show { get; set; }

            public string Title { get; set; }
        }
    }
}