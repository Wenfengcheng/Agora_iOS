using System;
using Agora_iOS;
using UIKit;

namespace Agora_Test
{
    public partial class ViewController : UIViewController
    {
        const string AgoraKey = "52b3981a39044683836505873424cae5";
        public AgoraRtcEngineKit agoraKit { get; set; }
        public UIView LocalVideo { get; set; }
        public UIView RemoteVideo { get; set; }
        public UIView ControlButtons { get; set; }
        public UIImageView RemoteVideoMutedIndicator { get; set; }
        public UIImageView LocalVideoMutedBg { get; set; }
        public UIImageView LocalVideoMutedIndicator { get; set; }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            InitializeAgoraEngine();
            this.LocalVideo = localVideo;
            this.RemoteVideo = remoteVideo;
            this.ControlButtons = controlButtons;
            this.RemoteVideoMutedIndicator = remoteVideoMutedIndicator;
            this.LocalVideoMutedBg = localVideoMutedBg;
            this.LocalVideoMutedIndicator = localVideoMutedIndicator;
            InitializeAgoraEngine();
            SetUpVideo();
            SetUpLocalVideo();
            JoinChannel();
            // Perform any additional setup after loading the view, typically from a nib.
        }
        private void InitializeAgoraEngine()
        {
            agoraKit = AgoraRtcEngineKit.SharedEngineWithAppId(AgoraKey, new AgoraRtcEngineXamarinDelegate(this));
        }

        private void SetUpVideo()
        {
            agoraKit.EnableLocalVideo(true);
            agoraKit.SetVideoProfile(AgoraRtcVideoProfile.AgoraRtc_VideoProfile_360P, false);
        }

        private void SetUpLocalVideo()
        {
            AgoraRtcVideoCanvas videoCanvas = new AgoraRtcVideoCanvas();
            videoCanvas.Uid = 0;
            videoCanvas.View = this.LocalVideo;
            videoCanvas.RenderMode = AgoraRtcRenderMode.Adaptive;
            agoraKit.SetupLocalVideo(videoCanvas);
        }

        private void JoinChannel()
        {
            agoraKit.JoinChannelByKey("channelKey", "demoChannel", "channelInfo", 0, (arg1, arg2, arg3) =>
            {
                agoraKit.SetEnableSpeakerphone(true);
                UIApplication.SharedApplication.IdleTimerDisabled = true;
            });
        }

        partial void HangUpButtonClicked(UIButton sender)
        {
            this.agoraKit.LeaveChannel((obj) => {
                HideControlButtons();
                UIApplication.SharedApplication.IdleTimerDisabled = false;
                this.remoteVideo.RemoveFromSuperview();
                this.localVideo.RemoveFromSuperview();
                this.agoraKit = null;
            });
        }

        public void HideControlButtons()
        {
            this.controlButtons.Hidden = true;
        }


        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        public class AgoraRtcEngineXamarinDelegate : AgoraRtcEngineDelegate
        {
            private ViewController _viewController;
            public AgoraRtcEngineXamarinDelegate(ViewController vc)
            {
                _viewController = vc;
            }

            public override void RtcEngine(AgoraRtcEngineKit engine, nuint uid, CoreGraphics.CGSize size, nint elapsed)
            {
                if (_viewController.remoteVideo.Hidden)
                    _viewController.remoteVideo.Hidden = false;
                AgoraRtcVideoCanvas videoCanvas = new AgoraRtcVideoCanvas();
                videoCanvas.Uid = uid;
                videoCanvas.View = _viewController.remoteVideo;
                videoCanvas.RenderMode = AgoraRtcRenderMode.Adaptive;
                _viewController.agoraKit.SetupRemoteVideo(videoCanvas);

                if (_viewController.remoteVideo.Hidden)
                    _viewController.remoteVideo.Hidden = false;
            }

            public override void RtcEngine(AgoraRtcEngineKit engine, nuint uid, AgoraRtcUserOfflineReason reason)
            {
                _viewController.remoteVideo.Hidden = true;
            }
        }
    }
}
