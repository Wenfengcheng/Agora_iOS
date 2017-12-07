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
	[Protocol (Name = "AgoraRtcEngineDelegate", WrapperType = typeof (AgoraRtcEngineDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didOccurWarning:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcWarningCode) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didOccurError:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcErrorCode) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (NSObject[]), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:firstLocalVideoFrameWithSize:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (CGSize), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (CGSize), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithVideoSizeChanged", Selector = "rtcEngine:videoSizeChangedOfUid:size:rotation:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (CGSize), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithfirstRemoteVideoFrame", Selector = "rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (CGSize), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didJoinedOfUid:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didOfflineOfUid:reason:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (Agora_iOS.AgoraRtcUserOfflineReason) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didAudioMuted:byUid:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (bool), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithDidVideoMuted", Selector = "rtcEngine:didVideoMuted:byUid:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (bool), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didAudioRouteChanged:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcAudioOutputRouting) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithDidVideoEnabled", Selector = "rtcEngine:didVideoEnabled:byUid:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (bool), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:localVideoStats:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcLocalVideoStats) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:remoteVideoStats:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcRemoteVideoStats) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineMediaEngineDidLoaded", Selector = "rtcEngineMediaEngineDidLoaded:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineMediaEngineDidStartCall", Selector = "rtcEngineMediaEngineDidStartCall:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineMediaEngineDidAudioMixingFinish", Selector = "rtcEngineMediaEngineDidAudioMixingFinish:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineMediaEngineDidAudioEffectFinish", Selector = "rtcEngineMediaEngineDidAudioEffectFinish:soundId:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineCameraDidReady", Selector = "rtcEngineCameraDidReady:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineVideoDidStop", Selector = "rtcEngineVideoDidStop:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineConnectionDidInterrupted", Selector = "rtcEngineConnectionDidInterrupted:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineConnectionDidLost", Selector = "rtcEngineConnectionDidLost:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didJoinChannel:withUid:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (string), typeof (nuint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithDidRejoinChannel", Selector = "rtcEngine:didRejoinChannel:withUid:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (string), typeof (nuint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:reportRtcStats:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcStats) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithDidLeaveChannelWithStats", Selector = "rtcEngine:didLeaveChannelWithStats:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcStats) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:audioQualityOfUid:quality:delay:lost:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (Agora_iOS.AgoraRtcQuality), typeof (nuint), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:networkQuality:txQuality:rxQuality:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (Agora_iOS.AgoraRtcQuality), typeof (Agora_iOS.AgoraRtcQuality) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:lastmileQuality:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcQuality) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didApiCallExecute:error:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didRefreshRecordingServiceStatus:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:receiveStreamMessageFromUid:streamId:data:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (nint), typeof (NSData) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (nint), typeof (nint), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineRequestChannelKey", Selector = "rtcEngineRequestChannelKey:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithFirstLoadAudioFrame", Selector = "rtcEngine:firstLocalAudioFrame:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngineWithFirstRemoteAudioFrame", Selector = "rtcEngine:firstRemoteAudioFrameOfUid:elapsed:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:activeSpeaker:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RtcEngine", Selector = "rtcEngine:didClientRoleChanged:newRole:", ParameterType = new Type [] { typeof (Agora_iOS.AgoraRtcEngineKit), typeof (Agora_iOS.AgoraRtcClientRole), typeof (Agora_iOS.AgoraRtcClientRole) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IAgoraRtcEngineDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class AgoraRtcEngineDelegate_Extensions {
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcWarningCode warningCode)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (This.Handle, Selector.GetHandle ("rtcEngine:didOccurWarning:"), engine.Handle, (Int64)warningCode);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcErrorCode errorCode)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (This.Handle, Selector.GetHandle ("rtcEngine:didOccurError:"), engine.Handle, (Int64)errorCode);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, NSObject[] speakers, nint totalVolume)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (speakers == null)
				throw new ArgumentNullException ("speakers");
			var nsa_speakers = NSArray.FromNSObjects (speakers);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nint (This.Handle, Selector.GetHandle ("rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:"), engine.Handle, nsa_speakers.Handle, totalVolume);
			nsa_speakers.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, CGSize size, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_CGSize_nint (This.Handle, Selector.GetHandle ("rtcEngine:firstLocalVideoFrameWithSize:elapsed:"), engine.Handle, size, elapsed);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_CGSize_nint (This.Handle, Selector.GetHandle ("rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:"), engine.Handle, uid, size, elapsed);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithVideoSizeChanged (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, CGSize size, nint rotation)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_CGSize_nint (This.Handle, Selector.GetHandle ("rtcEngine:videoSizeChangedOfUid:size:rotation:"), engine.Handle, uid, size, rotation);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithfirstRemoteVideoFrame (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_CGSize_nint (This.Handle, Selector.GetHandle ("rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:"), engine.Handle, uid, size, elapsed);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_nint (This.Handle, Selector.GetHandle ("rtcEngine:didJoinedOfUid:elapsed:"), engine.Handle, uid, elapsed);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, AgoraRtcUserOfflineReason reason)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_UInt64 (This.Handle, Selector.GetHandle ("rtcEngine:didOfflineOfUid:reason:"), engine.Handle, uid, (UInt64)reason);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, bool muted, nuint uid)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_nuint (This.Handle, Selector.GetHandle ("rtcEngine:didAudioMuted:byUid:"), engine.Handle, muted, uid);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithDidVideoMuted (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, bool muted, nuint uid)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_nuint (This.Handle, Selector.GetHandle ("rtcEngine:didVideoMuted:byUid:"), engine.Handle, muted, uid);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcAudioOutputRouting routing)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64 (This.Handle, Selector.GetHandle ("rtcEngine:didAudioRouteChanged:"), engine.Handle, (Int64)routing);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithDidVideoEnabled (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, bool enabled, nuint uid)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_nuint (This.Handle, Selector.GetHandle ("rtcEngine:didVideoEnabled:byUid:"), engine.Handle, enabled, uid);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcLocalVideoStats stats)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (stats == null)
				throw new ArgumentNullException ("stats");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("rtcEngine:localVideoStats:"), engine.Handle, stats.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcRemoteVideoStats stats)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (stats == null)
				throw new ArgumentNullException ("stats");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("rtcEngine:remoteVideoStats:"), engine.Handle, stats.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineMediaEngineDidLoaded (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineMediaEngineDidLoaded:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineMediaEngineDidStartCall (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineMediaEngineDidStartCall:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineMediaEngineDidAudioMixingFinish (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineMediaEngineDidAudioMixingFinish:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineMediaEngineDidAudioEffectFinish (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nint soundId)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("rtcEngineMediaEngineDidAudioEffectFinish:soundId:"), engine.Handle, soundId);
		}
		
		[CompilerGenerated]
		public static void RtcEngineCameraDidReady (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineCameraDidReady:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineVideoDidStop (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineVideoDidStop:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineConnectionDidInterrupted (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineConnectionDidInterrupted:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineConnectionDidLost (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineConnectionDidLost:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (channel == null)
				throw new ArgumentNullException ("channel");
			var nschannel = NSString.CreateNative (channel);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_nint (This.Handle, Selector.GetHandle ("rtcEngine:didJoinChannel:withUid:elapsed:"), engine.Handle, nschannel, uid, elapsed);
			NSString.ReleaseNative (nschannel);
			
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithDidRejoinChannel (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (channel == null)
				throw new ArgumentNullException ("channel");
			var nschannel = NSString.CreateNative (channel);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_nint (This.Handle, Selector.GetHandle ("rtcEngine:didRejoinChannel:withUid:elapsed:"), engine.Handle, nschannel, uid, elapsed);
			NSString.ReleaseNative (nschannel);
			
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcStats stats)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (stats == null)
				throw new ArgumentNullException ("stats");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("rtcEngine:reportRtcStats:"), engine.Handle, stats.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithDidLeaveChannelWithStats (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcStats stats)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (stats == null)
				throw new ArgumentNullException ("stats");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("rtcEngine:didLeaveChannelWithStats:"), engine.Handle, stats.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, AgoraRtcQuality quality, nuint delay, nuint lost)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_UInt64_nuint_nuint (This.Handle, Selector.GetHandle ("rtcEngine:audioQualityOfUid:quality:delay:lost:"), engine.Handle, uid, (UInt64)quality, delay, lost);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, AgoraRtcQuality txQuality, AgoraRtcQuality rxQuality)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_UInt64_UInt64 (This.Handle, Selector.GetHandle ("rtcEngine:networkQuality:txQuality:rxQuality:"), engine.Handle, uid, (UInt64)txQuality, (UInt64)rxQuality);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcQuality quality)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("rtcEngine:lastmileQuality:"), engine.Handle, (UInt64)quality);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, string api, nint error)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (api == null)
				throw new ArgumentNullException ("api");
			var nsapi = NSString.CreateNative (api);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_nint (This.Handle, Selector.GetHandle ("rtcEngine:didApiCallExecute:error:"), engine.Handle, nsapi, error);
			NSString.ReleaseNative (nsapi);
			
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nint status)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("rtcEngine:didRefreshRecordingServiceStatus:"), engine.Handle, status);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, nint streamId, NSData data)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			if (data == null)
				throw new ArgumentNullException ("data");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_nint_IntPtr (This.Handle, Selector.GetHandle ("rtcEngine:receiveStreamMessageFromUid:streamId:data:"), engine.Handle, uid, streamId, data.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, nint streamId, nint error, nint missed, nint cached)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_nint_nint_nint_nint (This.Handle, Selector.GetHandle ("rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:"), engine.Handle, uid, streamId, error, missed, cached);
		}
		
		[CompilerGenerated]
		public static void RtcEngineRequestChannelKey (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rtcEngineRequestChannelKey:"), engine.Handle);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithFirstLoadAudioFrame (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("rtcEngine:firstLocalAudioFrame:"), engine.Handle, elapsed);
		}
		
		[CompilerGenerated]
		public static void RtcEngineWithFirstRemoteAudioFrame (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint uid, nint elapsed)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint_nint (This.Handle, Selector.GetHandle ("rtcEngine:firstRemoteAudioFrameOfUid:elapsed:"), engine.Handle, uid, elapsed);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, nuint speakerUid)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nuint (This.Handle, Selector.GetHandle ("rtcEngine:activeSpeaker:"), engine.Handle, speakerUid);
		}
		
		[CompilerGenerated]
		public static void RtcEngine (this IAgoraRtcEngineDelegate This, AgoraRtcEngineKit engine, AgoraRtcClientRole oldRole, AgoraRtcClientRole newRole)
		{
			if (engine == null)
				throw new ArgumentNullException ("engine");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Int64_Int64 (This.Handle, Selector.GetHandle ("rtcEngine:didClientRoleChanged:newRole:"), engine.Handle, (Int64)oldRole, (Int64)newRole);
		}
		
	}
	
	internal sealed class AgoraRtcEngineDelegateWrapper : BaseWrapper, IAgoraRtcEngineDelegate {
		[Preserve (Conditional = true)]
		public AgoraRtcEngineDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Agora_iOS {
	[Protocol]
	[Register("AgoraRtcEngineDelegate", false)]
	[Model]
	public unsafe partial class AgoraRtcEngineDelegate : NSObject, IAgoraRtcEngineDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AgoraRtcEngineDelegate () : base (NSObjectFlag.Empty)
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
		protected AgoraRtcEngineDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AgoraRtcEngineDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("rtcEngine:didOccurWarning:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcWarningCode warningCode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didOccurError:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcErrorCode errorCode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, NSObject[] speakers, nint totalVolume)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:firstLocalVideoFrameWithSize:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, CGSize size, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didJoinedOfUid:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didOfflineOfUid:reason:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, AgoraRtcUserOfflineReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didAudioMuted:byUid:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, bool muted, nuint uid)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didAudioRouteChanged:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcAudioOutputRouting routing)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:localVideoStats:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcLocalVideoStats stats)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:remoteVideoStats:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcRemoteVideoStats stats)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didJoinChannel:withUid:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:reportRtcStats:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcStats stats)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:audioQualityOfUid:quality:delay:lost:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, AgoraRtcQuality quality, nuint delay, nuint lost)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:networkQuality:txQuality:rxQuality:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, AgoraRtcQuality txQuality, AgoraRtcQuality rxQuality)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:lastmileQuality:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcQuality quality)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didApiCallExecute:error:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, string api, nint error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didRefreshRecordingServiceStatus:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nint status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:receiveStreamMessageFromUid:streamId:data:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, nint streamId, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint uid, nint streamId, nint error, nint missed, nint cached)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:activeSpeaker:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, nuint speakerUid)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didClientRoleChanged:newRole:")]
		[CompilerGenerated]
		public virtual void RtcEngine (AgoraRtcEngineKit engine, AgoraRtcClientRole oldRole, AgoraRtcClientRole newRole)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineCameraDidReady:")]
		[CompilerGenerated]
		public virtual void RtcEngineCameraDidReady (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineConnectionDidInterrupted:")]
		[CompilerGenerated]
		public virtual void RtcEngineConnectionDidInterrupted (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineConnectionDidLost:")]
		[CompilerGenerated]
		public virtual void RtcEngineConnectionDidLost (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineMediaEngineDidAudioEffectFinish:soundId:")]
		[CompilerGenerated]
		public virtual void RtcEngineMediaEngineDidAudioEffectFinish (AgoraRtcEngineKit engine, nint soundId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineMediaEngineDidAudioMixingFinish:")]
		[CompilerGenerated]
		public virtual void RtcEngineMediaEngineDidAudioMixingFinish (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineMediaEngineDidLoaded:")]
		[CompilerGenerated]
		public virtual void RtcEngineMediaEngineDidLoaded (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineMediaEngineDidStartCall:")]
		[CompilerGenerated]
		public virtual void RtcEngineMediaEngineDidStartCall (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineRequestChannelKey:")]
		[CompilerGenerated]
		public virtual void RtcEngineRequestChannelKey (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngineVideoDidStop:")]
		[CompilerGenerated]
		public virtual void RtcEngineVideoDidStop (AgoraRtcEngineKit engine)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didLeaveChannelWithStats:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithDidLeaveChannelWithStats (AgoraRtcEngineKit engine, AgoraRtcStats stats)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didRejoinChannel:withUid:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithDidRejoinChannel (AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didVideoEnabled:byUid:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithDidVideoEnabled (AgoraRtcEngineKit engine, bool enabled, nuint uid)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:didVideoMuted:byUid:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithDidVideoMuted (AgoraRtcEngineKit engine, bool muted, nuint uid)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:firstLocalAudioFrame:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithFirstLoadAudioFrame (AgoraRtcEngineKit engine, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:firstRemoteAudioFrameOfUid:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithFirstRemoteAudioFrame (AgoraRtcEngineKit engine, nuint uid, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:videoSizeChangedOfUid:size:rotation:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithVideoSizeChanged (AgoraRtcEngineKit engine, nuint uid, CGSize size, nint rotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:")]
		[CompilerGenerated]
		public virtual void RtcEngineWithfirstRemoteVideoFrame (AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class AgoraRtcEngineDelegate */
}
