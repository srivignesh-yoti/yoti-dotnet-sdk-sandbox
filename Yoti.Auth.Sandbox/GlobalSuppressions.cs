﻿// This file is used by Code Analysis to maintain SuppressMessage attributes that are applied to this
// project. Project-level suppressions either have no target or are given a specific target and
// scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validated in method in line above", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder.WithAttribute(Yoti.Auth.Sandbox.Profile.Request.Attribute.SandboxAttribute)~Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validated in method in line above", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder.WithDocumentDetails(Yoti.Auth.Document.DocumentDetails)~Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validated in method in line above", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder.WithDocumentDetails(Yoti.Auth.Document.DocumentDetails,System.Collections.Generic.List{Yoti.Auth.Sandbox.Profile.Request.Attribute.SandboxAnchor})~Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validated in method in line above", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder.WithAgeVerification(Yoti.Auth.Sandbox.Profile.Request.Attribute.Derivation.SandboxAgeVerification)~Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validated in method in line above", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.YotiSandboxClient.SetupSharingProfile(System.Net.Http.HttpClient,Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequest)~System.String")]
[assembly: SuppressMessage("Major Code Smell", "S3925:\"ISerializable\" should be implemented correctly", Justification = "Serializable constructor not available in some target frameworks", Scope = "type", Target = "~T:Yoti.Auth.Sandbox.SandboxException")]
[assembly: SuppressMessage("Design", "CA1055:Uri return values should not be strings", Justification = "String value is required to pass in JSON payload", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.Media.SandboxMedia.GetBase64URI~System.String")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validated in method in line above", Scope = "member", Target = "~M:Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder.WithDocumentImages(Yoti.Auth.Sandbox.Profile.Request.Attribute.SandboxDocumentImages,System.Collections.Generic.List{Yoti.Auth.Sandbox.Profile.Request.Attribute.SandboxAnchor})~Yoti.Auth.Sandbox.Profile.Request.YotiTokenRequestBuilder")]