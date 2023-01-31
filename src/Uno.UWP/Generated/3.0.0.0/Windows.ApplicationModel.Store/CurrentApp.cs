#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class CurrentApp 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Guid AppId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid CurrentApp.AppId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Guid%20CurrentApp.AppId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Store.LicenseInformation LicenseInformation
		{
			get
			{
				throw new global::System.NotImplementedException("The member LicenseInformation CurrentApp.LicenseInformation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=LicenseInformation%20CurrentApp.LicenseInformation");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Uri LinkUri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri CurrentApp.LinkUri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Uri%20CurrentApp.LinkUri");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetCustomerPurchaseIdAsync( string serviceTicket,  string publisherUserId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.GetCustomerPurchaseIdAsync(string serviceTicket, string publisherUserId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.GetCustomerPurchaseIdAsync%28string%20serviceTicket%2C%20string%20publisherUserId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetCustomerCollectionsIdAsync( string serviceTicket,  string publisherUserId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.GetCustomerCollectionsIdAsync(string serviceTicket, string publisherUserId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.GetCustomerCollectionsIdAsync%28string%20serviceTicket%2C%20string%20publisherUserId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetAppPurchaseCampaignIdAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.GetAppPurchaseCampaignIdAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.GetAppPurchaseCampaignIdAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByProductIdsAsync( global::System.Collections.Generic.IEnumerable<string> productIds)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ListingInformation> CurrentApp.LoadListingInformationByProductIdsAsync(IEnumerable<string> productIds) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CListingInformation%3E%20CurrentApp.LoadListingInformationByProductIdsAsync%28IEnumerable%3Cstring%3E%20productIds%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByKeywordsAsync( global::System.Collections.Generic.IEnumerable<string> keywords)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ListingInformation> CurrentApp.LoadListingInformationByKeywordsAsync(IEnumerable<string> keywords) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CListingInformation%3E%20CurrentApp.LoadListingInformationByKeywordsAsync%28IEnumerable%3Cstring%3E%20keywords%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void ReportProductFulfillment( string productId)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Store.CurrentApp", "void CurrentApp.ReportProductFulfillment(string productId)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.FulfillmentResult> ReportConsumableFulfillmentAsync( string productId,  global::System.Guid transactionId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<FulfillmentResult> CurrentApp.ReportConsumableFulfillmentAsync(string productId, Guid transactionId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CFulfillmentResult%3E%20CurrentApp.ReportConsumableFulfillmentAsync%28string%20productId%2C%20Guid%20transactionId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync( string productId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PurchaseResults> CurrentApp.RequestProductPurchaseAsync(string productId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CPurchaseResults%3E%20CurrentApp.RequestProductPurchaseAsync%28string%20productId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync( string productId,  string offerId,  global::Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties displayProperties)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<PurchaseResults> CurrentApp.RequestProductPurchaseAsync(string productId, string offerId, ProductPurchaseDisplayProperties displayProperties) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CPurchaseResults%3E%20CurrentApp.RequestProductPurchaseAsync%28string%20productId%2C%20string%20offerId%2C%20ProductPurchaseDisplayProperties%20displayProperties%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Store.UnfulfilledConsumable>> GetUnfulfilledConsumablesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<UnfulfilledConsumable>> CurrentApp.GetUnfulfilledConsumablesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CUnfulfilledConsumable%3E%3E%20CurrentApp.GetUnfulfilledConsumablesAsync%28%29");
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Store.CurrentApp.LicenseInformation.get
		// Forced skipping of method Windows.ApplicationModel.Store.CurrentApp.LinkUri.get
		// Forced skipping of method Windows.ApplicationModel.Store.CurrentApp.AppId.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> RequestAppPurchaseAsync( bool includeReceipt)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.RequestAppPurchaseAsync(bool includeReceipt) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.RequestAppPurchaseAsync%28bool%20includeReceipt%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> RequestProductPurchaseAsync( string productId,  bool includeReceipt)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.RequestProductPurchaseAsync(string productId, bool includeReceipt) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.RequestProductPurchaseAsync%28string%20productId%2C%20bool%20includeReceipt%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ListingInformation> CurrentApp.LoadListingInformationAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CListingInformation%3E%20CurrentApp.LoadListingInformationAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetAppReceiptAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.GetAppReceiptAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.GetAppReceiptAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<string> GetProductReceiptAsync( string productId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<string> CurrentApp.GetProductReceiptAsync(string productId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cstring%3E%20CurrentApp.GetProductReceiptAsync%28string%20productId%29");
		}
		#endif
	}
}
