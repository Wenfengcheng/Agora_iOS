using System;
using CoreGraphics;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace Agora_iOS
{
    // @interface AgoraRtcVideoCanvas : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCanvas
    {
        // @property (nonatomic, strong) VIEW_CLASS * view;
        [Export("view", ArgumentSemantic.Strong)]
        UIView View { get; set; }

        // @property (assign, nonatomic) AgoraRtcRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        AgoraRtcRenderMode RenderMode { get; set; }

        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }
    }

    // @interface AgoraVideoFrame : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraVideoFrame
    {
        // @property (assign, nonatomic) NSInteger format;
        [Export("format")]
        nint Format { get; set; }

        // @property (assign, nonatomic) CMTime time;
        [Export("time", ArgumentSemantic.Assign)]
        CMTime Time { get; set; }

        // @property (assign, nonatomic) int stride __attribute__((deprecated("use strideInPixels instead")));
        [Export("stride")]
        int Stride { get; set; }

        // @property (assign, nonatomic) int strideInPixels;
        [Export("strideInPixels")]
        int StrideInPixels { get; set; }

        // @property (assign, nonatomic) int height;
        [Export("height")]
        int Height { get; set; }

        // @property (assign, nonatomic) CVPixelBufferRef textureBuf;
        [Export("textureBuf", ArgumentSemantic.Assign)]
        unsafe CVPixelBuffer TextureBuf { get; set; }

        // @property (nonatomic, strong) NSData * dataBuf;
        [Export("dataBuf", ArgumentSemantic.Strong)]
        NSData DataBuf { get; set; }

        // @property (assign, nonatomic) int cropLeft;
        [Export("cropLeft")]
        int CropLeft { get; set; }

        // @property (assign, nonatomic) int cropTop;
        [Export("cropTop")]
        int CropTop { get; set; }

        // @property (assign, nonatomic) int cropRight;
        [Export("cropRight")]
        int CropRight { get; set; }

        // @property (assign, nonatomic) int cropBottom;
        [Export("cropBottom")]
        int CropBottom { get; set; }

        // @property (assign, nonatomic) int rotation;
        [Export("rotation")]
        int Rotation { get; set; }
    }

    // @interface AgoraRtcStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcStats
    {
        // @property (assign, nonatomic) NSUInteger duration;
        [Export("duration")]
        nuint Duration { get; set; }

        // @property (assign, nonatomic) NSUInteger txBytes;
        [Export("txBytes")]
        nuint TxBytes { get; set; }

        // @property (assign, nonatomic) NSUInteger rxBytes;
        [Export("rxBytes")]
        nuint RxBytes { get; set; }

        // @property (assign, nonatomic) NSUInteger txAudioKBitrate;
        [Export("txAudioKBitrate")]
        nuint TxAudioKBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger rxAudioKBitrate;
        [Export("rxAudioKBitrate")]
        nuint RxAudioKBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger txVideoKBitrate;
        [Export("txVideoKBitrate")]
        nuint TxVideoKBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger rxVideoKBitrate;
        [Export("rxVideoKBitrate")]
        nuint RxVideoKBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger users;
        [Export("users")]
        nuint Users { get; set; }

        // @property (assign, nonatomic) double cpuAppUsage;
        [Export("cpuAppUsage")]
        double CpuAppUsage { get; set; }

        // @property (assign, nonatomic) double cpuTotalUsage;
        [Export("cpuTotalUsage")]
        double CpuTotalUsage { get; set; }
    }

    // @interface AgoraRtcLocalVideoStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcLocalVideoStats
    {
        // @property (assign, nonatomic) NSUInteger sentBitrate;
        [Export("sentBitrate")]
        nuint SentBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger sentFrameRate;
        [Export("sentFrameRate")]
        nuint SentFrameRate { get; set; }
    }

    // @interface AgoraRtcRemoteVideoStats : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcRemoteVideoStats
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) NSUInteger delay;
        [Export("delay")]
        nuint Delay { get; set; }

        // @property (assign, nonatomic) NSUInteger width;
        [Export("width")]
        nuint Width { get; set; }

        // @property (assign, nonatomic) NSUInteger height;
        [Export("height")]
        nuint Height { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedBitrate;
        [Export("receivedBitrate")]
        nuint ReceivedBitrate { get; set; }

        // @property (assign, nonatomic) NSUInteger receivedFrameRate;
        [Export("receivedFrameRate")]
        nuint ReceivedFrameRate { get; set; }

        // @property (assign, nonatomic) AgoraRtcVideoStreamType rxStreamType;
        [Export("rxStreamType", ArgumentSemantic.Assign)]
        AgoraRtcVideoStreamType RxStreamType { get; set; }
    }

    // @interface AgoraRtcAudioVolumeInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcAudioVolumeInfo
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) NSUInteger volume;
        [Export("volume")]
        nuint Volume { get; set; }
    }

    // @interface AgoraRtcVideoCompositingRegion : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCompositingRegion
    {
        // @property (assign, nonatomic) NSUInteger uid;
        [Export("uid")]
        nuint Uid { get; set; }

        // @property (assign, nonatomic) double x;
        [Export("x")]
        double X { get; set; }

        // @property (assign, nonatomic) double y;
        [Export("y")]
        double Y { get; set; }

        // @property (assign, nonatomic) double width;
        [Export("width")]
        double Width { get; set; }

        // @property (assign, nonatomic) double height;
        [Export("height")]
        double Height { get; set; }

        // @property (assign, nonatomic) NSInteger zOrder;
        [Export("zOrder")]
        nint ZOrder { get; set; }

        // @property (assign, nonatomic) double alpha;
        [Export("alpha")]
        double Alpha { get; set; }

        // @property (assign, nonatomic) AgoraRtcRenderMode renderMode;
        [Export("renderMode", ArgumentSemantic.Assign)]
        AgoraRtcRenderMode RenderMode { get; set; }
    }

    // @interface AgoraRtcVideoCompositingLayout : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcVideoCompositingLayout
    {
        // @property (assign, nonatomic) NSInteger canvasWidth;
        [Export("canvasWidth")]
        nint CanvasWidth { get; set; }

        // @property (assign, nonatomic) NSInteger canvasHeight;
        [Export("canvasHeight")]
        nint CanvasHeight { get; set; }

        // @property (copy, nonatomic) NSString * backgroundColor;
        [Export("backgroundColor")]
        string BackgroundColor { get; set; }

        // @property (retain, nonatomic) NSArray * regions;
        [Export("regions", ArgumentSemantic.Retain)]
        NSObject[] Regions { get; set; }

        // @property (copy, nonatomic) NSString * appData;
        [Export("appData")]
        string AppData { get; set; }
    }

    // @interface AgoraPublisherConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraPublisherConfiguration
    {
        // @property (assign, nonatomic) BOOL owner;
        [Export("owner")]
        bool Owner { get; set; }

        // @property (assign, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; set; }

        // @property (assign, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; set; }

        // @property (assign, nonatomic) NSInteger framerate;
        [Export("framerate")]
        nint Framerate { get; set; }

        // @property (assign, nonatomic) NSInteger bitrate;
        [Export("bitrate")]
        nint Bitrate { get; set; }

        // @property (assign, nonatomic) NSInteger defaultLayout;
        [Export("defaultLayout")]
        nint DefaultLayout { get; set; }

        // @property (assign, nonatomic) AgoraRtmpStreamLifeCycle lifeCycle;
        [Export("lifeCycle", ArgumentSemantic.Assign)]
        AgoraRtmpStreamLifeCycle LifeCycle { get; set; }

        // @property (assign, nonatomic) NSInteger injectStreamWidth;
        [Export("injectStreamWidth")]
        nint InjectStreamWidth { get; set; }

        // @property (assign, nonatomic) NSInteger injectStreamHeight;
        [Export("injectStreamHeight")]
        nint InjectStreamHeight { get; set; }

        // @property (copy, nonatomic) NSString * injectStreamUrl;
        [Export("injectStreamUrl")]
        string InjectStreamUrl { get; set; }

        // @property (copy, nonatomic) NSString * publishUrl;
        [Export("publishUrl")]
        string PublishUrl { get; set; }

        // @property (copy, nonatomic) NSString * rawStreamUrl;
        [Export("rawStreamUrl")]
        string RawStreamUrl { get; set; }

        // @property (copy, nonatomic) NSString * extraInfo;
        [Export("extraInfo")]
        string ExtraInfo { get; set; }

        // -(BOOL)validate;
        [Export("validate")]
        bool Validate { get; }

        // -(NSString *)toJsonString;
        [Export("toJsonString")]
        string ToJsonString { get; }
    }

    // @interface AgoraPublisherConfigurationBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraPublisherConfigurationBuilder
    {
        // -(AgoraPublisherConfigurationBuilder *)setOwner:(BOOL)isOwner;
        [Export("setOwner:")]
        AgoraPublisherConfigurationBuilder SetOwner(bool isOwner);

        // -(AgoraPublisherConfigurationBuilder *)setWidth:(NSInteger)width height:(NSInteger)height framerate:(NSInteger)framerate bitrate:(NSInteger)bitrate;
        [Export("setWidth:height:framerate:bitrate:")]
        AgoraPublisherConfigurationBuilder SetWidth(nint width, nint height, nint framerate, nint bitrate);

        // -(AgoraPublisherConfigurationBuilder *)setDefaultLayout:(NSInteger)layoutStyle;
        [Export("setDefaultLayout:")]
        AgoraPublisherConfigurationBuilder SetDefaultLayout(nint layoutStyle);

        // -(AgoraPublisherConfigurationBuilder *)setLifeCycle:(AgoraRtmpStreamLifeCycle)lifecycle;
        [Export("setLifeCycle:")]
        AgoraPublisherConfigurationBuilder SetLifeCycle(AgoraRtmpStreamLifeCycle lifecycle);

        // -(AgoraPublisherConfigurationBuilder *)setPublisherUrl:(NSString *)url;
        [Export("setPublisherUrl:")]
        AgoraPublisherConfigurationBuilder SetPublisherUrl(string url);

        // -(AgoraPublisherConfigurationBuilder *)setRawStreamUrl:(NSString *)url;
        [Export("setRawStreamUrl:")]
        AgoraPublisherConfigurationBuilder SetRawStreamUrl(string url);

        // -(AgoraPublisherConfigurationBuilder *)setExtraInfo:(NSString *)info;
        [Export("setExtraInfo:")]
        AgoraPublisherConfigurationBuilder SetExtraInfo(string info);

        // -(AgoraPublisherConfigurationBuilder *)injectStream:(NSString *)url width:(NSInteger)width height:(NSInteger)height;
        [Export("injectStream:width:height:")]
        AgoraPublisherConfigurationBuilder InjectStream(string url, nint width, nint height);

        // -(AgoraPublisherConfiguration *)build;
        [Export("build")]
        AgoraPublisherConfiguration Build { get; }
    }

    // @protocol AgoraRtcEngineDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AgoraRtcEngineDelegate
    {
        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOccurWarning:(AgoraRtcWarningCode)warningCode;
        [Export("rtcEngine:didOccurWarning:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcWarningCode warningCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOccurError:(AgoraRtcErrorCode)errorCode;
        [Export("rtcEngine:didOccurError:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcErrorCode errorCode);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine reportAudioVolumeIndicationOfSpeakers:(NSArray *)speakers totalVolume:(NSInteger)totalVolume;
        [Export("rtcEngine:reportAudioVolumeIndicationOfSpeakers:totalVolume:")]

        void RtcEngine(AgoraRtcEngineKit engine, NSObject[] speakers, nint totalVolume);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstLocalVideoFrameWithSize:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalVideoFrameWithSize:elapsed:")]
        void RtcEngine(AgoraRtcEngineKit engine, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstRemoteVideoDecodedOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoDecodedOfUid:size:elapsed:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine videoSizeChangedOfUid:(NSUInteger)uid size:(CGSize)size rotation:(NSInteger)rotation;
        [Export("rtcEngine:videoSizeChangedOfUid:size:rotation:")]
        void RtcEngineWithVideoSizeChanged(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint rotation);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstRemoteVideoFrameOfUid:(NSUInteger)uid size:(CGSize)size elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteVideoFrameOfUid:size:elapsed:")]
        void RtcEngineWithfirstRemoteVideoFrame(AgoraRtcEngineKit engine, nuint uid, CGSize size, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didJoinedOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinedOfUid:elapsed:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOfflineOfUid:(NSUInteger)uid reason:(AgoraRtcUserOfflineReason)reason;
        [Export("rtcEngine:didOfflineOfUid:reason:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, AgoraRtcUserOfflineReason reason);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didAudioMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didAudioMuted:byUid:")]
        void RtcEngine(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didVideoMuted:(BOOL)muted byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoMuted:byUid:")]
        void RtcEngineWithDidVideoMuted(AgoraRtcEngineKit engine, bool muted, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didAudioRouteChanged:(AgoraRtcAudioOutputRouting)routing;
        [Export("rtcEngine:didAudioRouteChanged:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcAudioOutputRouting routing);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didVideoEnabled:(BOOL)enabled byUid:(NSUInteger)uid;
        [Export("rtcEngine:didVideoEnabled:byUid:")]
        void RtcEngineWithDidVideoEnabled(AgoraRtcEngineKit engine, bool enabled, nuint uid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine localVideoStats:(AgoraRtcLocalVideoStats *)stats;
        [Export("rtcEngine:localVideoStats:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcLocalVideoStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine remoteVideoStats:(AgoraRtcRemoteVideoStats *)stats;
        [Export("rtcEngine:remoteVideoStats:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcRemoteVideoStats stats);

        // @optional -(void)rtcEngineMediaEngineDidLoaded:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineMediaEngineDidLoaded:")]
        void RtcEngineMediaEngineDidLoaded(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineMediaEngineDidStartCall:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineMediaEngineDidStartCall:")]
        void RtcEngineMediaEngineDidStartCall(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineMediaEngineDidAudioMixingFinish:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineMediaEngineDidAudioMixingFinish:")]
        void RtcEngineMediaEngineDidAudioMixingFinish(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineMediaEngineDidAudioEffectFinish:(AgoraRtcEngineKit *)engine soundId:(NSInteger)soundId;
        [Export("rtcEngineMediaEngineDidAudioEffectFinish:soundId:")]
        void RtcEngineMediaEngineDidAudioEffectFinish(AgoraRtcEngineKit engine, nint soundId);

        // @optional -(void)rtcEngineCameraDidReady:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineCameraDidReady:")]
        void RtcEngineCameraDidReady(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineVideoDidStop:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineVideoDidStop:")]
        void RtcEngineVideoDidStop(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidInterrupted:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineConnectionDidInterrupted:")]
        void RtcEngineConnectionDidInterrupted(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngineConnectionDidLost:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineConnectionDidLost:")]
        void RtcEngineConnectionDidLost(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didJoinChannel:(NSString *)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didJoinChannel:withUid:elapsed:")]
        void RtcEngine(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didRejoinChannel:(NSString *)channel withUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:didRejoinChannel:withUid:elapsed:")]
        void RtcEngineWithDidRejoinChannel(AgoraRtcEngineKit engine, string channel, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine reportRtcStats:(AgoraRtcStats *)stats;
        [Export("rtcEngine:reportRtcStats:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didLeaveChannelWithStats:(AgoraRtcStats *)stats;
        [Export("rtcEngine:didLeaveChannelWithStats:")]
        void RtcEngineWithDidLeaveChannelWithStats(AgoraRtcEngineKit engine, AgoraRtcStats stats);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine audioQualityOfUid:(NSUInteger)uid quality:(AgoraRtcQuality)quality delay:(NSUInteger)delay lost:(NSUInteger)lost;
        [Export("rtcEngine:audioQualityOfUid:quality:delay:lost:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, AgoraRtcQuality quality, nuint delay, nuint lost);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine networkQuality:(NSUInteger)uid txQuality:(AgoraRtcQuality)txQuality rxQuality:(AgoraRtcQuality)rxQuality;
        [Export("rtcEngine:networkQuality:txQuality:rxQuality:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, AgoraRtcQuality txQuality, AgoraRtcQuality rxQuality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine lastmileQuality:(AgoraRtcQuality)quality;
        [Export("rtcEngine:lastmileQuality:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcQuality quality);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didApiCallExecute:(NSString *)api error:(NSInteger)error;
        [Export("rtcEngine:didApiCallExecute:error:")]
        void RtcEngine(AgoraRtcEngineKit engine, string api, nint error);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didRefreshRecordingServiceStatus:(NSInteger)status;
        [Export("rtcEngine:didRefreshRecordingServiceStatus:")]
        void RtcEngine(AgoraRtcEngineKit engine, nint status);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine receiveStreamMessageFromUid:(NSUInteger)uid streamId:(NSInteger)streamId data:(NSData *)data;
        [Export("rtcEngine:receiveStreamMessageFromUid:streamId:data:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, nint streamId, NSData data);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didOccurStreamMessageErrorFromUid:(NSUInteger)uid streamId:(NSInteger)streamId error:(NSInteger)error missed:(NSInteger)missed cached:(NSInteger)cached;
        [Export("rtcEngine:didOccurStreamMessageErrorFromUid:streamId:error:missed:cached:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint uid, nint streamId, nint error, nint missed, nint cached);

        // @optional -(void)rtcEngineRequestChannelKey:(AgoraRtcEngineKit *)engine;
        [Export("rtcEngineRequestChannelKey:")]
        void RtcEngineRequestChannelKey(AgoraRtcEngineKit engine);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstLocalAudioFrame:(NSInteger)elapsed;
        [Export("rtcEngine:firstLocalAudioFrame:")]
        void RtcEngineWithFirstLoadAudioFrame(AgoraRtcEngineKit engine, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine firstRemoteAudioFrameOfUid:(NSUInteger)uid elapsed:(NSInteger)elapsed;
        [Export("rtcEngine:firstRemoteAudioFrameOfUid:elapsed:")]
        void RtcEngineWithFirstRemoteAudioFrame(AgoraRtcEngineKit engine, nuint uid, nint elapsed);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine activeSpeaker:(NSUInteger)speakerUid;
        [Export("rtcEngine:activeSpeaker:")]
        void RtcEngine(AgoraRtcEngineKit engine, nuint speakerUid);

        // @optional -(void)rtcEngine:(AgoraRtcEngineKit *)engine didClientRoleChanged:(AgoraRtcClientRole)oldRole newRole:(AgoraRtcClientRole)newRole;
        [Export("rtcEngine:didClientRoleChanged:newRole:")]
        void RtcEngine(AgoraRtcEngineKit engine, AgoraRtcClientRole oldRole, AgoraRtcClientRole newRole);
    }

    // @interface AgoraRtcEngineKit : NSObject
    [BaseType(typeof(NSObject))]
    interface AgoraRtcEngineKit
    {
        // +(NSString *)getSdkVersion;
        [Static]
        [Export("getSdkVersion")]
        string SdkVersion { get; }

        // +(NSString *)getMediaEngineVersion;
        [Static]
        [Export("getMediaEngineVersion")]
        string MediaEngineVersion { get; }

        // -(void *)getNativeHandle;
        //[Export("getNativeHandle")]
        //unsafe void NativeHandle { get; }

        // +(instancetype)sharedEngineWithAppId:(NSString *)appId delegate:(id<AgoraRtcEngineDelegate>)delegate;
        [Static]
        [Export("sharedEngineWithAppId:delegate:")]
        AgoraRtcEngineKit SharedEngineWithAppId(string appId, AgoraRtcEngineDelegate @delegate);

        // +(instancetype)sharedEngineWithAppId:(NSString *)AppId error:(void (^)(AgoraRtcErrorCode))errorBlock __attribute__((deprecated("")));
        [Static]
        [Export("sharedEngineWithAppId:error:")]
        AgoraRtcEngineKit SharedEngineWithAppId(string AppId, Action<AgoraRtcErrorCode> errorBlock);

        // +(void)destroy;
        [Static]
        [Export("destroy")]
        void Destroy();

        // -(void)audioVolumeIndicationBlock:(void (^)(NSArray *, NSInteger))audioVolumeIndicationBlock __attribute__((deprecated("")));
        [Export("audioVolumeIndicationBlock:")]
        void AudioVolumeIndicationBlock(Action<NSArray, nint> audioVolumeIndicationBlock);

        // -(void)firstLocalVideoFrameBlock:(void (^)(NSInteger, NSInteger, NSInteger))firstLocalVideoFrameBlock __attribute__((deprecated("")));
        [Export("firstLocalVideoFrameBlock:")]
        void FirstLocalVideoFrameBlock(Action<nint, nint, nint> firstLocalVideoFrameBlock);

        // -(void)firstRemoteVideoDecodedBlock:(void (^)(NSUInteger, NSInteger, NSInteger, NSInteger))firstRemoteVideoDecodedBlock __attribute__((deprecated("")));
        [Export("firstRemoteVideoDecodedBlock:")]
        void FirstRemoteVideoDecodedBlock(Action<nuint, nint, nint, nint> firstRemoteVideoDecodedBlock);

        // -(void)firstRemoteVideoFrameBlock:(void (^)(NSUInteger, NSInteger, NSInteger, NSInteger))firstRemoteVideoFrameBlock __attribute__((deprecated("")));
        [Export("firstRemoteVideoFrameBlock:")]
        void FirstRemoteVideoFrameBlock(Action<nuint, nint, nint, nint> firstRemoteVideoFrameBlock);

        // -(void)userJoinedBlock:(void (^)(NSUInteger, NSInteger))userJoinedBlock __attribute__((deprecated("")));
        [Export("userJoinedBlock:")]
        void UserJoinedBlock(Action<nuint, nint> userJoinedBlock);

        // -(void)userOfflineBlock:(void (^)(NSUInteger))userOfflineBlock __attribute__((deprecated("")));
        [Export("userOfflineBlock:")]
        void UserOfflineBlock(Action<nuint> userOfflineBlock);

        // -(void)userMuteAudioBlock:(void (^)(NSUInteger, BOOL))userMuteAudioBlock __attribute__((deprecated("")));
        [Export("userMuteAudioBlock:")]
        void UserMuteAudioBlock(Action<nuint, bool> userMuteAudioBlock);

        // -(void)userMuteVideoBlock:(void (^)(NSUInteger, BOOL))userMuteVideoBlock __attribute__((deprecated("")));
        [Export("userMuteVideoBlock:")]
        void UserMuteVideoBlock(Action<nuint, bool> userMuteVideoBlock);

        // -(void)localVideoStatBlock:(void (^)(NSInteger, NSInteger))localVideoStatBlock __attribute__((deprecated("")));
        [Export("localVideoStatBlock:")]
        void LocalVideoStatBlock(Action<nint, nint> localVideoStatBlock);

        // -(void)remoteVideoStatBlock:(void (^)(NSUInteger, NSInteger, NSInteger, NSInteger))remoteVideoStatBlock __attribute__((deprecated("")));
        [Export("remoteVideoStatBlock:")]
        void RemoteVideoStatBlock(Action<nuint, nint, nint, nint> remoteVideoStatBlock);

        // -(void)cameraReadyBlock:(void (^)())cameraReadyBlock __attribute__((deprecated("")));
        [Export("cameraReadyBlock:")]
        void CameraReadyBlock(Action cameraReadyBlock);

        // -(void)connectionLostBlock:(void (^)())connectionLostBlock __attribute__((deprecated("")));
        [Export("connectionLostBlock:")]
        void ConnectionLostBlock(Action connectionLostBlock);

        // -(void)rejoinChannelSuccessBlock:(void (^)(NSString *, NSUInteger, NSInteger))rejoinChannelSuccessBlock __attribute__((deprecated("")));
        [Export("rejoinChannelSuccessBlock:")]
        void RejoinChannelSuccessBlock(Action<NSString, nuint, nint> rejoinChannelSuccessBlock);

        // -(void)rtcStatsBlock:(void (^)(AgoraRtcStats *))rtcStatsBlock __attribute__((deprecated("")));
        [Export("rtcStatsBlock:")]
        void RtcStatsBlock(Action<AgoraRtcStats> rtcStatsBlock);

        // -(void)leaveChannelBlock:(void (^)(AgoraRtcStats *))leaveChannelBlock __attribute__((deprecated("")));
        [Export("leaveChannelBlock:")]
        void LeaveChannelBlock(Action<AgoraRtcStats> leaveChannelBlock);

        // -(void)audioQualityBlock:(void (^)(NSUInteger, AgoraRtcQuality, NSUInteger, NSUInteger))audioQualityBlock __attribute__((deprecated("")));
        [Export("audioQualityBlock:")]
        void AudioQualityBlock(Action<nuint, AgoraRtcQuality, nuint, nuint> audioQualityBlock);

        // -(void)networkQualityBlock:(void (^)(NSUInteger, AgoraRtcQuality, AgoraRtcQuality))networkQualityBlock __attribute__((deprecated("")));
        [Export("networkQualityBlock:")]
        void NetworkQualityBlock(Action<nuint, AgoraRtcQuality, AgoraRtcQuality> networkQualityBlock);

        // -(void)lastmileQualityBlock:(void (^)(AgoraRtcQuality))lastmileQualityBlock __attribute__((deprecated("")));
        [Export("lastmileQualityBlock:")]
        void LastmileQualityBlock(Action<AgoraRtcQuality> lastmileQualityBlock);

        // -(void)mediaEngineEventBlock:(void (^)(NSInteger))mediaEngineEventBlock __attribute__((deprecated("")));
        [Export("mediaEngineEventBlock:")]
        void MediaEngineEventBlock(Action<nint> mediaEngineEventBlock);

        // -(int)enableMainQueueDispatch:(BOOL)enabled;
        [Export("enableMainQueueDispatch:")]
        int EnableMainQueueDispatch(bool enabled);

        // -(int)joinChannelByKey:(NSString *)channelKey channelName:(NSString *)channelName info:(NSString *)info uid:(NSUInteger)uid joinSuccess:(void (^)(NSString *, NSUInteger, NSInteger))joinSuccessBlock;
        [Export("joinChannelByKey:channelName:info:uid:joinSuccess:")]
        int JoinChannelByKey(string channelKey, string channelName, string info, nuint uid, Action<NSString, nuint, nint> joinSuccessBlock);

        // -(int)leaveChannel:(void (^)(AgoraRtcStats *))leaveChannelBlock;
        [Export("leaveChannel:")]
        int LeaveChannel(Action<AgoraRtcStats> leaveChannelBlock);

        // -(int)enableLastmileTest;
        [Export("enableLastmileTest")]
        int EnableLastmileTest { get; }

        // -(int)disableLastmileTest;
        [Export("disableLastmileTest")]
        int DisableLastmileTest { get; }

        // -(int)enableVideo;
        [Export("enableVideo")]
        int EnableVideo { get; }

        // -(int)disableVideo;
        [Export("disableVideo")]
        int DisableVideo { get; }

        // -(int)enableLocalVideo:(BOOL)enabled;
        [Export("enableLocalVideo:")]
        int EnableLocalVideo(bool enabled);

        // -(int)startPreview;
        [Export("startPreview")]
        int StartPreview { get; }

        // -(int)stopPreview;
        [Export("stopPreview")]

        int StopPreview { get; }

        // -(int)enableAudio;
        [Export("enableAudio")]

        int EnableAudio { get; }

        // -(int)disableAudio;
        [Export("disableAudio")]

        int DisableAudio { get; }

        // -(int)setParameters:(NSString *)options;
        [Export("setParameters:")]
        int SetParameters(string options);

        // -(NSString *)getParameter:(NSString *)parameter args:(NSString *)args;
        [Export("getParameter:args:")]
        string GetParameter(string parameter, string args);

        // -(NSString *)getCallId;
        [Export("getCallId")]

        string CallId { get; }

        // -(int)rate:(NSString *)callId rating:(NSInteger)rating description:(NSString *)description;
        [Export("rate:rating:description:")]
        int Rate(string callId, nint rating, string description);

        // -(int)complain:(NSString *)callId description:(NSString *)description;
        [Export("complain:description:")]
        int Complain(string callId, string description);

        // -(int)setEnableSpeakerphone:(BOOL)enableSpeaker;
        [Export("setEnableSpeakerphone:")]
        int SetEnableSpeakerphone(bool enableSpeaker);

        // -(BOOL)isSpeakerphoneEnabled;
        [Export("isSpeakerphoneEnabled")]

        bool IsSpeakerphoneEnabled { get; }

        // -(int)setDefaultAudioRouteToSpeakerphone:(BOOL)defaultToSpeaker;
        [Export("setDefaultAudioRouteToSpeakerphone:")]
        int SetDefaultAudioRouteToSpeakerphone(bool defaultToSpeaker);

        // -(int)setSpeakerphoneVolume:(NSUInteger)volume __attribute__((deprecated("")));
        [Export("setSpeakerphoneVolume:")]
        int SetSpeakerphoneVolume(nuint volume);

        // -(int)enableAudioVolumeIndication:(NSInteger)interval smooth:(NSInteger)smooth;
        [Export("enableAudioVolumeIndication:smooth:")]
        int EnableAudioVolumeIndication(nint interval, nint smooth);

        // -(int)startAudioRecording:(NSString *)filePath quality:(AgoraRtcAudioRecordingQuality)quality;
        [Export("startAudioRecording:quality:")]
        int StartAudioRecording(string filePath, AgoraRtcAudioRecordingQuality quality);

        // -(int)stopAudioRecording;
        [Export("stopAudioRecording")]

        int StopAudioRecording { get; }

        // -(int)startAudioMixing:(NSString *)filePath loopback:(BOOL)loopback replace:(BOOL)replace cycle:(NSInteger)cycle;
        [Export("startAudioMixing:loopback:replace:cycle:")]
        int StartAudioMixing(string filePath, bool loopback, bool replace, nint cycle);

        // -(int)stopAudioMixing;
        [Export("stopAudioMixing")]

        int StopAudioMixing { get; }

        // -(int)pauseAudioMixing;
        [Export("pauseAudioMixing")]

        int PauseAudioMixing { get; }

        // -(int)resumeAudioMixing;
        [Export("resumeAudioMixing")]

        int ResumeAudioMixing { get; }

        // -(int)adjustAudioMixingVolume:(NSInteger)volume;
        [Export("adjustAudioMixingVolume:")]
        int AdjustAudioMixingVolume(nint volume);

        // -(int)getAudioMixingDuration;
        [Export("getAudioMixingDuration")]

        int AudioMixingDuration { get; }

        // -(int)getAudioMixingCurrentPosition;
        [Export("getAudioMixingCurrentPosition")]

        int AudioMixingCurrentPosition { get; }

        // -(int)setAudioMixingPosition:(NSInteger)pos;
        [Export("setAudioMixingPosition:")]
        int SetAudioMixingPosition(nint pos);

        // -(int)startEchoTest:(void (^)(NSString *, NSUInteger, NSInteger))successBlock;
        [Export("startEchoTest:")]
        int StartEchoTest(Action<NSString, nuint, nint> successBlock);

        // -(int)stopEchoTest;
        [Export("stopEchoTest")]

        int StopEchoTest { get; }

        // -(int)muteLocalAudioStream:(BOOL)mute;
        [Export("muteLocalAudioStream:")]
        int MuteLocalAudioStream(bool mute);

        // -(int)muteAllRemoteAudioStreams:(BOOL)mute;
        [Export("muteAllRemoteAudioStreams:")]
        int MuteAllRemoteAudioStreams(bool mute);

        // -(int)muteRemoteAudioStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteAudioStream:mute:")]
        int MuteRemoteAudioStream(nuint uid, bool mute);

        // -(int)setupLocalVideo:(AgoraRtcVideoCanvas *)local;
        [Export("setupLocalVideo:")]
        int SetupLocalVideo(AgoraRtcVideoCanvas local);

        // -(int)setupRemoteVideo:(AgoraRtcVideoCanvas *)remote;
        [Export("setupRemoteVideo:")]
        int SetupRemoteVideo(AgoraRtcVideoCanvas remote);

        // -(int)setLocalRenderMode:(AgoraRtcRenderMode)mode;
        [Export("setLocalRenderMode:")]
        int SetLocalRenderMode(AgoraRtcRenderMode mode);

        // -(int)setRemoteRenderMode:(NSUInteger)uid mode:(AgoraRtcRenderMode)mode;
        [Export("setRemoteRenderMode:mode:")]
        int SetRemoteRenderMode(nuint uid, AgoraRtcRenderMode mode);

        // -(int)switchView:(NSUInteger)uid1 andAnother:(NSUInteger)uid2 __attribute__((deprecated("")));
        [Export("switchView:andAnother:")]
        int SwitchView(nuint uid1, nuint uid2);

        // -(int)switchCamera;
        [Export("switchCamera")]

        int SwitchCamera { get; }

        // -(int)setVideoProfile:(AgoraRtcVideoProfile)profile swapWidthAndHeight:(BOOL)swapWidthAndHeight;
        [Export("setVideoProfile:swapWidthAndHeight:")]
        int SetVideoProfile(AgoraRtcVideoProfile profile, bool swapWidthAndHeight);

        // -(int)setAudioProfile:(AgoraRtcAudioProfile)profile scenario:(AgoraRtcAudioScenario)scenario;
        [Export("setAudioProfile:scenario:")]
        int SetAudioProfile(AgoraRtcAudioProfile profile, AgoraRtcAudioScenario scenario);

        // -(int)muteLocalVideoStream:(BOOL)mute;
        [Export("muteLocalVideoStream:")]
        int MuteLocalVideoStream(bool mute);

        // -(int)muteAllRemoteVideoStreams:(BOOL)mute;
        [Export("muteAllRemoteVideoStreams:")]
        int MuteAllRemoteVideoStreams(bool mute);

        // -(int)muteRemoteVideoStream:(NSUInteger)uid mute:(BOOL)mute;
        [Export("muteRemoteVideoStream:mute:")]
        int MuteRemoteVideoStream(nuint uid, bool mute);

        // -(int)setLogFile:(NSString *)filePath;
        [Export("setLogFile:")]
        int SetLogFile(string filePath);

        // -(int)setLogFilter:(NSUInteger)filter;
        [Export("setLogFilter:")]
        int SetLogFilter(nuint filter);

        // -(int)renewChannelKey:(NSString *)channelKey;
        [Export("renewChannelKey:")]
        int RenewChannelKey(string channelKey);

        // -(int)setChannelProfile:(AgoraRtcChannelProfile)profile;
        [Export("setChannelProfile:")]
        int SetChannelProfile(AgoraRtcChannelProfile profile);

        // -(int)setClientRole:(AgoraRtcClientRole)role withKey:(NSString *)permissionKey;
        [Export("setClientRole:withKey:")]
        int SetClientRole(AgoraRtcClientRole role, string permissionKey);

        // -(int)enableDualStreamMode:(BOOL)enabled;
        [Export("enableDualStreamMode:")]
        int EnableDualStreamMode(bool enabled);

        // -(int)setEncryptionMode:(NSString *)encryptionMode;
        [Export("setEncryptionMode:")]
        int SetEncryptionMode(string encryptionMode);

        // -(int)setEncryptionSecret:(NSString *)secret;
        [Export("setEncryptionSecret:")]
        int SetEncryptionSecret(string secret);

        // -(int)setRemoteVideoStream:(NSUInteger)uid type:(AgoraRtcVideoStreamType)streamType;
        [Export("setRemoteVideoStream:type:")]
        int SetRemoteVideoStream(nuint uid, AgoraRtcVideoStreamType streamType);

        // -(int)startRecordingService:(NSString *)recordingKey;
        [Export("startRecordingService:")]
        int StartRecordingService(string recordingKey);

        // -(int)stopRecordingService:(NSString *)recordingKey;
        [Export("stopRecordingService:")]
        int StopRecordingService(string recordingKey);

        // -(int)refreshRecordingServiceStatus;
        [Export("refreshRecordingServiceStatus")]

        int RefreshRecordingServiceStatus { get; }

        // -(int)createDataStream:(NSInteger *)streamId reliable:(BOOL)reliable ordered:(BOOL)ordered;
        [Export("createDataStream:reliable:ordered:")]
        unsafe int CreateDataStream(nint streamId, bool reliable, bool ordered);

        // -(int)sendStreamMessage:(NSInteger)streamId data:(NSData *)data;
        [Export("sendStreamMessage:data:")]
        int SendStreamMessage(nint streamId, NSData data);

        // -(int)setRecordingAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraRtcRawAudioFrameOpMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setRecordingAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetRecordingAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AgoraRtcRawAudioFrameOpMode mode, nint samplesPerCall);

        // -(int)setPlaybackAudioFrameParametersWithSampleRate:(NSInteger)sampleRate channel:(NSInteger)channel mode:(AgoraRtcRawAudioFrameOpMode)mode samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setPlaybackAudioFrameParametersWithSampleRate:channel:mode:samplesPerCall:")]
        int SetPlaybackAudioFrameParametersWithSampleRate(nint sampleRate, nint channel, AgoraRtcRawAudioFrameOpMode mode, nint samplesPerCall);

        // -(int)setMixedAudioFrameParametersWithSampleRate:(NSInteger)sampleRate samplesPerCall:(NSInteger)samplesPerCall;
        [Export("setMixedAudioFrameParametersWithSampleRate:samplesPerCall:")]
        int SetMixedAudioFrameParametersWithSampleRate(nint sampleRate, nint samplesPerCall);

        // -(int)adjustRecordingSignalVolume:(NSInteger)volume;
        [Export("adjustRecordingSignalVolume:")]
        int AdjustRecordingSignalVolume(nint volume);

        // -(int)adjustPlaybackSignalVolume:(NSInteger)volume;
        [Export("adjustPlaybackSignalVolume:")]
        int AdjustPlaybackSignalVolume(nint volume);

        // -(int)setHighQualityAudioParametersWithFullband:(BOOL)fullband stereo:(BOOL)stereo fullBitrate:(BOOL)fullBitrate;
        [Export("setHighQualityAudioParametersWithFullband:stereo:fullBitrate:")]
        int SetHighQualityAudioParametersWithFullband(bool fullband, bool stereo, bool fullBitrate);

        // -(int)enableWebSdkInteroperability:(BOOL)enabled;
        [Export("enableWebSdkInteroperability:")]
        int EnableWebSdkInteroperability(bool enabled);

        // -(int)setVideoQualityParameters:(BOOL)preferFrameRateOverImageQuality;
        [Export("setVideoQualityParameters:")]
        int SetVideoQualityParameters(bool preferFrameRateOverImageQuality);

        // -(int)configPublisher:(AgoraPublisherConfiguration *)config;
        [Export("configPublisher:")]
        int ConfigPublisher(AgoraPublisherConfiguration config);

        // -(int)setVideoCompositingLayout:(AgoraRtcVideoCompositingLayout *)layout;
        [Export("setVideoCompositingLayout:")]
        int SetVideoCompositingLayout(AgoraRtcVideoCompositingLayout layout);

        // -(int)clearVideoCompositingLayout;
        [Export("clearVideoCompositingLayout")]

        int ClearVideoCompositingLayout { get; }

        // -(int)enableInEarMonitoring:(BOOL)enabled;
        [Export("enableInEarMonitoring:")]
        int EnableInEarMonitoring(bool enabled);

        // -(int)setInEarMonitoringVolume:(NSInteger)volume;
        [Export("setInEarMonitoringVolume:")]
        int SetInEarMonitoringVolume(nint volume);

        // -(double)getEffectsVolume;
        [Export("getEffectsVolume")]

        double EffectsVolume { get; }

        // -(int)setEffectsVolume:(double)volume;
        [Export("setEffectsVolume:")]
        int SetEffectsVolume(double volume);

        // -(int)setVolumeOfEffect:(int)soundId withVolume:(double)volume;
        [Export("setVolumeOfEffect:withVolume:")]
        int SetVolumeOfEffect(int soundId, double volume);

        // -(int)playEffect:(int)soundId filePath:(NSString *)filePath loop:(BOOL)loop pitch:(double)pitch pan:(double)pan gain:(double)gain;
        [Export("playEffect:filePath:loop:pitch:pan:gain:")]
        int PlayEffect(int soundId, string filePath, bool loop, double pitch, double pan, double gain);

        // -(int)stopEffect:(int)soundId;
        [Export("stopEffect:")]
        int StopEffect(int soundId);

        // -(int)stopAllEffects;
        [Export("stopAllEffects")]

        int StopAllEffects { get; }

        // -(int)preloadEffect:(int)soundId filePath:(NSString *)filePath;
        [Export("preloadEffect:filePath:")]
        int PreloadEffect(int soundId, string filePath);

        // -(int)unloadEffect:(int)soundId;
        [Export("unloadEffect:")]
        int UnloadEffect(int soundId);

        // -(int)pauseEffect:(int)soundId;
        [Export("pauseEffect:")]
        int PauseEffect(int soundId);

        // -(int)pauseAllEffects;
        [Export("pauseAllEffects")]

        int PauseAllEffects { get; }

        // -(int)resumeEffect:(int)soundId;
        [Export("resumeEffect:")]
        int ResumeEffect(int soundId);

        // -(int)resumeAllEffects;
        [Export("resumeAllEffects")]

        int ResumeAllEffects { get; }

        // -(int)setLocalVoicePitch:(double)pitch;
        [Export("setLocalVoicePitch:")]
        int SetLocalVoicePitch(double pitch);

        // -(void)setExternalVideoSource:(BOOL)enable useTexture:(BOOL)useTexture pushMode:(BOOL)pushMode;
        [Export("setExternalVideoSource:useTexture:pushMode:")]
        void SetExternalVideoSource(bool enable, bool useTexture, bool pushMode);

        // -(BOOL)pushExternalVideoFrame:(AgoraVideoFrame *)frame;
        [Export("pushExternalVideoFrame:")]
        bool PushExternalVideoFrame(AgoraVideoFrame frame);
    }
}