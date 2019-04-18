


# 《深入浅出WPF》视频列表

 

## 序言

- 什么是WPF
- 为什么要学习WPF

## 第一章 XAML概览

- XAML是什么？
- XAML有哪些优点

## 第二章 从零起步认识XAML

- 新建WPF项目 【<http://www.cnblogs.com/prism/archive/2010/07/20/1781026.html>】

- 剖析最简单的XAML代码 【<http://www.cnblogs.com/prism/archive/2010/07/20/1781026.html>】

## 第三章 系统学习XAML语法

- XAML文档的树形结构 【http://www.cnblogs.com/prism/archive/2010/07/22/1782661.html】
  　　2. XAML中为对象属性赋值的语法
       　　2.1 使用标签的Attribute为对象属性赋值 【http://www.cnblogs.com/prism/archive/2010/07/23/1783408.html】
       　　　　2.2 使用TypeConverter 【http://www.cnblogs.com/prism/archive/2010/07/23/1783408.html】
       　　　　2.3 属性元素 【http://www.cnblogs.com/prism/archive/2010/07/26/1785086.html】
       　　　　2.4 标记扩展（Markup Extensions）【http://www.cnblogs.com/prism/archive/2010/07/26/1785086.html】
  　　3. 事件处理器与代码后置 【http://www.cnblogs.com/prism/archive/2010/09/06/1818910.html】
  　　4. 导入程序集和引用其中的名称空间 【http://www.cnblogs.com/prism/archive/2010/09/06/1818910.html】
  　　5. XAML的注释 【http://www.cnblogs.com/prism/archive/2010/09/06/1818910.html】

## 第四章 x名称空间详解

　　1. x名称空间里都有什么【<http://www.cnblogs.com/prism/archive/2010/09/13/1824789.html>】
　　2. x名称空间中的Attribute
　　　　2.1 x:Class【<http://www.cnblogs.com/prism/archive/2010/09/13/1824789.html>】
　　　　2.2 x: ClassModifier【<http://www.cnblogs.com/prism/archive/2010/09/13/1824789.html>】
　　　　2.3 x: Name【<http://www.cnblogs.com/prism/archive/2010/09/13/1824789.html>】
　　　　2.4 x:FieldModifier【<http://www.cnblogs.com/prism/archive/2010/09/13/1824789.html>】
　　　　2.5 x:Key
　　　　2.6 x:Shared
　　3. x名称空间中的标记扩展
　　　　3.1 x:Type
　　　　3.2 x:Null
　　　　3.3 标记扩展实例的两种声明语法
　　　　3.4 x:Array
　　　　3.5 x:Static
　　4. XAML指令元素

## 第五章 控件与布局

* 控件到底是什么
* WPF的内容模型
    * 内容与内容属性

* 各类内容模型详解
    * ContentControl族
    * HeaderedContentControl族
    * ItemsControl族
    * 3.4 HeaderedItemsControl族
    * 3.5 Decorator族
    * 3.6 TextBlock和TextBox
    * 3.7 Shape族元素
    * 3.8 Panel族元素
* UI布局（Layout）
    * 布局元素
    * Grid
    * StackPanel
    * Canvas
    * DockPanel
    * WrapPanel

## 第六章 深入浅出话Binding

* Data Binding在WPF中的地位
* Binding基础
* Binding的源与路径
    * 把控件作为Binding源与Binding标记扩展
    * 控制Binding的方向及数据更新
    * Binding的路径（Path）
    * “没有Path”的Binding
    * 为Binding指定源（Source）的几种方法
    * 省略Source的Binding
    * 使用集合对象作数据源
    * 使用使用ADO.NET对象作为Binding的源
    * 使用使用XML数据作为Binding的源
    * 使用使用LINQ检索结果作为数据源
    * 使用ObjectDataProvider
    * 使用Binding的RelativeSource
* Binding对数据的转换与校验
    * Binding的数据校验
    * Binding的数据转换
* MultiBinding（多路Binding）

## 第七章 深入浅话属性

* 属性（Property）的来龙去脉
* 依赖属性（Dependency Property）
    * 依赖属性对内存的使用方式
    * 声明和使用依赖属性
    * 依赖属性值存取的秘密
* 附加属性（Attached Properties）

## 第八章 深入浅出话事件

* 近观WPF的树形结构
* 事件的来龙去脉
* 深入浅出路由事件
    * 使用WPF内置路由事件
    * 自定义路由事件
    * Source与OriginalSource
    * 事件也附加——深入浅出附加事件

## 第九章 深入浅出话命令

* 命令系统的基本元素与关系
    * 命令系统的基本元素
    * 基本元素之间的关系
    * 小试命令
    * WPF的命令库
    * 命令参数
    * 命令与Binding的结合
* 近观命令
    * ICommand接口与RoutedCommand
    * 自定义Command

## 第十章 深入浅出话资源

* WPF对象级资源的定义与查找
* 且“静”且“动”用资源
* 向程序添加二进制资源
* 使用Pack URI路径访问二进制资源

## 第十一章 深入浅出话模板

* 模板的内涵
* 数据的外衣DataTemplate
* 控件的外衣ControlTemplate
    * 庖丁解牛看控件
    * ItemsControl的PanelTemplate
* DataTemplate与ControlTemplate的关系与应用
    * DataTemplate与ControlTemplate的关系
    * DataTemplate与ControlTemplate的应用
    * 寻找失落的控件
* 深入浅出话Style
    * Style中的Setter
    * Style中的Trigger

## 第十二章 绘图和动画

* WPF绘图
    * 绘制图形
* 图形的效果与滤镜
    * 简单易用的BitmapEffect
    * 丰富多彩的Effect
* 图形的变形
    * 呈现变形
    * 布局变形
* 动画
    * 简单独立动画
    * 场景
    * 综合实例资源
 

## 特辑（书中未包含的内容）

1. 《深入浅出WPF》系列视频（特辑）——MVVM入门与提高（难度300+）  
[wpfgeek的自频道-优酷视频](http://i.youku.com/i/UMjc5NjgwMDU2/videos) 或 [深入浅出WPF_野生技术协会_科技_bilibili_哔哩哔哩](http://www.bilibili.com/video/av11063037/) .
