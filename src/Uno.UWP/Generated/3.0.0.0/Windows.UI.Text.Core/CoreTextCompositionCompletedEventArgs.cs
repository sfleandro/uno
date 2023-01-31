#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Text.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreTextCompositionCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.UI.Text.Core.CoreTextCompositionSegment> CompositionSegments
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<CoreTextCompositionSegment> CoreTextCompositionCompletedEventArgs.CompositionSegments is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CCoreTextCompositionSegment%3E%20CoreTextCompositionCompletedEventArgs.CompositionSegments");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsCanceled
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool CoreTextCompositionCompletedEventArgs.IsCanceled is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CoreTextCompositionCompletedEventArgs.IsCanceled");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs.IsCanceled.get
		// Forced skipping of method Windows.UI.Text.Core.CoreTextCompositionCompletedEventArgs.CompositionSegments.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral CoreTextCompositionCompletedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Deferral%20CoreTextCompositionCompletedEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
