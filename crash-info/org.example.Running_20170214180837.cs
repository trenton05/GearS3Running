S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: runner
PID: 21695
Date: 2017-02-14 18:08:37-0600
Executable File Path: /opt/usr/apps/org.example.Running/bin/runner
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21695, uid 5000)

Register Information
r0   = 0x0547f0e9, r1   = 0x0547f0e8
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffb48b20
r6   = 0xf5cb2022, r7   = 0x0547f0e9
r8   = 0x0000006e, r9   = 0x00000000
r10  = 0xf5cb1fe5, fp   = 0xffb48b14
ip   = 0xffb48c44, sp   = 0xffb485a8
lr   = 0xf6e15e8c, pc   = 0xf6e4b0b4
cpsr = 0x60000010

Memory Information
MemTotal:   620364 KB
MemFree:     28960 KB
Buffers:      4744 KB
Cached:      98328 KB
VmPeak:     132384 KB
VmSize:     132380 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31420 KB
VmRSS:       31416 KB
VmData:      47664 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43944 KB
VmPTE:         160 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 21695 TID = 21695
21695 21770 21777 21778 21779 

Maps Information
ef66e000 ef679000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
ef701000 eff00000 rw-p [stack:21779]
eff01000 f0700000 rw-p [stack:21778]
f0701000 f0f00000 rw-p [stack:21777]
f1006000 f1008000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
f1010000 f1011000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
f1019000 f1021000 r-xp /usr/lib/libfeedback.so.0.1.4
f10bb000 f18ba000 rw-p [stack:21770]
f18cf000 f18d1000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f18d9000 f18dd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f18e8000 f18e9000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
f18f1000 f18f4000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f18fc000 f1900000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f22f0000 f22f2000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f22fa000 f2311000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f231e000 f2323000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f232b000 f2336000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f265e000 f2750000 r-xp /usr/lib/libCOREGL.so.4.0
f2769000 f276d000 r-xp /usr/lib/libogg.so.0.7.1
f2775000 f2797000 r-xp /usr/lib/libvorbis.so.0.4.3
f279f000 f27a4000 r-xp /usr/lib/libsystem.so.0.0.0
f27ae000 f27b4000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f27bc000 f27cb000 r-xp /usr/lib/libmdm-common.so.1.1.22
f27d4000 f281b000 r-xp /usr/lib/libsndfile.so.1.0.26
f2827000 f2870000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2879000 f287e000 r-xp /usr/lib/libjson.so.0.0.1
f2886000 f2889000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2891000 f2897000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f289f000 f28aa000 r-xp /usr/lib/libresourced.so.0.2.96
f28b2000 f28b3000 r-xp /usr/lib/librd-network.so.0.2.96
f28bb000 f28bc000 r-xp /usr/lib/libresponse.so.0.2.96
f28c4000 f28c9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f28d2000 f28d9000 r-xp /usr/lib/libminizip.so.1.0.0
f28e1000 f28e3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f28eb000 f28f2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f28fb000 f2900000 r-xp /usr/lib/libstorage.so.0.1
f2908000 f290d000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f2915000 f2917000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f291f000 f2940000 r-xp /usr/lib/libexif.so.12.3.3
f2953000 f296c000 r-xp /usr/lib/libnetwork.so.0.0.0
f2974000 f297a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f2983000 f29cb000 r-xp /usr/lib/libmdm.so.1.2.62
f29cc000 f29d9000 r-xp /usr/lib/libail.so.0.1.0
f29e2000 f29e5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f29ed000 f2a25000 r-xp /usr/lib/libpulse.so.0.16.2
f2a26000 f2a29000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2a31000 f2a92000 r-xp /usr/lib/libasound.so.2.0.0
f2a9c000 f2ab6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2abe000 f2ac5000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2acd000 f2ad1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2ad9000 f2add000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2ae6000 f2ae8000 r-xp /usr/lib/libttrace.so.1.1
f4388000 f4389000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4392000 f4395000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f439d000 f43bf000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f43c8000 f43cd000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f43d5000 f4425000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f442b000 f4434000 r-xp /usr/lib/libcom-core.so.0.0.1
f443d000 f4447000 r-xp /usr/lib/libspdy.so.0.0.0
f4450000 f4456000 r-xp /usr/lib/libxcb-render.so.0.0.0
f445e000 f445f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f4468000 f4477000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f4480000 f448a000 r-xp /usr/lib/libsensord-shared.so
f4492000 f44a2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f44aa000 f44c3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f44cb000 f44e1000 r-xp /usr/lib/libtts.so
f44ea000 f44f5000 r-xp /usr/lib/libtbm.so.1.0.0
f44fd000 f4516000 r-xp /usr/lib/libstt.so
f451e000 f4535000 r-xp /usr/lib/libmmfsound.so.0.1.0
f4547000 f454c000 r-xp /usr/lib/libmemenv.so.1.1.0
f4554000 f4590000 r-xp /usr/lib/libleveldb.so.1.1.0
f4599000 f45a6000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f45af000 f45b1000 r-xp /usr/lib/libdri2.so.0.0.0
f45b9000 f45c4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f45d1000 f45d8000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f45e0000 f4609000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f4612000 f4616000 r-xp /usr/lib/libEGL.so.1.4
f4626000 f4637000 r-xp /usr/lib/libGLESv2.so.2.0
f4647000 f4655000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f465e000 f4676000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f467f000 f4688000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f4690000 f46d1000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f46da000 f4775000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f4781000 f4789000 r-xp /usr/lib/libdrm.so.2.4.0
f4791000 f4897000 r-xp /usr/lib/libicuuc.so.57.1
f48ad000 f4a35000 r-xp /usr/lib/libicui18n.so.57.1
f4a45000 f4a68000 r-xp /usr/lib/libui-extension.so.0.1.0
f4a71000 f4a83000 r-xp /usr/lib/libefl-assist.so.0.1.0
f4a8b000 f4a93000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4a9b000 f4aad000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f4ab5000 f4ab8000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4ac0000 f4ad3000 r-xp /usr/lib/libwidget_service.so.1.0.0
f4adc000 f4b28000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4b32000 f4b33000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4b3b000 f4bf3000 r-xp /usr/lib/libcairo.so.2.11200.14
f4bfe000 f4c03000 r-xp /usr/lib/libctx-client.so.0.8.3
f4c0b000 f4c12000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4c1a000 f4c44000 r-xp /usr/lib/libsensor.so.1.9.3
f4c4d000 f4c87000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4c90000 f5b54000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5c3a000 f5c5b000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c63000 f5c6f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5c78000 f5c7d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5c85000 f5c8a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5c92000 f5ca0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5ca9000 f5cb3000 r-xp /opt/usr/apps/org.example.Running/bin/runner
f5e56000 f5e60000 r-xp /lib/libnss_files-2.13.so
f5e69000 f5f38000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5f4e000 f5f72000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5f7b000 f5f81000 r-xp /usr/lib/libappsvc.so.0.1.0
f5f89000 f5f8d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5f9a000 f5fa5000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5fad000 f5faf000 r-xp /usr/lib/libiniparser.so.0
f5fb8000 f5fbd000 r-xp /usr/lib/libappcore-common.so.1.1
f5fc5000 f5fc7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5fd0000 f5fd4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5fe1000 f5fe3000 r-xp /usr/lib/libXau.so.6.0.0
f5feb000 f5ff2000 r-xp /lib/libcrypt-2.13.so
f6022000 f6024000 r-xp /usr/lib/libiri.so
f602d000 f61d6000 r-xp /usr/lib/libcrypto.so.1.0.0
f61f6000 f623d000 r-xp /usr/lib/libssl.so.1.0.0
f6249000 f6277000 r-xp /usr/lib/libidn.so.11.5.44
f627f000 f6288000 r-xp /usr/lib/libcares.so.2.1.0
f6292000 f62a5000 r-xp /usr/lib/libxcb.so.1.1.0
f62ae000 f62b1000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f62b9000 f62bb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f62c4000 f6390000 r-xp /usr/lib/libxml2.so.2.7.8
f639d000 f639f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f63a8000 f63ad000 r-xp /usr/lib/libffi.so.5.0.10
f63b5000 f63b6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f63be000 f63c1000 r-xp /lib/libattr.so.1.1.0
f63c9000 f645d000 r-xp /usr/lib/libstdc++.so.6.0.16
f6470000 f648d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6497000 f64af000 r-xp /usr/lib/libpng12.so.0.50.0
f64b7000 f64cd000 r-xp /lib/libexpat.so.1.6.0
f64d7000 f651b000 r-xp /usr/lib/libcurl.so.4.3.0
f6524000 f652e000 r-xp /usr/lib/libXext.so.6.4.0
f6537000 f653b000 r-xp /usr/lib/libXtst.so.6.1.0
f6543000 f6549000 r-xp /usr/lib/libXrender.so.1.3.0
f6551000 f6557000 r-xp /usr/lib/libXrandr.so.2.2.0
f655f000 f6560000 r-xp /usr/lib/libXinerama.so.1.0.0
f6569000 f6572000 r-xp /usr/lib/libXi.so.6.1.0
f657a000 f657d000 r-xp /usr/lib/libXfixes.so.3.1.0
f6585000 f6587000 r-xp /usr/lib/libXgesture.so.7.0.0
f658f000 f6591000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6599000 f659b000 r-xp /usr/lib/libXdamage.so.1.1.0
f65a3000 f65aa000 r-xp /usr/lib/libXcursor.so.1.0.2
f65b2000 f65b5000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f65bd000 f65c1000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f65ca000 f65cf000 r-xp /usr/lib/libecore_fb.so.1.7.99
f65d8000 f66b9000 r-xp /usr/lib/libX11.so.6.3.0
f66c4000 f66e7000 r-xp /usr/lib/libjpeg.so.8.0.2
f66ff000 f6715000 r-xp /lib/libz.so.1.2.5
f671d000 f671f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6727000 f679c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f67a6000 f67c0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67c8000 f67fc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6805000 f68d8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68e3000 f68f3000 r-xp /lib/libresolv-2.13.so
f68f7000 f690f000 r-xp /usr/lib/liblzma.so.5.0.3
f6917000 f691a000 r-xp /lib/libcap.so.2.21
f6922000 f6951000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6959000 f695a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6962000 f6968000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6970000 f6987000 r-xp /usr/lib/liblua-5.1.so
f6990000 f6997000 r-xp /usr/lib/libembryo.so.1.7.99
f699f000 f69a5000 r-xp /lib/librt-2.13.so
f69ae000 f6a04000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6a11000 f6a67000 r-xp /usr/lib/libfreetype.so.6.11.3
f6a73000 f6a9b000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a9c000 f6ae1000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6aea000 f6afd000 r-xp /usr/lib/libfribidi.so.0.3.1
f6b05000 f6b1f000 r-xp /usr/lib/libecore_con.so.1.7.99
f6b28000 f6b31000 r-xp /usr/lib/libedbus.so.1.7.99
f6b39000 f6b89000 r-xp /usr/lib/libecore_x.so.1.7.99
f6b8b000 f6b94000 r-xp /usr/lib/libvconf.so.0.2.45
f6b9c000 f6bad000 r-xp /usr/lib/libecore_input.so.1.7.99
f6bb5000 f6bba000 r-xp /usr/lib/libecore_file.so.1.7.99
f6bc2000 f6be4000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6bed000 f6c2e000 r-xp /usr/lib/libeina.so.1.7.99
f6c37000 f6c50000 r-xp /usr/lib/libeet.so.1.7.99
f6c61000 f6cca000 r-xp /lib/libm-2.13.so
f6cd3000 f6cd9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ce2000 f6ce3000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ceb000 f6d0e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d16000 f6d1b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d23000 f6d4d000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d56000 f6d6d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d75000 f6d80000 r-xp /lib/libunwind.so.8.0.1
f6dad000 f6dcb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6dd5000 f6ef9000 r-xp /lib/libc-2.13.so
f6f07000 f6f0f000 r-xp /lib/libgcc_s-4.6.so.1
f6f10000 f6f14000 r-xp /usr/lib/libsmack.so.1.0.0
f6f1d000 f6f23000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6f2b000 f6ffb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ffc000 f705a000 r-xp /usr/lib/libedje.so.1.7.99
f7064000 f707b000 r-xp /usr/lib/libecore.so.1.7.99
f7092000 f7160000 r-xp /usr/lib/libevas.so.1.7.99
f7185000 f72c1000 r-xp /usr/lib/libelementary.so.1.7.99
f72d8000 f72ec000 r-xp /lib/libpthread-2.13.so
f72f7000 f72f9000 r-xp /usr/lib/libdlog.so.0.0.0
f7301000 f7304000 r-xp /usr/lib/libbundle.so.0.1.22
f730c000 f730e000 r-xp /lib/libdl-2.13.so
f7317000 f7324000 r-xp /usr/lib/libaul.so.0.1.0
f7336000 f733c000 r-xp /usr/lib/libappcore-efl.so.1.1
f7345000 f7349000 r-xp /usr/lib/libsys-assert.so
f7352000 f736f000 r-xp /lib/ld-2.13.so
f7378000 f737d000 r-xp /usr/bin/launchpad-loader
f77e8000 f7a1c000 rw-p [heap]
ffb29000 ffb4a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21695)
Call Stack Count: 1
 0: strlen + 0x4 (0xf6e4b0b4) [/lib/libc.so.6] + 0x760b4
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
W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:08:37.081-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(173) > [1;40;33mSHealth Capability message[0;m
02-14 18:08:37.081-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(debug_wearable_message), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.081-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(debug_wearable_message) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.081-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : debug_wearable_message error
02-14 18:08:37.091-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24460) > 
02-14 18:08:37.091-0600 E/WMS     ( 2479): ==========
02-14 18:08:37.091-0600 E/WMS     ( 2479): ##WMS RECEIVED : mgr_host_status_res
02-14 18:08:37.091-0600 E/WMS     ( 2479): ==========
02-14 18:08:37.091-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17075) > type : sync
02-14 18:08:37.091-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17078) > preinstalled: true
02-14 18:08:37.091-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:08:37.091-0600 E/WMS     ( 2479): ==========
02-14 18:08:37.091-0600 E/WMS     ( 2479): ##WMS SEND : mgr_status_exchange_done
02-14 18:08:37.091-0600 E/WMS     ( 2479): ==========
02-14 18:08:37.091-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 73 MAX Buffer Size: 61440
02-14 18:08:37.091-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_get_device_status(873) > Host device vendor: ZTE
02-14 18:08:37.091-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.091-0600 W/SHealthService( 3446): SAPCapabilityManager.cpp: OnSAPCapabilityMessageReceived(1428) > [1;40;33mHost SHealth version : 5410005.000000[0;m
02-14 18:08:37.091-0600 W/SHealthCommon( 3446): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 0.000000[0;m
02-14 18:08:37.091-0600 W/APP_SHORTCUT_WIDGET( 2920): main.c: _vendor_changed_cb(441) >  vendor : ZTE
02-14 18:08:37.091-0600 E/wnoti-service( 3108): wnoti-sap-client.c: _get_vendor_cb(3568) > vendor : ZTE, vendor_type : 1
02-14 18:08:37.101-0600 W/SHealthCommon( 3446): PreferenceManager.cpp: SetMobileSHealthVersion(1021) > [1;35mMobileSHealthVersion: 5410005.000000[0;m
02-14 18:08:37.101-0600 I/W_INDICATOR( 2713): windicator.c: windicator_is_lo_connected(945) > [windicator_is_lo_connected:945] Connected target vendor : ZTE
02-14 18:08:37.101-0600 W/W_INDICATOR( 2713): windicator.c: _windicator_lo_cb(500) > [_windicator_lo_cb:500] LO is NOT Connected, so change layout to default layout (Show all button)
02-14 18:08:37.111-0600 W/MM_CAMCORDER(21694): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
02-14 18:08:37.111-0600 W/MM_CAMCORDER(21694): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
02-14 18:08:37.111-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_get_device_status(888) > host mcc [310], mnc [410]
02-14 18:08:37.111-0600 E/WMS     ( 2479): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
02-14 18:08:37.111-0600 E/WMS     ( 2479): wms_xml_util.c: wms_xml_util_get_nodeset(62) > No result
02-14 18:08:37.111-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.121-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_sync_host_status(1247) > host platform version: 7.0
02-14 18:08:37.121-0600 I/capability-manager(21711): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
02-14 18:08:37.121-0600 I/capability-manager(21711): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
02-14 18:08:37.121-0600 I/efl-extension(21694): efl_extension.c: eext_mod_init(40) > Init
02-14 18:08:37.121-0600 W/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_wms_host_status_vendor_changed_cb(329) > vendor: ZTE.
02-14 18:08:37.121-0600 I/wnotib  ( 2797): w-notification-board-empty-panel.c: _wnb_empty_panel_message_receive(59) > type: 24
02-14 18:08:37.121-0600 I/wnotib  ( 2797): w-notification-board-empty-panel.c: _wnb_ep_set_texts(345) > is_connected_vendor_LO: 0, is_standalone_mode: 0
02-14 18:08:37.131-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_value_int(463) > Enter [system_settings_get_value_int]
02-14 18:08:37.131-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-14 18:08:37.131-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=3
02-14 18:08:37.131-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2797): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 3, key = 3, type = 1
02-14 18:08:37.131-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_sync_host_status(1435) > Host telephony feature is supported - enable call app
02-14 18:08:37.151-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_sync_host_status(1487) > vendor[ ZTE ], support.email.sync[ false ]
02-14 18:08:37.161-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_enable(2552) > enable pkg[com.samsung.call] start
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): clock_view_indicator.c: _view_remove_by_type(267) > removed:3
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): clock_indicator.c: clock_indicator_pop(364) > icon:3(0) is popped from clock indicator
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): cfwd.c: cfwd_get_icon_status(362) > 
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): ============================
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): multi_sim_category:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): multi_sim_model:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): support_callforward_auto:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): conn_status:1
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): remote_call_forward_auto:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): auto_call_forward_status:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): support_callforward_reverse:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): reverse_call_forward_auto:0
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): fwd_type:ARS
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): ============================
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): 
02-14 18:08:37.161-0600 W/W_HOME  ( 2797): clock_view_indicator.c: _view_call_fw_icon(136) > call fwd status:0
02-14 18:08:37.171-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.201-0600 W/SHealthService( 3446): SAPCapabilityManager.cpp: CastHostTrackerFeatureCapabilityUpdatedEvent(1376) > [1;35mCastHostTrackerFeatureCapabilityUpdatedEvent[0;m
02-14 18:08:37.201-0600 W/SHealthService( 3446): WaterCaffeineController.cpp: OnHostTrackerFeatureCapabilityUpdated(130) > [1;35misHostSupportWaterMinus: 1, isHostSupportCaffeineMinus: 1, isHostSupportWaterAmount : 1, isHostSupportCaffeineAmount : 1[0;m
02-14 18:08:37.211-0600 W/SHealthService( 3446): DirectShareController.cpp: OnHostTrackerFeatureCapabilityUpdated(260) > [1;40;33m[tracker_type] is not available in capability. Set default SPORT:[1,2,3] only.[0;m
02-14 18:08:37.211-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(together_prod_list_support), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.211-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(together_prod_list_support) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.211-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : together_prod_list_support error
02-14 18:08:37.211-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.211-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(host_together_supported), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.211-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(host_together_supported) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.211-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : host_together_supported error
02-14 18:08:37.221-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.221-0600 D/UIB_APP (21695): Heart: 0.000000, 0.000000, 0.000000, 0.000000
02-14 18:08:37.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(host_together_supported), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(host_together_supported) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : host_together_supported error
02-14 18:08:37.221-0600 W/SHealthService( 3446): SocialController.cpp: OnHostTrackerFeatureCapabilityUpdated(686) > [1;40;33mmNegotiatedFeatureCapabilityVersion[1010], hostChallengeNudgeListSupport[0], hostServerSyncTriggerSupport[1][0;m
02-14 18:08:37.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(disclaimer), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(disclaimer) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_boolean(1173) > preference_get_boolean(3446) : disclaimer error
02-14 18:08:37.231-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.231-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [382][0;m
02-14 18:08:37.231-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:08:37.231-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:08:37.231-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f370030000efc925317b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e736f6369616c222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e736f6369616c222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a203131342c20227479706522203a20224d455353414745222c2022626f647922203a2022483473494141414141414141413674575543704c4c53724f7a4d3954557242534d4451774e4e42525545724c4c30704f6a53387453456b735351554a5679736f4a536158514e556f75666b484f627647687761344f49613478676535426f6136426f636f4158575656426141565373427453556d4a5259444f62554b74514330576a41475951414141413d3d22207d0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:08:37.231-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:08:37.231-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000070030000028ba5687b20226d65737361676522203a202252455155455354222c202273656e64657222203a2022636f6d2e73616d73756e672e74697a656e676561722e6170702e736865616c74682e736f6369616c222c2022726563656976657222203a2022636f6d2e73616d73756e672e6d6f62696c652e6170702e736865616c74682e736f6369616c222c202276657273696f6e22203a20352e303039393939393939393939393939382c202264657669636522203a20223130303338222c202273657175656e63655f6e756d22203a203131342c20227479706522203a20224d455353414745222c2022626f647922203a2022483473494141414141414141413674575543704c4c53724f7a4d3954557242534d4451774e4e42525545724c4c30704f6a53387453456b735351554a5679736f4a536158514e556f75666b484f627647687761344f49613478676535426f6136426f636f4158575656426141565373427453556d4a5259444f62554b74514330576a41475951414141413d3d22207d0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000
02-14 18:08:37.241-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [382][0;m
02-14 18:08:37.241-0600 W/SHealthService( 3446): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
02-14 18:08:37.241-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
02-14 18:08:37.241-0600 W/SHealthService( 3446): CommonSyncStorage.cpp: RecoverCommonSyncDuration(244) > [1;35mUpdated all 'shealth_common_sync_duration' start_time to 1484460000000.000000[0;m
02-14 18:08:37.241-0600 W/SHealthService( 3446): CommonSyncStorage.cpp: RecoverCommonSyncDurationThatHasEndtimeBiggerThanCurrentTime(298) > [1;35mUpdated all 'shealth_common_sync_duration' end_time to 1487117317251.000000[0;m
02-14 18:08:37.241-0600 W/SHealthService( 3446): CommonSyncStorage.cpp: RemoveCommonSyncDurationThatHasStartTimeBiggerThanEndTime(328) > [1;35mRemoved all where start_time is bigger than end_time[0;m
02-14 18:08:37.241-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:08:37.241-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:08:37.241-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f380030000efc9253134bea9a2d8c873033b423fb9e0d409da68771256699e54a657b46e6cd8344ac5f9002655f1c9af818dbc48d5e48a3b7983f6b3742180899413fe5292987fd4af4c3adf02f4dbdbae3d0aa457025f4bcaab63e8f47b9c68bbc7f629550bbeabb4cf5b845c33c60f01ed79a540e0689b8c4c11956a57b8970e5609ad26fbc5104171ea0359dd238c1f86e68fc13adf3998b9ad45bd6adab1565b12a71d17f06c8c910d00dd0d95cd794e7af9f925cc7a594dfce892287434e4c66adbb966befd90ce743ce3fc038ba30f94cfa231dfc8a16885dd41049e7ef154c7cebe58dc888a2d1f0b3276488b09df28027f916d22c5e33a2a353a42bcd69fc619a59b32d1a38d5b9dd45c8cc3a1fcd807a147206009022279aca2ce2429e3627efc50d708c78c9cbb0e62f9c6a3b4d363fa55ac795e73bed4bbdd216e5a6b3c393a2b8933cf13d564c8847bdb017e527f5282d56940df6a58ed9e9b9973522008450f66ba4551f34ad578e6896616bfc4360de2a602b5536ae5b5a176afbf69886516965eefe4fee8615b5e7e3ac82781e724be652e2307ede9041fcfcd2d7797880b4cb830d159d2a515e2a71b1bef44d960e2bf4b1176e02fcb9eccdf36e4cb974debbe01c16f28726eb30000004ed19f7d4766be3c091dfe18afba8f17f2301822fae5
02-14 18:08:37.241-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:08:37.241-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba56834bea9a2d8c873033b423fb9e0d409da68771256699e54a657b46e6cd8344ac5f9002655f1c9af818dbc48d5e48a3b7983f6b3742180899413fe5292987fd4af4c3adf02f4dbdbae3d0aa457025f4bcaab63e8f47b9c68bbc7f629550bbeabb4cf5b845c33c60f01ed79a540e0689b8c4c11956a57b8970e5609ad26fbc5104171ea0359dd238c1f86e68fc13adf3998b9ad45bd6adab1565b12a71d17f06c8c910d00dd0d95cd794e7af9f925cc7a594dfce892287434e4c66adbb966befd90ce743ce3fc038ba30f94cfa231dfc8a16885dd41049e7ef154c7cebe58dc888a2d1f0b3276488b09df28027f916d22c5e33a2a353a42bcd69fc619a59b32d1a38d5b9dd45c8cc3a1fcd807a147206009022279aca2ce2429e3627efc50d708c78c9cbb0e62f9c6a3b4d363fa55ac795e73bed4bbdd216e5a6b3c393a2b8933cf13d564c8847bdb017e527f5282d56940df6a58ed9e9b9973522008450f66ba4551f34ad578e6896616bfc4360de2a602b5536ae5b5a176afbf69886516965eefe4fee8615b5e7e3ac82781e724be652e2307ede9041fcfcd2d7797880b4cb830d159d2a515e2a71b1bef44d960e2bf4b1176e02fcb9eccdf36e4cb974debbe01c16f28726eb30000004ed19f7d4766be3c091dfe18afba8f17f2301822fae5105
02-14 18:08:37.271-0600 E/PKGMGR_SERVER(21784): pkgmgr-server.c: main(2227) > package manager server start
02-14 18:08:37.281-0600 W/SHealthService( 3446): CommonSyncStorage.cpp: RecoverCommonSyncDurationForSyncTimeException(273) > [1;35mUpdated syncTimeException true records endtime to [1484460000000.000000][0;m
02-14 18:08:37.281-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncStart(175) > [1;35mRequest cpu lock[0;m
02-14 18:08:37.281-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
02-14 18:08:37.361-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(maximum_long_term_sync_score), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.361-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(maximum_long_term_sync_score) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.361-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_double(1214) > preference_get_double(3446) : maximum_long_term_sync_score error
02-14 18:08:37.361-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_check_retry_err(507) > key(chunk_per_hour), check retry err: -21/(2/No such file or directory).
02-14 18:08:37.361-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: _preference_get_key(1101) > _preference_get_key(chunk_per_hour) step(-17825744) failed(2 / No such file or directory)
02-14 18:08:37.361-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3446): preference.c: preference_get_int(1132) > preference_get_int(3446) : key(chunk_per_hour) error
02-14 18:08:37.361-0600 W/SHealthService( 3446): CommonSyncMakingTableInfo.cpp: GetStartOfTImeByScoreV45(212) > [1;40;33mstartTime[1487117316980.000000], endTime[1487117317247.000000], maxiumScore[3145728], chunkPerHour[1][0;m
02-14 18:08:37.361-0600 W/SHealthService( 3446): CommonSyncMakingTableInfo.cpp: GetStartOfTImeByScoreV45(223) > [1;40;33mestimateStartTime[1487116800000.000000], scoreStartTime[1487117316980.000000], scoreEndTime[1487117317247.000000], score[1890.000000][0;m
02-14 18:08:37.361-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:08:37.371-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_enable(2638) > enable pkg finish, ret=[0]
02-14 18:08:37.371-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_disable(2645) > disable pkg[com.samsung.wemail] start
02-14 18:08:37.371-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncStart(228) > [1;35mRelease cpu lock[0;m
02-14 18:08:37.371-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncStart(234) > [1;35mRequest cpu lock[0;m
02-14 18:08:37.381-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [179999][0;m
02-14 18:08:37.391-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(169) > [1;40;33mstarTime: 1487117316980.000000, endTime: 1487117317247.000000, isLastChunk: 0, isMobileSHealthReset&sendMobileData: 1[0;m
02-14 18:08:37.391-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.411-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.411-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakeHeartRateJsonArray(755) > [1;40;33mHeartRate is empty[0;m
02-14 18:08:37.411-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakePedoStepCountJsonArray(833) > [1;40;33mpedo step is empty[0;m
02-14 18:08:37.411-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakePedoEventJsonArray(885) > [1;40;33mpedo event is empty[0;m
02-14 18:08:37.421-0600 W/SHealthService( 3446): SAPV45MessageBuilder.cpp: MakeCommonSyncRequestMsg(325) > [1;40;33mGEAR_SYNC_MSG [ action : SYNC_DATA ][ device : Gear S3, device_type : 10038, version : 4.510000, start_time : 1487117316980, end_time : 1487117317247, last_sync_time : 1487117234983, is_last_chunk : 0, reset_time : 1486533600000 ] [size: 2648][0;m
02-14 18:08:37.421-0600 W/SHealthCommon( 3446): SystemUtil.cpp: GetDeviceNickName(624) > [1;40;33mDevice Nick Name [Solis][0;m
02-14 18:08:37.421-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(423) > [1;40;33msend before message length [1144][0;m
02-14 18:08:37.501-0600 W/SHealthService( 3446): SAP.cpp: SAPClientSend(440) > [1;40;33msend data success !! message length = [1144][0;m
02-14 18:08:37.501-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:08:37.501-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:08:37.501-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] e803e0f370030000efc9253178da8d9349afab461085ffca95b78e0c6676a4b76863c0a631e001336c22689ac9cc3344f9eff17d4f91b2c822b53ca7ead329a9eacfaf4d81bbce8ff1e6ebf7afcd5dba59d2e3b9f9ed6bd3e132c4ed4f1555c5aef38b6e28e35d9faeb88cb1dfeefcbade7509f6f33ed94d1fc10f72bceb9612157ef9e1b5df9016239c8eff81f1cbb0add2f07f413ef35d5a95df0c764792877f97f0f1433ca6e857fe3d49d2c2aff4cd804b84ff2887e2dbd9efd98fda2ff5afbe137882efb6a00a979fc299e92ee09f62297bb2b9ec7a14156772725ab228bdcfc85769e726de63aa1b9aa606da8d07e2b17f1741e03403b70d4991ed63e5395fee1047dbc58ca88b791294c8d50d70b52f5af1bae7c3540cf18408e85c5a7b6b453a8d89e8b02f688a18823538da04704799663190f9c221540331212a39405ea5907acd0768ecdb704a92042434498f37af4f8f4926c35930cfd9ddf1bddca5e665850af2af8cf8cc17e975947d34cbf9b9705b6bd2336384e3b64941a21b8e04fd009e203c707d6488567f531c493cc5d6365033291123353b182c4b317745879e437df6b5c2aee1015db5bade437b6458064fd570c89103a4133683f92a4c8d86dafd02baec184f2c7b7b2ec3954458d94236100d3a3ef0d09752be2fc545a02866e04c36c89dca
02-14 18:08:37.511-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:08:37.511-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000070030000028ba56878da8d9349afab461085ffca95b78e0c6676a4b76863c0a631e001336c22689ac9cc3344f9eff17d4f91b2c822b53ca7ead329a9eacfaf4d81bbce8ff1e6ebf7afcd5dba59d2e3b9f9ed6bd3e132c4ed4f1555c5aef38b6e28e35d9faeb88cb1dfeefcbade7509f6f33ed94d1fc10f72bceb9612157ef9e1b5df9016239c8eff81f1cbb0add2f07f413ef35d5a95df0c764792877f97f0f1433ca6e857fe3d49d2c2aff4cd804b84ff2887e2dbd9efd98fda2ff5afbe137882efb6a00a979fc299e92ee09f62297bb2b9ec7a14156772725ab228bdcfc85769e726de63aa1b9aa606da8d07e2b17f1741e03403b70d4991ed63e5395fee1047dbc58ca88b791294c8d50d70b52f5af1bae7c3540cf18408e85c5a7b6b453a8d89e8b02f688a18823538da04704799663190f9c221540331212a39405ea5907acd0768ecdb704a92042434498f37af4f8f4926c35930cfd9ddf1bddca5e665850af2af8cf8cc17e975947d34cbf9b9705b6bd2336384e3b64941a21b8e04fd009e203c707d6488567f531c493cc5d6365033291123353b182c4b317745879e437df6b5c2aee1015db5bade437b6458064fd570c89103a4133683f92a4c8d86dafd02baec184f2c7b7b2ec3954458d94236100d3a3ef0d09752be2fc545a02866e04c36c89dca58e
02-14 18:08:37.511-0600 W/SHealthService( 3446): SHealthServiceProxy.cpp: OnHostSendSuccess(148) > [1;35mmessage is sent successfully[0;m
02-14 18:08:37.521-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: OnHostMessageProgress(464) > [1;35msync progress [0][0;m
02-14 18:08:37.521-0600 E/PKGMGR_SERVER(21785): pkgmgr-server.c: queue_job(1966) > ENABLE_PKG start, pkgid=[com.samsung.call]
02-14 18:08:37.521-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:08:37.531-0600 E/PKGMGR  ( 2479): pkgmgr.c: pkgmgr_client_disable(2731) > disable pkg finish, ret=[0]
02-14 18:08:37.531-0600 E/PKGMGR_SERVER(21786): pkgmgr-server.c: queue_job(1975) > DISABLE_PKG start, pkgid=[com.samsung.wemail]
02-14 18:08:37.561-0600 I/CAPI_TELEPHONY( 2479): telephony_sim.c: telephony_sim_get_operator(170) > SIM operator: [310410]
02-14 18:08:37.561-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(289) > mccMnc : ____
02-14 18:08:37.601-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncStart(281) > [1;35mRelease cpu lock[0;m
02-14 18:08:37.721-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 437[0;m
02-14 18:08:37.721-0600 E/PKGMGR_STATE(21785): pkg_state.c: __pkg_state_enable_pkg(339) > start enable_pkg : pkgid = com.samsung.call
02-14 18:08:37.721-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:08:37.731-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:08:37.731-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
02-14 18:08:37.741-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:08:37.741-0600 E/PKGMGR_STATE(21785): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.call] is decided not to broadcast.
02-14 18:08:37.741-0600 E/PKGMGR_STATE(21785): pkg_state.c: __pkg_state_enable_pkg(350) > nothing to broadcast.
02-14 18:08:37.741-0600 E/PKGMGR_STATE(21786): pkg_state.c: __pkg_state_disable_pkg(420) > start disable_pkg : pkgid = com.samsung.wemail
02-14 18:08:37.751-0600 E/PKGMGR_SERVER(21784): pkgmgr-server.c: sighandler(486) > child NORMAL exit [21785]
02-14 18:08:37.751-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
02-14 18:08:37.751-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:08:37.751-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:08:37.751-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
02-14 18:08:37.751-0600 W/SHealthService( 3446): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
02-14 18:08:37.751-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
02-14 18:08:37.751-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
02-14 18:08:37.751-0600 W/SHealthService( 3446): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
02-14 18:08:37.761-0600 E/PKGMGR_STATE(21786): pkg_state.c: __make_filtered_pkgid_list(317) > pkgid[com.samsung.wemail] is decided not to broadcast.
02-14 18:08:37.761-0600 E/PKGMGR_STATE(21786): pkg_state.c: __pkg_state_disable_pkg(431) > nothing to broadcast.
02-14 18:08:37.771-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1487117236923,  ] [size: 166][0;m
02-14 18:08:37.771-0600 E/PKGMGR_SERVER(21784): pkgmgr-server.c: sighandler(486) > child NORMAL exit [21786]
02-14 18:08:37.771-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
02-14 18:08:37.771-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(493) > [1;40;33mresponse : SUCCESS[0;m
02-14 18:08:37.781-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(128) > [1;40;33mRELEASE POWER LOCK CPU[0;m
02-14 18:08:37.811-0600 E/EFL     (21695): ecore_x<21695> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=78077349 button=1
02-14 18:08:37.911-0600 E/EFL     (21695): ecore_x<21695> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=78077454 button=1
02-14 18:08:38.051-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(506) > telephony : 1
02-14 18:08:38.051-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(507) > wifi : 1
02-14 18:08:38.051-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(511) > scs : true
02-14 18:08:38.061-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(527) > svoice not disabled
02-14 18:08:38.061-0600 E/PKGMGR_INFO( 2479): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
02-14 18:08:38.061-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(546) > camera : 0
02-14 18:08:38.061-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(552) > gps : 1
02-14 18:08:38.071-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(558) > wps : 1
02-14 18:08:38.071-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(564) > speaker : 1
02-14 18:08:38.081-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(570) > width : 360
02-14 18:08:38.081-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(576) > height : 360
02-14 18:08:38.081-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(582) > barometer : 1
02-14 18:08:38.091-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(588) > magnetometer : 0
02-14 18:08:38.091-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(594) > photometer : 1
02-14 18:08:38.101-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(600) > heartrate : 1
02-14 18:08:38.101-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(606) > ultraviolet : 0
02-14 18:08:38.101-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(612) > irled : 0
02-14 18:08:38.121-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(629) > success get number : 13163050754
02-14 18:08:38.131-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(672) > esim phase : 0
02-14 18:08:38.141-0600 I/WSM     ( 3119): WSM_I [Run, line = 118, thread  = f69c1460] Read request from client. 
02-14 18:08:38.141-0600 I/WSM     ( 3119): WSM_I [Run] Request len 406c 
02-14 18:08:38.141-0600 I/WSM     ( 3119): WSM_D [Run] Request data  =  [len=16492] f803e0f380030000efc9253182abcbe039627fcef07fd3f710ff4524a4af36b658679151f800f44ed194516255b1561888ec510da41a121297032f703cca5af9122c887a3518eb089a32eb792bd09dae938fad863ecdff46cef12c687296259a6170c47cae22239e9bc0d16a0b385f59494829a346f73a349a9a4dc1003a5a4aefeff8186026345786eb355f79bc203b9703780211964e7bff50d95ff7d5e799fc3048841715c418566c9a581b88fbe8d6f2cc7274e9bae17f479f1d20e1f646021954bd2af892bff73d202eec8dca6c105b8a239265878a9794384f5728457be1194f7f9fd961f6c79b90f6aa80522077d02574b0e5edf7c85805bfcd8b68de8edde7279e38f4012793184ea4db9403f30349666f35dc5bd3a4ffcdfce758d9447cb69446fb48d70ad2f4b38b6965c3bcf9ddc589b15e1c1765397c11045e51ced81e179b24f749b55439075add116b56d67838f3b16de904f168001211dbecb422bd39e8a928d7279620e8aab2ce7a7094d7459fba545ac93f618857388d3c6e818e12b865e53982411c9bd9b7948269a02d0610995fce15ed98f59fd1929ac2e204ee7af37fdbc5b6140f9a7248940c6a3a5b61b8d7d388ebf79ec0fcc619bcf9df05d2f9cf2301cc6804d995f2c2e4b4000000cd89508ffdbd5b26276b8019fed9ac176b6789b1d1ca
02-14 18:08:38.141-0600 I/WSM     ( 3119): WSM_I [Run, line = 150] Send reply to client.
02-14 18:08:38.141-0600 I/WSM     ( 3119): WSM_D [Run] Send reply =  [len=16492] 0100000080030000028ba56882abcbe039627fcef07fd3f710ff4524a4af36b658679151f800f44ed194516255b1561888ec510da41a121297032f703cca5af9122c887a3518eb089a32eb792bd09dae938fad863ecdff46cef12c687296259a6170c47cae22239e9bc0d16a0b385f59494829a346f73a349a9a4dc1003a5a4aefeff8186026345786eb355f79bc203b9703780211964e7bff50d95ff7d5e799fc3048841715c418566c9a581b88fbe8d6f2cc7274e9bae17f479f1d20e1f646021954bd2af892bff73d202eec8dca6c105b8a239265878a9794384f5728457be1194f7f9fd961f6c79b90f6aa80522077d02574b0e5edf7c85805bfcd8b68de8edde7279e38f4012793184ea4db9403f30349666f35dc5bd3a4ffcdfce758d9447cb69446fb48d70ad2f4b38b6965c3bcf9ddc589b15e1c1765397c11045e51ced81e179b24f749b55439075add116b56d67838f3b16de904f168001211dbecb422bd39e8a928d7279620e8aab2ce7a7094d7459fba545ac93f618857388d3c6e818e12b865e53982411c9bd9b7948269a02d0610995fce15ed98f59fd1929ac2e204ee7af37fdbc5b6140f9a7248940c6a3a5b61b8d7d388ebf79ec0fcc619bcf9df05d2f9cf2301cc6804d995f2c2e4b4000000cd89508ffdbd5b26276b8019fed9ac176b6789b1d1ca012
02-14 18:08:38.151-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(689) > push : 1
02-14 18:08:38.151-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(700) > auto connection : true
02-14 18:08:38.151-0600 W/SHealthService( 3446): SAPNotificationCallback.cpp: SAPNotiOnDataIndication(49) > [1;35muwServiceHandle:3, uwChannelId:999, uwPayloadLength: 437[0;m
02-14 18:08:38.151-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 0[0;m
02-14 18:08:38.151-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: GetHostMessageInfo(274) > [1;40;33mobject format[0;m
02-14 18:08:38.161-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (responseMessage)[0;m
02-14 18:08:38.171-0600 E/PKGMGR_INFO( 2479): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_destroy_pkginfo(1915) > (handle == NULL) pkginfo handle is NULL
02-14 18:08:38.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (message_type)[0;m
02-14 18:08:38.171-0600 E/WMS     ( 2479): wms_status_manager.c: wms_status_manager_write_wearable_status_xml_file(773) > support hfp : 1
02-14 18:08:38.171-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (capability_type)[0;m
02-14 18:08:38.181-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1825) > 
02-14 18:08:38.181-0600 E/WMS     ( 2479): ==========
02-14 18:08:38.181-0600 E/WMS     ( 2479): ##WMS SEND : mgr_wearable_status_res
02-14 18:08:38.181-0600 E/WMS     ( 2479): ==========
02-14 18:08:38.181-0600 E/WMS     ( 2479): wms_msg_broker.c: wms_msg_broker_send(1841) > Data size: 16517 MAX Buffer Size: 61440
02-14 18:08:38.181-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17110) > need full check 0
02-14 18:08:38.181-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17112) > isFirstConnect[0], is_full_sync[0]
02-14 18:08:38.181-0600 E/WMS     ( 2479): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1211) > wmanager_connected value is already true. but rewrite.
02-14 18:08:38.181-0600 E/wnoti-ancs( 3108): wnoti-ancs.c: wnoti_ancs_ios_connected_status(2585) > pre_connect_status : 0, bap_connected_status : 0
02-14 18:08:38.181-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: _wms_connection_changed_callback(449) > [33m WMS Connected, g_eServiceConnectState = 3[0m
02-14 18:08:38.181-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: _music_control_consumer_control_print_msg_type(105) > [33m[TID:3613]   msg [WMC_SERVICE_WIPC_MSG_ID_CONNECTION_CHANGED][0m
02-14 18:08:38.181-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(241) > [33m[TID:3613]   Device State [0] normal:0 dim:1 off:2[0m
02-14 18:08:38.181-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_msg_process(341) > [33m[TID:3613]   connection state = 1[0m
02-14 18:08:38.181-0600 W/MUSIC_CONTROL_SERVICE( 3613): music-control-consumer-control.c: music_control_consumer_media_changed_ind_request(199) > [33m[TID:3613]   remote mode[1][0m
02-14 18:08:38.181-0600 W/MC_CONSUMER( 3613): wmc-service-consumer.c: wmc_service_consumer_send_data(587) > [33m {"msgId":"music-getattribute-req"}[0m
02-14 18:08:38.181-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_type)[0;m
02-14 18:08:38.181-0600 W/SHealthCommon( 3446): Message.cpp: Get(266) > [1;40;33mIt doesn't have key with name (action_message_feature)[0;m
02-14 18:08:38.181-0600 W/SHealthService( 3446): SAPMessageDispatcher.cpp: Dispatch(200) > [1;40;33mAPP COMMAND MESSAGE!![0;m
02-14 18:08:38.181-0600 W/SHealthService( 3446): AppCmdManager.cpp: OnSAPAppCommand(391) > [1;35mAPP COMMAND MESSAGE RECEIVER: com.samsung.tizengear.app.shealth.wearable.syncmanager, BODY SIZE[208] [0;m
02-14 18:08:38.181-0600 W/SHealthCommon( 3446): JsonMessage.cpp: ParseMessage(139) > [1;40;33mRoot node type : 1[0;m
02-14 18:08:38.181-0600 W/SHealthService( 3446): CpuLock.cpp: CheckAndReset(125) > [1;40;33mREQUEST POWER LOCK CPU [180000][0;m
02-14 18:08:38.211-0600 W/SHealthService( 3446): CommonSyncController.cpp: OnAppCommand(379) > [1;40;33mCommon Sync protocol type : 3[0;m
02-14 18:08:38.211-0600 I/capability-manager(21711): capability_manager_util.c: is_file_exist(120) > File /opt/usr/share/wms/HostStatus.xml Exists
02-14 18:08:38.211-0600 I/capability-manager(21711): capability_manager_xml.c: capability_manager_xml_util_get_device_info(114) > capability_manager_xml_util_get_device_info() called.
02-14 18:08:38.211-0600 W/TWINNINGD( 3105): <_set_number_sync_on_off:36> host_carrier:[ATT] on:[1]
02-14 18:08:38.211-0600 W/WECONN  ( 2534): <__wc_feature_wms_connected_cb:438> priv->wms_connected = 1
02-14 18:08:38.211-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 1
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(414) > network status : 3
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(421) > svc type : 7
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(428) > scs login : 0
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_event.c: _wmanager_connectivity_get(470) > connected via bluetooth
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
02-14 18:08:38.221-0600 W/W_HOME  ( 2797): clock_indicator.c: clock_indicator_pop(364) > icon:5(0) is popped from clock indicator
02-14 18:08:38.221-0600 W/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_connection_state_changed_cb(374) > is_LO: 0, is_connected: 1
02-14 18:08:38.221-0600 E/wnotib  ( 2797): w-notification-board-noti-manager-common.c: wnb_nm_get_category_by_application_id(1192) > No category matched.
02-14 18:08:38.221-0600 W/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_connection_state_changed_cb(383) > No tips notification.
02-14 18:08:38.221-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(406) > [1;40;33mHOST_SYNC_MSG [ action : SYNC_DATA, result : SUCCESS,  ][ version : 4.510000, last_sync_time : 1487117236923,  ] [size: 166][0;m
02-14 18:08:38.221-0600 E/WMS     ( 2479): wms_event_handler.c: _wms_event_handler_signal_to_systemd(1213) > 
02-14 18:08:38.221-0600 E/WMS     ( 2479): ==========
02-14 18:08:38.221-0600 E/WMS     ( 2479): ##WMS WMANAGER CONNECTED : TRUE
02-14 18:08:38.221-0600 E/WMS     ( 2479): ==========
02-14 18:08:38.221-0600 W/WPROXY  ( 3095): net-device.c: __connection_changed_cb(163) > WMS:[1], SAP:[0x1], BAP:[0]
02-14 18:08:38.221-0600 W/WPROXY  ( 3095): net-device.c: __connection_changed_cb(166) > [Ignore] Any connection status is not changed.
02-14 18:08:38.221-0600 W/MSG_CONSUMER( 3489): SapClient.cpp: _onWmsConnectionChanged(810) > [0;35mprevious_status: (1), status: (1)[0;m
02-14 18:08:38.231-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 21695 pgid = 21695
02-14 18:08:38.231-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-14 18:08:38.241-0600 E/WMS     ( 2479): wms_event_handler.c: handle_mgr_host_status_res(17121) > TIMESTAMP saved: 1487117314683B>L?>;BCKCMN
02-14 18:08:38.241-0600 E/WMS     ( 2479): wms_event_handler.c: wms_event_handler_routine(24476) > [mgr_host_status_res] handler success.
02-14 18:08:38.251-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(415) > [1;40;33maction type : SYNC_DATA[0;m
02-14 18:08:38.251-0600 W/SHealthService( 3446): CommonSyncController.cpp: CommonSyncDispather(493) > [1;40;33mresponse : SUCCESS[0;m
02-14 18:08:38.261-0600 W/MSG_CONSUMER( 3489): SapClient.cpp: _onWmsConnectionChanged(813) > [0;35m_onWmsConnectionChanged() is ignored for same status change. prev:(1), cur:(1)[0;m
02-14 18:08:38.311-0600 W/AUL_AMD ( 2555): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-14 18:08:38.311-0600 W/AUL_AMD ( 2555): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-14 18:08:38.311-0600 W/AUL     ( 2555): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2797) status(fg) type(uiapp)
02-14 18:08:38.311-0600 W/STARTER ( 2711): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2797] goes to (3)
02-14 18:08:38.311-0600 E/STARTER ( 2711): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2797)'s state(3)
02-14 18:08:38.311-0600 W/W_INDICATOR( 2713): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(925) > [_dynamic_bluetooth_state_changed_cb:925] isBTOn : 1
02-14 18:08:38.311-0600 W/W_INDICATOR( 2713): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(931) > [_dynamic_bluetooth_state_changed_cb:931] sap connected : 1
02-14 18:08:38.311-0600 W/W_INDICATOR( 2713): windicator_dynamic.c: _dynamic_bluetooth_state_changed_cb(937) > [_dynamic_bluetooth_state_changed_cb:937] sap connectivity type : 1
02-14 18:08:38.371-0600 W/AUL_PAD ( 3358): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-14 18:08:38.371-0600 E/WMS     ( 2479): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
02-14 18:08:38.381-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-14 18:08:38.381-0600 I/AUL_AMD ( 2555): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21695
02-14 18:08:38.381-0600 W/AUL     ( 2555): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21695)
02-14 18:08:38.401-0600 W/W_HOME  ( 2797): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-14 18:08:38.401-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.401-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.401-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.401-0600 W/W_HOME  ( 2797): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-14 18:08:38.411-0600 W/WATCH_CORE( 2884): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-14 18:08:38.411-0600 I/WATCH_CORE( 2884): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _window_visibility_cb(473) > Window [0x2200003] is now visible(0)
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): main.c: _window_visibility_cb(963) > Window [0x2200003] is now visible(0)
02-14 18:08:38.431-0600 I/APP_CORE( 2797): appcore-efl.c: __do_app(453) > [APP 2797] Event: RESUME State: PAUSED
02-14 18:08:38.431-0600 I/CAPI_APPFW_APPLICATION( 2797): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): main.c: _appcore_resume_cb(478) > appcore resume
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): main.c: home_resume(530) > clock/widget resumed
02-14 18:08:38.431-0600 W/W_HOME  ( 2797): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-14 18:08:38.431-0600 I/GATE    ( 2797): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-14 18:08:38.431-0600 I/wnotib  ( 2797): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-14 18:08:38.431-0600 E/wnotib  ( 2797): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-14 18:08:38.431-0600 W/wnotib  ( 2797): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
02-14 18:08:38.461-0600 W/WATCH_CORE( 2884): appcore-watch.c: __widget_resume(1124) > widget_resume
02-14 18:08:38.461-0600 W/AUL     ( 2884): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2884) status(fg) type(watchapp)
02-14 18:08:38.461-0600 I/CAPI_WATCH_APPLICATION( 2884): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-14 18:08:38.461-0600 E/WMS     ( 2479): wms_msg_broker.c: on_broker_buffer_send(307) > Data sending is success.
02-14 18:08:38.491-0600 W/CRASH_MANAGER(21788): worker.c: worker_job(1199) > 112169572756e148711731
