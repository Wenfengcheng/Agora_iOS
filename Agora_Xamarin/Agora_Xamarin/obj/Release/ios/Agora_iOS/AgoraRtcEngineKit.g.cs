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
	[Register("AgoraRtcEngineKit", true)]
	public unsafe partial class AgoraRtcEngineKit : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AgoraRtcEngineKit");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AgoraRtcEngineKit () : base (NSObjectFlag.Empty)
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
		protected AgoraRtcEngineKit (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AgoraRtcEngineKit (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("adjustAudioMixingVolume:")]
		[CompilerGenerated]
		public virtual int AdjustAudioMixingVolume (nint volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("adjustAudioMixingVolume:"), volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("adjustAudioMixingVolume:"), volume);
			}
		}
		
		[Export ("adjustPlaybackSignalVolume:")]
		[CompilerGenerated]
		public virtual int AdjustPlaybackSignalVolume (nint volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("adjustPlaybackSignalVolume:"), volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("adjustPlaybackSignalVolume:"), volume);
			}
		}
		
		[Export ("adjustRecordingSignalVolume:")]
		[CompilerGenerated]
		public virtual int AdjustRecordingSignalVolume (nint volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("adjustRecordingSignalVolume:"), volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("adjustRecordingSignalVolume:"), volume);
			}
		}
		
		[Export ("audioQualityBlock:")]
		[CompilerGenerated]
		public unsafe virtual void AudioQualityBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V0))]global::System.Action<nuint, AgoraRtcQuality, nuint, nuint> audioQualityBlock)
		{
			if (audioQualityBlock == null)
				throw new ArgumentNullException ("audioQualityBlock");
			BlockLiteral *block_ptr_audioQualityBlock;
			BlockLiteral block_audioQualityBlock;
			block_audioQualityBlock = new BlockLiteral ();
			block_ptr_audioQualityBlock = &block_audioQualityBlock;
			block_audioQualityBlock.SetupBlock (Trampolines.SDActionArity4V0.Handler, audioQualityBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("audioQualityBlock:"), (IntPtr) block_ptr_audioQualityBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("audioQualityBlock:"), (IntPtr) block_ptr_audioQualityBlock);
			}
			block_ptr_audioQualityBlock->CleanupBlock ();
			
		}
		
		[Export ("audioVolumeIndicationBlock:")]
		[CompilerGenerated]
		public unsafe virtual void AudioVolumeIndicationBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<NSArray, nint> audioVolumeIndicationBlock)
		{
			if (audioVolumeIndicationBlock == null)
				throw new ArgumentNullException ("audioVolumeIndicationBlock");
			BlockLiteral *block_ptr_audioVolumeIndicationBlock;
			BlockLiteral block_audioVolumeIndicationBlock;
			block_audioVolumeIndicationBlock = new BlockLiteral ();
			block_ptr_audioVolumeIndicationBlock = &block_audioVolumeIndicationBlock;
			block_audioVolumeIndicationBlock.SetupBlock (Trampolines.SDActionArity2V0.Handler, audioVolumeIndicationBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("audioVolumeIndicationBlock:"), (IntPtr) block_ptr_audioVolumeIndicationBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("audioVolumeIndicationBlock:"), (IntPtr) block_ptr_audioVolumeIndicationBlock);
			}
			block_ptr_audioVolumeIndicationBlock->CleanupBlock ();
			
		}
		
		[Export ("cameraReadyBlock:")]
		[CompilerGenerated]
		public unsafe virtual void CameraReadyBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action cameraReadyBlock)
		{
			if (cameraReadyBlock == null)
				throw new ArgumentNullException ("cameraReadyBlock");
			BlockLiteral *block_ptr_cameraReadyBlock;
			BlockLiteral block_cameraReadyBlock;
			block_cameraReadyBlock = new BlockLiteral ();
			block_ptr_cameraReadyBlock = &block_cameraReadyBlock;
			block_cameraReadyBlock.SetupBlock (Trampolines.SDAction.Handler, cameraReadyBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cameraReadyBlock:"), (IntPtr) block_ptr_cameraReadyBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cameraReadyBlock:"), (IntPtr) block_ptr_cameraReadyBlock);
			}
			block_ptr_cameraReadyBlock->CleanupBlock ();
			
		}
		
		[Export ("complain:description:")]
		[CompilerGenerated]
		public virtual int Complain (string callId, string description)
		{
			if (callId == null)
				throw new ArgumentNullException ("callId");
			if (description == null)
				throw new ArgumentNullException ("description");
			var nscallId = NSString.CreateNative (callId);
			var nsdescription = NSString.CreateNative (description);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("complain:description:"), nscallId, nsdescription);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("complain:description:"), nscallId, nsdescription);
			}
			NSString.ReleaseNative (nscallId);
			NSString.ReleaseNative (nsdescription);
			
			return ret;
		}
		
		[Export ("configPublisher:")]
		[CompilerGenerated]
		public virtual int ConfigPublisher (AgoraPublisherConfiguration config)
		{
			if (config == null)
				throw new ArgumentNullException ("config");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("configPublisher:"), config.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("configPublisher:"), config.Handle);
			}
		}
		
		[Export ("connectionLostBlock:")]
		[CompilerGenerated]
		public unsafe virtual void ConnectionLostBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action connectionLostBlock)
		{
			if (connectionLostBlock == null)
				throw new ArgumentNullException ("connectionLostBlock");
			BlockLiteral *block_ptr_connectionLostBlock;
			BlockLiteral block_connectionLostBlock;
			block_connectionLostBlock = new BlockLiteral ();
			block_ptr_connectionLostBlock = &block_connectionLostBlock;
			block_connectionLostBlock.SetupBlock (Trampolines.SDAction.Handler, connectionLostBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("connectionLostBlock:"), (IntPtr) block_ptr_connectionLostBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("connectionLostBlock:"), (IntPtr) block_ptr_connectionLostBlock);
			}
			block_ptr_connectionLostBlock->CleanupBlock ();
			
		}
		
		[Export ("createDataStream:reliable:ordered:")]
		[CompilerGenerated]
		public virtual int CreateDataStream (nint streamId, bool reliable, bool ordered)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_bool_bool (this.Handle, Selector.GetHandle ("createDataStream:reliable:ordered:"), streamId, reliable, ordered);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_bool_bool (this.SuperHandle, Selector.GetHandle ("createDataStream:reliable:ordered:"), streamId, reliable, ordered);
			}
		}
		
		[Export ("destroy")]
		[CompilerGenerated]
		public static void Destroy ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("destroy"));
		}
		
		[Export ("enableAudioVolumeIndication:smooth:")]
		[CompilerGenerated]
		public virtual int EnableAudioVolumeIndication (nint interval, nint smooth)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("enableAudioVolumeIndication:smooth:"), interval, smooth);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint (this.SuperHandle, Selector.GetHandle ("enableAudioVolumeIndication:smooth:"), interval, smooth);
			}
		}
		
		[Export ("enableDualStreamMode:")]
		[CompilerGenerated]
		public virtual int EnableDualStreamMode (bool enabled)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableDualStreamMode:"), enabled);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableDualStreamMode:"), enabled);
			}
		}
		
		[Export ("enableInEarMonitoring:")]
		[CompilerGenerated]
		public virtual int EnableInEarMonitoring (bool enabled)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableInEarMonitoring:"), enabled);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableInEarMonitoring:"), enabled);
			}
		}
		
		[Export ("enableLocalVideo:")]
		[CompilerGenerated]
		public virtual int EnableLocalVideo (bool enabled)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableLocalVideo:"), enabled);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableLocalVideo:"), enabled);
			}
		}
		
		[Export ("enableMainQueueDispatch:")]
		[CompilerGenerated]
		public virtual int EnableMainQueueDispatch (bool enabled)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableMainQueueDispatch:"), enabled);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableMainQueueDispatch:"), enabled);
			}
		}
		
		[Export ("enableWebSdkInteroperability:")]
		[CompilerGenerated]
		public virtual int EnableWebSdkInteroperability (bool enabled)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableWebSdkInteroperability:"), enabled);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableWebSdkInteroperability:"), enabled);
			}
		}
		
		[Export ("firstLocalVideoFrameBlock:")]
		[CompilerGenerated]
		public unsafe virtual void FirstLocalVideoFrameBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<nint, nint, nint> firstLocalVideoFrameBlock)
		{
			if (firstLocalVideoFrameBlock == null)
				throw new ArgumentNullException ("firstLocalVideoFrameBlock");
			BlockLiteral *block_ptr_firstLocalVideoFrameBlock;
			BlockLiteral block_firstLocalVideoFrameBlock;
			block_firstLocalVideoFrameBlock = new BlockLiteral ();
			block_ptr_firstLocalVideoFrameBlock = &block_firstLocalVideoFrameBlock;
			block_firstLocalVideoFrameBlock.SetupBlock (Trampolines.SDActionArity3V0.Handler, firstLocalVideoFrameBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("firstLocalVideoFrameBlock:"), (IntPtr) block_ptr_firstLocalVideoFrameBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("firstLocalVideoFrameBlock:"), (IntPtr) block_ptr_firstLocalVideoFrameBlock);
			}
			block_ptr_firstLocalVideoFrameBlock->CleanupBlock ();
			
		}
		
		[Export ("firstRemoteVideoDecodedBlock:")]
		[CompilerGenerated]
		public unsafe virtual void FirstRemoteVideoDecodedBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V1))]global::System.Action<nuint, nint, nint, nint> firstRemoteVideoDecodedBlock)
		{
			if (firstRemoteVideoDecodedBlock == null)
				throw new ArgumentNullException ("firstRemoteVideoDecodedBlock");
			BlockLiteral *block_ptr_firstRemoteVideoDecodedBlock;
			BlockLiteral block_firstRemoteVideoDecodedBlock;
			block_firstRemoteVideoDecodedBlock = new BlockLiteral ();
			block_ptr_firstRemoteVideoDecodedBlock = &block_firstRemoteVideoDecodedBlock;
			block_firstRemoteVideoDecodedBlock.SetupBlock (Trampolines.SDActionArity4V1.Handler, firstRemoteVideoDecodedBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("firstRemoteVideoDecodedBlock:"), (IntPtr) block_ptr_firstRemoteVideoDecodedBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("firstRemoteVideoDecodedBlock:"), (IntPtr) block_ptr_firstRemoteVideoDecodedBlock);
			}
			block_ptr_firstRemoteVideoDecodedBlock->CleanupBlock ();
			
		}
		
		[Export ("firstRemoteVideoFrameBlock:")]
		[CompilerGenerated]
		public unsafe virtual void FirstRemoteVideoFrameBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V1))]global::System.Action<nuint, nint, nint, nint> firstRemoteVideoFrameBlock)
		{
			if (firstRemoteVideoFrameBlock == null)
				throw new ArgumentNullException ("firstRemoteVideoFrameBlock");
			BlockLiteral *block_ptr_firstRemoteVideoFrameBlock;
			BlockLiteral block_firstRemoteVideoFrameBlock;
			block_firstRemoteVideoFrameBlock = new BlockLiteral ();
			block_ptr_firstRemoteVideoFrameBlock = &block_firstRemoteVideoFrameBlock;
			block_firstRemoteVideoFrameBlock.SetupBlock (Trampolines.SDActionArity4V1.Handler, firstRemoteVideoFrameBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("firstRemoteVideoFrameBlock:"), (IntPtr) block_ptr_firstRemoteVideoFrameBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("firstRemoteVideoFrameBlock:"), (IntPtr) block_ptr_firstRemoteVideoFrameBlock);
			}
			block_ptr_firstRemoteVideoFrameBlock->CleanupBlock ();
			
		}
		
		[Export ("getParameter:args:")]
		[CompilerGenerated]
		public virtual string GetParameter (string parameter, string args)
		{
			if (parameter == null)
				throw new ArgumentNullException ("parameter");
			if (args == null)
				throw new ArgumentNullException ("args");
			var nsparameter = NSString.CreateNative (parameter);
			var nsargs = NSString.CreateNative (args);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getParameter:args:"), nsparameter, nsargs));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getParameter:args:"), nsparameter, nsargs));
			}
			NSString.ReleaseNative (nsparameter);
			NSString.ReleaseNative (nsargs);
			
			return ret;
		}
		
		[Export ("joinChannelByKey:channelName:info:uid:joinSuccess:")]
		[CompilerGenerated]
		public unsafe virtual int JoinChannelByKey (string channelKey, string channelName, string info, nuint uid, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSString, nuint, nint> joinSuccessBlock)
		{
			if (channelKey == null)
				throw new ArgumentNullException ("channelKey");
			if (channelName == null)
				throw new ArgumentNullException ("channelName");
			if (info == null)
				throw new ArgumentNullException ("info");
			if (joinSuccessBlock == null)
				throw new ArgumentNullException ("joinSuccessBlock");
			var nschannelKey = NSString.CreateNative (channelKey);
			var nschannelName = NSString.CreateNative (channelName);
			var nsinfo = NSString.CreateNative (info);
			BlockLiteral *block_ptr_joinSuccessBlock;
			BlockLiteral block_joinSuccessBlock;
			block_joinSuccessBlock = new BlockLiteral ();
			block_ptr_joinSuccessBlock = &block_joinSuccessBlock;
			block_joinSuccessBlock.SetupBlock (Trampolines.SDActionArity3V1.Handler, joinSuccessBlock);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("joinChannelByKey:channelName:info:uid:joinSuccess:"), nschannelKey, nschannelName, nsinfo, uid, (IntPtr) block_ptr_joinSuccessBlock);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("joinChannelByKey:channelName:info:uid:joinSuccess:"), nschannelKey, nschannelName, nsinfo, uid, (IntPtr) block_ptr_joinSuccessBlock);
			}
			NSString.ReleaseNative (nschannelKey);
			NSString.ReleaseNative (nschannelName);
			NSString.ReleaseNative (nsinfo);
			block_ptr_joinSuccessBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("lastmileQualityBlock:")]
		[CompilerGenerated]
		public unsafe virtual void LastmileQualityBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<AgoraRtcQuality> lastmileQualityBlock)
		{
			if (lastmileQualityBlock == null)
				throw new ArgumentNullException ("lastmileQualityBlock");
			BlockLiteral *block_ptr_lastmileQualityBlock;
			BlockLiteral block_lastmileQualityBlock;
			block_lastmileQualityBlock = new BlockLiteral ();
			block_ptr_lastmileQualityBlock = &block_lastmileQualityBlock;
			block_lastmileQualityBlock.SetupBlock (Trampolines.SDActionArity1V0.Handler, lastmileQualityBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("lastmileQualityBlock:"), (IntPtr) block_ptr_lastmileQualityBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("lastmileQualityBlock:"), (IntPtr) block_ptr_lastmileQualityBlock);
			}
			block_ptr_lastmileQualityBlock->CleanupBlock ();
			
		}
		
		[Export ("leaveChannel:")]
		[CompilerGenerated]
		public unsafe virtual int LeaveChannel ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<AgoraRtcStats> leaveChannelBlock)
		{
			if (leaveChannelBlock == null)
				throw new ArgumentNullException ("leaveChannelBlock");
			BlockLiteral *block_ptr_leaveChannelBlock;
			BlockLiteral block_leaveChannelBlock;
			block_leaveChannelBlock = new BlockLiteral ();
			block_ptr_leaveChannelBlock = &block_leaveChannelBlock;
			block_leaveChannelBlock.SetupBlock (Trampolines.SDActionArity1V1.Handler, leaveChannelBlock);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("leaveChannel:"), (IntPtr) block_ptr_leaveChannelBlock);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("leaveChannel:"), (IntPtr) block_ptr_leaveChannelBlock);
			}
			block_ptr_leaveChannelBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("leaveChannelBlock:")]
		[CompilerGenerated]
		public unsafe virtual void LeaveChannelBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<AgoraRtcStats> leaveChannelBlock)
		{
			if (leaveChannelBlock == null)
				throw new ArgumentNullException ("leaveChannelBlock");
			BlockLiteral *block_ptr_leaveChannelBlock;
			BlockLiteral block_leaveChannelBlock;
			block_leaveChannelBlock = new BlockLiteral ();
			block_ptr_leaveChannelBlock = &block_leaveChannelBlock;
			block_leaveChannelBlock.SetupBlock (Trampolines.SDActionArity1V1.Handler, leaveChannelBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("leaveChannelBlock:"), (IntPtr) block_ptr_leaveChannelBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("leaveChannelBlock:"), (IntPtr) block_ptr_leaveChannelBlock);
			}
			block_ptr_leaveChannelBlock->CleanupBlock ();
			
		}
		
		[Export ("localVideoStatBlock:")]
		[CompilerGenerated]
		public unsafe virtual void LocalVideoStatBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<nint, nint> localVideoStatBlock)
		{
			if (localVideoStatBlock == null)
				throw new ArgumentNullException ("localVideoStatBlock");
			BlockLiteral *block_ptr_localVideoStatBlock;
			BlockLiteral block_localVideoStatBlock;
			block_localVideoStatBlock = new BlockLiteral ();
			block_ptr_localVideoStatBlock = &block_localVideoStatBlock;
			block_localVideoStatBlock.SetupBlock (Trampolines.SDActionArity2V1.Handler, localVideoStatBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("localVideoStatBlock:"), (IntPtr) block_ptr_localVideoStatBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("localVideoStatBlock:"), (IntPtr) block_ptr_localVideoStatBlock);
			}
			block_ptr_localVideoStatBlock->CleanupBlock ();
			
		}
		
		[Export ("mediaEngineEventBlock:")]
		[CompilerGenerated]
		public unsafe virtual void MediaEngineEventBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<nint> mediaEngineEventBlock)
		{
			if (mediaEngineEventBlock == null)
				throw new ArgumentNullException ("mediaEngineEventBlock");
			BlockLiteral *block_ptr_mediaEngineEventBlock;
			BlockLiteral block_mediaEngineEventBlock;
			block_mediaEngineEventBlock = new BlockLiteral ();
			block_ptr_mediaEngineEventBlock = &block_mediaEngineEventBlock;
			block_mediaEngineEventBlock.SetupBlock (Trampolines.SDActionArity1V2.Handler, mediaEngineEventBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("mediaEngineEventBlock:"), (IntPtr) block_ptr_mediaEngineEventBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("mediaEngineEventBlock:"), (IntPtr) block_ptr_mediaEngineEventBlock);
			}
			block_ptr_mediaEngineEventBlock->CleanupBlock ();
			
		}
		
		[Export ("muteAllRemoteAudioStreams:")]
		[CompilerGenerated]
		public virtual int MuteAllRemoteAudioStreams (bool mute)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("muteAllRemoteAudioStreams:"), mute);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("muteAllRemoteAudioStreams:"), mute);
			}
		}
		
		[Export ("muteAllRemoteVideoStreams:")]
		[CompilerGenerated]
		public virtual int MuteAllRemoteVideoStreams (bool mute)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("muteAllRemoteVideoStreams:"), mute);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("muteAllRemoteVideoStreams:"), mute);
			}
		}
		
		[Export ("muteLocalAudioStream:")]
		[CompilerGenerated]
		public virtual int MuteLocalAudioStream (bool mute)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("muteLocalAudioStream:"), mute);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("muteLocalAudioStream:"), mute);
			}
		}
		
		[Export ("muteLocalVideoStream:")]
		[CompilerGenerated]
		public virtual int MuteLocalVideoStream (bool mute)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("muteLocalVideoStream:"), mute);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("muteLocalVideoStream:"), mute);
			}
		}
		
		[Export ("muteRemoteAudioStream:mute:")]
		[CompilerGenerated]
		public virtual int MuteRemoteAudioStream (nuint uid, bool mute)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("muteRemoteAudioStream:mute:"), uid, mute);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("muteRemoteAudioStream:mute:"), uid, mute);
			}
		}
		
		[Export ("muteRemoteVideoStream:mute:")]
		[CompilerGenerated]
		public virtual int MuteRemoteVideoStream (nuint uid, bool mute)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint_bool (this.Handle, Selector.GetHandle ("muteRemoteVideoStream:mute:"), uid, mute);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint_bool (this.SuperHandle, Selector.GetHandle ("muteRemoteVideoStream:mute:"), uid, mute);
			}
		}
		
		[Export ("networkQualityBlock:")]
		[CompilerGenerated]
		public unsafe virtual void NetworkQualityBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V2))]global::System.Action<nuint, AgoraRtcQuality, AgoraRtcQuality> networkQualityBlock)
		{
			if (networkQualityBlock == null)
				throw new ArgumentNullException ("networkQualityBlock");
			BlockLiteral *block_ptr_networkQualityBlock;
			BlockLiteral block_networkQualityBlock;
			block_networkQualityBlock = new BlockLiteral ();
			block_ptr_networkQualityBlock = &block_networkQualityBlock;
			block_networkQualityBlock.SetupBlock (Trampolines.SDActionArity3V2.Handler, networkQualityBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("networkQualityBlock:"), (IntPtr) block_ptr_networkQualityBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("networkQualityBlock:"), (IntPtr) block_ptr_networkQualityBlock);
			}
			block_ptr_networkQualityBlock->CleanupBlock ();
			
		}
		
		[Export ("pauseEffect:")]
		[CompilerGenerated]
		public virtual int PauseEffect (int soundId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("pauseEffect:"), soundId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("pauseEffect:"), soundId);
			}
		}
		
		[Export ("playEffect:filePath:loop:pitch:pan:gain:")]
		[CompilerGenerated]
		public virtual int PlayEffect (int soundId, string filePath, bool loop, double pitch, double pan, double gain)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_int_IntPtr_bool_Double_Double_Double (this.Handle, Selector.GetHandle ("playEffect:filePath:loop:pitch:pan:gain:"), soundId, nsfilePath, loop, pitch, pan, gain);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_IntPtr_bool_Double_Double_Double (this.SuperHandle, Selector.GetHandle ("playEffect:filePath:loop:pitch:pan:gain:"), soundId, nsfilePath, loop, pitch, pan, gain);
			}
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
		[Export ("preloadEffect:filePath:")]
		[CompilerGenerated]
		public virtual int PreloadEffect (int soundId, string filePath)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_int_IntPtr (this.Handle, Selector.GetHandle ("preloadEffect:filePath:"), soundId, nsfilePath);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_IntPtr (this.SuperHandle, Selector.GetHandle ("preloadEffect:filePath:"), soundId, nsfilePath);
			}
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
		[Export ("pushExternalVideoFrame:")]
		[CompilerGenerated]
		public virtual bool PushExternalVideoFrame (AgoraVideoFrame frame)
		{
			if (frame == null)
				throw new ArgumentNullException ("frame");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("pushExternalVideoFrame:"), frame.Handle);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("pushExternalVideoFrame:"), frame.Handle);
			}
		}
		
		[Export ("rate:rating:description:")]
		[CompilerGenerated]
		public virtual int Rate (string callId, nint rating, string description)
		{
			if (callId == null)
				throw new ArgumentNullException ("callId");
			if (description == null)
				throw new ArgumentNullException ("description");
			var nscallId = NSString.CreateNative (callId);
			var nsdescription = NSString.CreateNative (description);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("rate:rating:description:"), nscallId, rating, nsdescription);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("rate:rating:description:"), nscallId, rating, nsdescription);
			}
			NSString.ReleaseNative (nscallId);
			NSString.ReleaseNative (nsdescription);
			
			return ret;
		}
		
		[Export ("rejoinChannelSuccessBlock:")]
		[CompilerGenerated]
		public unsafe virtual void RejoinChannelSuccessBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSString, nuint, nint> rejoinChannelSuccessBlock)
		{
			if (rejoinChannelSuccessBlock == null)
				throw new ArgumentNullException ("rejoinChannelSuccessBlock");
			BlockLiteral *block_ptr_rejoinChannelSuccessBlock;
			BlockLiteral block_rejoinChannelSuccessBlock;
			block_rejoinChannelSuccessBlock = new BlockLiteral ();
			block_ptr_rejoinChannelSuccessBlock = &block_rejoinChannelSuccessBlock;
			block_rejoinChannelSuccessBlock.SetupBlock (Trampolines.SDActionArity3V1.Handler, rejoinChannelSuccessBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("rejoinChannelSuccessBlock:"), (IntPtr) block_ptr_rejoinChannelSuccessBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("rejoinChannelSuccessBlock:"), (IntPtr) block_ptr_rejoinChannelSuccessBlock);
			}
			block_ptr_rejoinChannelSuccessBlock->CleanupBlock ();
			
		}
		
		[Export ("remoteVideoStatBlock:")]
		[CompilerGenerated]
		public unsafe virtual void RemoteVideoStatBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity4V1))]global::System.Action<nuint, nint, nint, nint> remoteVideoStatBlock)
		{
			if (remoteVideoStatBlock == null)
				throw new ArgumentNullException ("remoteVideoStatBlock");
			BlockLiteral *block_ptr_remoteVideoStatBlock;
			BlockLiteral block_remoteVideoStatBlock;
			block_remoteVideoStatBlock = new BlockLiteral ();
			block_ptr_remoteVideoStatBlock = &block_remoteVideoStatBlock;
			block_remoteVideoStatBlock.SetupBlock (Trampolines.SDActionArity4V1.Handler, remoteVideoStatBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("remoteVideoStatBlock:"), (IntPtr) block_ptr_remoteVideoStatBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("remoteVideoStatBlock:"), (IntPtr) block_ptr_remoteVideoStatBlock);
			}
			block_ptr_remoteVideoStatBlock->CleanupBlock ();
			
		}
		
		[Export ("renewChannelKey:")]
		[CompilerGenerated]
		public virtual int RenewChannelKey (string channelKey)
		{
			if (channelKey == null)
				throw new ArgumentNullException ("channelKey");
			var nschannelKey = NSString.CreateNative (channelKey);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("renewChannelKey:"), nschannelKey);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("renewChannelKey:"), nschannelKey);
			}
			NSString.ReleaseNative (nschannelKey);
			
			return ret;
		}
		
		[Export ("resumeEffect:")]
		[CompilerGenerated]
		public virtual int ResumeEffect (int soundId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("resumeEffect:"), soundId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("resumeEffect:"), soundId);
			}
		}
		
		[Export ("rtcStatsBlock:")]
		[CompilerGenerated]
		public unsafe virtual void RtcStatsBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<AgoraRtcStats> rtcStatsBlock)
		{
			if (rtcStatsBlock == null)
				throw new ArgumentNullException ("rtcStatsBlock");
			BlockLiteral *block_ptr_rtcStatsBlock;
			BlockLiteral block_rtcStatsBlock;
			block_rtcStatsBlock = new BlockLiteral ();
			block_ptr_rtcStatsBlock = &block_rtcStatsBlock;
			block_rtcStatsBlock.SetupBlock (Trampolines.SDActionArity1V1.Handler, rtcStatsBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("rtcStatsBlock:"), (IntPtr) block_ptr_rtcStatsBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("rtcStatsBlock:"), (IntPtr) block_ptr_rtcStatsBlock);
			}
			block_ptr_rtcStatsBlock->CleanupBlock ();
			
		}
		
		[Export ("sendStreamMessage:data:")]
		[CompilerGenerated]
		public virtual int SendStreamMessage (nint streamId, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("sendStreamMessage:data:"), streamId, data.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("sendStreamMessage:data:"), streamId, data.Handle);
			}
		}
		
		[Export ("setAudioMixingPosition:")]
		[CompilerGenerated]
		public virtual int SetAudioMixingPosition (nint pos)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setAudioMixingPosition:"), pos);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setAudioMixingPosition:"), pos);
			}
		}
		
		[Export ("setAudioProfile:scenario:")]
		[CompilerGenerated]
		public virtual int SetAudioProfile (AgoraRtcAudioProfile profile, AgoraRtcAudioScenario scenario)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_Int64_Int64 (this.Handle, Selector.GetHandle ("setAudioProfile:scenario:"), (Int64)profile, (Int64)scenario);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_Int64_Int64 (this.SuperHandle, Selector.GetHandle ("setAudioProfile:scenario:"), (Int64)profile, (Int64)scenario);
			}
		}
		
		[Export ("setChannelProfile:")]
		[CompilerGenerated]
		public virtual int SetChannelProfile (AgoraRtcChannelProfile profile)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setChannelProfile:"), (Int64)profile);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setChannelProfile:"), (Int64)profile);
			}
		}
		
		[Export ("setClientRole:withKey:")]
		[CompilerGenerated]
		public virtual int SetClientRole (AgoraRtcClientRole role, string permissionKey)
		{
			if (permissionKey == null)
				throw new ArgumentNullException ("permissionKey");
			var nspermissionKey = NSString.CreateNative (permissionKey);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_Int64_IntPtr (this.Handle, Selector.GetHandle ("setClientRole:withKey:"), (Int64)role, nspermissionKey);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_Int64_IntPtr (this.SuperHandle, Selector.GetHandle ("setClientRole:withKey:"), (Int64)role, nspermissionKey);
			}
			NSString.ReleaseNative (nspermissionKey);
			
			return ret;
		}
		
		[Export ("setDefaultAudioRouteToSpeakerphone:")]
		[CompilerGenerated]
		public virtual int SetDefaultAudioRouteToSpeakerphone (bool defaultToSpeaker)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDefaultAudioRouteToSpeakerphone:"), defaultToSpeaker);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDefaultAudioRouteToSpeakerphone:"), defaultToSpeaker);
			}
		}
		
		[Export ("setEffectsVolume:")]
		[CompilerGenerated]
		public virtual int SetEffectsVolume (double volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setEffectsVolume:"), volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setEffectsVolume:"), volume);
			}
		}
		
		[Export ("setEnableSpeakerphone:")]
		[CompilerGenerated]
		public virtual int SetEnableSpeakerphone (bool enableSpeaker)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableSpeakerphone:"), enableSpeaker);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableSpeakerphone:"), enableSpeaker);
			}
		}
		
		[Export ("setEncryptionMode:")]
		[CompilerGenerated]
		public virtual int SetEncryptionMode (string encryptionMode)
		{
			if (encryptionMode == null)
				throw new ArgumentNullException ("encryptionMode");
			var nsencryptionMode = NSString.CreateNative (encryptionMode);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEncryptionMode:"), nsencryptionMode);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEncryptionMode:"), nsencryptionMode);
			}
			NSString.ReleaseNative (nsencryptionMode);
			
			return ret;
		}
		
		[Export ("setEncryptionSecret:")]
		[CompilerGenerated]
		public virtual int SetEncryptionSecret (string secret)
		{
			if (secret == null)
				throw new ArgumentNullException ("secret");
			var nssecret = NSString.CreateNative (secret);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEncryptionSecret:"), nssecret);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEncryptionSecret:"), nssecret);
			}
			NSString.ReleaseNative (nssecret);
			
			return ret;
		}
		
		[Export ("setExternalVideoSource:useTexture:pushMode:")]
		[CompilerGenerated]
		public virtual void SetExternalVideoSource (bool enable, bool useTexture, bool pushMode)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool_bool (this.Handle, Selector.GetHandle ("setExternalVideoSource:useTexture:pushMode:"), enable, useTexture, pushMode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool_bool (this.SuperHandle, Selector.GetHandle ("setExternalVideoSource:useTexture:pushMode:"), enable, useTexture, pushMode);
			}
		}
		
		[Export ("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:")]
		[CompilerGenerated]
		public virtual int SetHighQualityAudioParametersWithFullband (bool fullband, bool stereo, bool fullBitrate)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool_bool_bool (this.Handle, Selector.GetHandle ("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:"), fullband, stereo, fullBitrate);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool_bool_bool (this.SuperHandle, Selector.GetHandle ("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:"), fullband, stereo, fullBitrate);
			}
		}
		
		[Export ("setInEarMonitoringVolume:")]
		[CompilerGenerated]
		public virtual int SetInEarMonitoringVolume (nint volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setInEarMonitoringVolume:"), volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setInEarMonitoringVolume:"), volume);
			}
		}
		
		[Export ("setLocalRenderMode:")]
		[CompilerGenerated]
		public virtual int SetLocalRenderMode (AgoraRtcRenderMode mode)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setLocalRenderMode:"), (UInt64)mode);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setLocalRenderMode:"), (UInt64)mode);
			}
		}
		
		[Export ("setLocalVoicePitch:")]
		[CompilerGenerated]
		public virtual int SetLocalVoicePitch (double pitch)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_Double (this.Handle, Selector.GetHandle ("setLocalVoicePitch:"), pitch);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_Double (this.SuperHandle, Selector.GetHandle ("setLocalVoicePitch:"), pitch);
			}
		}
		
		[Export ("setLogFile:")]
		[CompilerGenerated]
		public virtual int SetLogFile (string filePath)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLogFile:"), nsfilePath);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLogFile:"), nsfilePath);
			}
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
		[Export ("setLogFilter:")]
		[CompilerGenerated]
		public virtual int SetLogFilter (nuint filter)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setLogFilter:"), filter);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setLogFilter:"), filter);
			}
		}
		
		[Export ("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:")]
		[CompilerGenerated]
		public virtual int SetMixedAudioFrameParametersWithSampleRate (nint sampleRate, nint samplesPerCall)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:"), sampleRate, samplesPerCall);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint (this.SuperHandle, Selector.GetHandle ("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:"), sampleRate, samplesPerCall);
			}
		}
		
		[Export ("setParameters:")]
		[CompilerGenerated]
		public virtual int SetParameters (string options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			var nsoptions = NSString.CreateNative (options);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setParameters:"), nsoptions);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setParameters:"), nsoptions);
			}
			NSString.ReleaseNative (nsoptions);
			
			return ret;
		}
		
		[Export ("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
		[CompilerGenerated]
		public virtual int SetPlaybackAudioFrameParametersWithSampleRate (nint sampleRate, nint channel, AgoraRtcRawAudioFrameOpMode mode, nint samplesPerCall)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_Int64_nint (this.Handle, Selector.GetHandle ("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:"), sampleRate, channel, (Int64)mode, samplesPerCall);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_Int64_nint (this.SuperHandle, Selector.GetHandle ("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:"), sampleRate, channel, (Int64)mode, samplesPerCall);
			}
		}
		
		[Export ("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
		[CompilerGenerated]
		public virtual int SetRecordingAudioFrameParametersWithSampleRate (nint sampleRate, nint channel, AgoraRtcRawAudioFrameOpMode mode, nint samplesPerCall)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_Int64_nint (this.Handle, Selector.GetHandle ("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:"), sampleRate, channel, (Int64)mode, samplesPerCall);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_Int64_nint (this.SuperHandle, Selector.GetHandle ("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:"), sampleRate, channel, (Int64)mode, samplesPerCall);
			}
		}
		
		[Export ("setRemoteRenderMode:mode:")]
		[CompilerGenerated]
		public virtual int SetRemoteRenderMode (nuint uid, AgoraRtcRenderMode mode)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint_UInt64 (this.Handle, Selector.GetHandle ("setRemoteRenderMode:mode:"), uid, (UInt64)mode);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint_UInt64 (this.SuperHandle, Selector.GetHandle ("setRemoteRenderMode:mode:"), uid, (UInt64)mode);
			}
		}
		
		[Export ("setRemoteVideoStream:type:")]
		[CompilerGenerated]
		public virtual int SetRemoteVideoStream (nuint uid, AgoraRtcVideoStreamType streamType)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint_Int64 (this.Handle, Selector.GetHandle ("setRemoteVideoStream:type:"), uid, (Int64)streamType);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint_Int64 (this.SuperHandle, Selector.GetHandle ("setRemoteVideoStream:type:"), uid, (Int64)streamType);
			}
		}
		
		[Export ("setSpeakerphoneVolume:")]
		[CompilerGenerated]
		public virtual int SetSpeakerphoneVolume (nuint volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setSpeakerphoneVolume:"), volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setSpeakerphoneVolume:"), volume);
			}
		}
		
		[Export ("setVideoCompositingLayout:")]
		[CompilerGenerated]
		public virtual int SetVideoCompositingLayout (AgoraRtcVideoCompositingLayout layout)
		{
			if (layout == null)
				throw new ArgumentNullException ("layout");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVideoCompositingLayout:"), layout.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setVideoCompositingLayout:"), layout.Handle);
			}
		}
		
		[Export ("setVideoProfile:swapWidthAndHeight:")]
		[CompilerGenerated]
		public virtual int SetVideoProfile (AgoraRtcVideoProfile profile, bool swapWidthAndHeight)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_Int64_bool (this.Handle, Selector.GetHandle ("setVideoProfile:swapWidthAndHeight:"), (Int64)profile, swapWidthAndHeight);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_Int64_bool (this.SuperHandle, Selector.GetHandle ("setVideoProfile:swapWidthAndHeight:"), (Int64)profile, swapWidthAndHeight);
			}
		}
		
		[Export ("setVideoQualityParameters:")]
		[CompilerGenerated]
		public virtual int SetVideoQualityParameters (bool preferFrameRateOverImageQuality)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setVideoQualityParameters:"), preferFrameRateOverImageQuality);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setVideoQualityParameters:"), preferFrameRateOverImageQuality);
			}
		}
		
		[Export ("setVolumeOfEffect:withVolume:")]
		[CompilerGenerated]
		public virtual int SetVolumeOfEffect (int soundId, double volume)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_Double (this.Handle, Selector.GetHandle ("setVolumeOfEffect:withVolume:"), soundId, volume);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_Double (this.SuperHandle, Selector.GetHandle ("setVolumeOfEffect:withVolume:"), soundId, volume);
			}
		}
		
		[Export ("setupLocalVideo:")]
		[CompilerGenerated]
		public virtual int SetupLocalVideo (AgoraRtcVideoCanvas local)
		{
			if (local == null)
				throw new ArgumentNullException ("local");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setupLocalVideo:"), local.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setupLocalVideo:"), local.Handle);
			}
		}
		
		[Export ("setupRemoteVideo:")]
		[CompilerGenerated]
		public virtual int SetupRemoteVideo (AgoraRtcVideoCanvas remote)
		{
			if (remote == null)
				throw new ArgumentNullException ("remote");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setupRemoteVideo:"), remote.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setupRemoteVideo:"), remote.Handle);
			}
		}
		
		[Export ("sharedEngineWithAppId:delegate:")]
		[CompilerGenerated]
		public static AgoraRtcEngineKit SharedEngineWithAppId (string appId, AgoraRtcEngineDelegate @delegate)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			var nsappId = NSString.CreateNative (appId);
			
			AgoraRtcEngineKit ret;
			ret =  Runtime.GetNSObject<AgoraRtcEngineKit> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sharedEngineWithAppId:delegate:"), nsappId, @delegate.Handle));
			NSString.ReleaseNative (nsappId);
			
			return ret;
		}
		
		[Export ("sharedEngineWithAppId:error:")]
		[CompilerGenerated]
		public unsafe static AgoraRtcEngineKit SharedEngineWithAppId (string AppId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<AgoraRtcErrorCode> errorBlock)
		{
			if (AppId == null)
				throw new ArgumentNullException ("AppId");
			if (errorBlock == null)
				throw new ArgumentNullException ("errorBlock");
			var nsAppId = NSString.CreateNative (AppId);
			BlockLiteral *block_ptr_errorBlock;
			BlockLiteral block_errorBlock;
			block_errorBlock = new BlockLiteral ();
			block_ptr_errorBlock = &block_errorBlock;
			block_errorBlock.SetupBlock (Trampolines.SDActionArity1V3.Handler, errorBlock);
			
			AgoraRtcEngineKit ret;
			ret =  Runtime.GetNSObject<AgoraRtcEngineKit> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sharedEngineWithAppId:error:"), nsAppId, (IntPtr) block_ptr_errorBlock));
			NSString.ReleaseNative (nsAppId);
			block_ptr_errorBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startAudioMixing:loopback:replace:cycle:")]
		[CompilerGenerated]
		public virtual int StartAudioMixing (string filePath, bool loopback, bool replace, nint cycle)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_bool_bool_nint (this.Handle, Selector.GetHandle ("startAudioMixing:loopback:replace:cycle:"), nsfilePath, loopback, replace, cycle);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_bool_bool_nint (this.SuperHandle, Selector.GetHandle ("startAudioMixing:loopback:replace:cycle:"), nsfilePath, loopback, replace, cycle);
			}
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
		[Export ("startAudioRecording:quality:")]
		[CompilerGenerated]
		public virtual int StartAudioRecording (string filePath, AgoraRtcAudioRecordingQuality quality)
		{
			if (filePath == null)
				throw new ArgumentNullException ("filePath");
			var nsfilePath = NSString.CreateNative (filePath);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_Int64 (this.Handle, Selector.GetHandle ("startAudioRecording:quality:"), nsfilePath, (Int64)quality);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_Int64 (this.SuperHandle, Selector.GetHandle ("startAudioRecording:quality:"), nsfilePath, (Int64)quality);
			}
			NSString.ReleaseNative (nsfilePath);
			
			return ret;
		}
		
		[Export ("startEchoTest:")]
		[CompilerGenerated]
		public unsafe virtual int StartEchoTest ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V1))]global::System.Action<NSString, nuint, nint> successBlock)
		{
			if (successBlock == null)
				throw new ArgumentNullException ("successBlock");
			BlockLiteral *block_ptr_successBlock;
			BlockLiteral block_successBlock;
			block_successBlock = new BlockLiteral ();
			block_ptr_successBlock = &block_successBlock;
			block_successBlock.SetupBlock (Trampolines.SDActionArity3V1.Handler, successBlock);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startEchoTest:"), (IntPtr) block_ptr_successBlock);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startEchoTest:"), (IntPtr) block_ptr_successBlock);
			}
			block_ptr_successBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startRecordingService:")]
		[CompilerGenerated]
		public virtual int StartRecordingService (string recordingKey)
		{
			if (recordingKey == null)
				throw new ArgumentNullException ("recordingKey");
			var nsrecordingKey = NSString.CreateNative (recordingKey);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startRecordingService:"), nsrecordingKey);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startRecordingService:"), nsrecordingKey);
			}
			NSString.ReleaseNative (nsrecordingKey);
			
			return ret;
		}
		
		[Export ("stopEffect:")]
		[CompilerGenerated]
		public virtual int StopEffect (int soundId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("stopEffect:"), soundId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("stopEffect:"), soundId);
			}
		}
		
		[Export ("stopRecordingService:")]
		[CompilerGenerated]
		public virtual int StopRecordingService (string recordingKey)
		{
			if (recordingKey == null)
				throw new ArgumentNullException ("recordingKey");
			var nsrecordingKey = NSString.CreateNative (recordingKey);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stopRecordingService:"), nsrecordingKey);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stopRecordingService:"), nsrecordingKey);
			}
			NSString.ReleaseNative (nsrecordingKey);
			
			return ret;
		}
		
		[Export ("switchView:andAnother:")]
		[CompilerGenerated]
		public virtual int SwitchView (nuint uid1, nuint uid2)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nuint_nuint (this.Handle, Selector.GetHandle ("switchView:andAnother:"), uid1, uid2);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nuint_nuint (this.SuperHandle, Selector.GetHandle ("switchView:andAnother:"), uid1, uid2);
			}
		}
		
		[Export ("unloadEffect:")]
		[CompilerGenerated]
		public virtual int UnloadEffect (int soundId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("unloadEffect:"), soundId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("unloadEffect:"), soundId);
			}
		}
		
		[Export ("userJoinedBlock:")]
		[CompilerGenerated]
		public unsafe virtual void UserJoinedBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V2))]global::System.Action<nuint, nint> userJoinedBlock)
		{
			if (userJoinedBlock == null)
				throw new ArgumentNullException ("userJoinedBlock");
			BlockLiteral *block_ptr_userJoinedBlock;
			BlockLiteral block_userJoinedBlock;
			block_userJoinedBlock = new BlockLiteral ();
			block_ptr_userJoinedBlock = &block_userJoinedBlock;
			block_userJoinedBlock.SetupBlock (Trampolines.SDActionArity2V2.Handler, userJoinedBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("userJoinedBlock:"), (IntPtr) block_ptr_userJoinedBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("userJoinedBlock:"), (IntPtr) block_ptr_userJoinedBlock);
			}
			block_ptr_userJoinedBlock->CleanupBlock ();
			
		}
		
		[Export ("userMuteAudioBlock:")]
		[CompilerGenerated]
		public unsafe virtual void UserMuteAudioBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<nuint, bool> userMuteAudioBlock)
		{
			if (userMuteAudioBlock == null)
				throw new ArgumentNullException ("userMuteAudioBlock");
			BlockLiteral *block_ptr_userMuteAudioBlock;
			BlockLiteral block_userMuteAudioBlock;
			block_userMuteAudioBlock = new BlockLiteral ();
			block_ptr_userMuteAudioBlock = &block_userMuteAudioBlock;
			block_userMuteAudioBlock.SetupBlock (Trampolines.SDActionArity2V3.Handler, userMuteAudioBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("userMuteAudioBlock:"), (IntPtr) block_ptr_userMuteAudioBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("userMuteAudioBlock:"), (IntPtr) block_ptr_userMuteAudioBlock);
			}
			block_ptr_userMuteAudioBlock->CleanupBlock ();
			
		}
		
		[Export ("userMuteVideoBlock:")]
		[CompilerGenerated]
		public unsafe virtual void UserMuteVideoBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V3))]global::System.Action<nuint, bool> userMuteVideoBlock)
		{
			if (userMuteVideoBlock == null)
				throw new ArgumentNullException ("userMuteVideoBlock");
			BlockLiteral *block_ptr_userMuteVideoBlock;
			BlockLiteral block_userMuteVideoBlock;
			block_userMuteVideoBlock = new BlockLiteral ();
			block_ptr_userMuteVideoBlock = &block_userMuteVideoBlock;
			block_userMuteVideoBlock.SetupBlock (Trampolines.SDActionArity2V3.Handler, userMuteVideoBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("userMuteVideoBlock:"), (IntPtr) block_ptr_userMuteVideoBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("userMuteVideoBlock:"), (IntPtr) block_ptr_userMuteVideoBlock);
			}
			block_ptr_userMuteVideoBlock->CleanupBlock ();
			
		}
		
		[Export ("userOfflineBlock:")]
		[CompilerGenerated]
		public unsafe virtual void UserOfflineBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V4))]global::System.Action<nuint> userOfflineBlock)
		{
			if (userOfflineBlock == null)
				throw new ArgumentNullException ("userOfflineBlock");
			BlockLiteral *block_ptr_userOfflineBlock;
			BlockLiteral block_userOfflineBlock;
			block_userOfflineBlock = new BlockLiteral ();
			block_ptr_userOfflineBlock = &block_userOfflineBlock;
			block_userOfflineBlock.SetupBlock (Trampolines.SDActionArity1V4.Handler, userOfflineBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("userOfflineBlock:"), (IntPtr) block_ptr_userOfflineBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("userOfflineBlock:"), (IntPtr) block_ptr_userOfflineBlock);
			}
			block_ptr_userOfflineBlock->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual int AudioMixingCurrentPosition {
			[Export ("getAudioMixingCurrentPosition")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getAudioMixingCurrentPosition"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAudioMixingCurrentPosition"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int AudioMixingDuration {
			[Export ("getAudioMixingDuration")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getAudioMixingDuration"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAudioMixingDuration"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CallId {
			[Export ("getCallId")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCallId")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCallId")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ClearVideoCompositingLayout {
			[Export ("clearVideoCompositingLayout")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("clearVideoCompositingLayout"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearVideoCompositingLayout"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DisableAudio {
			[Export ("disableAudio")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("disableAudio"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableAudio"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DisableLastmileTest {
			[Export ("disableLastmileTest")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("disableLastmileTest"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableLastmileTest"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int DisableVideo {
			[Export ("disableVideo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("disableVideo"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableVideo"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual double EffectsVolume {
			[Export ("getEffectsVolume")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.Double_objc_msgSend (this.Handle, Selector.GetHandle ("getEffectsVolume"));
				} else {
					return global::ApiDefinition.Messaging.Double_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEffectsVolume"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int EnableAudio {
			[Export ("enableAudio")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("enableAudio"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableAudio"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int EnableLastmileTest {
			[Export ("enableLastmileTest")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("enableLastmileTest"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableLastmileTest"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int EnableVideo {
			[Export ("enableVideo")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("enableVideo"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableVideo"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsSpeakerphoneEnabled {
			[Export ("isSpeakerphoneEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSpeakerphoneEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSpeakerphoneEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static string MediaEngineVersion {
			[Export ("getMediaEngineVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getMediaEngineVersion")));
			}
			
		}
		
		[CompilerGenerated]
		public virtual int PauseAllEffects {
			[Export ("pauseAllEffects")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("pauseAllEffects"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pauseAllEffects"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int PauseAudioMixing {
			[Export ("pauseAudioMixing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("pauseAudioMixing"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pauseAudioMixing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int RefreshRecordingServiceStatus {
			[Export ("refreshRecordingServiceStatus")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("refreshRecordingServiceStatus"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refreshRecordingServiceStatus"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ResumeAllEffects {
			[Export ("resumeAllEffects")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("resumeAllEffects"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resumeAllEffects"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ResumeAudioMixing {
			[Export ("resumeAudioMixing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("resumeAudioMixing"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resumeAudioMixing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static string SdkVersion {
			[Export ("getSdkVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getSdkVersion")));
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StartPreview {
			[Export ("startPreview")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("startPreview"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startPreview"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StopAllEffects {
			[Export ("stopAllEffects")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stopAllEffects"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAllEffects"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StopAudioMixing {
			[Export ("stopAudioMixing")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stopAudioMixing"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAudioMixing"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StopAudioRecording {
			[Export ("stopAudioRecording")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stopAudioRecording"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAudioRecording"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StopEchoTest {
			[Export ("stopEchoTest")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stopEchoTest"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopEchoTest"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StopPreview {
			[Export ("stopPreview")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stopPreview"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopPreview"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int SwitchCamera {
			[Export ("switchCamera")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("switchCamera"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("switchCamera"));
				}
			}
			
		}
		
	} /* class AgoraRtcEngineKit */
}
