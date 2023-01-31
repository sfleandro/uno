#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SizeHelper 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.Size Empty
		{
			get
			{
				throw new global::System.NotImplementedException("The member Size SizeHelper.Empty is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Size%20SizeHelper.Empty");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.SizeHelper.Empty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.Size FromDimensions( float width,  float height)
		{
			throw new global::System.NotImplementedException("The member Size SizeHelper.FromDimensions(float width, float height) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Size%20SizeHelper.FromDimensions%28float%20width%2C%20float%20height%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool GetIsEmpty( global::Windows.Foundation.Size target)
		{
			throw new global::System.NotImplementedException("The member bool SizeHelper.GetIsEmpty(Size target) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SizeHelper.GetIsEmpty%28Size%20target%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool Equals( global::Windows.Foundation.Size target,  global::Windows.Foundation.Size value)
		{
			throw new global::System.NotImplementedException("The member bool SizeHelper.Equals(Size target, Size value) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20SizeHelper.Equals%28Size%20target%2C%20Size%20value%29");
		}
		#endif
	}
}
