using System;
using ObjCRuntime;
namespace Agora_iOS
{
public enum AgoraRtcWarningCode : long
{
    InvalidView = 8,
    InitVideo = 16,
    Pending = 20,
    NoAvailableChannel = 103,
    LookupChannelTimeout = 104,
    LookupChannelRejected = 105,
    OpenChannelTimeout = 106,
    OpenChannelRejected = 107,
    SwitchLiveVideoTimeout = 111,
    SetClientRoleTimeout = 118,
    SetClientRoleNotAuthorized = 119,
    AudioMixingOpenError = 701,
    Adm_RuntimePlayoutWarning = 1014,
    Adm_RuntimeRecordingWarning = 1016,
    Adm_RecordAudioSilence = 1019,
    Adm_PlaybackMalfunction = 1020,
    Adm_RecordMalfunction = 1021,
    Adm_Interruption = 1025,
    Apm_Howling = 1051
}

public enum AgoraRtcErrorCode : long
{
    NoError = 0,
    Failed = 1,
    InvalidArgument = 2,
    NotReady = 3,
    NotSupported = 4,
    Refused = 5,
    BufferTooSmall = 6,
    NotInitialized = 7,
    NoPermission = 9,
    TimedOut = 10,
    Canceled = 11,
    TooOften = 12,
    BindSocket = 13,
    NetDown = 14,
    NoBufs = 15,
    JoinChannelRejected = 17,
    LeaveChannelRejected = 18,
    AlreadyInUse = 19,
    InvalidAppId = 101,
    InvalidChannelName = 102,
    ChannelKeyExpired = 109,
    InvalidChannelKey = 110,
    ConnectionInterrupted = 111,
    ConnectionLost = 112,
    NotInChannel = 113,
    SizeTooLarge = 114,
    BitrateLimit = 115,
    TooManyDataStreams = 116,
    DecryptionFailed = 120,
    LoadMediaEngine = 1001,
    StartCall = 1002,
    StartCamera = 1003,
    StartVideoRender = 1004,
    Adm_GeneralError = 1005,
    Adm_JavaResource = 1006,
    Adm_SampleRate = 1007,
    Adm_InitPlayout = 1008,
    Adm_StartPlayout = 1009,
    Adm_StopPlayout = 1010,
    Adm_InitRecording = 1011,
    Adm_StartRecording = 1012,
    Adm_StopRecording = 1013,
    Adm_RuntimePlayoutError = 1015,
    Adm_RuntimeRecordingError = 1017,
    Adm_RecordAudioFailed = 1018,
    Adm_Play_Abnormal_Frequency = 1020,
    Adm_Record_Abnormal_Frequency = 1021,
    Adm_Init_Loopback = 1022,
    Adm_Start_Loopback = 1023,
    Vdm_Camera_Not_Authorized = 1501,
    Vcm_Unknown_Error = 1600,
    Vcm_Encoder_Init_Error = 1601,
    Vcm_Encoder_Encode_Error = 1602,
    Vcm_Encoder_Set_Error = 1603
}

public enum AgoraRtcChannelProfile : long
{
    Communication = 0,
    LiveBroadcasting = 1,
    Game = 2
}

public enum AgoraRtcClientRole : long
{
    Broadcaster = 1,
    Audience = 2
}

public enum AgoraRtcVideoProfile : long
{
    Invalid = -1,
    AgoraRtc_VideoProfile_120P = 0,
    AgoraRtc_VideoProfile_120P_3 = 2,
    AgoraRtc_VideoProfile_180P = 10,
    AgoraRtc_VideoProfile_180P_3 = 12,
    AgoraRtc_VideoProfile_180P_4 = 13,
    AgoraRtc_VideoProfile_240P = 20,
    AgoraRtc_VideoProfile_240P_3 = 22,
    AgoraRtc_VideoProfile_240P_4 = 23,
    AgoraRtc_VideoProfile_360P = 30,
    AgoraRtc_VideoProfile_360P_3 = 32,
    AgoraRtc_VideoProfile_360P_4 = 33,
    AgoraRtc_VideoProfile_360P_6 = 35,
    AgoraRtc_VideoProfile_360P_7 = 36,
    AgoraRtc_VideoProfile_360P_8 = 37,
    AgoraRtc_VideoProfile_360P_9 = 38,
    AgoraRtc_VideoProfile_360P_10 = 39,
    AgoraRtc_VideoProfile_360P_11 = 100,
    AgoraRtc_VideoProfile_480P = 40,
    AgoraRtc_VideoProfile_480P_3 = 42,
    AgoraRtc_VideoProfile_480P_4 = 43,
    AgoraRtc_VideoProfile_480P_6 = 45,
    AgoraRtc_VideoProfile_480P_8 = 47,
    AgoraRtc_VideoProfile_480P_9 = 48,
    AgoraRtc_VideoProfile_480P_10 = 49,
    AgoraRtc_VideoProfile_720P = 50,
    AgoraRtc_VideoProfile_720P_3 = 52,
    AgoraRtc_VideoProfile_720P_5 = 54,
    AgoraRtc_VideoProfile_720P_6 = 55,
    AgoraRtc_VideoProfile_1080P = 60,
    AgoraRtc_VideoProfile_1080P_3 = 62,
    AgoraRtc_VideoProfile_1080P_5 = 64,
    AgoraRtc_VideoProfile_1440P = 66,
    AgoraRtc_VideoProfile_1440P_2 = 67,
    AgoraRtc_VideoProfile_4K = 70,
    AgoraRtc_VideoProfile_4K_3 = 72,
    Default = AgoraRtc_VideoProfile_360P
}

public enum AgoraRtcAudioProfile : long
{
    Default = 0,
    SpeechStandard = 1,
    MusicStandard = 2,
    MusicStandardStereo = 3,
    MusicHighQuality = 4,
    MusicHighQualityStereo = 5
}

public enum AgoraRtcAudioScenario : long
{
    Default = 0,
    ChatRoom = 1,
    Education = 2,
    GameStreaming = 3,
    ShowRoom = 4
}

public enum AgoraRtcQuality : ulong
{
    Unknown = 0,
    Excellent = 1,
    Good = 2,
    Poor = 3,
    Bad = 4,
    VBad = 5,
    Down = 6
}

public enum AgoraRtcUserOfflineReason : ulong
{
    Quit = 0,
    Dropped = 1,
    BecomeAudience = 2
}

public enum AgoraRtcVideoStreamType : long
{
    High = 0,
    Low = 1
}

public enum AgoraRtcAudioOutputRouting : long
{
    Default = -1,
    Headset = 0,
    Earpiece = 1,
    HeadsetNoMic = 2,
    Speakerphone = 3,
    Loudspeaker = 4,
    HeadsetBluetooth = 5
}

public enum AgoraRtcAudioRecordingQuality : long
{
    Low = 0,
    Medium = 1,
    High = 2
}

public enum AgoraRtcLogFilter : ulong
{
    Off = 0,
    Debug = 2063,
    Info = 15,
    Warn = 14,
    Error = 12,
    Critical = 8
}

public enum AgoraRtmpStreamLifeCycle : long
{
    Channel = 1,
    Ownner = 2
}

public enum AgoraRtcRenderMode : ulong
{
    Hidden = 1,
    Fit = 2,
    Adaptive = 3
}

public enum AgoraRtcQualityReportFormat : ulong
{
    Json = 0,
    Html = 1
}

public enum AgoraRtcRawAudioFrameOpMode : long
{
    ReadOnly = 0,
    WriteOnly = 1,
    ReadWrite = 2
}

public enum AgoraVideoFormat : ulong
{
    texture = 12,
    I420 = 1,
    Rgba = 4,
    Imc2 = 5
}
}