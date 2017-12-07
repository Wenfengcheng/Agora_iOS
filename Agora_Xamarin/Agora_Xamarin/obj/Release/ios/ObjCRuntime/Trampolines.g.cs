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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::Agora_iOS.AgoraRtcErrorCode>))]
		internal delegate void DActionArity1V3 (IntPtr block, global::Agora_iOS.AgoraRtcErrorCode obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V3 {
			static internal readonly DActionArity1V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V3))]
			static unsafe void Invoke (IntPtr block, global::Agora_iOS.AgoraRtcErrorCode obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::Agora_iOS.AgoraRtcErrorCode>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V3 */
		
		internal class NIDActionArity1V3 {
			IntPtr blockPtr;
			DActionArity1V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::Agora_iOS.AgoraRtcErrorCode> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::Agora_iOS.AgoraRtcErrorCode>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Agora_iOS.AgoraRtcErrorCode obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V3 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::Agora_iOS.AgoraRtcQuality>))]
		internal delegate void DActionArity1V0 (IntPtr block, global::Agora_iOS.AgoraRtcQuality obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, global::Agora_iOS.AgoraRtcQuality obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::Agora_iOS.AgoraRtcQuality>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::Agora_iOS.AgoraRtcQuality> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::Agora_iOS.AgoraRtcQuality>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Agora_iOS.AgoraRtcQuality obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::Agora_iOS.AgoraRtcStats>))]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::Agora_iOS.AgoraRtcStats>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Agora_iOS.AgoraRtcStats> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::Agora_iOS.AgoraRtcStats> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::Agora_iOS.AgoraRtcStats>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Agora_iOS.AgoraRtcStats obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nint>))]
		internal delegate void DActionArity1V2 (IntPtr block, nint obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			static internal readonly DActionArity1V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V2))]
			static unsafe void Invoke (IntPtr block, nint obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nint>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V2 */
		
		internal class NIDActionArity1V2 {
			IntPtr blockPtr;
			DActionArity1V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nint obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nuint>))]
		internal delegate void DActionArity1V4 (IntPtr block, nuint obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V4 {
			static internal readonly DActionArity1V4 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V4))]
			static unsafe void Invoke (IntPtr block, nuint obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nuint>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V4 */
		
		internal class NIDActionArity1V4 {
			IntPtr blockPtr;
			DActionArity1V4 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V4 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V4> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V4 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nuint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nuint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V4 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nuint obj)
			{
				invoker (blockPtr, obj);
			}
		} /* class NIDActionArity1V4 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSArray, nint>))]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, nint arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, nint arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSArray, nint>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSArray> (arg1), arg2);
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSArray, nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSArray, nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSArray arg1, nint arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nint, nint>))]
		internal delegate void DActionArity2V1 (IntPtr block, nint arg1, nint arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V1 {
			static internal readonly DActionArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V1))]
			static unsafe void Invoke (IntPtr block, nint arg1, nint arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nint, nint>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2);
			}
		} /* class SDActionArity2V1 */
		
		internal class NIDActionArity2V1 {
			IntPtr blockPtr;
			DActionArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nint, nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nint, nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nint arg1, nint arg2)
			{
				invoker (blockPtr, arg1, arg2);
			}
		} /* class NIDActionArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nuint, bool>))]
		internal delegate void DActionArity2V3 (IntPtr block, nuint arg1, bool arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V3 {
			static internal readonly DActionArity2V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V3))]
			static unsafe void Invoke (IntPtr block, nuint arg1, bool arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nuint, bool>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2);
			}
		} /* class SDActionArity2V3 */
		
		internal class NIDActionArity2V3 {
			IntPtr blockPtr;
			DActionArity2V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nuint, bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nuint, bool>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nuint arg1, bool arg2)
			{
				invoker (blockPtr, arg1, arg2);
			}
		} /* class NIDActionArity2V3 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nuint, nint>))]
		internal delegate void DActionArity2V2 (IntPtr block, nuint arg1, nint arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V2 {
			static internal readonly DActionArity2V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V2))]
			static unsafe void Invoke (IntPtr block, nuint arg1, nint arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nuint, nint>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2);
			}
		} /* class SDActionArity2V2 */
		
		internal class NIDActionArity2V2 {
			IntPtr blockPtr;
			DActionArity2V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nuint, nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nuint, nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity2V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nuint arg1, nint arg2)
			{
				invoker (blockPtr, arg1, arg2);
			}
		} /* class NIDActionArity2V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString, nuint, nint>))]
		internal delegate void DActionArity3V1 (IntPtr block, IntPtr arg1, nuint arg2, nint arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V1 {
			static internal readonly DActionArity3V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V1))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, nuint arg2, nint arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString, nuint, nint>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (arg1), arg2, arg3);
			}
		} /* class SDActionArity3V1 */
		
		internal class NIDActionArity3V1 {
			IntPtr blockPtr;
			DActionArity3V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSString, nuint, nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSString, nuint, nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity3V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSString arg1, nuint arg2, nint arg3)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2, arg3);
			}
		} /* class NIDActionArity3V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nint, nint, nint>))]
		internal delegate void DActionArity3V0 (IntPtr block, nint arg1, nint arg2, nint arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, nint arg1, nint arg2, nint arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nint, nint, nint>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2, arg3);
			}
		} /* class SDActionArity3V0 */
		
		internal class NIDActionArity3V0 {
			IntPtr blockPtr;
			DActionArity3V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nint, nint, nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nint, nint, nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nint arg1, nint arg2, nint arg3)
			{
				invoker (blockPtr, arg1, arg2, arg3);
			}
		} /* class NIDActionArity3V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, global::Agora_iOS.AgoraRtcQuality>))]
		internal delegate void DActionArity3V2 (IntPtr block, nuint arg1, global::Agora_iOS.AgoraRtcQuality arg2, global::Agora_iOS.AgoraRtcQuality arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V2 {
			static internal readonly DActionArity3V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity3V2))]
			static unsafe void Invoke (IntPtr block, nuint arg1, global::Agora_iOS.AgoraRtcQuality arg2, global::Agora_iOS.AgoraRtcQuality arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, global::Agora_iOS.AgoraRtcQuality>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2, arg3);
			}
		} /* class SDActionArity3V2 */
		
		internal class NIDActionArity3V2 {
			IntPtr blockPtr;
			DActionArity3V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity3V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity3V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity3V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, global::Agora_iOS.AgoraRtcQuality> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, global::Agora_iOS.AgoraRtcQuality>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity3V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nuint arg1, global::Agora_iOS.AgoraRtcQuality arg2, global::Agora_iOS.AgoraRtcQuality arg3)
			{
				invoker (blockPtr, arg1, arg2, arg3);
			}
		} /* class NIDActionArity3V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, nuint, nuint>))]
		internal delegate void DActionArity4V0 (IntPtr block, nuint arg1, global::Agora_iOS.AgoraRtcQuality arg2, nuint arg3, nuint arg4);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity4V0 {
			static internal readonly DActionArity4V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity4V0))]
			static unsafe void Invoke (IntPtr block, nuint arg1, global::Agora_iOS.AgoraRtcQuality arg2, nuint arg3, nuint arg4) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, nuint, nuint>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2, arg3, arg4);
			}
		} /* class SDActionArity4V0 */
		
		internal class NIDActionArity4V0 {
			IntPtr blockPtr;
			DActionArity4V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity4V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity4V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity4V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, nuint, nuint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nuint, global::Agora_iOS.AgoraRtcQuality, nuint, nuint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity4V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nuint arg1, global::Agora_iOS.AgoraRtcQuality arg2, nuint arg3, nuint arg4)
			{
				invoker (blockPtr, arg1, arg2, arg3, arg4);
			}
		} /* class NIDActionArity4V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<nuint, nint, nint, nint>))]
		internal delegate void DActionArity4V1 (IntPtr block, nuint arg1, nint arg2, nint arg3, nint arg4);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity4V1 {
			static internal readonly DActionArity4V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity4V1))]
			static unsafe void Invoke (IntPtr block, nuint arg1, nint arg2, nint arg3, nint arg4) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<nuint, nint, nint, nint>) (descriptor->Target);
				if (del != null)
					del (arg1, arg2, arg3, arg4);
			}
		} /* class SDActionArity4V1 */
		
		internal class NIDActionArity4V1 {
			IntPtr blockPtr;
			DActionArity4V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity4V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity4V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity4V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<nuint, nint, nint, nint> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<nuint, nint, nint, nint>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity4V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (nuint arg1, nint arg2, nint arg3, nint arg4)
			{
				invoker (blockPtr, arg1, arg2, arg3, arg4);
			}
		} /* class NIDActionArity4V1 */
	}
}
