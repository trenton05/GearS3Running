S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: runner
PID: 21995
Date: 2017-02-14 18:12:29-0600
Executable File Path: /opt/usr/apps/org.example.Running/bin/runner
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21995, uid 5000)

Register Information
r0   = 0x04b082b5, r1   = 0x04b082b4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffd55908
r6   = 0xf5c8804e, r7   = 0x04b082b5
r8   = 0x0000006e, r9   = 0x00000000
r10  = 0xf5c88011, fp   = 0xffd558fc
ip   = 0xffd55a2c, sp   = 0xffd55390
lr   = 0xf6debe8c, pc   = 0xf6e210b4
cpsr = 0x60000010

Memory Information
MemTotal:   620364 KB
MemFree:     27508 KB
Buffers:      4464 KB
Cached:      94356 KB
VmPeak:     131952 KB
VmSize:     131948 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31044 KB
VmRSS:       31040 KB
VmData:      47740 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43944 KB
VmPTE:         152 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 21995 TID = 21995
21995 22071 22078 22079 22080 

Maps Information
ef6c3000 ef6ce000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
ef6d6000 ef6d8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
ef6e0000 ef6e1000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
ef806000 ef80e000 r-xp /usr/lib/libfeedback.so.0.1.4
ef891000 f0090000 rw-p [stack:22080]
f0091000 f0890000 rw-p [stack:22079]
f0891000 f1090000 rw-p [stack:22078]
f1091000 f1890000 rw-p [stack:22071]
f18a5000 f18a7000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f18af000 f18b3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f18be000 f18bf000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f18c7000 f18ca000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f18d2000 f18d6000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f22c6000 f22c8000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f22d0000 f22e7000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f22f4000 f22f9000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f2301000 f230c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f2634000 f2726000 r-xp /usr/lib/libCOREGL.so.4.0
f273f000 f2743000 r-xp /usr/lib/libogg.so.0.7.1
f274b000 f276d000 r-xp /usr/lib/libvorbis.so.0.4.3
f2775000 f277a000 r-xp /usr/lib/libsystem.so.0.0.0
f2784000 f278a000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f2792000 f27a1000 r-xp /usr/lib/libmdm-common.so.1.1.22
f27aa000 f27f1000 r-xp /usr/lib/libsndfile.so.1.0.26
f27fd000 f2846000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f284f000 f2854000 r-xp /usr/lib/libjson.so.0.0.1
f285c000 f285f000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2867000 f286d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f2875000 f2880000 r-xp /usr/lib/libresourced.so.0.2.96
f2888000 f2889000 r-xp /usr/lib/librd-network.so.0.2.96
f2891000 f2892000 r-xp /usr/lib/libresponse.so.0.2.96
f289a000 f289f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f28a8000 f28af000 r-xp /usr/lib/libminizip.so.1.0.0
f28b7000 f28b9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f28c1000 f28c8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f28d1000 f28d6000 r-xp /usr/lib/libstorage.so.0.1
f28de000 f28e3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f28eb000 f28ed000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f28f5000 f2916000 r-xp /usr/lib/libexif.so.12.3.3
f2929000 f2942000 r-xp /usr/lib/libnetwork.so.0.0.0
f294a000 f2950000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f2959000 f29a1000 r-xp /usr/lib/libmdm.so.1.2.62
f29a2000 f29af000 r-xp /usr/lib/libail.so.0.1.0
f29b8000 f29bb000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f29c3000 f29fb000 r-xp /usr/lib/libpulse.so.0.16.2
f29fc000 f29ff000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2a07000 f2a68000 r-xp /usr/lib/libasound.so.2.0.0
f2a72000 f2a8c000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2a94000 f2a9b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2aa3000 f2aa7000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2aaf000 f2ab3000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2abc000 f2abe000 r-xp /usr/lib/libttrace.so.1.1
f435e000 f435f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4368000 f436b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f4373000 f4395000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f439e000 f43a3000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f43ab000 f43fb000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f4401000 f440a000 r-xp /usr/lib/libcom-core.so.0.0.1
f4413000 f441d000 r-xp /usr/lib/libspdy.so.0.0.0
f4426000 f442c000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4434000 f4435000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f443e000 f444d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f4456000 f4460000 r-xp /usr/lib/libsensord-shared.so
f4468000 f4478000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f4480000 f4499000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f44a1000 f44b7000 r-xp /usr/lib/libtts.so
f44c0000 f44cb000 r-xp /usr/lib/libtbm.so.1.0.0
f44d3000 f44ec000 r-xp /usr/lib/libstt.so
f44f4000 f450b000 r-xp /usr/lib/libmmfsound.so.0.1.0
f451d000 f4522000 r-xp /usr/lib/libmemenv.so.1.1.0
f452a000 f4566000 r-xp /usr/lib/libleveldb.so.1.1.0
f456f000 f457c000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f4585000 f4587000 r-xp /usr/lib/libdri2.so.0.0.0
f458f000 f459a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f45a7000 f45ae000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f45b6000 f45df000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f45e8000 f45ec000 r-xp /usr/lib/libEGL.so.1.4
f45fc000 f460d000 r-xp /usr/lib/libGLESv2.so.2.0
f461d000 f462b000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f4634000 f464c000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f4655000 f465e000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f4666000 f46a7000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f46b0000 f474b000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f4757000 f475f000 r-xp /usr/lib/libdrm.so.2.4.0
f4767000 f486d000 r-xp /usr/lib/libicuuc.so.57.1
f4883000 f4a0b000 r-xp /usr/lib/libicui18n.so.57.1
f4a1b000 f4a3e000 r-xp /usr/lib/libui-extension.so.0.1.0
f4a47000 f4a59000 r-xp /usr/lib/libefl-assist.so.0.1.0
f4a61000 f4a69000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4a71000 f4a83000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f4a8b000 f4a8e000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4a96000 f4aa9000 r-xp /usr/lib/libwidget_service.so.1.0.0
f4ab2000 f4afe000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4b08000 f4b09000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4b11000 f4bc9000 r-xp /usr/lib/libcairo.so.2.11200.14
f4bd4000 f4bd9000 r-xp /usr/lib/libctx-client.so.0.8.3
f4be1000 f4be8000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4bf0000 f4c1a000 r-xp /usr/lib/libsensor.so.1.9.3
f4c23000 f4c5d000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4c66000 f5b2a000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5c10000 f5c31000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c39000 f5c45000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5c4e000 f5c53000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5c5b000 f5c60000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5c68000 f5c76000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5c7f000 f5c89000 r-xp /opt/usr/apps/org.example.Running/bin/runner
f5e2c000 f5e36000 r-xp /lib/libnss_files-2.13.so
f5e3f000 f5f0e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5f24000 f5f48000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5f51000 f5f57000 r-xp /usr/lib/libappsvc.so.0.1.0
f5f5f000 f5f63000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5f70000 f5f7b000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5f83000 f5f85000 r-xp /usr/lib/libiniparser.so.0
f5f8e000 f5f93000 r-xp /usr/lib/libappcore-common.so.1.1
f5f9b000 f5f9d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5fa6000 f5faa000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5fb7000 f5fb9000 r-xp /usr/lib/libXau.so.6.0.0
f5fc1000 f5fc8000 r-xp /lib/libcrypt-2.13.so
f5ff8000 f5ffa000 r-xp /usr/lib/libiri.so
f6003000 f61ac000 r-xp /usr/lib/libcrypto.so.1.0.0
f61cc000 f6213000 r-xp /usr/lib/libssl.so.1.0.0
f621f000 f624d000 r-xp /usr/lib/libidn.so.11.5.44
f6255000 f625e000 r-xp /usr/lib/libcares.so.2.1.0
f6268000 f627b000 r-xp /usr/lib/libxcb.so.1.1.0
f6284000 f6287000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f628f000 f6291000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f629a000 f6366000 r-xp /usr/lib/libxml2.so.2.7.8
f6373000 f6375000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f637e000 f6383000 r-xp /usr/lib/libffi.so.5.0.10
f638b000 f638c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6394000 f6397000 r-xp /lib/libattr.so.1.1.0
f639f000 f6433000 r-xp /usr/lib/libstdc++.so.6.0.16
f6446000 f6463000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f646d000 f6485000 r-xp /usr/lib/libpng12.so.0.50.0
f648d000 f64a3000 r-xp /lib/libexpat.so.1.6.0
f64ad000 f64f1000 r-xp /usr/lib/libcurl.so.4.3.0
f64fa000 f6504000 r-xp /usr/lib/libXext.so.6.4.0
f650d000 f6511000 r-xp /usr/lib/libXtst.so.6.1.0
f6519000 f651f000 r-xp /usr/lib/libXrender.so.1.3.0
f6527000 f652d000 r-xp /usr/lib/libXrandr.so.2.2.0
f6535000 f6536000 r-xp /usr/lib/libXinerama.so.1.0.0
f653f000 f6548000 r-xp /usr/lib/libXi.so.6.1.0
f6550000 f6553000 r-xp /usr/lib/libXfixes.so.3.1.0
f655b000 f655d000 r-xp /usr/lib/libXgesture.so.7.0.0
f6565000 f6567000 r-xp /usr/lib/libXcomposite.so.1.0.0
f656f000 f6571000 r-xp /usr/lib/libXdamage.so.1.1.0
f6579000 f6580000 r-xp /usr/lib/libXcursor.so.1.0.2
f6588000 f658b000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6593000 f6597000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f65a0000 f65a5000 r-xp /usr/lib/libecore_fb.so.1.7.99
f65ae000 f668f000 r-xp /usr/lib/libX11.so.6.3.0
f669a000 f66bd000 r-xp /usr/lib/libjpeg.so.8.0.2
f66d5000 f66eb000 r-xp /lib/libz.so.1.2.5
f66f3000 f66f5000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66fd000 f6772000 r-xp /usr/lib/libsqlite3.so.0.8.6
f677c000 f6796000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f679e000 f67d2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f67db000 f68ae000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68b9000 f68c9000 r-xp /lib/libresolv-2.13.so
f68cd000 f68e5000 r-xp /usr/lib/liblzma.so.5.0.3
f68ed000 f68f0000 r-xp /lib/libcap.so.2.21
f68f8000 f6927000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f692f000 f6930000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6938000 f693e000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6946000 f695d000 r-xp /usr/lib/liblua-5.1.so
f6966000 f696d000 r-xp /usr/lib/libembryo.so.1.7.99
f6975000 f697b000 r-xp /lib/librt-2.13.so
f6984000 f69da000 r-xp /usr/lib/libpixman-1.so.0.28.2
f69e7000 f6a3d000 r-xp /usr/lib/libfreetype.so.6.11.3
f6a49000 f6a71000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a72000 f6ab7000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6ac0000 f6ad3000 r-xp /usr/lib/libfribidi.so.0.3.1
f6adb000 f6af5000 r-xp /usr/lib/libecore_con.so.1.7.99
f6afe000 f6b07000 r-xp /usr/lib/libedbus.so.1.7.99
f6b0f000 f6b5f000 r-xp /usr/lib/libecore_x.so.1.7.99
f6b61000 f6b6a000 r-xp /usr/lib/libvconf.so.0.2.45
f6b72000 f6b83000 r-xp /usr/lib/libecore_input.so.1.7.99
f6b8b000 f6b90000 r-xp /usr/lib/libecore_file.so.1.7.99
f6b98000 f6bba000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6bc3000 f6c04000 r-xp /usr/lib/libeina.so.1.7.99
f6c0d000 f6c26000 r-xp /usr/lib/libeet.so.1.7.99
f6c37000 f6ca0000 r-xp /lib/libm-2.13.so
f6ca9000 f6caf000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cb8000 f6cb9000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6cc1000 f6ce4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cec000 f6cf1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cf9000 f6d23000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d2c000 f6d43000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d4b000 f6d56000 r-xp /lib/libunwind.so.8.0.1
f6d83000 f6da1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dab000 f6ecf000 r-xp /lib/libc-2.13.so
f6edd000 f6ee5000 r-xp /lib/libgcc_s-4.6.so.1
f6ee6000 f6eea000 r-xp /usr/lib/libsmack.so.1.0.0
f6ef3000 f6ef9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6f01000 f6fd1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fd2000 f7030000 r-xp /usr/lib/libedje.so.1.7.99
f703a000 f7051000 r-xp /usr/lib/libecore.so.1.7.99
f7068000 f7136000 r-xp /usr/lib/libevas.so.1.7.99
f715b000 f7297000 r-xp /usr/lib/libelementary.so.1.7.99
f72ae000 f72c2000 r-xp /lib/libpthread-2.13.so
f72cd000 f72cf000 r-xp /usr/lib/libdlog.so.0.0.0
f72d7000 f72da000 r-xp /usr/lib/libbundle.so.0.1.22
f72e2000 f72e4000 r-xp /lib/libdl-2.13.so
f72ed000 f72fa000 r-xp /usr/lib/libaul.so.0.1.0
f730c000 f7312000 r-xp /usr/lib/libappcore-efl.so.1.1
f731b000 f731f000 r-xp /usr/lib/libsys-assert.so
f7328000 f7345000 r-xp /lib/ld-2.13.so
f734e000 f7353000 r-xp /usr/bin/launchpad-loader
f78ba000 f7b01000 rw-p [heap]
ffd36000 ffd57000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21995)
Call Stack Count: 1
 0: strlen + 0x4 (0xf6e210b4) [/lib/libc.so.6] + 0x760b4
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
HealthService( 3446): SAPV45MessageBuilder.cpp: MakePedoEventJsonArray(885) > [1;40;33mpedo event is empty[0;m
02-14 18:12:27.641-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(325) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA ][ device : Gear S3, device_type : 10038, version : 4.510000, start_time : 1487117322528, end_time : 1487117546202, last_sync_time : 1487117547600, is_last_chunk : 1, reset_time : 1486533600000 ] [size: 2647][0;m
02-14 18:12:27.651-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:12:27.651-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [1144][0;m
02-14 18:12:27.661-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:12:27.661-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:12:27.661-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] 083659f770030000efc9253178da8d9349afab561084ffca95b78e0c186c43a4b7009bc1183093993611700e98f1304f51fe7b7cdf53a42cb2482dabab3f552ffacfaf5d05fb3e4ce1eeebf7af9dc91b2fdeb277bf7ded7a5803d8fd7463541dfab0eac73a3d0cd906eb1486dd216c9a43ff866139bc0ff3c708a3121efab58eabb0fef0ba6f480763984dff81096bd0a10cfc2fc867bfcf50fdcd381d709cf9b7e8cf1cc0298b7ff527709ca47fb56f4758c7f08f7aacbe270479fcb8c3dafccadd589bfd8e4508ac3f0d89eaefec3f3a1dddd93de72a7715bdd92b49de13b521c79dda2d7548c0633fb66dc32ac591156e8aace155ee0082be20870c59b5ce8cd5a031264d30da8035ba637388449f3644b5adddcd6aa95b70a11b351b22d9c4bc1b4963b59b24117399845e886861a3a528a766af0f74aa3c6d26b9e90567a4b11e48de86224b62ded983bf2ab10d19b6222949ec7d241954a21101aa8832a82f771410127f55fd8529056301c0b7b9a7dadf07671e725512cc7d57b1b251506fdbf35f27d7ad87f29402038c1e7a7236d957aac58f8b4f72ed1e6892d998157e1ae6b7cc07f138abe7ebe6e4a073631e7b5286e3595041ab8824861193a9e126673c7195f09e396eb1f3eaadf3942dec2fa19f9de977ac2ddaeac4e48d88a0e205766983d66a75b1b1
02-14 18:12:27.661-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [1144][0;m
02-14 18:12:27.661-0600 W/SHealthService( 3446): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
02-14 18:12:27.661-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
02-14 18:12:27.661-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:12:27.661-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:12:27.661-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000070030000028ba56878da8d9349afab561084ffca95b78e0c186c43a4b7009bc1183093993611700e98f1304f51fe7b7cdf53a42cb2482dabab3f552ffacfaf5d05fb3e4ce1eeebf7af9dc91b2fdeb277bf7ded7a5803d8fd7463541dfab0eac73a3d0cd906eb1486dd216c9a43ff866139bc0ff3c708a3121efab58eabb0fef0ba6f480763984dff81096bd0a10cfc2fc867bfcf50fdcd381d709cf9b7e8cf1cc0298b7ff527709ca47fb56f4758c7f08f7aacbe270479fcb8c3dafccadd589bfd8e4508ac3f0d89eaefec3f3a1dddd93de72a7715bdd92b49de13b521c79dda2d7548c0633fb66dc32ac591156e8aace155ee0082be20870c59b5ce8cd5a031264d30da8035ba637388449f3644b5adddcd6aa95b70a11b351b22d9c4bc1b4963b59b24117399845e886861a3a528a766af0f74aa3c6d26b9e90567a4b11e48de86224b62ded983bf2ab10d19b6222949ec7d241954a21101aa8832a82f771410127f55fd8529056301c0b7b9a7dadf07671e725512cc7d57b1b251506fdbf35f27d7ad87f29402038c1e7a7236d957aac58f8b4f72ed1e6892d998157e1ae6b7cc07f138abe7ebe6e4a073631e7b5286e3595041ab8824861193a9e126673c7195f09e396eb1f3eaadf3942dec2fa19f9de977ac2ddaeac4e48d88a0e205766983d66a75b1b1897
02-14 18:12:27.661-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncStart(281) > [1;35mRelease cpu lock[0;m
02-14 18:12:27.671-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:12:27.731-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.731-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.731-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.731-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.741-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.751-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.751-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.751-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.761-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.771-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.771-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.771-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.781-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.781-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.781-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.781-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.791-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.801-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.801-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.801-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.811-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.811-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.811-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.811-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.821-0600 D/UIB_APP (21995): Heart: 0.000000, 0.000000, 0.000000, 0.000000
02-14 18:12:27.821-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.831-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.831-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.831-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.841-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.851-0600 I/AUL     (21994): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:27.851-0600 E/AUL     (21994): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:27.851-0600 E/AUL     (21994): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:27.861-0600 I/UXT     (21994): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
02-14 18:12:27.911-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:12:27.911-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:12:27.911-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] 083659f780030000efc925311a63cf03dae260f833fd56c37b55a4ba3cbfcaba562fee5ab0123a46a7d01c6c22efb100d2ecba673a9bfbd3481428c0924d8f5d0197feb0e5325143d4828db600c288a0281f43f9458d9d89380d2344bc3cffb30da4f2b8494aad72eb3a79f0521e3f9ddc8366a98b52464026748fa446bf5ad6f98afedde2eb1bec32345321163cdb1ce898659cadfce551838724c749e31516370ef3b5648c08539783bac6614a1f3c6af54a9b86e0dc54ac366ee8152c3d7dbb63c3a19bccebf402ea8961e791d1f7c6fc4f9ee9251aec88100003343ab75346582bf09ee392b8fa6d0a1bc14ceaf20085db04a6a61cc323fc8519367eb7bc2d499c974e22b35d5fb1cb68928ab9c61fd5a1c59f00ff848c0a88b43b7e570cbe6b7bf469a7410cb31d7d2e3d0d4226aaf7dcc70fc624193dc3db125325afb362e6fc5c166d057a74ce3dba5854b9375634a9525ce1ce687f008daa53695df967be2a0824f92d6396b51ac60a022be2940f6b4eb21758de2fe46d7e00c3a89a55aeabfe68cc8c492aa3d56923e07cebe6489af4a1294006f8b60b1533c33d3796d1e2ee29609828194f3a6355a3245e7cf9c6399c8ba84b40c6a744f5f7f2480c526ed88a2bf624f35e2a67f3c1fcb1a2cf00000093b83dee4bc0c1cbddbd796e185d7ba3baba734ddcc3
02-14 18:12:27.911-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:12:27.911-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba5681a63cf03dae260f833fd56c37b55a4ba3cbfcaba562fee5ab0123a46a7d01c6c22efb100d2ecba673a9bfbd3481428c0924d8f5d0197feb0e5325143d4828db600c288a0281f43f9458d9d89380d2344bc3cffb30da4f2b8494aad72eb3a79f0521e3f9ddc8366a98b52464026748fa446bf5ad6f98afedde2eb1bec32345321163cdb1ce898659cadfce551838724c749e31516370ef3b5648c08539783bac6614a1f3c6af54a9b86e0dc54ac366ee8152c3d7dbb63c3a19bccebf402ea8961e791d1f7c6fc4f9ee9251aec88100003343ab75346582bf09ee392b8fa6d0a1bc14ceaf20085db04a6a61cc323fc8519367eb7bc2d499c974e22b35d5fb1cb68928ab9c61fd5a1c59f00ff848c0a88b43b7e570cbe6b7bf469a7410cb31d7d2e3d0d4226aaf7dcc70fc624193dc3db125325afb362e6fc5c166d057a74ce3dba5854b9375634a9525ce1ce687f008daa53695df967be2a0824f92d6396b51ac60a022be2940f6b4eb21758de2fe46d7e00c3a89a55aeabfe68cc8c492aa3d56923e07cebe6489af4a1294006f8b60b1533c33d3796d1e2ee29609828194f3a6355a3245e7cf9c6399c8ba84b40c6a744f5f7f2480c526ed88a2bf624f35e2a67f3c1fcb1a2cf00000093b83dee4bc0c1cbddbd796e185d7ba3baba734ddcc36e9
02-14 18:12:27.931-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 437[0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
02-14 18:12:27.931-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1487117324611,  ] [size: 166][0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
02-14 18:12:27.931-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(493) > [1;40;33mresponse : SUCCESS[0;m
02-14 18:12:27.951-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:12:27.961-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:12:27.961-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakeRequestDataRequestMsg(512) > [1;40;33mGEAR_SYNC_MSG [ action : REQUEST_DATA ][ device : Gear S3, device_type : 10038, version : 4.510000, last_sync_time : 1487117547947, reset_time : 1486533600000 ][0;m
02-14 18:12:27.961-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:12:27.961-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [496][0;m
02-14 18:12:27.971-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [496][0;m
02-14 18:12:27.971-0600 W/SHealthService( 3446): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
02-14 18:12:27.971-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:12:27.971-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:12:27.971-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] 083659f770030000efc925317b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a203133332c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f775171444d4242456632584a57556f6b305768765171586e566e7353436346754a5643314a45475134722f5861436e53756532384758597165415070304672566f74543959794277684d7162716e46363650314a72766e6c6c68656c5047566c526d434747756241522b343436756176746e6c7237597a4b514d464938457536366257696b464b574c506149786e366638454e453037303866797272704a3336526a7264625532656944415545526370463076436f455733703348455745793974714651667743
02-14 18:12:27.971-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
02-14 18:12:27.971-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:12:27.971-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000070030000028ba5687b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a203133332c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f775171444d4242456632584a57556f6b305768765171586e566e7353436346754a5643314a45475134722f5861436e53756532384758597165415070304672566f74543959794277684d7162716e46363650314a72766e6c6c68656c5047566c526d434747756241522b343436756176746e6c7237597a4b514d464938457536366257696b464b574c506149786e366638454e453037303866797272704a3336526a7264625532656944415545526370463076436f4557337033484557457939747146516677432b3
02-14 18:12:27.971-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:12:28.001-0600 E/MALI    (21994): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(232) >  GL-state 'gl_vertex_attrib_value_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[3] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[7] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[11] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[15] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[19] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[23] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[27] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[31] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[35] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[39] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[43] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[47] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[51] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[55] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[59] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_state.h: fastpath_init_context_states(235) >  GL-state 'gl_vertex_attrib_value_unsigned_integer'[63] value [1065353216] is different from SPEC-DEFAULT [         1]
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath.c: fastpath_init_context_states(1463) >  [40;31;1mNumber of uniform buffer binding is too big! (64-72)[0m
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:28.011-0600 W/CoreGL  (21994): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:28.171-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:12:28.171-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:12:28.171-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] 083659f780030000efc9253179e202ec5c8a4079ab564124adff56c67e6941cf2ca657be5a669d82f4712d39b7ae1ce65136ce59ec35cfc42fc05ab268fc7cca996ced2724e099408d843e178f5e1e2c983a6ae208be6a3a0c0ec00ab99c24554ca08fb5048b0a0651da9c036748c1c027308cb78c4e4dda74ed4cf0f2119b29ee525d2801ecc172c4b69880524d507abc4058ac4fa310091a1634359554625f366d01e79607ae900bb212c28e72c33fe57367a6a93d928226a18d752300387bf7437d53c4fa07229ce59d43f27a70d632b0ef1b17fe232df6090c11f0065be3c3ba878ce5d236c2c3c1ecfa226d52a899c65105b47734733c77ee38bdfea8b851ab492bee51c9430f76176b92bea8ad6c615cac5774e609d79798291deb4312d01ccf40fb0a9c6dfdb3bdd4323dcf9cd34d43a3ab5d3314856d2bf4e87b57973213ee9a80b639e3c15844767ca1cebc113b3112ca68e61fc233965ccea04c68f8192aab78b4bffc7baec9e53ec44607bc2e354e438727fff2af13832ae9ccdd6569b4afb5eefebd3ef51e9cb2a2fc85a272136b81e0acac7b24436c6010f57750600eb3bd2e51e4587f5f80a5d926044f1a198e9f1065e1e0b42a3ad8452e84be8bdd2cbd58459c2fb4a37916f6c222fa1b7b160a26c38fa610d0000000f385cc7593b1a690f8f873752f
02-14 18:12:28.171-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:12:28.171-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba56879e202ec5c8a4079ab564124adff56c67e6941cf2ca657be5a669d82f4712d39b7ae1ce65136ce59ec35cfc42fc05ab268fc7cca996ced2724e099408d843e178f5e1e2c983a6ae208be6a3a0c0ec00ab99c24554ca08fb5048b0a0651da9c036748c1c027308cb78c4e4dda74ed4cf0f2119b29ee525d2801ecc172c4b69880524d507abc4058ac4fa310091a1634359554625f366d01e79607ae900bb212c28e72c33fe57367a6a93d928226a18d752300387bf7437d53c4fa07229ce59d43f27a70d632b0ef1b17fe232df6090c11f0065be3c3ba878ce5d236c2c3c1ecfa226d52a899c65105b47734733c77ee38bdfea8b851ab492bee51c9430f76176b92bea8ad6c615cac5774e609d79798291deb4312d01ccf40fb0a9c6dfdb3bdd4323dcf9cd34d43a3ab5d3314856d2bf4e87b57973213ee9a80b639e3c15844767ca1cebc113b3112ca68e61fc233965ccea04c68f8192aab78b4bffc7baec9e53ec44607bc2e354e438727fff2af13832ae9ccdd6569b4afb5eefebd3ef51e9cb2a2fc85a272136b81e0acac7b24436c6010f57750600eb3bd2e51e4587f5f80a5d926044f1a198e9f1065e1e0b42a3ad8452e84be8bdd2cbd58459c2fb4a37916f6c222fa1b7b160a26c38fa610d0000000f385cc7593b1a690f8f873752f340
02-14 18:12:28.171-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 446[0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:12:28.171-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:12:28.171-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
02-14 18:12:28.171-0600 W/SHealthService( 3446): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[212] [0;m
02-14 18:12:28.171-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
02-14 18:12:28.171-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [179999][0;m
02-14 18:12:28.181-0600 W/SHealthService( 3446): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
02-14 18:12:28.181-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : REQUEST_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1487117324611,  ] [size: 169][0;m
02-14 18:12:28.181-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : REQUEST_DATA[0;m
02-14 18:12:28.181-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(548) > [1;40;33mresponse : SUCCESS[0;m
02-14 18:12:28.181-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:12:28.821-0600 D/UIB_APP (21995): Heart: 0.000000, 0.000000, 0.000000, 0.000000
02-14 18:12:29.051-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:12:29.051-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:12:29.051-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] 083659f780030000efc925319542ea853363c9f3d7631b72d072561988203fbaed868658b2683a84bc2d43e48dae51b6051b16ea97b705607e06f002da99edfc5c5e020474c2d25d590b37c18a63be1d7cb204d3624cade2172caf2bf555279b5fb6507ceed59132d9882bffe38edf47030d0d51c38525f8a8c1b55d1d5f58e34d018229b70f682b01fbf334fc5a58fa406699a08b199e6519a4704d1d49ab84e6145e76836d4b4fb7197873c6fe62e585052c76ffdf77e31493b9b729e3a4f5616d258a89141456b4aa2df67a3980cc743e5abfbfc79c6200543bd2d4d9dfe5c8011a186643462d31c091fc2c5cf4924511f571949607c4f3877291027008090ed5eb35e95a325cc96ed78d0e2dbacdfc99b6b257ed7ed7c29e8d3f4a6892f1cd6202b44f4d7dee65e12b54755fc07a73f4dacc639f90527de820bd3975beee06b30200aa03c590119d771b2b0aa898fee1dfdad6f0aef2200c15c2c123d5f7c0b1b42ba487c532feb7341c3c22c421722112b0f8cb09c44b8ba3e57fd4e60659ca82239d8285bbb68edb4b1e853a0a7cd4e8f808281486a34b9ff9d9511075ce3354d427edf56b646d2242ec7b57c8f460c8a112e03d0b474d75d25ad226091ced0844a1a678115ea7d7d8308fb4866c3849bb6e0252bededd1d05375a328a03af012547fb9f7fdf03e1
02-14 18:12:29.061-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:12:29.061-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba5689542ea853363c9f3d7631b72d072561988203fbaed868658b2683a84bc2d43e48dae51b6051b16ea97b705607e06f002da99edfc5c5e020474c2d25d590b37c18a63be1d7cb204d3624cade2172caf2bf555279b5fb6507ceed59132d9882bffe38edf47030d0d51c38525f8a8c1b55d1d5f58e34d018229b70f682b01fbf334fc5a58fa406699a08b199e6519a4704d1d49ab84e6145e76836d4b4fb7197873c6fe62e585052c76ffdf77e31493b9b729e3a4f5616d258a89141456b4aa2df67a3980cc743e5abfbfc79c6200543bd2d4d9dfe5c8011a186643462d31c091fc2c5cf4924511f571949607c4f3877291027008090ed5eb35e95a325cc96ed78d0e2dbacdfc99b6b257ed7ed7c29e8d3f4a6892f1cd6202b44f4d7dee65e12b54755fc07a73f4dacc639f90527de820bd3975beee06b30200aa03c590119d771b2b0aa898fee1dfdad6f0aef2200c15c2c123d5f7c0b1b42ba487c532feb7341c3c22c421722112b0f8cb09c44b8ba3e57fd4e60659ca82239d8285bbb68edb4b1e853a0a7cd4e8f808281486a34b9ff9d9511075ce3354d427edf56b646d2242ec7b57c8f460c8a112e03d0b474d75d25ad226091ced0844a1a678115ea7d7d8308fb4866c3849bb6e0252bededd1d05375a328a03af012547fb9f7fdf03e1e52
02-14 18:12:29.061-0600 E/EFL     (21995): ecore_x<21995> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=78308590 button=1
02-14 18:12:29.071-0600 I/AUL     (22120): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
02-14 18:12:29.081-0600 I/AUL     (22120): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-14 18:12:29.081-0600 E/AUL     (22120): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-14 18:12:29.081-0600 E/AUL     (22120): aul_path.c: __get_path(169) > root_path is NULL!
02-14 18:12:29.091-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 630[0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:12:29.091-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:12:29.091-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
02-14 18:12:29.091-0600 W/SHealthService( 3446): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[404] [0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
02-14 18:12:29.091-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
02-14 18:12:29.091-0600 W/SHealthService( 3446): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
02-14 18:12:29.091-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA,  ][ version : 4.510000, start_time : 0xf72e7c28, end_time : 0xf7305968, last_sync_time : 1487117324611, is_last_chunk : 1,  ] [size: 616][0;m
02-14 18:12:29.091-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (result)[0;m
02-14 18:12:29.101-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
02-14 18:12:29.101-0600 W/SHealthCommon( 3446): SystemUtil.cpp: IsShowCaseBinary(1220) > [1;35misShowCaseBinary : 0[0;m
02-14 18:12:29.111-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:12:29.121-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:12:29.121-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakeCommonSyncResponseMsg(464) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA , result : SUCCESS ][ device : Gear S3, device_type : 10038, version : 4.510000, last_sync_time : 1487117547947, reset_time : 1486533600000 ][0;m
02-14 18:12:29.121-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [507][0;m
02-14 18:12:29.121-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [507][0;m
02-14 18:12:29.121-0600 W/SHealthService( 3446): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
02-14 18:12:29.121-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
02-14 18:12:29.141-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:12:29.141-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:12:29.141-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] 083659f770030000efc925317b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a20382c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5171444d4243455832584a57556f6b305768766b706265656b6c374b434968324c51452f436b6d46615434376d324d422b6e633970756433536e6841366a563171716e6c715a3739416a325548716f616d66367a6f3949334d3563486f704c67534a41673762767867562b3566776f4249495a4b70676a6e3772723064522f6c774a62456965744268444533316b33336652617242686a6b763377714165372f715737424f646265623952316b6b37646256307067314a6d7245345a676c6c4f5757686f485a62
02-14 18:12:29.141-0600 E/EFL     (21995): ecore_x<21995> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=78308686 button=1
02-14 18:12:29.141-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:12:29.151-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000070030000028ba5687b20226d65737361676522203a2022524553504f4e5345222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c2022726563656976657222203a2022636f6d2e73616d73756e672e616e64726f69642e6170702e736865616c74682e7765617261626c652e73796e636d616e61676572222c202276657273696f6e22203a20342e353039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a20382c20227479706522203a202244415441222c2022626f647922203a20224834734941414141414141414131324f7a5171444d4243455832584a57556f6b305768766b706265656b6c374b434968324c51452f436b6d46615434376d324d422b6e633970756433536e6841366a563171716e6c715a3739416a325548716f616d66367a6f3949334d3563486f704c67534a41673762767867562b3566776f4249495a4b70676a6e3772723064522f6c774a62456965744268444533316b33336652617242686a6b763377714165372f715737424f646265623952316b6b37646256307067314a6d7245345a676c6c4f5757686f485a624e3
02-14 18:12:29.151-0600 W/SHealthService( 3446): SHealthSapSyncManager.cpp: NotifySAPSyncSuccess(152) > [1;35msync is completed[0;m
02-14 18:12:29.151-0600 W/SHealthCommon( 3446): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: sync_done, pendingClientInfoList.size(): 0[0;m
02-14 18:12:29.161-0600 I/HealthDataService( 3008): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-14 18:12:29.171-0600 I/healthData( 3446): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-14 18:12:29.171-0600 W/SHealthCommon( 3446): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: pedo_goal_changed, pendingClientInfoList.size(): 0[0;m
02-14 18:12:29.201-0600 D/UIB_APP (21995): Getting oauth token
02-14 18:12:29.201-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:12:29.211-0600 W/SHealthCommon( 3446): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: floor_update, pendingClientInfoList.size(): 0[0;m
02-14 18:12:29.221-0600 W/SHealthCommon( 3446): SystemUtil.cpp: IsShowCaseBinary(1220) > [1;35misShowCaseBinary : 0[0;m
02-14 18:12:29.221-0600 I/HealthDataService( 3008): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-14 18:12:29.241-0600 I/healthData( 3446): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-14 18:12:29.431-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 21995 pgid = 21995
02-14 18:12:29.431-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-14 18:12:29.441-0600 W/STARTER ( 2711): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2797] goes to (3)
02-14 18:12:29.441-0600 E/STARTER ( 2711): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2797)'s state(3)
02-14 18:12:29.441-0600 W/AUL_AMD ( 2555): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-14 18:12:29.441-0600 W/AUL_AMD ( 2555): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-14 18:12:29.441-0600 W/AUL     ( 2555): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2797) status(fg) type(uiapp)
02-14 18:12:29.471-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-14 18:12:29.471-0600 W/W_HOME  ( 2797): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-14 18:12:29.471-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.471-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.481-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.481-0600 W/W_HOME  ( 2797): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-14 18:12:29.511-0600 W/WATCH_CORE( 2884): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-14 18:12:29.511-0600 I/WATCH_CORE( 2884): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _window_visibility_cb(473) > Window [0x2200003] is now visible(0)
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): main.c: _window_visibility_cb(963) > Window [0x2200003] is now visible(0)
02-14 18:12:29.521-0600 I/APP_CORE( 2797): appcore-efl.c: __do_app(453) > [APP 2797] Event: RESUME State: PAUSED
02-14 18:12:29.521-0600 I/CAPI_APPFW_APPLICATION( 2797): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): main.c: _appcore_resume_cb(478) > appcore resume
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): main.c: home_resume(530) > clock/widget resumed
02-14 18:12:29.521-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:12:29.521-0600 I/GATE    ( 2797): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-14 18:12:29.521-0600 I/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-14 18:12:29.521-0600 E/wnotib  ( 2797): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-14 18:12:29.521-0600 W/wnotib  ( 2797): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
02-14 18:12:29.541-0600 W/WATCH_CORE( 2884): appcore-watch.c: __widget_resume(1124) > widget_resume
02-14 18:12:29.541-0600 W/AUL     ( 2884): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2884) status(fg) type(watchapp)
02-14 18:12:29.561-0600 I/CAPI_WATCH_APPLICATION( 2884): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-14 18:12:29.561-0600 W/W_INDICATOR( 2713): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
02-14 18:12:29.591-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-14 18:12:29.591-0600 W/W_INDICATOR( 2713): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
02-14 18:12:29.591-0600 W/W_INDICATOR( 2713): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
02-14 18:12:29.601-0600 I/AUL_AMD ( 2555): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21995
02-14 18:12:29.601-0600 W/AUL     ( 2555): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21995)
02-14 18:12:29.631-0600 W/W_INDICATOR( 2713): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(31), length(2)
02-14 18:12:29.631-0600 W/W_INDICATOR( 2713): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 31%
02-14 18:12:29.631-0600 W/W_INDICATOR( 2713): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 31, isCharging: 0
02-14 18:12:29.631-0600 W/W_INDICATOR( 2713): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_35
02-14 18:12:29.631-0600 W/W_INDICATOR( 2713): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
02-14 18:12:29.721-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:29.721-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:29.731-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:29.731-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:29.731-0600 W/CoreGL  ( 2905): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-14 18:12:29.771-0600 W/CRASH_MANAGER(22136): worker.c: worker_job(1199) > 112199572756e148711754
