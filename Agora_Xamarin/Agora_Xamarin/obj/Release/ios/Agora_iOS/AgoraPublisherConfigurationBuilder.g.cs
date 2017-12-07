//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Agora_iOS {
	[Register("AgoraPublisherConfigurationBuilder", true)]
	public unsafe partial class AgoraPublisherConfigurationBuilder : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AgoraPublisherConfigurationBuilder");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AgoraPublisherConfigurationBuilder () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AgoraPublisherConfigurationBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AgoraPublisherConfigurationBuilder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("injectStream:width:height:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder InjectStream (string url, nint width, nint height)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsurl = NSString.CreateNative (url);
			
			AgoraPublisherConfigurationBuilder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint (this.Handle, Selector.GetHandle ("injectStream:width:height:"), nsurl, width, height));
			} else {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_nint (this.SuperHandle, Selector.GetHandle ("injectStream:width:height:"), nsurl, width, height));
			}
			NSString.ReleaseNative (nsurl);
			
			return ret;
		}
		
		[Export ("setDefaultLayout:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetDefaultLayout (nint layoutStyle)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setDefaultLayout:"), layoutStyle));
			} else {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setDefaultLayout:"), layoutStyle));
			}
		}
		
		[Export ("setExtraInfo:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetExtraInfo (string info)
		{
			if (info == null)
				throw new ArgumentNullException ("info");
			var nsinfo = NSString.CreateNative (info);
			
			AgoraPublisherConfigurationBuilder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setExtraInfo:"), nsinfo));
			} else {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setExtraInfo:"), nsinfo));
			}
			NSString.ReleaseNative (nsinfo);
			
			return ret;
		}
		
		[Export ("setLifeCycle:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetLifeCycle (AgoraRtmpStreamLifeCycle lifecycle)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setLifeCycle:"), (Int64)lifecycle));
			} else {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setLifeCycle:"), (Int64)lifecycle));
			}
		}
		
		[Export ("setOwner:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetOwner (bool isOwner)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setOwner:"), isOwner));
			} else {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setOwner:"), isOwner));
			}
		}
		
		[Export ("setPublisherUrl:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetPublisherUrl (string url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsurl = NSString.CreateNative (url);
			
			AgoraPublisherConfigurationBuilder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPublisherUrl:"), nsurl));
			} else {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPublisherUrl:"), nsurl));
			}
			NSString.ReleaseNative (nsurl);
			
			return ret;
		}
		
		[Export ("setRawStreamUrl:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetRawStreamUrl (string url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsurl = NSString.CreateNative (url);
			
			AgoraPublisherConfigurationBuilder ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRawStreamUrl:"), nsurl));
			} else {
				ret =  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRawStreamUrl:"), nsurl));
			}
			NSString.ReleaseNative (nsurl);
			
			return ret;
		}
		
		[Export ("setWidth:height:framerate:bitrate:")]
		[CompilerGenerated]
		public virtual AgoraPublisherConfigurationBuilder SetWidth (nint width, nint height, nint framerate, nint bitrate)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nint_nint_nint_nint (this.Handle, Selector.GetHandle ("setWidth:height:framerate:bitrate:"), width, height, framerate, bitrate));
			} else {
				return  Runtime.GetNSObject<AgoraPublisherConfigurationBuilder> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nint_nint_nint_nint (this.SuperHandle, Selector.GetHandle ("setWidth:height:framerate:bitrate:"), width, height, framerate, bitrate));
			}
		}
		
		[CompilerGenerated]
		public virtual AgoraPublisherConfiguration Build {
			[Export ("build")]
			get {
				AgoraPublisherConfiguration ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AgoraPublisherConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("build")));
				} else {
					ret =  Runtime.GetNSObject<AgoraPublisherConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("build")));
				}
				return ret;
			}
			
		}
		
	} /* class AgoraPublisherConfigurationBuilder */
}
