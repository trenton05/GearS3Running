S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: runner
PID: 22375
Date: 2017-02-14 18:15:18-0600
Executable File Path: /opt/usr/apps/org.example.Running/bin/runner
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 22375, uid 5000)

Register Information
r0   = 0x0547f0e9, r1   = 0x0547f0e8
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xff85c328
r6   = 0xf5ed60a8, r7   = 0x0547f0e9
r8   = 0x0000006e, r9   = 0x00000000
r10  = 0xf5ed606b, fp   = 0xff85c31c
ip   = 0xff85c44c, sp   = 0xff85bdb0
lr   = 0xf7039e8c, pc   = 0xf706f0b4
cpsr = 0x60000010

Memory Information
MemTotal:   620364 KB
MemFree:     26540 KB
Buffers:      5128 KB
Cached:     104812 KB
VmPeak:     132252 KB
VmSize:     132248 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31284 KB
VmRSS:       31280 KB
VmData:      47532 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43944 KB
VmPTE:         156 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 22375 TID = 22375
22375 22466 22473 22474 22475 

Maps Information
ef901000 f0100000 rw-p [stack:22475]
f0101000 f0900000 rw-p [stack:22474]
f0901000 f1100000 rw-p [stack:22473]
f1217000 f1222000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
f122a000 f122c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1234000 f1235000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f123d000 f1245000 r-xp /usr/lib/libfeedback.so.0.1.4
f12df000 f1ade000 rw-p [stack:22466]
f1af3000 f1af5000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f1afd000 f1b01000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f1b0c000 f1b0d000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f1b15000 f1b18000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f1b20000 f1b24000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f2514000 f2516000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f251e000 f2535000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f2542000 f2547000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f254f000 f255a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f2882000 f2974000 r-xp /usr/lib/libCOREGL.so.4.0
f298d000 f2991000 r-xp /usr/lib/libogg.so.0.7.1
f2999000 f29bb000 r-xp /usr/lib/libvorbis.so.0.4.3
f29c3000 f29c8000 r-xp /usr/lib/libsystem.so.0.0.0
f29d2000 f29d8000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f29e0000 f29ef000 r-xp /usr/lib/libmdm-common.so.1.1.22
f29f8000 f2a3f000 r-xp /usr/lib/libsndfile.so.1.0.26
f2a4b000 f2a94000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2a9d000 f2aa2000 r-xp /usr/lib/libjson.so.0.0.1
f2aaa000 f2aad000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2ab5000 f2abb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f2ac3000 f2ace000 r-xp /usr/lib/libresourced.so.0.2.96
f2ad6000 f2ad7000 r-xp /usr/lib/librd-network.so.0.2.96
f2adf000 f2ae0000 r-xp /usr/lib/libresponse.so.0.2.96
f2ae8000 f2aed000 r-xp /usr/lib/libproc-stat.so.0.2.96
f2af6000 f2afd000 r-xp /usr/lib/libminizip.so.1.0.0
f2b05000 f2b07000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f2b0f000 f2b16000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f2b1f000 f2b24000 r-xp /usr/lib/libstorage.so.0.1
f2b2c000 f2b31000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f2b39000 f2b3b000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f2b43000 f2b64000 r-xp /usr/lib/libexif.so.12.3.3
f2b77000 f2b90000 r-xp /usr/lib/libnetwork.so.0.0.0
f2b98000 f2b9e000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f2ba7000 f2bef000 r-xp /usr/lib/libmdm.so.1.2.62
f2bf0000 f2bfd000 r-xp /usr/lib/libail.so.0.1.0
f2c06000 f2c09000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2c11000 f2c49000 r-xp /usr/lib/libpulse.so.0.16.2
f2c4a000 f2c4d000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2c55000 f2cb6000 r-xp /usr/lib/libasound.so.2.0.0
f2cc0000 f2cda000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2ce2000 f2ce9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2cf1000 f2cf5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2cfd000 f2d01000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2d0a000 f2d0c000 r-xp /usr/lib/libttrace.so.1.1
f45ac000 f45ad000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f45b6000 f45b9000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f45c1000 f45e3000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f45ec000 f45f1000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f45f9000 f4649000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f464f000 f4658000 r-xp /usr/lib/libcom-core.so.0.0.1
f4661000 f466b000 r-xp /usr/lib/libspdy.so.0.0.0
f4674000 f467a000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4682000 f4683000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f468c000 f469b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f46a4000 f46ae000 r-xp /usr/lib/libsensord-shared.so
f46b6000 f46c6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f46ce000 f46e7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f46ef000 f4705000 r-xp /usr/lib/libtts.so
f470e000 f4719000 r-xp /usr/lib/libtbm.so.1.0.0
f4721000 f473a000 r-xp /usr/lib/libstt.so
f4742000 f4759000 r-xp /usr/lib/libmmfsound.so.0.1.0
f476b000 f4770000 r-xp /usr/lib/libmemenv.so.1.1.0
f4778000 f47b4000 r-xp /usr/lib/libleveldb.so.1.1.0
f47bd000 f47ca000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f47d3000 f47d5000 r-xp /usr/lib/libdri2.so.0.0.0
f47dd000 f47e8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f47f5000 f47fc000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f4804000 f482d000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f4836000 f483a000 r-xp /usr/lib/libEGL.so.1.4
f484a000 f485b000 r-xp /usr/lib/libGLESv2.so.2.0
f486b000 f4879000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f4882000 f489a000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f48a3000 f48ac000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f48b4000 f48f5000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f48fe000 f4999000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f49a5000 f49ad000 r-xp /usr/lib/libdrm.so.2.4.0
f49b5000 f4abb000 r-xp /usr/lib/libicuuc.so.57.1
f4ad1000 f4c59000 r-xp /usr/lib/libicui18n.so.57.1
f4c69000 f4c8c000 r-xp /usr/lib/libui-extension.so.0.1.0
f4c95000 f4ca7000 r-xp /usr/lib/libefl-assist.so.0.1.0
f4caf000 f4cb7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4cbf000 f4cd1000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f4cd9000 f4cdc000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4ce4000 f4cf7000 r-xp /usr/lib/libwidget_service.so.1.0.0
f4d00000 f4d4c000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4d56000 f4d57000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4d5f000 f4e17000 r-xp /usr/lib/libcairo.so.2.11200.14
f4e22000 f4e27000 r-xp /usr/lib/libctx-client.so.0.8.3
f4e2f000 f4e36000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4e3e000 f4e68000 r-xp /usr/lib/libsensor.so.1.9.3
f4e71000 f4eab000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4eb4000 f5d78000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5e5e000 f5e7f000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5e87000 f5e93000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5e9c000 f5ea1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5ea9000 f5eae000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5eb6000 f5ec4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5ecd000 f5ed7000 r-xp /opt/usr/apps/org.example.Running/bin/runner
f607a000 f6084000 r-xp /lib/libnss_files-2.13.so
f608d000 f615c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f6172000 f6196000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f619f000 f61a5000 r-xp /usr/lib/libappsvc.so.0.1.0
f61ad000 f61b1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f61be000 f61c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f61d1000 f61d3000 r-xp /usr/lib/libiniparser.so.0
f61dc000 f61e1000 r-xp /usr/lib/libappcore-common.so.1.1
f61e9000 f61eb000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f61f4000 f61f8000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6205000 f6207000 r-xp /usr/lib/libXau.so.6.0.0
f620f000 f6216000 r-xp /lib/libcrypt-2.13.so
f6246000 f6248000 r-xp /usr/lib/libiri.so
f6251000 f63fa000 r-xp /usr/lib/libcrypto.so.1.0.0
f641a000 f6461000 r-xp /usr/lib/libssl.so.1.0.0
f646d000 f649b000 r-xp /usr/lib/libidn.so.11.5.44
f64a3000 f64ac000 r-xp /usr/lib/libcares.so.2.1.0
f64b6000 f64c9000 r-xp /usr/lib/libxcb.so.1.1.0
f64d2000 f64d5000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f64dd000 f64df000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f64e8000 f65b4000 r-xp /usr/lib/libxml2.so.2.7.8
f65c1000 f65c3000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f65cc000 f65d1000 r-xp /usr/lib/libffi.so.5.0.10
f65d9000 f65da000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f65e2000 f65e5000 r-xp /lib/libattr.so.1.1.0
f65ed000 f6681000 r-xp /usr/lib/libstdc++.so.6.0.16
f6694000 f66b1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66bb000 f66d3000 r-xp /usr/lib/libpng12.so.0.50.0
f66db000 f66f1000 r-xp /lib/libexpat.so.1.6.0
f66fb000 f673f000 r-xp /usr/lib/libcurl.so.4.3.0
f6748000 f6752000 r-xp /usr/lib/libXext.so.6.4.0
f675b000 f675f000 r-xp /usr/lib/libXtst.so.6.1.0
f6767000 f676d000 r-xp /usr/lib/libXrender.so.1.3.0
f6775000 f677b000 r-xp /usr/lib/libXrandr.so.2.2.0
f6783000 f6784000 r-xp /usr/lib/libXinerama.so.1.0.0
f678d000 f6796000 r-xp /usr/lib/libXi.so.6.1.0
f679e000 f67a1000 r-xp /usr/lib/libXfixes.so.3.1.0
f67a9000 f67ab000 r-xp /usr/lib/libXgesture.so.7.0.0
f67b3000 f67b5000 r-xp /usr/lib/libXcomposite.so.1.0.0
f67bd000 f67bf000 r-xp /usr/lib/libXdamage.so.1.1.0
f67c7000 f67ce000 r-xp /usr/lib/libXcursor.so.1.0.2
f67d6000 f67d9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f67e1000 f67e5000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f67ee000 f67f3000 r-xp /usr/lib/libecore_fb.so.1.7.99
f67fc000 f68dd000 r-xp /usr/lib/libX11.so.6.3.0
f68e8000 f690b000 r-xp /usr/lib/libjpeg.so.8.0.2
f6923000 f6939000 r-xp /lib/libz.so.1.2.5
f6941000 f6943000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f694b000 f69c0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69ca000 f69e4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69ec000 f6a20000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6a29000 f6afc000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b07000 f6b17000 r-xp /lib/libresolv-2.13.so
f6b1b000 f6b33000 r-xp /usr/lib/liblzma.so.5.0.3
f6b3b000 f6b3e000 r-xp /lib/libcap.so.2.21
f6b46000 f6b75000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b7d000 f6b7e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6b86000 f6b8c000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6b94000 f6bab000 r-xp /usr/lib/liblua-5.1.so
f6bb4000 f6bbb000 r-xp /usr/lib/libembryo.so.1.7.99
f6bc3000 f6bc9000 r-xp /lib/librt-2.13.so
f6bd2000 f6c28000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6c35000 f6c8b000 r-xp /usr/lib/libfreetype.so.6.11.3
f6c97000 f6cbf000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6cc0000 f6d05000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6d0e000 f6d21000 r-xp /usr/lib/libfribidi.so.0.3.1
f6d29000 f6d43000 r-xp /usr/lib/libecore_con.so.1.7.99
f6d4c000 f6d55000 r-xp /usr/lib/libedbus.so.1.7.99
f6d5d000 f6dad000 r-xp /usr/lib/libecore_x.so.1.7.99
f6daf000 f6db8000 r-xp /usr/lib/libvconf.so.0.2.45
f6dc0000 f6dd1000 r-xp /usr/lib/libecore_input.so.1.7.99
f6dd9000 f6dde000 r-xp /usr/lib/libecore_file.so.1.7.99
f6de6000 f6e08000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6e11000 f6e52000 r-xp /usr/lib/libeina.so.1.7.99
f6e5b000 f6e74000 r-xp /usr/lib/libeet.so.1.7.99
f6e85000 f6eee000 r-xp /lib/libm-2.13.so
f6ef7000 f6efd000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f06000 f6f07000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f0f000 f6f32000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f3a000 f6f3f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f47000 f6f71000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f7a000 f6f91000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f99000 f6fa4000 r-xp /lib/libunwind.so.8.0.1
f6fd1000 f6fef000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ff9000 f711d000 r-xp /lib/libc-2.13.so
f712b000 f7133000 r-xp /lib/libgcc_s-4.6.so.1
f7134000 f7138000 r-xp /usr/lib/libsmack.so.1.0.0
f7141000 f7147000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f714f000 f721f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7220000 f727e000 r-xp /usr/lib/libedje.so.1.7.99
f7288000 f729f000 r-xp /usr/lib/libecore.so.1.7.99
f72b6000 f7384000 r-xp /usr/lib/libevas.so.1.7.99
f73a9000 f74e5000 r-xp /usr/lib/libelementary.so.1.7.99
f74fc000 f7510000 r-xp /lib/libpthread-2.13.so
f751b000 f751d000 r-xp /usr/lib/libdlog.so.0.0.0
f7525000 f7528000 r-xp /usr/lib/libbundle.so.0.1.22
f7530000 f7532000 r-xp /lib/libdl-2.13.so
f753b000 f7548000 r-xp /usr/lib/libaul.so.0.1.0
f755a000 f7560000 r-xp /usr/lib/libappcore-efl.so.1.1
f7569000 f756d000 r-xp /usr/lib/libsys-assert.so
f7576000 f7593000 r-xp /lib/ld-2.13.so
f759c000 f75a1000 r-xp /usr/bin/launchpad-loader
f79ee000 f7c01000 rw-p [heap]
ff83d000 ff85e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22375)
Call Stack Count: 1
 0: strlen + 0x4 (0xf706f0b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: org.example.Running
Package ID : org.example.Running
Version: 1.0.0
Package Type: rpm
App Name: Running
App ID: org.example.Running
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
RemotePort.
02-14 18:15:16.951-0600 I/MESSAGE_PORT( 2545): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
02-14 18:15:16.951-0600 I/MESSAGE_PORT( 2545): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-14 18:15:16.951-0600 I/MESSAGE_PORT( 2545): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-14 18:15:16.951-0600 I/MESSAGE_PORT( 2545): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-14 18:15:16.961-0600 I/MESSAGE_PORT( 2545): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-14 18:15:16.961-0600 E/WMS     ( 2479): wms_package_manager.c: get_watch_app_info(705) > app[Music Player] metadata: notification-disable-on-gearmanager
02-14 18:15:16.961-0600 E/CAPI_APPFW_APP_CONTROL( 3613): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-14 18:15:16.961-0600 E/WMS     ( 2479): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.w-music-player_settings.xml
02-14 18:15:16.961-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-music-player], Appname[Music Player]
02-14 18:15:16.971-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3613]   [com.samsung.w-home]register msg port [false][0m
02-14 18:15:17.031-0600 E/WMS     ( 2479): wms_package_manager.c: get_watch_app_info(705) > app[Reminders] metadata: notification-disable-on-gearmanager
02-14 18:15:17.031-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-reminder], Appname[Reminders]
02-14 18:15:17.041-0600 W/AUL_AMD ( 2555): amd_request.c: __request_handler(669) > __request_handler: 14
02-14 18:15:17.051-0600 W/AUL_AMD ( 2555): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22375
02-14 18:15:17.061-0600 W/AUL_AMD ( 2555): amd_request.c: __request_handler(669) > __request_handler: 12
02-14 18:15:17.071-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.w-taskmanager], Appname[Recent apps]
02-14 18:15:17.091-0600 E/WMS     ( 2479): wms_package_manager.c: get_watch_app_info(754) > Setting File Exist!: com.samsung.weather_settings.xml
02-14 18:15:17.091-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.weather], Appname[Weather]
02-14 18:15:17.111-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.windicator], Appname[Controls]
02-14 18:15:17.131-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [336][0;m
02-14 18:15:17.141-0600 E/WMS     ( 2479): wms_package_manager.c: get_watch_app_info(705) > app[Notifications] metadata: notification-disable-on-gearmanager
02-14 18:15:17.141-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.wnotification2], Appname[Notifications]
02-14 18:15:17.171-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.samsung.worldclock], Appname[World Clock]
02-14 18:15:17.191-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[com.spotify.w-spotify], Appname[Spotify]
02-14 18:15:17.221-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.example.Running], Appname[Running]
02-14 18:15:17.241-0600 E/WMS     ( 2479): wms_package_manager.c: _wms_pkg_mgr_cb_watch_app_filter(1167) > PKG[org.tizen.tizenseckeystring], Appname[Tizen Keystring]
02-14 18:15:17.261-0600 E/AUL     ( 2555): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
02-14 18:15:17.261-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [128][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":0,"earjack":false}][0m
02-14 18:15:17.341-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
02-14 18:15:17.361-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:15:17.361-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [336][0;m
02-14 18:15:17.361-0600 W/SHealthService( 3446): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
02-14 18:15:17.361-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
02-14 18:15:17.361-0600 W/SHealthService( 3446): HostConnectController.cpp: FlushMessageWaitingList(309) > [1;40;33m[0] messages to send[0;m
02-14 18:15:17.361-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(328) > [33m[TID:3613]   volume = 0, earjack = 0[0m
02-14 18:15:17.371-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:15:17.371-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:15:17.371-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f370030000efc925317b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e73706f7274222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e73706f7274222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a203133352c20227479706522203a20224d455353414745222c2022626f647922203a202248347349414141414141414141367457554d704e4c53354f544539565572425355484b745343314b7a697a4f7a4575504479354a4c436b7456744a525543704c4c53724f7a4d38444b5441304d44425171415541426355534e7a55414141413d22207d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:15:17.371-0600 I/HealthDataService( 3008): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-14 18:15:17.371-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:15:17.371-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000070030000028ba5687b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e73706f7274222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e73706f7274222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a203133352c20227479706522203a20224d455353414745222c2022626f647922203a202248347349414141414141414141367457554d704e4c53354f544539565572425355484b745343314b7a697a4f7a4575504479354a4c436b7456744a525543704c4c53724f7a4d38444b5441304d44425171415541426355534e7a55414141413d22207d000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:15:17.381-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
02-14 18:15:17.381-0600 I/UXT     (22376): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
02-14 18:15:17.391-0600 I/APP_CORE( 2797): appcore-efl.c: __do_app(453) > [APP 2797] Event: MEM_FLUSH State: PAUSED
02-14 18:15:17.411-0600 I/CAPI_TELEPHONY( 2479): telephony_sim.c: telephony_sim_get_operator(170) > SIM operator: [310410]
02-14 18:15:17.411-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(289) > mccMnc : ____
02-14 18:15:17.491-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [64][{"msgId":"music-mediachanged-rsp","result":"success","reason":0}][0m
02-14 18:15:17.531-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [3347][{"msgId":"music-mediachanged-ind","audioId":"-1","playStatus":"false","image":"\/9j\/4AAQSkZJRgABAQAAAQABAAD\/2wBDABALDA4MChAODQ4SERATGCgaGBYWGDEjJR0oOjM9PDkzODdASFxOQERXRTc4UG1RV19iZ2hnPk1xeXBkeFxlZ2P\/2wBDARESEhgVGC8aGi9jQjhCY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2NjY2P\/wAARCAFAAUADASIAAhEBAxEB\/8QAGgABAAIDAQAAAAAAAAAAAAAAAAUGAQIEA\/\/EACQQAQACAQQCAwEBAQEAAAAAAAABAgMEBTEyEUESIVFCExUi\/8QAGgEBAAMBAQEAAAAAAAAAAAAAAAECBQMEBv\/EAB8RAQACAwEAAwEBAAAAAAAAAAABAgMEETISMUEhUf\/aAAwDAQACEQMRAD8A4QHJ9WAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB4Zisz6BgbxitPEPSulyW\/mRWbRDwHdTbstv5l049nyW5g45zmpH6iBO\/wDGmK+ZhxanR\/5eU8RXPS08hHja0eJaodwAAAAAAAAAAAAAAAAAAGYiZBgbxjtPEN66bJbisis2iHiO2m35bfzLox7Rkt6OKTmpH6ivDMVmfSe
02-14 18:15:17.541-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_MEDIA_CHANGED_IND][0m
02-14 18:15:17.601-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:15:17.601-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(269) > [33m[TID:3613]   title = , playing = 0[0m
02-14 18:15:17.631-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3613]   [MUSIC_PLAYER_EVENT][0m
02-14 18:15:17.731-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [44][{"msgId":"music-queuechanged-ind","count":0}9][0m
02-14 18:15:17.731-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_CHANGED_IND][0m
02-14 18:15:17.761-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:15:17.761-0600 D/UIB_APP (22375): Heart: 0.000000, 0.000000, 0.000000, 0.000000
02-14 18:15:17.811-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [81][{"msgId":"music-playstatechange-rsp","result":"success","reason":0,"playstate":2}][0m
02-14 18:15:17.811-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_PLAY_STATE_CHANGE_RESPONSE][0m
02-14 18:15:17.821-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:15:17.821-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(390) > [33m[TID:3613]   player state = 2[0m
02-14 18:15:17.831-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3613]   [MUSIC_PLAYER_EVENT][0m
02-14 18:15:17.841-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > telephony : 1
02-14 18:15:17.841-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(507) > wifi : 1
02-14 18:15:17.841-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(511) > scs : true
02-14 18:15:17.851-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(527) > svoice not disabled
02-14 18:15:17.851-0600 E/PKGMGR_INFO( 2479): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
02-14 18:15:17.851-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(546) > camera : 0
02-14 18:15:17.851-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(552) > gps : 1
02-14 18:15:17.861-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(558) > wps : 1
02-14 18:15:17.861-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(564) > speaker : 1
02-14 18:15:17.871-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(570) > width : 360
02-14 18:15:17.871-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(576) > height : 360
02-14 18:15:17.881-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(582) > barometer : 1
02-14 18:15:17.881-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(588) > magnetometer : 0
02-14 18:15:17.881-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(594) > photometer : 1
02-14 18:15:17.891-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(600) > heartrate : 1
02-14 18:15:17.891-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(606) > ultraviolet : 0
02-14 18:15:17.891-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [37][{"msgId":"music-queue-rsp","count":0}][0m
02-14 18:15:17.901-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(612) > irled : 0
02-14 18:15:17.911-0600 I/healthData( 3446): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-14 18:15:17.911-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_QUEUE_RSP][0m
02-14 18:15:17.921-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(629) > success get number : 13163050754
02-14 18:15:17.921-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(672) > esim phase : 0
02-14 18:15:17.931-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(689) > push : 1
02-14 18:15:17.931-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(700) > auto connection : true
02-14 18:15:17.951-0600 E/PKGMGR_INFO( 2479): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
02-14 18:15:17.951-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(773) > support hfp : 1
02-14 18:15:17.961-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:15:17.961-0600 E/WMS     ( 2479): ==========
02-14 18:15:17.961-0600 E/WMS     ( 2479): ##WMS SEND : mgr_wearable_status_res
02-14 18:15:17.961-0600 E/WMS     ( 2479): ==========
02-14 18:15:17.961-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 16517 MAX Buffer Size: 61440
02-14 18:15:17.961-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:15:17.961-0600 E/WMS     ( 2479): ==========
02-14 18:15:17.961-0600 E/WMS     ( 2479): ##WMS SEND : mgr_host_status_req
02-14 18:15:17.961-0600 E/WMS     ( 2479): ==========
02-14 18:15:17.961-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 52 MAX Buffer Size: 61440
02-14 18:15:17.961-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_wearable_status_req(16954) > handle_mgr_wearable_status_req completed
02-14 18:15:17.961-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24476) > [mgr_wearable_status_req] handler success.
02-14 18:15:17.971-0600 E/WMS     ( 2479): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
02-14 18:15:17.971-0600 E/WMS     ( 2479): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
02-14 18:15:17.981-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:15:18.011-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: __wmc_on_data_ind(381) > [33m length : [128][{"msgId":"music-getattribute-rsp","result":"failure","reason":0,"repeat":"repeatoff","shuffle":"off","volume":0,"earjack":false}][0m
02-14 18:15:18.011-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_GET_ATTRIBUTE_RESPONSE][0m
02-14 18:15:18.011-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:15:18.011-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(328) > [33m[TID:3613]   volume = 0, earjack = 0[0m
02-14 18:15:18.011-0600 W/AUL_AMD ( 2555): amd_request.c: __request_handler(669) > __request_handler: 14
02-14 18:15:18.021-0600 W/AUL_AMD ( 2555): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22375
02-14 18:15:18.021-0600 W/AUL_AMD ( 2555): amd_request.c: __request_handler(669) > __request_handler: 12
02-14 18:15:18.061-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 136[0;m
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:15:18.061-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:15:18.061-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:15:18.061-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f380030000efc92531865802ba4b77c01e9764dc34fa5cc5641c632f02c3d02ee18a4463fba823ad641b7d7c2ef31308435fa2df5ad88dbe95c5e60777f7cf62519a2328e1abded214e68ed494c4630a98ec7ba5914c24ca1371d2153cd761a9b19c7952be46a8c40b1f8db67148aa4b87e7f7223444360320d248a7b9973da47d52f59ef18002cc7340c1cc656ba69b454885616ec74c36f771f233372a28e1b8f4f74c48df39fbb9163ecef19b1c1741e6421ea81b4a38b05a28284587efc54a165790dd6c56a211b7fbb8391144e339d2eba91338d274e8b398a4e65154f57212e378c3e79f3552ea2a8f8842897c4a41d835fa9c8ab1efb4828832baaeb3e929a0fb4e7ab0c4b05508d31426e5a51fc07b1d1d8767e68646288642de7ff79cf0e1c4d621c2baa4c32b8bc624244dd300000075e055949987047f5389c9d7252c88732d08fc44f832d54b8b83de182524c5572f03f4bf81f0a059d4a6b32404a48f3c7fa99828d1e1568715964a09a0b3925e0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:15:18.061-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message)[0;m
02-14 18:15:18.061-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:15:18.061-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba568865802ba4b77c01e9764dc34fa5cc5641c632f02c3d02ee18a4463fba823ad641b7d7c2ef31308435fa2df5ad88dbe95c5e60777f7cf62519a2328e1abded214e68ed494c4630a98ec7ba5914c24ca1371d2153cd761a9b19c7952be46a8c40b1f8db67148aa4b87e7f7223444360320d248a7b9973da47d52f59ef18002cc7340c1cc656ba69b454885616ec74c36f771f233372a28e1b8f4f74c48df39fbb9163ecef19b1c1741e6421ea81b4a38b05a28284587efc54a165790dd6c56a211b7fbb8391144e339d2eba91338d274e8b398a4e65154f57212e378c3e79f3552ea2a8f8842897c4a41d835fa9c8ab1efb4828832baaeb3e929a0fb4e7ab0c4b05508d31426e5a51fc07b1d1d8767e68646288642de7ff79cf0e1c4d621c2baa4c32b8bc624244dd300000075e055949987047f5389c9d7252c88732d08fc44f832d54b8b83de182524c5572f03f4bf81f0a059d4a6b32404a48f3c7fa99828d1e1568715964a09a0b3925e0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (sender)[0;m
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:15:18.061-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:15:18.081-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24460) > 
02-14 18:15:18.081-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.081-0600 E/WMS     ( 2479): ##WMS RECEIVED : mgr_apps_order_req
02-14 18:15:18.081-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.081-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24476) > [mgr_apps_order_req] handler success.
02-14 18:15:18.091-0600 I/AUL_PAD (22376): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
02-14 18:15:18.091-0600 W/W_HOME  ( 2797): wms.c: wms_change_apps_order(59) > Backup
02-14 18:15:18.141-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24460) > 
02-14 18:15:18.141-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.141-0600 E/WMS     ( 2479): ##WMS RECEIVED : mgr_clocks_order_req
02-14 18:15:18.141-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.141-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24476) > [mgr_clocks_order_req] handler success.
02-14 18:15:18.161-0600 E/WMS     ( 2479): wms_event_handler.c: _wms_event_handler_cb_vconf_clocks_order(6752) > 
02-14 18:15:18.161-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:15:18.161-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.161-0600 E/WMS     ( 2479): ##WMS SEND : mgr_clocks_order_res
02-14 18:15:18.161-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.161-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 1078 MAX Buffer Size: 61440
02-14 18:15:18.171-0600 W/CLOCK-LIST( 2797): clocklist_main.c: __setting_clock_order_changed_vconf_cb(1654) > __setting_clock_order_changed_vconf_cb
02-14 18:15:18.181-0600 W/W_HOME  ( 2797): wms.c: wms_change_apps_order(72) > done
02-14 18:15:18.181-0600 E/WMS     ( 2479): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
02-14 18:15:18.191-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:15:18.191-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.191-0600 E/WMS     ( 2479): ##WMS SEND : mgr_apps_order_res
02-14 18:15:18.191-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.191-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 2918 MAX Buffer Size: 61440
02-14 18:15:18.201-0600 E/WMS     ( 2479): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
02-14 18:15:18.241-0600 E/MALI    (22376): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-14 18:15:18.251-0600 I/AUL_PAD (22476): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
02-14 18:15:18.331-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 279[0;m
02-14 18:15:18.331-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:15:18.331-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:15:18.331-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f380030000efc92531697db748958ad1b5cd9670d61baccb9ee69ada9905275c462aa63c2287fadfd14058fb3215cea5ed496e5d59cce33026e6b71f8a3534d6e6e22fc306247441f7e27e0f7bcdc2fc10f9520ea25f66a37a65286e1539b3f47badd46c96269eae1c96f7231fdcaa9f6a364635c3575c26cc50a8c65bb96565f53be0ee0f03bbcb7ca73025a473acc8f341f71b5a815d3e6010819e2fa2aa16c27021448ddd744971fd2ae8acea886cf2220f67dc1b127dc8c9b2dc8a44cf3438b07301fb766bed13f39df50c2b173015344cff6a2ee01a8b3ef639222f50d98d1ca77e8272a5aa8f1a8561a4e6991687ea32e3636cfba0773d80f0f87ad3b7a055efc883501c98abfaa7a902eb5f0801b8c5c5fb4ce0f160e950466d3ab575de460f1f95afb5b800410c918d22296ea280575ca2cb3dd978f27fb98ff3dab23958a3a44a3ac5077f439e7b5d99f5a075b4f046a7ab398b531bf1e5b5fa53026c222ad01f15c366d4000000d271bea9b7dbb954ead02a0b3baaa1e928a7544ffb580699024383dd7a4630d7b9aa64652c710e767f09d5ef2a18f15070987717b8e5276107f0b95530a9810b000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:15:18.331-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:15:18.331-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba568697db748958ad1b5cd9670d61baccb9ee69ada9905275c462aa63c2287fadfd14058fb3215cea5ed496e5d59cce33026e6b71f8a3534d6e6e22fc306247441f7e27e0f7bcdc2fc10f9520ea25f66a37a65286e1539b3f47badd46c96269eae1c96f7231fdcaa9f6a364635c3575c26cc50a8c65bb96565f53be0ee0f03bbcb7ca73025a473acc8f341f71b5a815d3e6010819e2fa2aa16c27021448ddd744971fd2ae8acea886cf2220f67dc1b127dc8c9b2dc8a44cf3438b07301fb766bed13f39df50c2b173015344cff6a2ee01a8b3ef639222f50d98d1ca77e8272a5aa8f1a8561a4e6991687ea32e3636cfba0773d80f0f87ad3b7a055efc883501c98abfaa7a902eb5f0801b8c5c5fb4ce0f160e950466d3ab575de460f1f95afb5b800410c918d22296ea280575ca2cb3dd978f27fb98ff3dab23958a3a44a3ac5077f439e7b5d99f5a075b4f046a7ab398b531bf1e5b5fa53026c222ad01f15c366d4000000d271bea9b7dbb954ead02a0b3baaa1e928a7544ffb580699024383dd7a4630d7b9aa64652c710e767f09d5ef2a18f15070987717b8e5276107f0b95530a9810b000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:15:18.331-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message)[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:15:18.331-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(170) > [1;40;33mGM Capability message[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 0.000000[0;m
02-14 18:15:18.331-0600 W/SHealthCommon( 3446): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 5410005.000000[0;m
02-14 18:15:18.341-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(disclaimer), check retry err: -21/(2/No such file or directory).
02-14 18:15:18.341-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(disclaimer) step(-17825744) failed(2 / No such file or directory)
02-14 18:15:18.341-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : disclaimer error
02-14 18:15:18.351-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(disclaimer), check retry err: -21/(2/No such file or directory).
02-14 18:15:18.351-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(disclaimer) step(-17825744) failed(2 / No such file or directory)
02-14 18:15:18.351-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : disclaimer error
02-14 18:15:18.351-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:18.351-0600 W/SHealthService( 3446): SAPCapabilityManager.cpp: FillWearableCapabilityInfoV4_51(573) > [1;40;33mMobile SHealth version[-147948424], GM SHealth version[1073741824].[0;m
02-14 18:15:18.371-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:18.441-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:15:18.441-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:15:18.441-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f38003000063e93a464499f76f3bc8e0ad15e637567762732a7f1d72fb81d8bfc4e4506bc0bdb2e69262e9d058a4fb786295e029267e75546b4282fb0f4e5afba5ae1dc9779fd7c0f3ea5d8c7c0993160481d991a5f2fa0def89281b4104783c8e637ac185811ecb2f751bde8fa5ac964f2116aa263cef84fe543251bbb426b3d24b91153dcf3acde44b0a3437a372e57789e19d8d12a01146a7fe9779cb878d291b40284ca57f8183dcec515b07a6b4e8e0d627eef3a7ae31038bbedcad31e99f1b8379775e011daa7587d1fa7f033536d25041c7b9f43311c6ea55d3a5e073ba0b2ba03a7629739f143f18436c6cc92491d6cfcc780539f0b01d7aba4547b572ba60148c08f53917e234bd55c9a90ddbee1ec4b46d4fc5517f1001ce0de2c6298944e66b563c67f4ca8facf3271f0788bd763c3151e9eef2413f8d45df160273afc61556df0642707183ffaa3a1cc4aed00a971058735da23c7028f55611c6f4c6244e12439ca74cc315346f41fdd320684835bb09afdcec6db8ba501f97bb3c420eca7c97ad39b09025ccd1cd3912bb116567c3be64a9a02a25316026e703ff93b00fda61a9ebd5f6a2b73f1d73a47a0f6001aa1b84f027fc6e5aa6896227a79251288c72d8a8c1565ab7a955de166fedc6d3d6db3590301d59e4610ad76288fd494f78e33d97
02-14 18:15:18.441-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:15:18.441-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 01000000800300003d8471674499f76f3bc8e0ad15e637567762732a7f1d72fb81d8bfc4e4506bc0bdb2e69262e9d058a4fb786295e029267e75546b4282fb0f4e5afba5ae1dc9779fd7c0f3ea5d8c7c0993160481d991a5f2fa0def89281b4104783c8e637ac185811ecb2f751bde8fa5ac964f2116aa263cef84fe543251bbb426b3d24b91153dcf3acde44b0a3437a372e57789e19d8d12a01146a7fe9779cb878d291b40284ca57f8183dcec515b07a6b4e8e0d627eef3a7ae31038bbedcad31e99f1b8379775e011daa7587d1fa7f033536d25041c7b9f43311c6ea55d3a5e073ba0b2ba03a7629739f143f18436c6cc92491d6cfcc780539f0b01d7aba4547b572ba60148c08f53917e234bd55c9a90ddbee1ec4b46d4fc5517f1001ce0de2c6298944e66b563c67f4ca8facf3271f0788bd763c3151e9eef2413f8d45df160273afc61556df0642707183ffaa3a1cc4aed00a971058735da23c7028f55611c6f4c6244e12439ca74cc315346f41fdd320684835bb09afdcec6db8ba501f97bb3c420eca7c97ad39b09025ccd1cd3912bb116567c3be64a9a02a25316026e703ff93b00fda61a9ebd5f6a2b73f1d73a47a0f6001aa1b84f027fc6e5aa6896227a79251288c72d8a8c1565ab7a955de166fedc6d3d6db3590301d59e4610ad76288fd494f78e33d97176
02-14 18:15:18.451-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24460) > 
02-14 18:15:18.451-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.451-0600 E/WMS     ( 2479): ##WMS RECEIVED : mgr_host_status_res
02-14 18:15:18.451-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.451-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17075) > type : sync
02-14 18:15:18.451-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17078) > preinstalled: true
02-14 18:15:18.451-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:15:18.451-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.451-0600 E/WMS     ( 2479): ##WMS SEND : mgr_status_exchange_done
02-14 18:15:18.451-0600 E/WMS     ( 2479): ==========
02-14 18:15:18.451-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 73 MAX Buffer Size: 61440
02-14 18:15:18.451-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_get_device_status(873) > Host device vendor: ZTE
02-14 18:15:18.461-0600 E/wnoti-service( 3108): wnoti-sap-client.c: _get_vendor_cb(3568) > vendor : ZTE, vendor_type : 1
02-14 18:15:18.461-0600 W/APP_SHORTCUT_WIDGET( 2920): main.c: _vendor_changed_cb(441) >  vendor : ZTE
02-14 18:15:18.471-0600 E/EFL     (22375): ecore_x<22375> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=78478013 button=1
02-14 18:15:18.481-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_get_device_status(888) > host mcc [310], mnc [410]
02-14 18:15:18.481-0600 E/WMS     ( 2479): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
02-14 18:15:18.491-0600 E/WMS     ( 2479): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
02-14 18:15:18.491-0600 I/W_INDICATOR( 2713): windicator.c: windicator_is_lo_connected(945) > [windicator_is_lo_connected:945] Connected target vendor : ZTE
02-14 18:15:18.491-0600 W/W_INDICATOR( 2713): windicator.c: _windicator_lo_cb(500) > [_windicator_lo_cb:500] LO is NOT Connected, so change layout to default layout (Show all button)
02-14 18:15:18.491-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:18.491-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_sync_host_status(1247) > host platform version: 7.0
02-14 18:15:18.491-0600 I/capability-manager(22380): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
02-14 18:15:18.491-0600 I/capability-manager(22380): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
02-14 18:15:18.501-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_sync_host_status(1435) > Host telephony feature is supported - enable call app
02-14 18:15:18.501-0600 W/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_wms_host_status_vendor_changed_cb(329) > vendor: ZTE.
02-14 18:15:18.501-0600 I/wnotib  ( 2797): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(59) > type: 24
02-14 18:15:18.501-0600 I/wnotib  ( 2797): w-notification-board-empty-panel.c: _wnb_ep_set_texts(345) > is_connected_vendor_LO: 0, is_standalone_mode: 0
02-14 18:15:18.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
02-14 18:15:18.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-14 18:15:18.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
02-14 18:15:18.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
02-14 18:15:18.521-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:18.521-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_sync_host_status(1487) > vendor[ ZTE ], support.email.sync[ false ]
02-14 18:15:18.521-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): clock_indicator.c: clock_indicator_pop(364) > icon:3(0) is popped from clock indicator
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): cfwd.c: cfwd_get_icon_status(362) > 
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): ============================
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): multi_sim_category:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): multi_sim_model:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): support_callforward_auto:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): conn_status:1
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): remote_call_forward_auto:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): auto_call_forward_status:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): support_callforward_reverse:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): reverse_call_forward_auto:0
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): fwd_type:ARS
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): ============================
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): 
02-14 18:15:18.561-0600 W/W_HOME  ( 2797): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
02-14 18:15:18.641-0600 E/EFL     (22375): ecore_x<22375> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=78478179 button=1
02-14 18:15:18.651-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:18.671-0600 E/PKGMGR_SERVER(22486): pkgmgr-server.c: main(2227) > package manager server start
02-14 18:15:18.691-0600 D/UIB_APP (22375): Getting oauth token
02-14 18:15:18.691-0600 D/UIB_APP (22375): the 1
02-14 18:15:18.691-0600 D/UIB_APP (22375): the 2
02-14 18:15:18.691-0600 D/UIB_APP (22375): the 3
02-14 18:15:18.771-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
02-14 18:15:18.771-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[com.samsung.wemail] start
02-14 18:15:18.771-0600 E/PKGMGR_SERVER(22487): pkgmgr-server.c: queue_job(1966) > ENABLE_PKG start, pkgid=[com.samsung.call]
02-14 18:15:18.791-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
02-14 18:15:18.851-0600 I/CAPI_TELEPHONY( 2479): telephony_sim.c: telephony_sim_get_operator(170) > SIM operator: [310410]
02-14 18:15:18.851-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(289) > mccMnc : ____
02-14 18:15:18.941-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:18.941-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:15:19.081-0600 E/PKGMGR_STATE(22487): pkg_state.c: __pkg_state_enable_pkg(339) > start enable_pkg : pkgid = com.samsung.call
02-14 18:15:19.141-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 22375 pgid = 22375
02-14 18:15:19.141-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-14 18:15:19.141-0600 E/PKGMGR_SERVER(22488): pkgmgr-server.c: queue_job(1975) > DISABLE_PKG start, pkgid=[com.samsung.wemail]
02-14 18:15:19.191-0600 E/PKGMGR_STATE(22487): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.call] is decided not to broadcast.
02-14 18:15:19.191-0600 E/PKGMGR_STATE(22487): pkg_state.c: __pkg_state_enable_pkg(350) > nothing to broadcast.
02-14 18:15:19.221-0600 W/STARTER ( 2711): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2797] goes to (3)
02-14 18:15:19.221-0600 E/STARTER ( 2711): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2797)'s state(3)
02-14 18:15:19.221-0600 W/AUL_AMD ( 2555): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-14 18:15:19.221-0600 W/AUL_AMD ( 2555): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-14 18:15:19.221-0600 W/AUL     ( 2555): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2797) status(fg) type(uiapp)
02-14 18:15:19.241-0600 E/PKGMGR_SERVER(22486): pkgmgr-server.c: sighandler(486) > child NORMAL exit [22487]
02-14 18:15:19.321-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-14 18:15:19.331-0600 I/AUL_AMD ( 2555): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22375
02-14 18:15:19.331-0600 W/AUL     ( 2555): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22375)
02-14 18:15:19.341-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-14 18:15:19.361-0600 W/WATCH_CORE( 2884): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-14 18:15:19.361-0600 I/WATCH_CORE( 2884): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _window_visibility_cb(473) > Window [0x2200003] is now visible(0)
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): main.c: _window_visibility_cb(963) > Window [0x2200003] is now visible(0)
02-14 18:15:19.391-0600 I/APP_CORE( 2797): appcore-efl.c: __do_app(453) > [APP 2797] Event: RESUME State: PAUSED
02-14 18:15:19.391-0600 I/CAPI_APPFW_APPLICATION( 2797): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): main.c: _appcore_resume_cb(478) > appcore resume
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-14 18:15:19.391-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.401-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.401-0600 W/W_HOME  ( 2797): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-14 18:15:19.401-0600 W/W_HOME  ( 2797): main.c: home_resume(530) > clock/widget resumed
02-14 18:15:19.401-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:15:19.401-0600 I/GATE    ( 2797): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-14 18:15:19.401-0600 I/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-14 18:15:19.401-0600 E/wnotib  ( 2797): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-14 18:15:19.401-0600 W/wnotib  ( 2797): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
02-14 18:15:19.411-0600 W/WATCH_CORE( 2884): appcore-watch.c: __widget_resume(1124) > widget_resume
02-14 18:15:19.411-0600 W/AUL     ( 2884): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2884) status(fg) type(watchapp)
02-14 18:15:19.421-0600 I/CAPI_WATCH_APPLICATION( 2884): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-14 18:15:19.461-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:15:19.471-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:15:19.471-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:15:19.471-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:15:19.481-0600 W/CRASH_MANAGER(22490): worker.c: worker_job(1199) > 112237572756e148711771
