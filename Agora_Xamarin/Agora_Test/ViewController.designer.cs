// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Agora_Test
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView controlButtons { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView localVideo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView localVideoMutedBg { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView localVideoMutedIndicator { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView remoteVideo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView remoteVideoMutedIndicator { get; set; }

        [Action ("HangUpButtonClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void HangUpButtonClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (controlButtons != null) {
                controlButtons.Dispose ();
                controlButtons = null;
            }

            if (localVideo != null) {
                localVideo.Dispose ();
                localVideo = null;
            }

            if (localVideoMutedBg != null) {
                localVideoMutedBg.Dispose ();
                localVideoMutedBg = null;
            }

            if (localVideoMutedIndicator != null) {
                localVideoMutedIndicator.Dispose ();
                localVideoMutedIndicator = null;
            }

            if (remoteVideo != null) {
                remoteVideo.Dispose ();
                remoteVideo = null;
            }

            if (remoteVideoMutedIndicator != null) {
                remoteVideoMutedIndicator.Dispose ();
                remoteVideoMutedIndicator = null;
            }
        }
    }
}