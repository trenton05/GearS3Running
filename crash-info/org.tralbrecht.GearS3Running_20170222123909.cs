S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: gears3running
PID: 15739
Date: 2017-02-22 12:39:09-0600
Executable File Path: /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 15739, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xf5d8f749
r4   = 0xf5da3618, r5   = 0x00000000
r6   = 0xf797a998, r7   = 0xffe24018
r8   = 0x00000000, r9   = 0xf797b300
r10  = 0xffe240c0, fp   = 0x00000000
ip   = 0xf5da3498, sp   = 0xffe24000
lr   = 0xf6f2ae8c, pc   = 0xf6f2b0b4
cpsr = 0x40000010

Memory Information
MemTotal:   620364 KB
MemFree:     56644 KB
Buffers:      3788 KB
Cached:      80048 KB
VmPeak:     132280 KB
VmSize:     131268 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28796 KB
VmRSS:       21500 KB
VmData:      47204 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43876 KB
VmPTE:         148 KB
VmSwap:       2312 KB

Threads Information
Threads: 4
PID = 15739 TID = 15739
15739 15826 15833 15834 

Maps Information
f0001000 f0800000 rw-p [stack:15834]
f0801000 f1000000 rw-p [stack:15833]
f1111000 f1112000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
f1199000 f119b000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f11a3000 f11a7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f11b0000 f11b3000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f11bb000 f11be000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f11c6000 f11ca000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f11d3000 f19d2000 rw-p [stack:15826]
f23cf000 f23d1000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f23d9000 f23f0000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f23fd000 f2402000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f240a000 f2415000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f273d000 f282f000 r-xp /usr/lib/libCOREGL.so.4.0
f2848000 f284c000 r-xp /usr/lib/libogg.so.0.7.1
f2854000 f2876000 r-xp /usr/lib/libvorbis.so.0.4.3
f287e000 f2883000 r-xp /usr/lib/libsystem.so.0.0.0
f288d000 f2893000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f289b000 f28aa000 r-xp /usr/lib/libmdm-common.so.1.1.22
f28b3000 f28fa000 r-xp /usr/lib/libsndfile.so.1.0.26
f2906000 f294f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2958000 f295d000 r-xp /usr/lib/libjson.so.0.0.1
f2965000 f2968000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2970000 f2976000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f297e000 f2989000 r-xp /usr/lib/libresourced.so.0.2.96
f2991000 f2992000 r-xp /usr/lib/librd-network.so.0.2.96
f299a000 f299b000 r-xp /usr/lib/libresponse.so.0.2.96
f29a3000 f29a8000 r-xp /usr/lib/libproc-stat.so.0.2.96
f29b1000 f29b3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f29bb000 f29c2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f29cb000 f29d0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f29d8000 f29da000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f29e2000 f2a03000 r-xp /usr/lib/libexif.so.12.3.3
f2a16000 f2a2f000 r-xp /usr/lib/libnetwork.so.0.0.0
f2a37000 f2a3d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f2a46000 f2a8e000 r-xp /usr/lib/libmdm.so.1.2.62
f2a8f000 f2a9c000 r-xp /usr/lib/libail.so.0.1.0
f2aa5000 f2aa8000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2ab0000 f2ae8000 r-xp /usr/lib/libpulse.so.0.16.2
f2ae9000 f2aec000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2af4000 f2b55000 r-xp /usr/lib/libasound.so.2.0.0
f2b5f000 f2b79000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2b81000 f2b88000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2b90000 f2b94000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2b9c000 f2ba0000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2ba9000 f2bab000 r-xp /usr/lib/libttrace.so.1.1
f444b000 f444c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f4455000 f4458000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f4460000 f4482000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f448b000 f4490000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f4498000 f44e8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f44ee000 f44f7000 r-xp /usr/lib/libcom-core.so.0.0.1
f4500000 f450a000 r-xp /usr/lib/libspdy.so.0.0.0
f4513000 f4519000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4521000 f4522000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f452b000 f453a000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f4543000 f454d000 r-xp /usr/lib/libsensord-shared.so
f4555000 f4565000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f456d000 f4586000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f458e000 f4595000 r-xp /usr/lib/libminizip.so.1.0.0
f459d000 f45a8000 r-xp /usr/lib/libtbm.so.1.0.0
f45b0000 f45c7000 r-xp /usr/lib/libmmfsound.so.0.1.0
f45d9000 f45de000 r-xp /usr/lib/libmemenv.so.1.1.0
f45e6000 f4622000 r-xp /usr/lib/libleveldb.so.1.1.0
f462b000 f4638000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f4641000 f4643000 r-xp /usr/lib/libdri2.so.0.0.0
f464b000 f4656000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f4663000 f466a000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f4672000 f469b000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f46a4000 f46a8000 r-xp /usr/lib/libEGL.so.1.4
f46b8000 f46c9000 r-xp /usr/lib/libGLESv2.so.2.0
f46d9000 f46e7000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f46f0000 f4708000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f4711000 f471a000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f4722000 f4763000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f476c000 f4807000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f4813000 f481b000 r-xp /usr/lib/libdrm.so.2.4.0
f4823000 f4929000 r-xp /usr/lib/libicuuc.so.57.1
f493f000 f4ac7000 r-xp /usr/lib/libicui18n.so.57.1
f4ad7000 f4afa000 r-xp /usr/lib/libui-extension.so.0.1.0
f4b03000 f4b15000 r-xp /usr/lib/libefl-assist.so.0.1.0
f4b1d000 f4b25000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4b2d000 f4b3f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f4b47000 f4b4a000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4b52000 f4b65000 r-xp /usr/lib/libwidget_service.so.1.0.0
f4b6e000 f4bba000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4bc4000 f4bc5000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4bcd000 f4c85000 r-xp /usr/lib/libcairo.so.2.11200.14
f4c90000 f4c95000 r-xp /usr/lib/libctx-client.so.0.8.3
f4c9d000 f4ca4000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4cac000 f4cd6000 r-xp /usr/lib/libsensor.so.1.9.3
f4cdf000 f4d19000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4d22000 f4d38000 r-xp /usr/lib/libtts.so
f4d41000 f4d5a000 r-xp /usr/lib/libstt.so
f4d62000 f4d67000 r-xp /usr/lib/libstorage.so.0.1
f4d6f000 f5c33000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5d19000 f5d3a000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5d42000 f5d4e000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5d57000 f5d5c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5d64000 f5d69000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5d71000 f5d7f000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5d88000 f5d94000 r-xp /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
f5f36000 f5f40000 r-xp /lib/libnss_files-2.13.so
f5f49000 f6018000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f602e000 f6052000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f605b000 f6061000 r-xp /usr/lib/libappsvc.so.0.1.0
f6069000 f606d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f607a000 f6085000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f608d000 f608f000 r-xp /usr/lib/libiniparser.so.0
f6098000 f609d000 r-xp /usr/lib/libappcore-common.so.1.1
f60a5000 f60a7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f60b0000 f60b4000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f60c1000 f60c3000 r-xp /usr/lib/libXau.so.6.0.0
f60cb000 f60d2000 r-xp /lib/libcrypt-2.13.so
f6102000 f6104000 r-xp /usr/lib/libiri.so
f610d000 f62b6000 r-xp /usr/lib/libcrypto.so.1.0.0
f62d6000 f631d000 r-xp /usr/lib/libssl.so.1.0.0
f6329000 f6357000 r-xp /usr/lib/libidn.so.11.5.44
f635f000 f6368000 r-xp /usr/lib/libcares.so.2.1.0
f6372000 f6385000 r-xp /usr/lib/libxcb.so.1.1.0
f638e000 f6391000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6399000 f639b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f63a4000 f6470000 r-xp /usr/lib/libxml2.so.2.7.8
f647d000 f647f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6488000 f648d000 r-xp /usr/lib/libffi.so.5.0.10
f6495000 f6496000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f649e000 f64a1000 r-xp /lib/libattr.so.1.1.0
f64a9000 f653d000 r-xp /usr/lib/libstdc++.so.6.0.16
f6550000 f656d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6577000 f658f000 r-xp /usr/lib/libpng12.so.0.50.0
f6597000 f65ad000 r-xp /lib/libexpat.so.1.6.0
f65b7000 f65fb000 r-xp /usr/lib/libcurl.so.4.3.0
f6604000 f660e000 r-xp /usr/lib/libXext.so.6.4.0
f6617000 f661b000 r-xp /usr/lib/libXtst.so.6.1.0
f6623000 f6629000 r-xp /usr/lib/libXrender.so.1.3.0
f6631000 f6637000 r-xp /usr/lib/libXrandr.so.2.2.0
f663f000 f6640000 r-xp /usr/lib/libXinerama.so.1.0.0
f6649000 f6652000 r-xp /usr/lib/libXi.so.6.1.0
f665a000 f665d000 r-xp /usr/lib/libXfixes.so.3.1.0
f6665000 f6667000 r-xp /usr/lib/libXgesture.so.7.0.0
f666f000 f6671000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6679000 f667b000 r-xp /usr/lib/libXdamage.so.1.1.0
f6683000 f668a000 r-xp /usr/lib/libXcursor.so.1.0.2
f6692000 f6695000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f669d000 f66a1000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f66aa000 f66af000 r-xp /usr/lib/libecore_fb.so.1.7.99
f66b8000 f6799000 r-xp /usr/lib/libX11.so.6.3.0
f67a4000 f67c7000 r-xp /usr/lib/libjpeg.so.8.0.2
f67df000 f67f5000 r-xp /lib/libz.so.1.2.5
f67fd000 f67ff000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6807000 f687c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6886000 f68a0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68a8000 f68dc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f68e5000 f69b8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69c3000 f69d3000 r-xp /lib/libresolv-2.13.so
f69d7000 f69ef000 r-xp /usr/lib/liblzma.so.5.0.3
f69f7000 f69fa000 r-xp /lib/libcap.so.2.21
f6a02000 f6a31000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a39000 f6a3a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6a42000 f6a48000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6a50000 f6a67000 r-xp /usr/lib/liblua-5.1.so
f6a70000 f6a77000 r-xp /usr/lib/libembryo.so.1.7.99
f6a7f000 f6a85000 r-xp /lib/librt-2.13.so
f6a8e000 f6ae4000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6af1000 f6b47000 r-xp /usr/lib/libfreetype.so.6.11.3
f6b53000 f6b7b000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6b7c000 f6bc1000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6bca000 f6bdd000 r-xp /usr/lib/libfribidi.so.0.3.1
f6be5000 f6bff000 r-xp /usr/lib/libecore_con.so.1.7.99
f6c08000 f6c11000 r-xp /usr/lib/libedbus.so.1.7.99
f6c19000 f6c69000 r-xp /usr/lib/libecore_x.so.1.7.99
f6c6b000 f6c74000 r-xp /usr/lib/libvconf.so.0.2.45
f6c7c000 f6c8d000 r-xp /usr/lib/libecore_input.so.1.7.99
f6c95000 f6c9a000 r-xp /usr/lib/libecore_file.so.1.7.99
f6ca2000 f6cc4000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6ccd000 f6d0e000 r-xp /usr/lib/libeina.so.1.7.99
f6d17000 f6d30000 r-xp /usr/lib/libeet.so.1.7.99
f6d41000 f6daa000 r-xp /lib/libm-2.13.so
f6db3000 f6db9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dc2000 f6dc3000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6dcb000 f6dee000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6df6000 f6dfb000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e03000 f6e2d000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e36000 f6e4d000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e55000 f6e60000 r-xp /lib/libunwind.so.8.0.1
f6e8d000 f6eab000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb5000 f6fd9000 r-xp /lib/libc-2.13.so
f6fe7000 f6fef000 r-xp /lib/libgcc_s-4.6.so.1
f6ff0000 f6ff4000 r-xp /usr/lib/libsmack.so.1.0.0
f6ffd000 f7003000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f700b000 f70db000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70dc000 f713a000 r-xp /usr/lib/libedje.so.1.7.99
f7144000 f715b000 r-xp /usr/lib/libecore.so.1.7.99
f7172000 f7240000 r-xp /usr/lib/libevas.so.1.7.99
f7265000 f73a1000 r-xp /usr/lib/libelementary.so.1.7.99
f73b8000 f73cc000 r-xp /lib/libpthread-2.13.so
f73d7000 f73d9000 r-xp /usr/lib/libdlog.so.0.0.0
f73e1000 f73e4000 r-xp /usr/lib/libbundle.so.0.1.22
f73ec000 f73ee000 r-xp /lib/libdl-2.13.so
f73f7000 f7404000 r-xp /usr/lib/libaul.so.0.1.0
f7416000 f741c000 r-xp /usr/lib/libappcore-efl.so.1.1
f7425000 f7429000 r-xp /usr/lib/libsys-assert.so
f7432000 f744f000 r-xp /lib/ld-2.13.so
f7458000 f745d000 r-xp /usr/bin/launchpad-loader
f7843000 f7a8f000 rw-p [heap]
ffe04000 ffe25000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15739)
Call Stack Count: 1
 0: strlen + 0x4 (0xf6f2b0b4) [/lib/libc.so.6] + 0x760b4
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
 ( 2534): amd_appinfo.c: appinfo_get_value(1257) > appinfo get value: Invalid argument, 31
02-22 12:39:03.329-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 15739
02-22 12:39:03.329-0600 E/AUL_AMD ( 2534): amd_launch.c: _start_app(1795) > no appinfo
02-22 12:39:03.329-0600 E/AUL_AMD ( 2534): amd_launch.c: __real_send(909) > send fail to client
02-22 12:39:03.329-0600 W/AUL     (15739): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
02-22 12:39:03.329-0600 E/CAPI_APPFW_APP_CONTROL(15739): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
02-22 12:39:03.349-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
02-22 12:39:03.349-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 0
02-22 12:39:03.349-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-22 12:39:03.379-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_resume(1124) > widget_resume
02-22 12:39:03.379-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(fg) type(watchapp)
02-22 12:39:03.379-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-22 12:39:03.379-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
02-22 12:39:03.379-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1235) > Skip the background tick update
02-22 12:39:03.389-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-22 12:39:03.389-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 12:39:03.389-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 18:39:23 (UTC).
02-22 12:39:03.389-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 12:39:03.409-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-22 12:39:03.419-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
02-22 12:39:03.419-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 3
02-22 12:39:03.419-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
02-22 12:39:03.419-0600 E/STARTER ( 2748): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
02-22 12:39:03.419-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
02-22 12:39:03.419-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
02-22 12:39:03.419-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:39:03.419-0600 W/STARTER ( 2748): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
02-22 12:39:03.429-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [powerkey] after screen off time [176]ms
02-22 12:39:03.429-0600 W/STARTER ( 2748): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:39:03.429-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2748].
02-22 12:39:03.429-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(124399294)
02-22 12:39:03.439-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-22 12:39:03.449-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 12:39:03.449-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 18:42:58 (UTC).
02-22 12:39:03.449-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 12:39:03.459-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-22 12:39:03.459-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[124399294] is removed.
02-22 12:39:03.469-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [powerkey]
02-22 12:39:03.469-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:39:03.469-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:39:03.479-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:39:03.479-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:39:03.489-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:39:03.669-0600 I/GATE    ( 2815): <GATE-M>SCREEN_LOADED_HOME</GATE-M>
02-22 12:39:03.829-0600 W/STARTER ( 2748): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
02-22 12:39:03.839-0600 W/STARTER ( 2748): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[3], current lcd status[1] pressed pm state[1]
02-22 12:39:03.839-0600 W/STARTER ( 2748): hw_key.c: _powerkey_timer_cb(1134) > [_powerkey_timer_cb:1134] LCD OFF state => ignore key operation
02-22 12:39:03.999-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-22 12:39:04.159-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:04.159-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:04.159-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-22 12:39:04.169-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:04.169-0600 E/CAPI_APPFW_APP_CONTROL( 3522): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-22 12:39:04.169-0600 W/MUSIC_CONTROL_SERVICE( 3522): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3522]   [com.samsung.w-home]register msg port [true][0m
02-22 12:39:04.169-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 14
02-22 12:39:04.189-0600 W/AUL_AMD ( 2534): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20295
02-22 12:39:04.189-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 14
02-22 12:39:04.199-0600 W/AUL_AMD ( 2534): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 2815
02-22 12:39:04.199-0600 W/MUSIC_CONTROL_SERVICE( 3522): music-control-message.c: music_control_message_send_media_changed_ind(231) > [36m[TID:3522]   [MUSIC_PLAYER_EVENT][0m
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:04.209-0600 W/MUSIC_CONTROL_SERVICE( 3522): music-control-message.c: music_control_message_send_player_state_changed_ind(255) > [36m[TID:3522]   [MUSIC_PLAYER_EVENT][0m
02-22 12:39:04.209-0600 W/W_HOME  ( 2815): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-22 12:39:04.209-0600 E/W_HOME  ( 2815): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-22 12:39:04.209-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:04.219-0600 W/W_HOME  ( 2815): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
02-22 12:39:04.219-0600 E/W_HOME  ( 2815): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-22 12:39:04.439-0600 W/KEYROUTER( 2366): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x2000003
02-22 12:39:04.439-0600 W/KEYROUTER( 2366): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1a00002
02-22 12:39:04.439-0600 E/EFL     ( 2815): ecore_x<2815> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=236252895
02-22 12:39:04.439-0600 W/W_HOME  ( 2815): main.c: _direct_home_key_cb(1444) > was_win_on_top:1
02-22 12:39:04.439-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
02-22 12:39:04.439-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
02-22 12:39:04.439-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
02-22 12:39:04.449-0600 E/STARTER ( 2748): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
02-22 12:39:04.449-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
02-22 12:39:04.449-0600 W/STARTER ( 2748): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
02-22 12:39:04.619-0600 W/KEYROUTER( 2366): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1a00002
02-22 12:39:04.619-0600 W/KEYROUTER( 2366): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x2000003
02-22 12:39:04.619-0600 W/STARTER ( 2748): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
02-22 12:39:04.619-0600 E/EFL     ( 2815): ecore_x<2815> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=236253069
02-22 12:39:04.869-0600 W/STARTER ( 2748): hw_key.c: _powerkey_timer_cb(922) > [_powerkey_timer_cb:922] _powerkey_timer_cb, powerkey count[1]
02-22 12:39:04.869-0600 W/STARTER ( 2748): hw_key.c: _powerkey_timer_cb(1132) > [_powerkey_timer_cb:1132] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
02-22 12:39:04.869-0600 E/STARTER ( 2748): dbus-util.c: dbus_request_cpu_boost(292) > [dbus_request_cpu_boost:292] failed to _invoke_dbus_method_sync
02-22 12:39:04.869-0600 W/AUL     ( 2748): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
02-22 12:39:04.879-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-22 12:39:04.879-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 2748
02-22 12:39:04.889-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(2815) type(uiapp) bg(0)
02-22 12:39:04.889-0600 W/AUL_AMD ( 2534): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 2815
02-22 12:39:04.889-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: RESET State: RUNNING
02-22 12:39:04.889-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_reset(245) > app_appcore_reset
02-22 12:39:04.889-0600 W/CAPI_APPFW_APP_CONTROL( 2815): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): main.c: _app_control_progress(1568) > Service value : powerkey
02-22 12:39:04.889-0600 W/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x40001
02-22 12:39:04.889-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_popup_shown(4738) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:04.889-0600 W/AUL_AMD ( 2534): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(22), pid(2815), cmd(0)
02-22 12:39:04.889-0600 W/AUL     ( 2748): launch.c: app_request_to_launchpad(298) > request cmd(0) result(2815)
02-22 12:39:04.889-0600 W/STARTER ( 2748): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [2815]
02-22 12:39:04.889-0600 E/AUL     ( 2534): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
02-22 12:39:04.889-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:04.889-0600 W/wnotib  ( 2815): w-notification-board-broker-main.c: wnotib_main_dismiss_confirmation_popup(1427) > 
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): noti_broker.c: _noti_broker_home_cb(779) > continue the home key execution
02-22 12:39:04.889-0600 E/W_HOME  ( 2815): cs_broker.c: _cs_broker_home_cb(274) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): main.c: _home_key_cb(1466) > Home Key operation tutorial:0 window:1 clock:1 apps:0 is_app_resumed:1
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): move.c: move_move_to_apps(216) > move to apps
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): rotary.c: rotary_attach(138) > rotary_attach:0xf7a3d068
02-22 12:39:04.889-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf7a3d068, elm_layout, _activated_obj : 0xf77f50e0, activated : 1
02-22 12:39:04.889-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): event_manager.c: _move_module_anim_start_cb(673) > state: 0 -> 1
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:04.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:04.889-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:39:04.889-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:39:04.899-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
02-22 12:39:04.909-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
02-22 12:39:04.909-0600 E/AUL     ( 2748): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): event_manager.c: _apptray_visibility_cb(611) > apps,show,start
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 0
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): clock_manager.c: _compositing_set(205) > hwc:0
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
02-22 12:39:04.909-0600 W/W_HOME  ( 2815): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
02-22 12:39:04.909-0600 W/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
02-22 12:39:04.909-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
02-22 12:39:04.909-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:39:04.909-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:39:04.949-0600 W/W_HOME  ( 2815): clock_manager.c: _hwc_disabled_timer_cb(125) > hwc disabled
02-22 12:39:04.959-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_unset_buffer(1602) > [236253.413346] layer(0x4f1388) now usable
02-22 12:39:04.959-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [236253.413378] layer[0x4f0e28]zpos[0]
02-22 12:39:04.999-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-22 12:39:05.179-0600 W/W_HOME  ( 2815): event_manager.c: _move_module_anim_end_cb(687) > state: 1 -> 0
02-22 12:39:05.179-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:39:05.179-0600 W/W_HOME  ( 2815): rotary.c: rotary_deattach(156) > rotary_deattach:0xf7a3d068
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf7a3d068, elm_layout, func : 0xf718032d
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf77f50e0, elm_box, _activated_obj : 0xf7a3d068, activated : 1
02-22 12:39:05.179-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-22 12:39:05.179-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:05.179-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 93, 202.
02-22 12:39:05.179-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): event_manager.c: _apptray_visibility_cb(611) > apps,show
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): event_manager.c: _apptray_visibility_cb(631) > state: 1 -> 1
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): main.c: home_pause(546) > clock/widget paused
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:05.189-0600 W/APPS    ( 2815): apps_main.c: _time_changed_cb(308) >  date : 22->22
02-22 12:39:05.189-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
02-22 12:39:05.189-0600 W/W_HOME  ( 2815): rotary.c: rotary_attach(138) > rotary_attach:0xf78b3a18
02-22 12:39:05.199-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf78b3a18, elm_layout, _activated_obj : 0xf77f50e0, activated : 1
02-22 12:39:05.199-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-22 12:39:05.199-0600 I/GATE    ( 2815): <GATE-M>SCREEN_LOADED_APP_MENU_3</GATE-M>
02-22 12:39:05.199-0600 W/W_HOME  ( 2815): win.c: win_back_gesture_disable_set(170) > disable back gesture
02-22 12:39:05.199-0600 W/W_HOME  ( 2815): win.c: win_back_gesture_disable_set(170) > disable back gesture
02-22 12:39:05.199-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:05.199-0600 W/W_HOME  ( 2815): noti_broker.c: _apptray_visibility_cb(786) > apps,show
02-22 12:39:05.199-0600 W/W_HOME  ( 2815): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
02-22 12:39:05.199-0600 W/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
02-22 12:39:05.199-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:05.199-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnb_basic_panel_close_second_depth_view(6316) > wnotib_action_drawer_is_event_receivable: 0, third_depth_genlist: (nil), _wnotib_basic_panel_is_third_depth_thread_view: 0, wnotib_common_is_toast_popup_displayed: 0
02-22 12:39:05.199-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_event_receivable(5108) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:05.199-0600 I/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
02-22 12:39:05.199-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [94], notiboard card appending count [210].
02-22 12:39:05.199-0600 E/APPS    ( 2815): apps_main.c: apps_main_resume(1003) >  resumed already
02-22 12:39:05.199-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:39:05.199-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:39:05.209-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_pause(1113) > widget_pause
02-22 12:39:05.209-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(bg) type(watchapp)
02-22 12:39:05.889-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-22 12:39:05.889-0600 W/AUL_AMD ( 2534): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
02-22 12:39:07.809-0600 E/EFL     ( 2815): ecore_x<2815> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236256262 button=1
02-22 12:39:07.809-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [190, 177]
02-22 12:39:07.809-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: onBubbleButtonEffect(2404) >  [249, 249, 249, 102]
02-22 12:39:07.809-0600 E/EFL     ( 2815): evas_main<2815> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
02-22 12:39:07.809-0600 E/EFL     ( 2815): evas_main<2815> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
02-22 12:39:07.809-0600 E/EFL     ( 2815): evas_main<2815> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
02-22 12:39:07.849-0600 E/EFL     ( 2815): ecore_x<2815> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236256307 button=1
02-22 12:39:07.849-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [190, 177]->[190, 177]
02-22 12:39:07.849-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: onBubbleButtonEffect(2422) >  [249, 249, 249, 255]
02-22 12:39:07.849-0600 W/APPS    ( 2815): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,22]
02-22 12:39:07.849-0600 E/APPS    ( 2815): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
02-22 12:39:07.849-0600 W/APPS    ( 2815): AppsItem.cpp: onItemClicked(487) >  item(Gear S3 Running) launched, open(0), tts(0)
02-22 12:39:07.849-0600 W/AUL     ( 2815): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.tralbrecht.GearS3Running)
02-22 12:39:07.859-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-22 12:39:07.859-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 2815
02-22 12:39:07.859-0600 I/AUL_AMD ( 2534): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
02-22 12:39:07.869-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(org.tralbrecht.GearS3Running) pid(15739) type(uiapp) bg(0)
02-22 12:39:07.869-0600 W/STARTER ( 2748): pkg-monitor.c: _app_mgr_status_cb(415) > [_app_mgr_status_cb:415] Resume request [15739]
02-22 12:39:07.879-0600 W/AUL_AMD ( 2534): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15739
02-22 12:39:07.879-0600 E/AUL     ( 2534): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
02-22 12:39:07.889-0600 W/AUL_AMD ( 2534): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(22), pid(15739), cmd(0)
02-22 12:39:07.889-0600 W/AUL     ( 2815): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15739)
02-22 12:39:07.889-0600 W/W_HOME  ( 2815): util.c: apps_util_launch_main_operation(643) > Launch app:[Gear S3 Running] ret:[0]
02-22 12:39:07.899-0600 I/APP_CORE(15739): appcore-efl.c: __do_app(453) > [APP 15739] Event: RESET State: PAUSED
02-22 12:39:07.899-0600 I/CAPI_APPFW_APPLICATION(15739): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-22 12:39:07.899-0600 I/APP_CORE(15739): appcore-efl.c: __do_app(529) > Legacy lifecycle: 0
02-22 12:39:07.899-0600 I/APP_CORE(15739): appcore-efl.c: __do_app(531) > [APP 15739] App already running, raise the window
02-22 12:39:07.939-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[15739] goes to (3)
02-22 12:39:07.949-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.tralbrecht.GearS3Running) pid(15739) status(fg) type(uiapp)
02-22 12:39:07.949-0600 I/APP_CORE(15739): appcore-efl.c: __do_app(535) > [APP 15739] Call the resume_cb
02-22 12:39:07.949-0600 I/CAPI_APPFW_APPLICATION(15739): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
02-22 12:39:07.949-0600 D/UIB_APP (15739): resuming
02-22 12:39:07.979-0600 W/W_HOME  ( 2815): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
02-22 12:39:07.979-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:07.979-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:07.979-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:07.979-0600 W/W_HOME  ( 2815): win.c: win_back_gesture_disable_set(173) > enable back gesture
02-22 12:39:07.979-0600 W/W_HOME  ( 2815): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
02-22 12:39:07.979-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:39:07.979-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:39:08.039-0600 I/APP_CORE(15739): appcore-efl.c: __do_app(453) > [APP 15739] Event: RESUME State: RUNNING
02-22 12:39:08.039-0600 I/GATE    (15739): <GATE-M>APP_FULLY_LOADED_GearS3Running</GATE-M>
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(1)
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): main.c: _window_visibility_cb(963) > Window [0x2000003] is now visible(1)
02-22 12:39:08.039-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: PAUSE State: RUNNING
02-22 12:39:08.039-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): main.c: _appcore_pause_cb(487) > appcore pause
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-22 12:39:08.039-0600 W/W_HOME  ( 2815): rotary.c: rotary_deattach(156) > rotary_deattach:0xf78b3a18
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xf78b3a18, elm_layout, func : 0xf718032d
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xf77f50e0, elm_box, _activated_obj : 0xf78b3a18, activated : 1
02-22 12:39:08.039-0600 I/efl-extension( 2815): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-22 12:39:08.039-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:08.039-0600 I/wnotib  ( 2815): w-notification-board-basic-panel.c: _wnb_basic_panel_passed_key_event_allow(6237) > Return true for 93, 202.
02-22 12:39:08.039-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
02-22 12:39:08.049-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:39:08.049-0600 W/W_HOME  ( 2815): win.c: win_back_gesture_disable_set(173) > enable back gesture
02-22 12:39:08.049-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-22 12:39:08.049-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-22 12:39:08.059-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:39:08.059-0600 E/CAPI_APPFW_APP_CONTROL( 3522): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-22 12:39:08.059-0600 W/MUSIC_CONTROL_SERVICE( 3522): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3522]   [com.samsung.w-home]register msg port [false][0m
02-22 12:39:08.059-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 14
02-22 12:39:08.069-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (4)
02-22 12:39:08.069-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(4)
02-22 12:39:08.079-0600 W/AUL_AMD ( 2534): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20295
02-22 12:39:08.079-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(bg) type(uiapp)
02-22 12:39:08.079-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
02-22 12:39:08.079-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:39:08.079-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [94], notiboard card appending count [210].
02-22 12:39:08.099-0600 W/APPS    ( 2815): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
02-22 12:39:08.429-0600 E/AUL     ( 2534): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
02-22 12:39:08.559-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: MEM_FLUSH State: PAUSED
02-22 12:39:09.449-0600 E/EFL     (15739): ecore_x<15739> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236257902 button=1
02-22 12:39:09.569-0600 E/EFL     (15739): ecore_x<15739> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236258023 button=1
02-22 12:39:09.849-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 15739 pgid = 15739
02-22 12:39:09.849-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-22 12:39:09.959-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-22 12:39:09.959-0600 W/AUL_AMD ( 2534): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-22 12:39:09.959-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(fg) type(uiapp)
02-22 12:39:09.969-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (3)
02-22 12:39:09.969-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(3)
02-22 12:39:10.009-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-22 12:39:10.009-0600 I/AUL_AMD ( 2534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15739
02-22 12:39:10.009-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15739)
02-22 12:39:10.039-0600 E/W_INDICATOR( 2749): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(418) > [dynamic_event_icon_refresh_position_for_3g:418] rssi 0 connection 0
02-22 12:39:10.119-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-22 12:39:10.159-0600 W/CRASH_MANAGER(15973): worker.c: worker_job(1199) > 1115739676561148778874
