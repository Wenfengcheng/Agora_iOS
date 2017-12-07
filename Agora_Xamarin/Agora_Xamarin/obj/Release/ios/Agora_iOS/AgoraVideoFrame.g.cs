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
	[Register("AgoraVideoFrame", true)]
	public unsafe partial class AgoraVideoFrame : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AgoraVideoFrame");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AgoraVideoFrame () : base (NSObjectFlag.Empty)
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
		protected AgoraVideoFrame (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AgoraVideoFrame (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual int CropBottom {
			[Export ("cropBottom")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cropBottom"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropBottom"));
				}
			}
			
			[Export ("setCropBottom:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCropBottom:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCropBottom:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int CropLeft {
			[Export ("cropLeft")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cropLeft"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropLeft"));
				}
			}
			
			[Export ("setCropLeft:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCropLeft:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCropLeft:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int CropRight {
			[Export ("cropRight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cropRight"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropRight"));
				}
			}
			
			[Export ("setCropRight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCropRight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCropRight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int CropTop {
			[Export ("cropTop")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("cropTop"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cropTop"));
				}
			}
			
			[Export ("setCropTop:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setCropTop:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setCropTop:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSData DataBuf {
			[Export ("dataBuf", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataBuf")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dataBuf")));
				}
				return ret;
			}
			
			[Export ("setDataBuf:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDataBuf:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDataBuf:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nint Format {
			[Export ("format")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("format"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("format"));
				}
			}
			
			[Export ("setFormat:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setFormat:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setFormat:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Height {
			[Export ("height")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("height"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("height"));
				}
			}
			
			[Export ("setHeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setHeight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Rotation {
			[Export ("rotation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("rotation"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotation"));
				}
			}
			
			[Export ("setRotation:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setRotation:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setRotation:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Stride {
			[Export ("stride")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stride"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stride"));
				}
			}
			
			[Export ("setStride:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setStride:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setStride:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int StrideInPixels {
			[Export ("strideInPixels")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("strideInPixels"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("strideInPixels"));
				}
			}
			
			[Export ("setStrideInPixels:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setStrideInPixels:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setStrideInPixels:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreVideo.CVPixelBuffer TextureBuf {
			[Export ("textureBuf", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return Runtime.GetINativeObject<CVPixelBuffer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textureBuf")), false);
				} else {
					return Runtime.GetINativeObject<CVPixelBuffer> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textureBuf")), false);
				}
			}
			
			[Export ("setTextureBuf:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextureBuf:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTextureBuf:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreMedia.CMTime Time {
			[Export ("time", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::CoreMedia.CMTime ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSend (this.Handle, Selector.GetHandle ("time"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("time"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("time"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("time"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("time"));
						} else {
							global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("time"));
						}
					} else if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("time"));
					} else {
						global::ApiDefinition.Messaging.CMTime_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("time"));
					}
				}
				return ret;
			}
			
			[Export ("setTime:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CMTime (this.Handle, Selector.GetHandle ("setTime:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CMTime (this.SuperHandle, Selector.GetHandle ("setTime:"), value);
				}
			}
		}
		
	} /* class AgoraVideoFrame */
}
