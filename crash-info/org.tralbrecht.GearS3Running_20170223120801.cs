S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: gears3running
PID: 25653
Date: 2017-02-23 12:08:01-0600
Executable File Path: /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25653, uid 5000)

Register Information
r0   = 0xf5c16691, r1   = 0xf5c27848
r2   = 0x00000004, r3   = 0x00000370
r4   = 0xf75575f8, r5   = 0x3e6e6769
r6   = 0xf75535b0, r7   = 0x00000000
r8   = 0x00000041, r9   = 0xf6f5f824
r10  = 0xf742fa28, fp   = 0x00000000
ip   = 0x00000001, sp   = 0xffafd8a8
lr   = 0xf6b65df5, pc   = 0xf4b44ac8
cpsr = 0xa0000010

Memory Information
MemTotal:   620364 KB
MemFree:     53424 KB
Buffers:      3908 KB
Cached:      80564 KB
VmPeak:     133676 KB
VmSize:     133672 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29764 KB
VmRSS:       28740 KB
VmData:      48080 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43872 KB
VmPTE:         160 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 25653 TID = 25653
25653 25735 25743 25744 

Maps Information
eff01000 f0700000 rw-p [stack:25744]
f0701000 f0f00000 rw-p [stack:25743]
f1014000 f1015000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f101d000 f101f000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f1027000 f102b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f1034000 f1037000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f103f000 f1042000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f104a000 f104e000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f1057000 f1856000 rw-p [stack:25735]
f2253000 f2255000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f225d000 f2274000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f2281000 f2286000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f228e000 f2299000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f25c1000 f26b3000 r-xp /usr/lib/libCOREGL.so.4.0
f26cc000 f26d0000 r-xp /usr/lib/libogg.so.0.7.1
f26d8000 f26fa000 r-xp /usr/lib/libvorbis.so.0.4.3
f2702000 f2707000 r-xp /usr/lib/libsystem.so.0.0.0
f2711000 f2717000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f271f000 f272e000 r-xp /usr/lib/libmdm-common.so.1.1.22
f2737000 f277e000 r-xp /usr/lib/libsndfile.so.1.0.26
f278a000 f27d3000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f27dc000 f27e1000 r-xp /usr/lib/libjson.so.0.0.1
f27e9000 f27ec000 r-xp /usr/lib/libtinycompress.so.0.0.0
f27f4000 f27fa000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f2802000 f280d000 r-xp /usr/lib/libresourced.so.0.2.96
f2815000 f2816000 r-xp /usr/lib/librd-network.so.0.2.96
f281e000 f281f000 r-xp /usr/lib/libresponse.so.0.2.96
f2827000 f282c000 r-xp /usr/lib/libproc-stat.so.0.2.96
f2835000 f2837000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f283f000 f2846000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f284f000 f2854000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f285c000 f285e000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f2866000 f2887000 r-xp /usr/lib/libexif.so.12.3.3
f289a000 f28b3000 r-xp /usr/lib/libnetwork.so.0.0.0
f28bb000 f28c1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f28ca000 f2912000 r-xp /usr/lib/libmdm.so.1.2.62
f2913000 f2920000 r-xp /usr/lib/libail.so.0.1.0
f2929000 f292c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2934000 f296c000 r-xp /usr/lib/libpulse.so.0.16.2
f296d000 f2970000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2978000 f29d9000 r-xp /usr/lib/libasound.so.2.0.0
f29e3000 f29fd000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2a05000 f2a0c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2a14000 f2a18000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2a20000 f2a24000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2a2d000 f2a2f000 r-xp /usr/lib/libttrace.so.1.1
f42cf000 f42d0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f42d9000 f42dc000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f42e4000 f4306000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f430f000 f4314000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f431c000 f436c000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f4372000 f437b000 r-xp /usr/lib/libcom-core.so.0.0.1
f4384000 f438e000 r-xp /usr/lib/libspdy.so.0.0.0
f4397000 f439d000 r-xp /usr/lib/libxcb-render.so.0.0.0
f43a5000 f43a6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f43af000 f43be000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f43c7000 f43d1000 r-xp /usr/lib/libsensord-shared.so
f43d9000 f43e9000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f43f1000 f440a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f4412000 f4419000 r-xp /usr/lib/libminizip.so.1.0.0
f4421000 f442c000 r-xp /usr/lib/libtbm.so.1.0.0
f4434000 f444b000 r-xp /usr/lib/libmmfsound.so.0.1.0
f445d000 f4462000 r-xp /usr/lib/libmemenv.so.1.1.0
f446a000 f44a6000 r-xp /usr/lib/libleveldb.so.1.1.0
f44af000 f44bc000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f44c5000 f44c7000 r-xp /usr/lib/libdri2.so.0.0.0
f44cf000 f44da000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f44e7000 f44ee000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f44f6000 f451f000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f4528000 f452c000 r-xp /usr/lib/libEGL.so.1.4
f453c000 f454d000 r-xp /usr/lib/libGLESv2.so.2.0
f455d000 f456b000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f4574000 f458c000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f4595000 f459e000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f45a6000 f45e7000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f45f0000 f468b000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f4697000 f469f000 r-xp /usr/lib/libdrm.so.2.4.0
f46a7000 f47ad000 r-xp /usr/lib/libicuuc.so.57.1
f47c3000 f494b000 r-xp /usr/lib/libicui18n.so.57.1
f495b000 f497e000 r-xp /usr/lib/libui-extension.so.0.1.0
f4987000 f4999000 r-xp /usr/lib/libefl-assist.so.0.1.0
f49a1000 f49a9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f49b1000 f49c3000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f49cb000 f49ce000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f49d6000 f49e9000 r-xp /usr/lib/libwidget_service.so.1.0.0
f49f2000 f4a3e000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4a48000 f4a49000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4a51000 f4b09000 r-xp /usr/lib/libcairo.so.2.11200.14
f4b14000 f4b19000 r-xp /usr/lib/libctx-client.so.0.8.3
f4b21000 f4b28000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4b30000 f4b5a000 r-xp /usr/lib/libsensor.so.1.9.3
f4b63000 f4b9d000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4ba6000 f4bbc000 r-xp /usr/lib/libtts.so
f4bc5000 f4bde000 r-xp /usr/lib/libstt.so
f4be6000 f4beb000 r-xp /usr/lib/libstorage.so.0.1
f4bf3000 f5ab7000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5b9d000 f5bbe000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5bc6000 f5bd2000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5bdb000 f5be0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5be8000 f5bed000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5bf5000 f5c03000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5c0c000 f5c17000 r-xp /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
f5dba000 f5dc4000 r-xp /lib/libnss_files-2.13.so
f5dcd000 f5e9c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5eb2000 f5ed6000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5edf000 f5ee5000 r-xp /usr/lib/libappsvc.so.0.1.0
f5eed000 f5ef1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5efe000 f5f09000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5f11000 f5f13000 r-xp /usr/lib/libiniparser.so.0
f5f1c000 f5f21000 r-xp /usr/lib/libappcore-common.so.1.1
f5f29000 f5f2b000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f5f34000 f5f38000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f5f45000 f5f47000 r-xp /usr/lib/libXau.so.6.0.0
f5f4f000 f5f56000 r-xp /lib/libcrypt-2.13.so
f5f86000 f5f88000 r-xp /usr/lib/libiri.so
f5f91000 f613a000 r-xp /usr/lib/libcrypto.so.1.0.0
f615a000 f61a1000 r-xp /usr/lib/libssl.so.1.0.0
f61ad000 f61db000 r-xp /usr/lib/libidn.so.11.5.44
f61e3000 f61ec000 r-xp /usr/lib/libcares.so.2.1.0
f61f6000 f6209000 r-xp /usr/lib/libxcb.so.1.1.0
f6212000 f6215000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f621d000 f621f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6228000 f62f4000 r-xp /usr/lib/libxml2.so.2.7.8
f6301000 f6303000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f630c000 f6311000 r-xp /usr/lib/libffi.so.5.0.10
f6319000 f631a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6322000 f6325000 r-xp /lib/libattr.so.1.1.0
f632d000 f63c1000 r-xp /usr/lib/libstdc++.so.6.0.16
f63d4000 f63f1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f63fb000 f6413000 r-xp /usr/lib/libpng12.so.0.50.0
f641b000 f6431000 r-xp /lib/libexpat.so.1.6.0
f643b000 f647f000 r-xp /usr/lib/libcurl.so.4.3.0
f6488000 f6492000 r-xp /usr/lib/libXext.so.6.4.0
f649b000 f649f000 r-xp /usr/lib/libXtst.so.6.1.0
f64a7000 f64ad000 r-xp /usr/lib/libXrender.so.1.3.0
f64b5000 f64bb000 r-xp /usr/lib/libXrandr.so.2.2.0
f64c3000 f64c4000 r-xp /usr/lib/libXinerama.so.1.0.0
f64cd000 f64d6000 r-xp /usr/lib/libXi.so.6.1.0
f64de000 f64e1000 r-xp /usr/lib/libXfixes.so.3.1.0
f64e9000 f64eb000 r-xp /usr/lib/libXgesture.so.7.0.0
f64f3000 f64f5000 r-xp /usr/lib/libXcomposite.so.1.0.0
f64fd000 f64ff000 r-xp /usr/lib/libXdamage.so.1.1.0
f6507000 f650e000 r-xp /usr/lib/libXcursor.so.1.0.2
f6516000 f6519000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6521000 f6525000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f652e000 f6533000 r-xp /usr/lib/libecore_fb.so.1.7.99
f653c000 f661d000 r-xp /usr/lib/libX11.so.6.3.0
f6628000 f664b000 r-xp /usr/lib/libjpeg.so.8.0.2
f6663000 f6679000 r-xp /lib/libz.so.1.2.5
f6681000 f6683000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f668b000 f6700000 r-xp /usr/lib/libsqlite3.so.0.8.6
f670a000 f6724000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f672c000 f6760000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6769000 f683c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6847000 f6857000 r-xp /lib/libresolv-2.13.so
f685b000 f6873000 r-xp /usr/lib/liblzma.so.5.0.3
f687b000 f687e000 r-xp /lib/libcap.so.2.21
f6886000 f68b5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68bd000 f68be000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f68c6000 f68cc000 r-xp /usr/lib/libecore_imf.so.1.7.99
f68d4000 f68eb000 r-xp /usr/lib/liblua-5.1.so
f68f4000 f68fb000 r-xp /usr/lib/libembryo.so.1.7.99
f6903000 f6909000 r-xp /lib/librt-2.13.so
f6912000 f6968000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6975000 f69cb000 r-xp /usr/lib/libfreetype.so.6.11.3
f69d7000 f69ff000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6a00000 f6a45000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6a4e000 f6a61000 r-xp /usr/lib/libfribidi.so.0.3.1
f6a69000 f6a83000 r-xp /usr/lib/libecore_con.so.1.7.99
f6a8c000 f6a95000 r-xp /usr/lib/libedbus.so.1.7.99
f6a9d000 f6aed000 r-xp /usr/lib/libecore_x.so.1.7.99
f6aef000 f6af8000 r-xp /usr/lib/libvconf.so.0.2.45
f6b00000 f6b11000 r-xp /usr/lib/libecore_input.so.1.7.99
f6b19000 f6b1e000 r-xp /usr/lib/libecore_file.so.1.7.99
f6b26000 f6b48000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6b51000 f6b92000 r-xp /usr/lib/libeina.so.1.7.99
f6b9b000 f6bb4000 r-xp /usr/lib/libeet.so.1.7.99
f6bc5000 f6c2e000 r-xp /lib/libm-2.13.so
f6c37000 f6c3d000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c46000 f6c47000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c4f000 f6c72000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c7a000 f6c7f000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c87000 f6cb1000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cba000 f6cd1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cd9000 f6ce4000 r-xp /lib/libunwind.so.8.0.1
f6d11000 f6d2f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d39000 f6e5d000 r-xp /lib/libc-2.13.so
f6e6b000 f6e73000 r-xp /lib/libgcc_s-4.6.so.1
f6e74000 f6e78000 r-xp /usr/lib/libsmack.so.1.0.0
f6e81000 f6e87000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6e8f000 f6f5f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f60000 f6fbe000 r-xp /usr/lib/libedje.so.1.7.99
f6fc8000 f6fdf000 r-xp /usr/lib/libecore.so.1.7.99
f6ff6000 f70c4000 r-xp /usr/lib/libevas.so.1.7.99
f70e9000 f7225000 r-xp /usr/lib/libelementary.so.1.7.99
f723c000 f7250000 r-xp /lib/libpthread-2.13.so
f725b000 f725d000 r-xp /usr/lib/libdlog.so.0.0.0
f7265000 f7268000 r-xp /usr/lib/libbundle.so.0.1.22
f7270000 f7272000 r-xp /lib/libdl-2.13.so
f727b000 f7288000 r-xp /usr/lib/libaul.so.0.1.0
f729a000 f72a0000 r-xp /usr/lib/libappcore-efl.so.1.1
f72a9000 f72ad000 r-xp /usr/lib/libsys-assert.so
f72b6000 f72d3000 r-xp /lib/ld-2.13.so
f72dc000 f72e1000 r-xp /usr/bin/launchpad-loader
f73f4000 f769c000 rw-p [heap]
ffade000 ffaff000 rw-p [stack]
End of Maps Information

Callstack Information (PID:25653)
Call Stack Count: 14
 0: (0xf4b44ac8) [/usr/lib/libsensor.so.1] + 0x14ac8
 1: (0xf6ec2fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 2: g_main_context_dispatch + 0xbc (0xf6ec47a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 3: (0xf6fd8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
 4: (0xf6fd3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
 5: (0xf6fd45a7) [/usr/lib/libecore.so.1] + 0xc5a7
 6: ecore_main_loop_begin + 0x30 (0xf6fd4879) [/usr/lib/libecore.so.1] + 0xc879
 7: appcore_efl_main + 0x332 (0xf729db47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
 8: ui_app_main + 0xb0 (0xf5f36421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
 9: uib_app_run + 0xc2 (0xf5c0f61b) [/opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running] + 0x361b
10: main + 0x22 (0xf5c12b03) [/opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running] + 0x6b03
11: (0xf72dda53) [/opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running] + 0x1a53
12: __libc_start_main + 0x114 (0xf6d5085c) [/lib/libc.so.6] + 0x1785c
13: (0xf72dde0c) [/opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running] + 0x1e0c
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
gnal_lcd_status_handler(1235) > Skip the background tick update
02-23 12:07:43.971-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-23 12:07:43.981-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-23 12:07:43.981-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-23 12:07:43.981-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 1
02-23 12:07:43.981-0600 W/W_HOME  ( 2815): event_manager.c: _lcd_off_cb(736) > lcd state: 0
02-23 12:07:43.981-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:07:43.991-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
02-23 12:07:43.991-0600 W/STARTER ( 2748): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
02-23 12:07:43.991-0600 E/STARTER ( 2748): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-23 12:07:43.991-0600 W/STARTER ( 2748): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
02-23 12:07:43.991-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -151127284[0;m
02-23 12:07:43.991-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
02-23 12:07:43.991-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-23 12:07:43.991-0600 W/STARTER ( 2748): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
02-23 12:07:43.991-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
02-23 12:07:43.991-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_context_handler(1302) > Skip the background tick update
02-23 12:07:43.991-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-23 12:07:43.991-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-23 12:07:43.991-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-23 12:07:44.001-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-23 12:07:44.001-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-23 12:07:44.001-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
02-23 12:07:44.001-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-23 12:07:44.001-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-23 12:07:44.001-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
02-23 12:07:44.001-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
02-23 12:07:44.001-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -148844088[0;m
02-23 12:07:44.001-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
02-23 12:07:44.001-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-23 12:07:44.001-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-23 12:07:44.011-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-23 12:07:44.011-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-23 12:07:44.011-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-23 12:07:44.011-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-23 12:07:44.011-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-23 12:07:44.021-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-23 12:07:44.021-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-23 12:07:44.021-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-23 12:07:44.021-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-23 12:07:44.081-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [251171.861128] dpms[3 -> 3]done
02-23 12:07:44.081-0600 I/TDM     ( 1991): 
02-23 12:07:44.091-0600 W/SHealthCommon( 3431): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
02-23 12:07:44.091-0600 W/SHealthService( 3431): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-23 12:07:44.091-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [251171.878632] dpms[3 -> 0]sync[0]
02-23 12:07:44.091-0600 I/TDM     ( 1991): 
02-23 12:07:44.091-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [251171.878833] dpms[0 -> 0]done
02-23 12:07:44.091-0600 I/TDM     ( 1991): 
02-23 12:07:44.121-0600 W/W_INDICATOR( 2749): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
02-23 12:07:44.131-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
02-23 12:07:44.131-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
02-23 12:07:44.131-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
02-23 12:07:44.131-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
02-23 12:07:44.131-0600 E/ALARM_MANAGER( 2748): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(23-2-2017, 12:08:04), repeat(1), interval(20), type(-1073741822)
02-23 12:07:44.141-0600 W/SHealthCommon( 2955): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
02-23 12:07:44.141-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(453) > [APP 25653] Event: PAUSE State: RUNNING
02-23 12:07:44.141-0600 I/CAPI_APPFW_APPLICATION(25653): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
02-23 12:07:44.141-0600 D/UIB_APP (25653): pausing
02-23 12:07:44.141-0600 W/APP_CORE(25653): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[4400002] -> redirected win[658bcb] for org.tralbrecht.GearS3Running[25653]
02-23 12:07:44.151-0600 W/wnotibp (16759): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
02-23 12:07:44.151-0600 I/wnotibp (16759): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
02-23 12:07:44.161-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
02-23 12:07:44.161-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1235) > Skip the background tick update
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_set(167) > timer set
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): gesture.c: _apps_status_get(128) > apps status:0
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:195
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): event_manager.c: _lcd_on_cb(728) > lcd state: 1
02-23 12:07:44.161-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:07:44.171-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [251171.955456] layer(0x4f13f8) not usable
02-23 12:07:44.171-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [251171.955494] layer(0x4f13f8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-23 12:07:44.171-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [251171.955518] layer[0x4f0f48]zpos[1]
02-23 12:07:44.171-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [251171.955603] layer(0x4f1448) not usable
02-23 12:07:44.171-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [251171.955621] layer(0x4f1448) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-23 12:07:44.171-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [251171.955642] layer[0x4f1068]zpos[2]
02-23 12:07:44.181-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
02-23 12:07:44.181-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
02-23 12:07:44.181-0600 W/W_INDICATOR( 2749): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
02-23 12:07:44.181-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151127284[0;m
02-23 12:07:44.181-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
02-23 12:07:44.181-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-23 12:07:44.181-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-23 12:07:44.181-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
02-23 12:07:44.181-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
02-23 12:07:44.181-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-23 12:07:44.191-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-23 12:07:44.191-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-23 12:07:44.191-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-23 12:07:44.191-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-23 12:07:44.201-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2748].
02-23 12:07:44.221-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
02-23 12:07:44.241-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
02-23 12:07:44.241-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_boolean(1173) > preference_get_boolean(3431) : test_healthy_pace error
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : pedometer_inactive_period error
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_10min_precaution_millisec error
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-23 12:07:44.271-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_before_10min_precaution_millisec error
02-23 12:07:44.281-0600 E/ALARM_MANAGER( 2496): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1443689234, next duetime: 1487873284
02-23 12:07:44.281-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1443689234)
02-23 12:07:44.281-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1487873312), due_time(1487873284)
02-23 12:07:44.291-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(453) > [APP 25653] Event: RESUME State: PAUSED
02-23 12:07:44.291-0600 I/CAPI_APPFW_APPLICATION(25653): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
02-23 12:07:44.291-0600 D/UIB_APP (25653): resuming
02-23 12:07:44.291-0600 I/GATE    (25653): <GATE-M>APP_FULLY_LOADED_GearS3Running</GATE-M>
02-23 12:07:44.301-0600 W/SHealthCommon( 3431): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1487808000000.000000[0;m
02-23 12:07:44.301-0600 W/SHealthCommon( 6231): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:3[0;m
02-23 12:07:44.301-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-23 12:07:44.301-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-23 12:07:44.301-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-23 12:07:44.301-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-23 12:07:44.311-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (828693)]][0;m
02-23 12:07:44.351-0600 W/SHealthCommon( 2955): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-23 12:07:44.351-0600 W/AUL     (25653): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.tralbrecht.GearS3Running)
02-23 12:07:44.351-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-23 12:07:44.361-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
02-23 12:07:44.361-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 0
02-23 12:07:44.361-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-23 12:07:44.371-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 25653
02-23 12:07:44.391-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1959) > caller process & callee process is same.[org.tralbrecht.GearS3Running:25653]
02-23 12:07:44.391-0600 W/AUL     (25653): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-7)
02-23 12:07:44.391-0600 E/AUL     (25653): launch.c: app_request_to_launchpad(304) > app_request_to_launchpad : Same Process Send Local
02-23 12:07:44.391-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(453) > [APP 25653] Event: RESET State: RUNNING
02-23 12:07:44.391-0600 I/CAPI_APPFW_APPLICATION(25653): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-23 12:07:44.391-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(529) > Legacy lifecycle: 0
02-23 12:07:44.391-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(531) > [APP 25653] App already running, raise the window
02-23 12:07:44.411-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-23 12:07:44.411-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-23 12:07:44.411-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-2-2017, 18:08:04 (UTC).
02-23 12:07:44.411-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-23 12:07:44.421-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-23 12:07:44.421-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [195]ms
02-23 12:07:44.421-0600 W/STARTER ( 2748): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
02-23 12:07:44.431-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2748].
02-23 12:07:44.431-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1443689234)
02-23 12:07:44.431-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-23 12:07:44.431-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-23 12:07:44.431-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-2-2017, 18:08:32 (UTC).
02-23 12:07:44.431-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-23 12:07:44.441-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.31][0;m
02-23 12:07:44.441-0600 W/SHealthCommon( 3431): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-23 12:07:44.441-0600 W/SHealthService( 3431): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-23 12:07:44.451-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-23 12:07:44.451-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1443689234] is removed.
02-23 12:07:44.461-0600 I/HealthDataService( 3034): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-23 12:07:44.471-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
02-23 12:07:44.471-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
02-23 12:07:44.471-0600 W/SHealthCommon( 6231): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-23 12:07:44.481-0600 I/healthData( 3431): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-23 12:07:44.481-0600 W/SHealthWidget( 2955): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (828693), msgName: timeline_summary_updated[0;m
02-23 12:07:44.481-0600 W/SHealthCommon( 2955): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
02-23 12:07:44.481-0600 W/SHealthWidget( 2955): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
02-23 12:07:44.491-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1487851664502.000000, pattern:[HH:mm][0;m
02-23 12:07:44.491-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:07:44.491-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:07:44.491-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:07:44.491-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:07:44.501-0600 E/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
02-23 12:07:44.501-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[12:07][0;m
02-23 12:07:44.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:07:44.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:07:44.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:07:44.511-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:07:44.511-0600 I/CAPI_WIDGET_APPLICATION( 2955): widget_app.c: __provider_update_cb(281) > received updating signal
02-23 12:07:45.161-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: MEM_FLUSH State: PAUSED
02-23 12:07:48.431-0600 W/AUL     (25832): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.tralbrecht.GearS3Running)
02-23 12:07:48.431-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-23 12:07:48.441-0600 I/AUL_AMD ( 2534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-23 12:07:48.471-0600 I/AUL_AMD ( 2534): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-23 12:07:48.471-0600 E/AUL_AMD ( 2534): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
02-23 12:07:48.471-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 25832
02-23 12:07:48.481-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(org.tralbrecht.GearS3Running) pid(25653) type(uiapp) bg(0)
02-23 12:07:48.491-0600 W/STARTER ( 2748): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [25653]
02-23 12:07:48.491-0600 W/AUL_AMD ( 2534): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25653
02-23 12:07:48.511-0600 W/AUL_AMD ( 2534): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(22), pid(25653), cmd(0)
02-23 12:07:48.511-0600 W/AUL     (25832): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25653)
02-23 12:07:48.521-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(453) > [APP 25653] Event: RESET State: RUNNING
02-23 12:07:48.521-0600 I/CAPI_APPFW_APPLICATION(25653): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-23 12:07:48.521-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(529) > Legacy lifecycle: 0
02-23 12:07:48.521-0600 I/APP_CORE(25653): appcore-efl.c: __do_app(531) > [APP 25653] App already running, raise the window
02-23 12:07:48.621-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251176405 button=1
02-23 12:07:48.751-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251176535 button=1
02-23 12:07:49.271-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251177056 button=1
02-23 12:07:49.391-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251177171 button=1
02-23 12:07:49.491-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-23 12:07:49.491-0600 W/AUL_AMD ( 2534): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
02-23 12:07:49.641-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: OnTimerTick(268) > [1;35m ###[0;m
02-23 12:07:49.641-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: UpdateCurrentTime(256) > [1;35m BEGIN >>>>[0;m
02-23 12:07:49.641-0600 W/WSLib   ( 6231): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1487851669647.000000, pattern:[HH:mm][0;m
02-23 12:07:49.641-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:07:49.641-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:07:49.641-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:07:49.641-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:07:49.641-0600 E/WSLib   ( 6231): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
02-23 12:07:49.671-0600 W/WSLib   ( 6231): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[12:07][0;m
02-23 12:07:49.681-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: UpdateCurrentTime(261) > [1;35m END <<<<[0;m
02-23 12:07:49.681-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: RotateArrowToCurrentTime(292) > [1;35m BEGIN >>>>[0;m
02-23 12:07:49.681-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: RotateArrowToCurrentTime(299) > [1;35m END <<<<[0;m
02-23 12:07:49.681-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: UpdateCurrentCalorie(240) > [1;35m BEGIN >>>>[0;m
02-23 12:07:49.701-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:07:49.701-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:07:49.701-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:07:49.701-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:07:49.701-0600 W/SHealth ( 6231): TodayPageVisualWidget.cpp: UpdateCurrentCalorie(251) > [1;35m END <<<<[0;m
02-23 12:07:49.711-0600 W/SHealthAppCommon( 6231): HeartRateLayout.cpp: RefreashTime(304) > [1;35m ###[0;m
02-23 12:07:49.711-0600 W/SHealthAppCommon( 6231): HeartRateLayout.cpp: UpdateTime(98) > [1;35mtimeString:[Yesterday][0;m
02-23 12:07:49.711-0600 W/SHealthAppCommon( 6231): HeartRateLayout.cpp: RefreashTime(307) > [1;35mprevious utc time:1487809851523.000000[0;m
02-23 12:07:49.711-0600 W/SHealthAppCommon( 6231): HeartRateLayout.cpp: RefreashTime(309) > [1;35m ###[0;m
02-23 12:07:49.711-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:07:49.711-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:07:49.711-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:07:49.711-0600 E/TIZEN_N_SYSTEM_SETTINGS( 6231): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:07:49.711-0600 W/SHealthAppCommon( 6231): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(264) > [1;35mhide_title_show_main_sub_text[0;m
02-23 12:07:49.711-0600 W/SHealthAppCommon( 6231): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(267) > [1;40;33mtag_icon_not_visible[0;m
02-23 12:07:50.361-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251178146 button=1
02-23 12:07:50.391-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4400002 time=251177171
02-23 12:07:50.391-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=251177171
02-23 12:07:50.391-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=251177171
02-23 12:07:50.471-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251178252 button=1
02-23 12:07:51.231-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251179009 button=1
02-23 12:07:51.381-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251179168 button=1
02-23 12:07:51.841-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251179622 button=1
02-23 12:07:51.991-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251179774 button=1
02-23 12:07:52.921-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251180705 button=1
02-23 12:07:53.071-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251180852 button=1
02-23 12:07:53.201-0600 I/GATE    ( 2490): <GATE-M>BATTERY_LEVEL_92</GATE-M>
02-23 12:07:53.641-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=251181426 button=1
02-23 12:07:53.711-0600 E/WMS     ( 2498): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23534) > _wms_event_handler_cb_nomove_detector is called
02-23 12:07:53.781-0600 E/EFL     (25653): ecore_x<25653> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=251181565 button=1
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : pedometer_inactive_period error
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_10min_precaution_millisec error
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-23 12:08:00.191-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_before_10min_precaution_millisec error
02-23 12:08:00.221-0600 W/SHealthCommon( 3431): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1487808000000.000000[0;m
02-23 12:08:00.241-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (828693)]][0;m
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-23 12:08:00.311-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-23 12:08:00.331-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.31][0;m
02-23 12:08:00.341-0600 I/HealthDataService( 3034): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-23 12:08:00.361-0600 W/SHealthWidget( 2955): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (828693), msgName: timeline_summary_updated[0;m
02-23 12:08:00.361-0600 W/SHealthCommon( 2955): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
02-23 12:08:00.361-0600 W/SHealthWidget( 2955): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-23 12:08:00.361-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1487851680373.000000, pattern:[HH:mm][0;m
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:08:00.361-0600 E/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
02-23 12:08:00.361-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[12:08][0;m
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-23 12:08:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-23 12:08:00.371-0600 I/CAPI_WIDGET_APPLICATION( 2955): widget_app.c: __provider_update_cb(281) > received updating signal
02-23 12:08:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-23 12:08:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-23 12:08:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-23 12:08:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-23 12:08:00.381-0600 I/healthData( 3431): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-23 12:08:00.601-0600 E/WMS     ( 2498): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23534) > _wms_event_handler_cb_nomove_detector is called
02-23 12:08:01.811-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 25653 pgid = 25653
02-23 12:08:01.811-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-23 12:08:02.001-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (3)
02-23 12:08:02.001-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(3)
02-23 12:08:02.001-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-23 12:08:02.001-0600 W/AUL_AMD ( 2534): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-23 12:08:02.001-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(fg) type(uiapp)
02-23 12:08:02.001-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-23 12:08:02.001-0600 W/W_HOME  ( 2815): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-23 12:08:02.001-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.001-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.001-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.011-0600 W/W_HOME  ( 2815): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-23 12:08:02.011-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-23 12:08:02.011-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): main.c: _window_visibility_cb(963) > Window [0x2000003] is now visible(0)
02-23 12:08:02.051-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: RESUME State: PAUSED
02-23 12:08:02.051-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): main.c: _appcore_resume_cb(478) > appcore resume
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): main.c: home_resume(530) > clock/widget resumed
02-23 12:08:02.051-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-23 12:08:02.051-0600 I/GATE    ( 2815): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-23 12:08:02.051-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-23 12:08:02.051-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-23 12:08:02.051-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
02-23 12:08:02.071-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_resume(1124) > widget_resume
02-23 12:08:02.071-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(fg) type(watchapp)
02-23 12:08:02.081-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-23 12:08:02.111-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-23 12:08:02.111-0600 I/AUL_AMD ( 2534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25653
02-23 12:08:02.111-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25653)
02-23 12:08:02.161-0600 E/W_INDICATOR( 2749): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(418) > [dynamic_event_icon_refresh_position_for_3g:418] rssi 0 connection 0
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(92), length(2)
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 92%
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 92, isCharging: 0
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_95
02-23 12:08:02.161-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
02-23 12:08:02.181-0600 W/CRASH_MANAGER(25837): worker.c: worker_job(1199) > 1125653676561148787328
