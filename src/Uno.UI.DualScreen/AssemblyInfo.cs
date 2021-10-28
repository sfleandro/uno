﻿using Windows.UI.ViewManagement;
using Uno.Devices.Sensors;
using Uno.Foundation.Extensibility;
using Uno.UI.DualScreen;

#if __ANDROID__
[assembly: ApiExtension(typeof(IApplicationViewSpanningRects), typeof(FoldableApplicationViewSpanningRects))]
[assembly: ApiExtension(typeof(INativeFoldableProvider), typeof(FoldableApplicationViewSpanningRects))]
[assembly: ApiExtension(typeof(INativeHingeAngleSensor), typeof(FoldableHingeAngleSensor))]
#endif
