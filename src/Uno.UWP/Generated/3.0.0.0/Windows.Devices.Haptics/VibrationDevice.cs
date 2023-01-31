#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Haptics
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VibrationDevice 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Id
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VibrationDevice.Id is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VibrationDevice.Id");
			}
		}
		#endif
		// Skipping already declared property SimpleHapticsController
		// Forced skipping of method Windows.Devices.Haptics.VibrationDevice.Id.get
		// Forced skipping of method Windows.Devices.Haptics.VibrationDevice.SimpleHapticsController.get
		// Skipping already declared method Windows.Devices.Haptics.VibrationDevice.RequestAccessAsync()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector()
		{
			throw new global::System.NotImplementedException("The member string VibrationDevice.GetDeviceSelector() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VibrationDevice.GetDeviceSelector%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Haptics.VibrationDevice> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VibrationDevice> VibrationDevice.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVibrationDevice%3E%20VibrationDevice.FromIdAsync%28string%20deviceId%29");
		}
		#endif
		// Skipping already declared method Windows.Devices.Haptics.VibrationDevice.GetDefaultAsync()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Haptics.VibrationDevice>> FindAllAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<VibrationDevice>> VibrationDevice.FindAllAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CVibrationDevice%3E%3E%20VibrationDevice.FindAllAsync%28%29");
		}
		#endif
	}
}
