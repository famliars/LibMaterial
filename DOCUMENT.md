# Documents

## 问题

> Button 控件的字体在 Dark 模式下呈现灰白色
- 这是由于 Button 控件单独使用了来自于父窗体的 ForeColor 引发的配色问题，修改 Button 控件的 FlatStyle 为 System 即可正常显示
> 半/透明窗体下字体模糊
- 这是由于透明窗体引发的字体阴影渲染异常问题，当字体悬浮于近似于父窗体的 ForeColor 的颜色区域上时，字体会发生模糊。修改字体为宋体或新宋体即可正常显示
