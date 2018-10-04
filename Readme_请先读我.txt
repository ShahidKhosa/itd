【Demo功能】

1、Demo介绍SDK初始化、登陆设备、登出设备、自动重连、监视、打开道闸、订阅智能交通事件、接收智能交通事件信息、解析智能交通事件信息、显示智能交通事件部分信息、显示大图、显示小图、手动抓拍、取消订阅智能交通事件功能。
2、Demo演示了闯红灯事件、卡口事件、超速事件、低速事件、手动抓拍事件、无车位事件、有车位事件、压车道线事件、逆行事件、违章左转事件、违章右转事件、违章掉头事件、违章停车事件、不按车道行事件、违章变道事件、压黄线事件、黄牌车占道事件、未礼让行人事件、有车占道事件、占用公交车道事件、违章倒车事件、未系安全带事件。


【注意事项】
1、编译环境为VS2010，NETSDKCS库最低只支持.NET Framework 4.0,如用户需要支持低于4.0的版本需要更改NetSDK.cs文件中使用到IntPtr.Add的方法,我们不提供修改。
2、此Demo接收智能事件图片时，采用默认的2M接收图片缓存，如部分事件图片过大，可能接收不到事件，请用户在SDK初始化后调用SetNetworkParam函数，修改接收图片缓存的大小，最大可支持到8M。
3、此Demo只演示监听单设备单通道订阅功能，不支持多设备多通道订阅功能，如用户有需求请自行修改。
4、此Demo仅演示部分通用的智能交通事件功能，如需另外智能交通事件功能，请自行添加。
5、运行前请把"\General_NetSDK_Chn_Win32_IS_V3.XX.X.R.XXXXXX\库文件\"里所有的DLL文件复制到"\General_NetSDK_Chn_Win32_IS_V3.XX.X.R.XXXXXX\演示程序\CSharpDemo\IntelligentTraffic\IntelligentTrafficDemoemo\bin\Release\"目录中,或"\General_NetSDK_Chn_Win64_IS_V3.XX.X.R.XXXXXX\库文件\"里所有的DLL文件复制到"\General_NetSDK_Chn_Win64_IS_V3.XX.X.R.XXXXXX\演示程\CSharpDemo\IntelligentTraffic\IntelligentTrafficDemoemo\bin\x64\Release\"目录中, 不要有遗漏DLL文件，以防启动程序时提示找不到依赖的库文件或运行出现问题。
6、如把库文件放入程序生成的目录中，运行有问题，请到大华官网下载最新的网络SDK版本：http://www.dahuatech.com/index.php/service/downloadlists/836.html 替换程序中的库文件。


【Demo Features】
1、Demo SDK initialization,login device,logout device,auto reconnect device, open strobe, subscribe intelligent traffic events, receive traffic event information, parse traffice event information,show some informations about traffic event,show picture,show platenumber picture, manual snap, unsubscribe intelligent traffic events function.
2、Demo run red light, junction,over speed,under speed,manual snap,no spaces,parking space,over line,retrograde,turn left illegally,turn right illegally,U-turn illegally,parking illegally,wrong route,lane change illegally,over yellow line,yellow plate in line,not courteous,vehicle in route,vehicle in bus route,backing,without safe belt.

【NOTE】
1、Complier for NetSDKCS project and Demo is VS2010,and target framework for NetSDKCS project is .NET Framework 4.Modify the code about IntPtr.Add method in the file "NetSDK.cs"，we don not support to modify it.
2、if the picture is larger than 2M will cannot receive the event,you can call SetNetworkParam function to set picture buffer size after SDK init and before login device,maximum support to 8M.
3、Just only demo subscribe one device one channel events.
4、Just only demo gengral traffic events, add others event code if the user has a requirement.
5、Copy All DLL files in the directory "\General_NetSDK_Eng_Win32_IS_V3.XX.X.R.XXXXXX\bin\" into the directory "\General_NetSDK_Eng_Win32_IS_V3.XX.X.R.XXXXXX\demo\CSharpDemo\IntelligentTraffic\IntelligentTrafficDemo\bin\Release\", or in the directory "\General_NetSDK_Eng_Win64_IS_V3.XX.X.R.XXXXXX\bin\" into the directory "\General_NetSDK_Eng_Win64_IS_V3.XX.X.R.XXXXXX\demo\CSharpDemo\IntelligentTraffic\IntelligentTrafficDemo\bin\x64\Release\"  before running. To avoid prompting to cannot find the dependent DLL files when the program start, or running with some problems.
6、If run the program with some problems,please go to 
http://www.dahuasecurity.com/download_3.html download the newest version,and replace the DLL files.
