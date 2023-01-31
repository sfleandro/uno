#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Security.Cryptography.Certificates
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CertificateChain 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.ChainValidationResult Validate()
		{
			throw new global::System.NotImplementedException("The member ChainValidationResult CertificateChain.Validate() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ChainValidationResult%20CertificateChain.Validate%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.ChainValidationResult Validate( global::Windows.Security.Cryptography.Certificates.ChainValidationParameters parameter)
		{
			throw new global::System.NotImplementedException("The member ChainValidationResult CertificateChain.Validate(ChainValidationParameters parameter) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ChainValidationResult%20CertificateChain.Validate%28ChainValidationParameters%20parameter%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Security.Cryptography.Certificates.Certificate> GetCertificates( bool includeRoot)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<Certificate> CertificateChain.GetCertificates(bool includeRoot) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CCertificate%3E%20CertificateChain.GetCertificates%28bool%20includeRoot%29");
		}
		#endif
	}
}
