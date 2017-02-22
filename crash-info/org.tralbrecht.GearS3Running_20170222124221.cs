S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: gears3running
PID: 16399
Date: 2017-02-22 12:42:21-0600
Executable File Path: /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16399, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xf5b3f765
r4   = 0xf5b53658, r5   = 0x00000000
r6   = 0xf75fbb30, r7   = 0xff980238
r8   = 0x00000000, r9   = 0xf75cdf18
r10  = 0xff9802e0, fp   = 0x00000000
ip   = 0xf5b534d8, sp   = 0xff980220
lr   = 0xf6cdae8c, pc   = 0xf6cdb0b4
cpsr = 0x40000010

Memory Information
MemTotal:   620364 KB
MemFree:     52800 KB
Buffers:      4248 KB
Cached:      92676 KB
VmPeak:     133704 KB
VmSize:     133700 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31888 KB
VmRSS:       31884 KB
VmData:      48108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43876 KB
VmPTE:         160 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16399 TID = 16399
16399 16481 16489 16490 

Maps Information
efe01000 f0600000 rw-p [stack:16490]
f0601000 f0e00000 rw-p [stack:16489]
f0f40000 f0f41000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f0f49000 f0f4b000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f0f53000 f0f57000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f0f60000 f0f63000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f0f6b000 f0f6e000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f0f76000 f0f7a000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f0f83000 f1782000 rw-p [stack:16481]
f217f000 f2181000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f2189000 f21a0000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f21ad000 f21b2000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f21ba000 f21c5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f24ed000 f25df000 r-xp /usr/lib/libCOREGL.so.4.0
f25f8000 f25fc000 r-xp /usr/lib/libogg.so.0.7.1
f2604000 f2626000 r-xp /usr/lib/libvorbis.so.0.4.3
f262e000 f2633000 r-xp /usr/lib/libsystem.so.0.0.0
f263d000 f2643000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f264b000 f265a000 r-xp /usr/lib/libmdm-common.so.1.1.22
f2663000 f26aa000 r-xp /usr/lib/libsndfile.so.1.0.26
f26b6000 f26ff000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2708000 f270d000 r-xp /usr/lib/libjson.so.0.0.1
f2715000 f2718000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2720000 f2726000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f272e000 f2739000 r-xp /usr/lib/libresourced.so.0.2.96
f2741000 f2742000 r-xp /usr/lib/librd-network.so.0.2.96
f274a000 f274b000 r-xp /usr/lib/libresponse.so.0.2.96
f2753000 f2758000 r-xp /usr/lib/libproc-stat.so.0.2.96
f2761000 f2763000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f276b000 f2772000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f277b000 f2780000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f2788000 f278a000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f2792000 f27b3000 r-xp /usr/lib/libexif.so.12.3.3
f27c6000 f27df000 r-xp /usr/lib/libnetwork.so.0.0.0
f27e7000 f27ed000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f27f6000 f283e000 r-xp /usr/lib/libmdm.so.1.2.62
f283f000 f284c000 r-xp /usr/lib/libail.so.0.1.0
f2855000 f2858000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2860000 f2898000 r-xp /usr/lib/libpulse.so.0.16.2
f2899000 f289c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f28a4000 f2905000 r-xp /usr/lib/libasound.so.2.0.0
f290f000 f2929000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2931000 f2938000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2940000 f2944000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f294c000 f2950000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2959000 f295b000 r-xp /usr/lib/libttrace.so.1.1
f41fb000 f41fc000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4205000 f4208000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f4210000 f4232000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f423b000 f4240000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f4248000 f4298000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f429e000 f42a7000 r-xp /usr/lib/libcom-core.so.0.0.1
f42b0000 f42ba000 r-xp /usr/lib/libspdy.so.0.0.0
f42c3000 f42c9000 r-xp /usr/lib/libxcb-render.so.0.0.0
f42d1000 f42d2000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f42db000 f42ea000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f42f3000 f42fd000 r-xp /usr/lib/libsensord-shared.so
f4305000 f4315000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f431d000 f4336000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f433e000 f4345000 r-xp /usr/lib/libminizip.so.1.0.0
f434d000 f4358000 r-xp /usr/lib/libtbm.so.1.0.0
f4360000 f4377000 r-xp /usr/lib/libmmfsound.so.0.1.0
f4389000 f438e000 r-xp /usr/lib/libmemenv.so.1.1.0
f4396000 f43d2000 r-xp /usr/lib/libleveldb.so.1.1.0
f43db000 f43e8000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f43f1000 f43f3000 r-xp /usr/lib/libdri2.so.0.0.0
f43fb000 f4406000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f4413000 f441a000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f4422000 f444b000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f4454000 f4458000 r-xp /usr/lib/libEGL.so.1.4
f4468000 f4479000 r-xp /usr/lib/libGLESv2.so.2.0
f4489000 f4497000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f44a0000 f44b8000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f44c1000 f44ca000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f44d2000 f4513000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f451c000 f45b7000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f45c3000 f45cb000 r-xp /usr/lib/libdrm.so.2.4.0
f45d3000 f46d9000 r-xp /usr/lib/libicuuc.so.57.1
f46ef000 f4877000 r-xp /usr/lib/libicui18n.so.57.1
f4887000 f48aa000 r-xp /usr/lib/libui-extension.so.0.1.0
f48b3000 f48c5000 r-xp /usr/lib/libefl-assist.so.0.1.0
f48cd000 f48d5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f48dd000 f48ef000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f48f7000 f48fa000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4902000 f4915000 r-xp /usr/lib/libwidget_service.so.1.0.0
f491e000 f496a000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4974000 f4975000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f497d000 f4a35000 r-xp /usr/lib/libcairo.so.2.11200.14
f4a40000 f4a45000 r-xp /usr/lib/libctx-client.so.0.8.3
f4a4d000 f4a54000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4a5c000 f4a86000 r-xp /usr/lib/libsensor.so.1.9.3
f4a8f000 f4ac9000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4ad2000 f4ae8000 r-xp /usr/lib/libtts.so
f4af1000 f4b0a000 r-xp /usr/lib/libstt.so
f4b12000 f4b17000 r-xp /usr/lib/libstorage.so.0.1
f4b1f000 f59e3000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5ac9000 f5aea000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5af2000 f5afe000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5b07000 f5b0c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5b14000 f5b19000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5b21000 f5b2f000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5b38000 f5b44000 r-xp /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
f5ce6000 f5cf0000 r-xp /lib/libnss_files-2.13.so
f5cf9000 f5dc8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5dde000 f5e02000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5e0b000 f5e11000 r-xp /usr/lib/libappsvc.so.0.1.0
f5e19000 f5e1d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5e2a000 f5e35000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5e3d000 f5e3f000 r-xp /usr/lib/libiniparser.so.0
f5e48000 f5e4d000 r-xp /usr/lib/libappcore-common.so.1.1
f5e55000 f5e57000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5e60000 f5e64000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5e71000 f5e73000 r-xp /usr/lib/libXau.so.6.0.0
f5e7b000 f5e82000 r-xp /lib/libcrypt-2.13.so
f5eb2000 f5eb4000 r-xp /usr/lib/libiri.so
f5ebd000 f6066000 r-xp /usr/lib/libcrypto.so.1.0.0
f6086000 f60cd000 r-xp /usr/lib/libssl.so.1.0.0
f60d9000 f6107000 r-xp /usr/lib/libidn.so.11.5.44
f610f000 f6118000 r-xp /usr/lib/libcares.so.2.1.0
f6122000 f6135000 r-xp /usr/lib/libxcb.so.1.1.0
f613e000 f6141000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6149000 f614b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6154000 f6220000 r-xp /usr/lib/libxml2.so.2.7.8
f622d000 f622f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6238000 f623d000 r-xp /usr/lib/libffi.so.5.0.10
f6245000 f6246000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f624e000 f6251000 r-xp /lib/libattr.so.1.1.0
f6259000 f62ed000 r-xp /usr/lib/libstdc++.so.6.0.16
f6300000 f631d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6327000 f633f000 r-xp /usr/lib/libpng12.so.0.50.0
f6347000 f635d000 r-xp /lib/libexpat.so.1.6.0
f6367000 f63ab000 r-xp /usr/lib/libcurl.so.4.3.0
f63b4000 f63be000 r-xp /usr/lib/libXext.so.6.4.0
f63c7000 f63cb000 r-xp /usr/lib/libXtst.so.6.1.0
f63d3000 f63d9000 r-xp /usr/lib/libXrender.so.1.3.0
f63e1000 f63e7000 r-xp /usr/lib/libXrandr.so.2.2.0
f63ef000 f63f0000 r-xp /usr/lib/libXinerama.so.1.0.0
f63f9000 f6402000 r-xp /usr/lib/libXi.so.6.1.0
f640a000 f640d000 r-xp /usr/lib/libXfixes.so.3.1.0
f6415000 f6417000 r-xp /usr/lib/libXgesture.so.7.0.0
f641f000 f6421000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6429000 f642b000 r-xp /usr/lib/libXdamage.so.1.1.0
f6433000 f643a000 r-xp /usr/lib/libXcursor.so.1.0.2
f6442000 f6445000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f644d000 f6451000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f645a000 f645f000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6468000 f6549000 r-xp /usr/lib/libX11.so.6.3.0
f6554000 f6577000 r-xp /usr/lib/libjpeg.so.8.0.2
f658f000 f65a5000 r-xp /lib/libz.so.1.2.5
f65ad000 f65af000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f65b7000 f662c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6636000 f6650000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6658000 f668c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6695000 f6768000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6773000 f6783000 r-xp /lib/libresolv-2.13.so
f6787000 f679f000 r-xp /usr/lib/liblzma.so.5.0.3
f67a7000 f67aa000 r-xp /lib/libcap.so.2.21
f67b2000 f67e1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67e9000 f67ea000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f67f2000 f67f8000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6800000 f6817000 r-xp /usr/lib/liblua-5.1.so
f6820000 f6827000 r-xp /usr/lib/libembryo.so.1.7.99
f682f000 f6835000 r-xp /lib/librt-2.13.so
f683e000 f6894000 r-xp /usr/lib/libpixman-1.so.0.28.2
f68a1000 f68f7000 r-xp /usr/lib/libfreetype.so.6.11.3
f6903000 f692b000 r-xp /usr/lib/libfontconfig.so.1.8.0
f692c000 f6971000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f697a000 f698d000 r-xp /usr/lib/libfribidi.so.0.3.1
f6995000 f69af000 r-xp /usr/lib/libecore_con.so.1.7.99
f69b8000 f69c1000 r-xp /usr/lib/libedbus.so.1.7.99
f69c9000 f6a19000 r-xp /usr/lib/libecore_x.so.1.7.99
f6a1b000 f6a24000 r-xp /usr/lib/libvconf.so.0.2.45
f6a2c000 f6a3d000 r-xp /usr/lib/libecore_input.so.1.7.99
f6a45000 f6a4a000 r-xp /usr/lib/libecore_file.so.1.7.99
f6a52000 f6a74000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6a7d000 f6abe000 r-xp /usr/lib/libeina.so.1.7.99
f6ac7000 f6ae0000 r-xp /usr/lib/libeet.so.1.7.99
f6af1000 f6b5a000 r-xp /lib/libm-2.13.so
f6b63000 f6b69000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6b72000 f6b73000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b7b000 f6b9e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ba6000 f6bab000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bb3000 f6bdd000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6be6000 f6bfd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c05000 f6c10000 r-xp /lib/libunwind.so.8.0.1
f6c3d000 f6c5b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c65000 f6d89000 r-xp /lib/libc-2.13.so
f6d97000 f6d9f000 r-xp /lib/libgcc_s-4.6.so.1
f6da0000 f6da4000 r-xp /usr/lib/libsmack.so.1.0.0
f6dad000 f6db3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6dbb000 f6e8b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e8c000 f6eea000 r-xp /usr/lib/libedje.so.1.7.99
f6ef4000 f6f0b000 r-xp /usr/lib/libecore.so.1.7.99
f6f22000 f6ff0000 r-xp /usr/lib/libevas.so.1.7.99
f7015000 f7151000 r-xp /usr/lib/libelementary.so.1.7.99
f7168000 f717c000 r-xp /lib/libpthread-2.13.so
f7187000 f7189000 r-xp /usr/lib/libdlog.so.0.0.0
f7191000 f7194000 r-xp /usr/lib/libbundle.so.0.1.22
f719c000 f719e000 r-xp /lib/libdl-2.13.so
f71a7000 f71b4000 r-xp /usr/lib/libaul.so.0.1.0
f71c6000 f71cc000 r-xp /usr/lib/libappcore-efl.so.1.1
f71d5000 f71d9000 r-xp /usr/lib/libsys-assert.so
f71e2000 f71ff000 r-xp /lib/ld-2.13.so
f7208000 f720d000 r-xp /usr/bin/launchpad-loader
f74c4000 f7773000 rw-p [heap]
ff961000 ff982000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16399)
Call Stack Count: 1
 0: strlen + 0x4 (0xf6cdb0b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: org.tralbrecht.GearS3Running
Package ID : org.tralbrecht.GearS3Running
Version: 1.0.0
Package Type: rpm
App Name: Gear S3 Running
App ID: org.tralbrecht.GearS3Running
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-22 12:42:06.789-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2748].
02-22 12:42:06.789-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(916698542)
02-22 12:42:06.789-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
02-22 12:42:06.789-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:06.789-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_boolean(1173) > preference_get_boolean(3431) : test_healthy_pace error
02-22 12:42:06.799-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:42:06.799-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:42:06.799-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:42:06.799-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-22 12:42:06.799-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-22 12:42:06.809-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:42:06.809-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-22 12:42:06.809-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-22 12:42:06.809-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151127284[0;m
02-22 12:42:06.809-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
02-22 12:42:06.809-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-22 12:42:06.809-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-22 12:42:06.809-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-22 12:42:06.809-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:42:06.819-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:42:06.819-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:42:06.819-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-22 12:42:06.819-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-22 12:42:06.819-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:42:06.819-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-22 12:42:06.819-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : pedometer_inactive_period error
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_10min_precaution_millisec error
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:06.849-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_before_10min_precaution_millisec error
02-22 12:42:06.929-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
02-22 12:42:06.929-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 0
02-22 12:42:06.929-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-22 12:42:06.929-0600 W/SHealthCommon( 2955): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-22 12:42:06.939-0600 W/AUL     (16399): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.tralbrecht.GearS3Running)
02-22 12:42:06.939-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-22 12:42:06.939-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 16399
02-22 12:42:06.959-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1959) > caller process & callee process is same.[org.tralbrecht.GearS3Running:16399]
02-22 12:42:06.959-0600 W/AUL     (16399): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-7)
02-22 12:42:06.959-0600 E/AUL     (16399): launch.c: app_request_to_launchpad(304) > app_request_to_launchpad : Same Process Send Local
02-22 12:42:06.989-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(453) > [APP 16399] Event: RESET State: RUNNING
02-22 12:42:06.989-0600 I/CAPI_APPFW_APPLICATION(16399): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-22 12:42:06.989-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(529) > Legacy lifecycle: 0
02-22 12:42:06.989-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(531) > [APP 16399] App already running, raise the window
02-22 12:42:06.999-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-22 12:42:06.999-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 12:42:06.999-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 18:49:02 (UTC).
02-22 12:42:06.999-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 12:42:06.999-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-22 12:42:06.999-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[916698542] is removed.
02-22 12:42:07.009-0600 E/wnoti-service( 3110): wnoti-consumer.c: on_receive(521) > on receive called. noti(17), handle(17) payloadLength(41)
02-22 12:42:07.009-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
02-22 12:42:07.009-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:42:07.019-0600 E/wnoti-service( 3110): wnoti-sap-client.c: publish_received_noti(1931) > type : 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : 39766, seq_num : 229562, noti_flag : 0, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 0.000000
02-22 12:42:07.019-0600 E/wnoti-service( 3110): wnoti-db-utility.c: lock_pm(567) > >> lock_pm status : 2
02-22 12:42:07.059-0600 W/SHealthCommon( 3431): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-22 12:42:07.059-0600 W/SHealthService( 3431): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-db-utility.c: set_pm_lock(551) > >> set_pm_lock status : 1
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-db-utility.c: unlock_pm(582) > >> unlock_pm status : 1
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-consumer.c: on_receive(521) > on receive called. noti(17), handle(17) payloadLength(41)
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-sap-client.c: publish_received_noti(1931) > type : 2, category : 0, source : 7, feedback : -1, popup_type(RICH) : 0, application_id : -1, seq_num : 229561, noti_flag : 0, g_span_version : 1, update_summary_icons : 0, latest_child_time : 0.000000, latest_summary_time : 0.000000, android_time : 0.000000
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-db-utility.c: lock_pm(567) > >> lock_pm status : 1
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-db-server.c: clear_notification_card(3194) > _query_step failed()
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-db-server.c: clear_notification_card_by_window_id(3108) > _query_step failed()
02-22 12:42:07.069-0600 E/wnoti-service( 3110): wnoti-db-utility.c: unlock_pm(582) > >> unlock_pm status : 1
02-22 12:42:07.569-0600 E/wnoti-service( 3110): wnoti-db-utility.c: set_pm_lock(551) > >> set_pm_lock status : 2
02-22 12:42:07.579-0600 E/wnoti-service( 3110): wnoti-db-utility.c: unlock_pm(582) > >> unlock_pm status : 0
02-22 12:42:07.579-0600 E/wnoti-service( 3110): wnoti-db-server.c: set_global_noti_count(1661) > pre_count : 1, count : 0
02-22 12:42:07.609-0600 I/AUL     ( 3110): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
02-22 12:42:07.629-0600 I/AUL     ( 3110): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wnoti-service2, ret : 0
02-22 12:42:07.639-0600 E/APPS    ( 2815): AppsBadge.cpp: onBadgeChange(214) >  (!pAppsItem) -> onBadgeChange() return
02-22 12:42:07.659-0600 E/WRT_PLUGINS/TIZEN( 2937): BadgeManager.cpp: badgeEventCB(73) > No matched application id : com.samsung.wnotification2
02-22 12:42:08.079-0600 E/wnoti-service( 3110): wnoti-msg-builder.c: _publish_notification(1603) > operation_type : 0, source : 0, application_id : 0, display_count : 0, 
02-22 12:42:08.089-0600 E/wnoti-proxy( 2815): wnoti-client.c: on_wnoti_event(1022) > !!!!!!!!!! on_noti_handle_cb : noti is comming ............. !!, pid : 2815, caller_id : 0, listener_type : 0
02-22 12:42:08.239-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(787) > Change type : 0, op_type: 0, category_id: 0, display count: 0
02-22 12:42:08.239-0600 I/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(821) > Handle this change type in idler.
02-22 12:42:08.239-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_data_changed_cb(825) > Postpone notiboard update.
02-22 12:42:08.499-0600 W/SCSD    (15574): <on_sap_socket_recv:28>  - recv length 2 bytes (0x00 0x05)
02-22 12:42:08.499-0600 W/SCSD    (15574): <on_sap_socket_recv:30>  - remain length: 5, crc_size: 4
02-22 12:42:08.499-0600 W/SCSD    (15574): <on_sap_socket_recv:62>  - recv 9 bytes [9 / 9] 
02-22 12:42:08.509-0600 W/SCSD    (15574): <util_scs_send:976> sent [11 / 11] bytes. 
02-22 12:42:13.209-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_unset_buffer(1602) > [236441.662808] layer(0x4f1448) now usable
02-22 12:42:13.209-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [236441.662856] layer[0x4f1068]zpos[2]
02-22 12:42:13.209-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_unset_buffer(1602) > [236441.662897] layer(0x4f13f8) now usable
02-22 12:42:13.209-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [236441.662916] layer[0x4f0f48]zpos[1]
02-22 12:42:13.209-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [236441.662943] dpms[0 -> 3]sync[1]
02-22 12:42:13.209-0600 I/TDM     ( 1991): 
02-22 12:42:13.229-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -151127284[0;m
02-22 12:42:13.229-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
02-22 12:42:13.229-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-22 12:42:13.229-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:42:13.229-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
02-22 12:42:13.229-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1235) > Skip the background tick update
02-22 12:42:13.229-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:42:13.229-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:42:13.239-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
02-22 12:42:13.239-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-22 12:42:13.239-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-22 12:42:13.239-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-22 12:42:13.239-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 1
02-22 12:42:13.239-0600 W/W_HOME  ( 2815): event_manager.c: _lcd_off_cb(736) > lcd state: 0
02-22 12:42:13.239-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:13.239-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-22 12:42:13.239-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:42:13.239-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
02-22 12:42:13.239-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
02-22 12:42:13.239-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
02-22 12:42:13.239-0600 W/STARTER ( 2748): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
02-22 12:42:13.239-0600 E/STARTER ( 2748): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-22 12:42:13.239-0600 W/STARTER ( 2748): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
02-22 12:42:13.239-0600 W/STARTER ( 2748): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
02-22 12:42:13.339-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [236441.791300] dpms[3 -> 3]done
02-22 12:42:13.339-0600 I/TDM     ( 1991): 
02-22 12:42:13.339-0600 W/SHealthCommon( 2955): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
02-22 12:42:13.349-0600 W/SHealthCommon( 3431): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
02-22 12:42:13.349-0600 W/SHealthService( 3431): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-22 12:42:13.349-0600 W/W_INDICATOR( 2749): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
02-22 12:42:13.369-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
02-22 12:42:13.369-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
02-22 12:42:13.369-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
02-22 12:42:13.369-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
02-22 12:42:13.369-0600 E/ALARM_MANAGER( 2748): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(22-2-2017, 12:42:33), repeat(1), interval(20), type(-1073741822)
02-22 12:42:13.379-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(453) > [APP 16399] Event: PAUSE State: RUNNING
02-22 12:42:13.379-0600 I/CAPI_APPFW_APPLICATION(16399): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
02-22 12:42:13.379-0600 D/UIB_APP (16399): pausing
02-22 12:42:13.379-0600 W/APP_CORE(16399): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[4600002] -> redirected win[650116] for org.tralbrecht.GearS3Running[16399]
02-22 12:42:13.379-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
02-22 12:42:13.379-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
02-22 12:42:13.379-0600 W/W_INDICATOR( 2749): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
02-22 12:42:13.389-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2748].
02-22 12:42:13.429-0600 E/ALARM_MANAGER( 2496): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1400699091, next duetime: 1487788953
02-22 12:42:13.429-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1400699091)
02-22 12:42:13.429-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1487789342), due_time(1487788953)
02-22 12:42:13.439-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-22 12:42:13.439-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 12:42:13.439-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 18:42:33 (UTC).
02-22 12:42:13.439-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 12:42:13.449-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-22 12:42:13.909-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
02-22 12:42:13.909-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_context_handler(1302) > Skip the background tick update
02-22 12:42:13.909-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-22 12:42:13.909-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-22 12:42:13.919-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [236442.372346] dpms[3 -> 0]sync[0]
02-22 12:42:13.919-0600 I/TDM     ( 1991): 
02-22 12:42:13.919-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [236442.372537] dpms[0 -> 0]done
02-22 12:42:13.919-0600 I/TDM     ( 1991): 
02-22 12:42:13.939-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -148844088[0;m
02-22 12:42:13.969-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
02-22 12:42:13.969-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1235) > Skip the background tick update
02-22 12:42:13.969-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-22 12:42:13.969-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_set(167) > timer set
02-22 12:42:13.969-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-22 12:42:13.979-0600 W/W_HOME  ( 2815): gesture.c: _apps_status_get(128) > apps status:0
02-22 12:42:13.979-0600 W/W_HOME  ( 2815): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:742
02-22 12:42:13.979-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-22 12:42:13.979-0600 W/W_HOME  ( 2815): event_manager.c: _lcd_on_cb(728) > lcd state: 1
02-22 12:42:13.979-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:13.979-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [742]ms
02-22 12:42:13.979-0600 W/STARTER ( 2748): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:42:13.979-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
02-22 12:42:13.979-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
02-22 12:42:13.979-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
02-22 12:42:13.979-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-22 12:42:13.979-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-22 12:42:13.989-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(453) > [APP 16399] Event: RESUME State: PAUSED
02-22 12:42:13.989-0600 I/CAPI_APPFW_APPLICATION(16399): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
02-22 12:42:13.989-0600 D/UIB_APP (16399): resuming
02-22 12:42:13.989-0600 I/GATE    (16399): <GATE-M>APP_FULLY_LOADED_GearS3Running</GATE-M>
02-22 12:42:13.989-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-22 12:42:13.989-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:42:13.989-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [236442.448435] layer(0x4f13f8) not usable
02-22 12:42:13.989-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [236442.448488] layer(0x4f13f8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-22 12:42:13.989-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [236442.448513] layer[0x4f0f48]zpos[1]
02-22 12:42:13.989-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [236442.448597] layer(0x4f1448) not usable
02-22 12:42:13.989-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [236442.448622] layer(0x4f1448) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-22 12:42:13.989-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [236442.448643] layer[0x4f1068]zpos[2]
02-22 12:42:13.999-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:42:13.999-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:42:13.999-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-22 12:42:13.999-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-22 12:42:13.999-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:42:13.999-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-22 12:42:13.999-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-22 12:42:13.999-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151127284[0;m
02-22 12:42:13.999-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
02-22 12:42:13.999-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-22 12:42:13.999-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-22 12:42:14.009-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-22 12:42:14.009-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:42:14.009-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:42:14.009-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:42:14.009-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-22 12:42:14.019-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-22 12:42:14.019-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:42:14.019-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-22 12:42:14.019-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-22 12:42:14.029-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2748].
02-22 12:42:14.029-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1400699091)
02-22 12:42:14.049-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
02-22 12:42:14.049-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:14.049-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_boolean(1173) > preference_get_boolean(3431) : test_healthy_pace error
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : pedometer_inactive_period error
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_10min_precaution_millisec error
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-22 12:42:14.109-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_before_10min_precaution_millisec error
02-22 12:42:14.179-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
02-22 12:42:14.179-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 0
02-22 12:42:14.179-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-22 12:42:14.179-0600 W/SHealthCommon( 2955): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-22 12:42:14.179-0600 W/AUL     (16399): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.tralbrecht.GearS3Running)
02-22 12:42:14.179-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-22 12:42:14.189-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 16399
02-22 12:42:14.199-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1959) > caller process & callee process is same.[org.tralbrecht.GearS3Running:16399]
02-22 12:42:14.199-0600 W/AUL     (16399): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-7)
02-22 12:42:14.199-0600 E/AUL     (16399): launch.c: app_request_to_launchpad(304) > app_request_to_launchpad : Same Process Send Local
02-22 12:42:14.199-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(453) > [APP 16399] Event: RESET State: RUNNING
02-22 12:42:14.199-0600 I/CAPI_APPFW_APPLICATION(16399): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-22 12:42:14.199-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(529) > Legacy lifecycle: 0
02-22 12:42:14.199-0600 I/APP_CORE(16399): appcore-efl.c: __do_app(531) > [APP 16399] App already running, raise the window
02-22 12:42:14.239-0600 W/SHealthCommon( 3431): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-22 12:42:14.239-0600 W/SHealthService( 3431): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-22 12:42:14.249-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-22 12:42:14.249-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 12:42:14.249-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 18:49:02 (UTC).
02-22 12:42:14.249-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 12:42:14.249-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-22 12:42:14.249-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1400699091] is removed.
02-22 12:42:14.259-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
02-22 12:42:14.259-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:42:19.839-0600 E/EFL     (16399): ecore_x<16399> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236448139 button=1
02-22 12:42:19.839-0600 E/EFL     (16399): ecore_x<16399> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236448288 button=1
02-22 12:42:19.839-0600 D/UIB_APP (16399): Pausing fit
02-22 12:42:20.839-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4600002 time=236448288
02-22 12:42:20.839-0600 E/EFL     (16399): ecore_x<16399> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=236448288
02-22 12:42:20.839-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=236448288
02-22 12:42:20.869-0600 E/EFL     (16399): ecore_x<16399> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236449321 button=1
02-22 12:42:20.999-0600 E/EFL     (16399): ecore_x<16399> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236449459 button=1
02-22 12:42:21.239-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 16399 pgid = 16399
02-22 12:42:21.239-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-22 12:42:21.369-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-22 12:42:21.409-0600 W/W_HOME  ( 2815): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-22 12:42:21.409-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.409-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.409-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.409-0600 W/W_HOME  ( 2815): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): main.c: _window_visibility_cb(963) > Window [0x2000003] is now visible(0)
02-22 12:42:21.439-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: RESUME State: PAUSED
02-22 12:42:21.439-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): main.c: _appcore_resume_cb(478) > appcore resume
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-22 12:42:21.439-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.449-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.449-0600 W/W_HOME  ( 2815): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-22 12:42:21.449-0600 W/W_HOME  ( 2815): main.c: home_resume(530) > clock/widget resumed
02-22 12:42:21.449-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(67), length(2)
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 67%
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 67, isCharging: 0
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_70
02-22 12:42:21.449-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
02-22 12:42:21.449-0600 I/GATE    ( 2815): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-22 12:42:21.459-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-22 12:42:21.459-0600 E/W_INDICATOR( 2749): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(418) > [dynamic_event_icon_refresh_position_for_3g:418] rssi 0 connection 0
02-22 12:42:21.459-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:42:21.459-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(946) > Do the postponed update job with is_for_VI: 0, postponed_for_VI: 0.
02-22 12:42:21.459-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(434) > idler for type: 0
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(67), length(2)
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 67%
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 67, isCharging: 0
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_70
02-22 12:42:21.459-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
02-22 12:42:21.469-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (3)
02-22 12:42:21.469-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(3)
02-22 12:42:21.479-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-22 12:42:21.479-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-22 12:42:21.479-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-22 12:42:21.479-0600 W/AUL_AMD ( 2534): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-22 12:42:21.479-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(fg) type(uiapp)
02-22 12:42:21.479-0600 E/wnoti-service( 3110): wnoti-db-client.c: _wnoti_get_categories_info(207) > _query_step failed(not SQLITE_ROW)
02-22 12:42:21.489-0600 E/wnoti-proxy( 2815): wnoti.c: _wnoti_get_categories(1267) > failed: GDBus.Error:org.freedesktop.DBus.Error.Failed: Empty List
02-22 12:42:21.489-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(720) > No categories available. Num old_notifications: 1
02-22 12:42:21.489-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_remove_card(409) > db_id: 356, application_id: 39766, application_name: Slack
02-22 12:42:21.489-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnb_basic_panel_message_receive(5105) > New event with category_id: 94, application_id: 39766, type: 2
02-22 12:42:21.489-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnotib_basic_panel_delete_card(3619) > We don't need to delete the item for second_depth_type: 0.
02-22 12:42:21.489-0600 E/EFL     ( 2815): elementary<2815> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
02-22 12:42:21.489-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnotib_basic_panel_coverview_gl_item_del(4346) > card[0xec61d060]
02-22 12:42:21.489-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnotib_basic_panel_delete_card(3716) > Hide the drawer for the current panel.
02-22 12:42:21.489-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnb_basic_panel_destroy(6054) > Destory panel, panel application_id [39766], panel category_id [94]
02-22 12:42:21.509-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnb_basic_panel_destroy(6216) > Destory panel, -------> Done
02-22 12:42:21.509-0600 W/wnotib  ( 2815): w-notification-board-panel-manager.c: wnb_pm_destroy_panel(330) > page_instance 94, 0xeaace198 is destoryed!
02-22 12:42:21.509-0600 I/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_free_data(240) > Free noti manager data.
02-22 12:42:21.509-0600 I/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_free_data(245) > Free previous notifications.
02-22 12:42:21.509-0600 I/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_free_data(266) > Free previous categories.
02-22 12:42:21.509-0600 I/wnotib  ( 2815): w-notification-board-noti-manager.c: _wnb_nm_idler_cb(735) > before_rpanel_count: 1, after_rpanel_count: 0.
02-22 12:42:21.509-0600 I/wnotib  ( 2815): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(59) > type: 0
02-22 12:42:21.509-0600 W/wnotib  ( 2815): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(78) > uncleared_category_count: 0, setting_power_saving_mode: 0
02-22 12:42:21.509-0600 W/wnotib  ( 2815): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(81) > Put empty view into panel body
02-22 12:42:21.509-0600 W/W_HOME  ( 2815): noti_broker.c: _handler_indicator_select(579) > 0
02-22 12:42:21.509-0600 W/W_HOME  ( 2815): noti_broker.c: _handler_indicator_select(589) > select index:1
02-22 12:42:21.519-0600 I/wnotib  ( 2815): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(97) > is_notification_enabled: 1, blocking mode: 0, is_connected_vendor_LO: 0
02-22 12:42:21.519-0600 I/wnotib  ( 2815): w-notification-board-empty-panel.c: _wnb_ep_set_texts(345) > is_connected_vendor_LO: 0, is_standalone_mode: 0
02-22 12:42:21.539-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-22 12:42:21.549-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2815): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
02-22 12:42:21.549-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2815): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:42:21.549-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2815): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
02-22 12:42:21.549-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2815): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
02-22 12:42:21.549-0600 I/AUL_AMD ( 2534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16399
02-22 12:42:21.549-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16399)
02-22 12:42:21.599-0600 W/W_HOME  ( 2815): noti_broker.c: _handler_indicator_update(560) > 0x1
02-22 12:42:21.609-0600 W/CRASH_MANAGER(16506): worker.c: worker_job(1199) > 1116399676561148778894
