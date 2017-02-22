S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: gears3running
PID: 16071
Date: 2017-02-22 12:40:57-0600
Executable File Path: /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 16071, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0xf5ce7765
r4   = 0xf5cfb658, r5   = 0x00000000
r6   = 0xf7961b58, r7   = 0xffdbc728
r8   = 0x00000000, r9   = 0xf7959618
r10  = 0xffdbc7d0, fp   = 0x00000000
ip   = 0xf5cfb4d8, sp   = 0xffdbc710
lr   = 0xf6e82e8c, pc   = 0xf6e830b4
cpsr = 0x40000010

Memory Information
MemTotal:   620364 KB
MemFree:     55444 KB
Buffers:      3724 KB
Cached:      88316 KB
VmPeak:     132680 KB
VmSize:     131656 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       30744 KB
VmRSS:       30040 KB
VmData:      47084 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       43876 KB
VmPTE:         156 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16071 TID = 16071
16071 16175 16182 16183 

Maps Information
ef4e7000 ef4e8000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
effeb000 f07ea000 rw-p [stack:16183]
f07eb000 f0fea000 rw-p [stack:16182]
f0fea000 f0fec000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f0ff4000 f0ff8000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f1108000 f110b000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
f1113000 f1116000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f111e000 f1122000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f112b000 f192a000 rw-p [stack:16175]
f2327000 f2329000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f2331000 f2348000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f2355000 f235a000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f2362000 f236d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f2695000 f2787000 r-xp /usr/lib/libCOREGL.so.4.0
f27a0000 f27a4000 r-xp /usr/lib/libogg.so.0.7.1
f27ac000 f27ce000 r-xp /usr/lib/libvorbis.so.0.4.3
f27d6000 f27db000 r-xp /usr/lib/libsystem.so.0.0.0
f27e5000 f27eb000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f27f3000 f2802000 r-xp /usr/lib/libmdm-common.so.1.1.22
f280b000 f2852000 r-xp /usr/lib/libsndfile.so.1.0.26
f285e000 f28a7000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f28b0000 f28b5000 r-xp /usr/lib/libjson.so.0.0.1
f28bd000 f28c0000 r-xp /usr/lib/libtinycompress.so.0.0.0
f28c8000 f28ce000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f28d6000 f28e1000 r-xp /usr/lib/libresourced.so.0.2.96
f28e9000 f28ea000 r-xp /usr/lib/librd-network.so.0.2.96
f28f2000 f28f3000 r-xp /usr/lib/libresponse.so.0.2.96
f28fb000 f2900000 r-xp /usr/lib/libproc-stat.so.0.2.96
f2909000 f290b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f2913000 f291a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f2923000 f2928000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f2930000 f2932000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f293a000 f295b000 r-xp /usr/lib/libexif.so.12.3.3
f296e000 f2987000 r-xp /usr/lib/libnetwork.so.0.0.0
f298f000 f2995000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f299e000 f29e6000 r-xp /usr/lib/libmdm.so.1.2.62
f29e7000 f29f4000 r-xp /usr/lib/libail.so.0.1.0
f29fd000 f2a00000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2a08000 f2a40000 r-xp /usr/lib/libpulse.so.0.16.2
f2a41000 f2a44000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2a4c000 f2aad000 r-xp /usr/lib/libasound.so.2.0.0
f2ab7000 f2ad1000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2ad9000 f2ae0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2ae8000 f2aec000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2af4000 f2af8000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2b01000 f2b03000 r-xp /usr/lib/libttrace.so.1.1
f43a3000 f43a4000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f43ad000 f43b0000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f43b8000 f43da000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f43e3000 f43e8000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f43f0000 f4440000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f4446000 f444f000 r-xp /usr/lib/libcom-core.so.0.0.1
f4458000 f4462000 r-xp /usr/lib/libspdy.so.0.0.0
f446b000 f4471000 r-xp /usr/lib/libxcb-render.so.0.0.0
f4479000 f447a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f4483000 f4492000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f449b000 f44a5000 r-xp /usr/lib/libsensord-shared.so
f44ad000 f44bd000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f44c5000 f44de000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f44e6000 f44ed000 r-xp /usr/lib/libminizip.so.1.0.0
f44f5000 f4500000 r-xp /usr/lib/libtbm.so.1.0.0
f4508000 f451f000 r-xp /usr/lib/libmmfsound.so.0.1.0
f4531000 f4536000 r-xp /usr/lib/libmemenv.so.1.1.0
f453e000 f457a000 r-xp /usr/lib/libleveldb.so.1.1.0
f4583000 f4590000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f4599000 f459b000 r-xp /usr/lib/libdri2.so.0.0.0
f45a3000 f45ae000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f45bb000 f45c2000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f45ca000 f45f3000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f45fc000 f4600000 r-xp /usr/lib/libEGL.so.1.4
f4610000 f4621000 r-xp /usr/lib/libGLESv2.so.2.0
f4631000 f463f000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f4648000 f4660000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f4669000 f4672000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f467a000 f46bb000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f46c4000 f475f000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f476b000 f4773000 r-xp /usr/lib/libdrm.so.2.4.0
f477b000 f4881000 r-xp /usr/lib/libicuuc.so.57.1
f4897000 f4a1f000 r-xp /usr/lib/libicui18n.so.57.1
f4a2f000 f4a52000 r-xp /usr/lib/libui-extension.so.0.1.0
f4a5b000 f4a6d000 r-xp /usr/lib/libefl-assist.so.0.1.0
f4a75000 f4a7d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4a85000 f4a97000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f4a9f000 f4aa2000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4aaa000 f4abd000 r-xp /usr/lib/libwidget_service.so.1.0.0
f4ac6000 f4b12000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4b1c000 f4b1d000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4b25000 f4bdd000 r-xp /usr/lib/libcairo.so.2.11200.14
f4be8000 f4bed000 r-xp /usr/lib/libctx-client.so.0.8.3
f4bf5000 f4bfc000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4c04000 f4c2e000 r-xp /usr/lib/libsensor.so.1.9.3
f4c37000 f4c71000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4c7a000 f4c90000 r-xp /usr/lib/libtts.so
f4c99000 f4cb2000 r-xp /usr/lib/libstt.so
f4cba000 f4cbf000 r-xp /usr/lib/libstorage.so.0.1
f4cc7000 f5b8b000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5c71000 f5c92000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5c9a000 f5ca6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f5caf000 f5cb4000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f5cbc000 f5cc1000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f5cc9000 f5cd7000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f5ce0000 f5cec000 r-xp /opt/usr/apps/org.tralbrecht.GearS3Running/bin/gears3running
f5e8e000 f5e98000 r-xp /lib/libnss_files-2.13.so
f5ea1000 f5f70000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f5f86000 f5faa000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f5fb3000 f5fb9000 r-xp /usr/lib/libappsvc.so.0.1.0
f5fc1000 f5fc5000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f5fd2000 f5fdd000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f5fe5000 f5fe7000 r-xp /usr/lib/libiniparser.so.0
f5ff0000 f5ff5000 r-xp /usr/lib/libappcore-common.so.1.1
f5ffd000 f5fff000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6008000 f600c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6019000 f601b000 r-xp /usr/lib/libXau.so.6.0.0
f6023000 f602a000 r-xp /lib/libcrypt-2.13.so
f605a000 f605c000 r-xp /usr/lib/libiri.so
f6065000 f620e000 r-xp /usr/lib/libcrypto.so.1.0.0
f622e000 f6275000 r-xp /usr/lib/libssl.so.1.0.0
f6281000 f62af000 r-xp /usr/lib/libidn.so.11.5.44
f62b7000 f62c0000 r-xp /usr/lib/libcares.so.2.1.0
f62ca000 f62dd000 r-xp /usr/lib/libxcb.so.1.1.0
f62e6000 f62e9000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f62f1000 f62f3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f62fc000 f63c8000 r-xp /usr/lib/libxml2.so.2.7.8
f63d5000 f63d7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f63e0000 f63e5000 r-xp /usr/lib/libffi.so.5.0.10
f63ed000 f63ee000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f63f6000 f63f9000 r-xp /lib/libattr.so.1.1.0
f6401000 f6495000 r-xp /usr/lib/libstdc++.so.6.0.16
f64a8000 f64c5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f64cf000 f64e7000 r-xp /usr/lib/libpng12.so.0.50.0
f64ef000 f6505000 r-xp /lib/libexpat.so.1.6.0
f650f000 f6553000 r-xp /usr/lib/libcurl.so.4.3.0
f655c000 f6566000 r-xp /usr/lib/libXext.so.6.4.0
f656f000 f6573000 r-xp /usr/lib/libXtst.so.6.1.0
f657b000 f6581000 r-xp /usr/lib/libXrender.so.1.3.0
f6589000 f658f000 r-xp /usr/lib/libXrandr.so.2.2.0
f6597000 f6598000 r-xp /usr/lib/libXinerama.so.1.0.0
f65a1000 f65aa000 r-xp /usr/lib/libXi.so.6.1.0
f65b2000 f65b5000 r-xp /usr/lib/libXfixes.so.3.1.0
f65bd000 f65bf000 r-xp /usr/lib/libXgesture.so.7.0.0
f65c7000 f65c9000 r-xp /usr/lib/libXcomposite.so.1.0.0
f65d1000 f65d3000 r-xp /usr/lib/libXdamage.so.1.1.0
f65db000 f65e2000 r-xp /usr/lib/libXcursor.so.1.0.2
f65ea000 f65ed000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f65f5000 f65f9000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6602000 f6607000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6610000 f66f1000 r-xp /usr/lib/libX11.so.6.3.0
f66fc000 f671f000 r-xp /usr/lib/libjpeg.so.8.0.2
f6737000 f674d000 r-xp /lib/libz.so.1.2.5
f6755000 f6757000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f675f000 f67d4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f67de000 f67f8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6800000 f6834000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f683d000 f6910000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f691b000 f692b000 r-xp /lib/libresolv-2.13.so
f692f000 f6947000 r-xp /usr/lib/liblzma.so.5.0.3
f694f000 f6952000 r-xp /lib/libcap.so.2.21
f695a000 f6989000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6991000 f6992000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f699a000 f69a0000 r-xp /usr/lib/libecore_imf.so.1.7.99
f69a8000 f69bf000 r-xp /usr/lib/liblua-5.1.so
f69c8000 f69cf000 r-xp /usr/lib/libembryo.so.1.7.99
f69d7000 f69dd000 r-xp /lib/librt-2.13.so
f69e6000 f6a3c000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6a49000 f6a9f000 r-xp /usr/lib/libfreetype.so.6.11.3
f6aab000 f6ad3000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6ad4000 f6b19000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6b22000 f6b35000 r-xp /usr/lib/libfribidi.so.0.3.1
f6b3d000 f6b57000 r-xp /usr/lib/libecore_con.so.1.7.99
f6b60000 f6b69000 r-xp /usr/lib/libedbus.so.1.7.99
f6b71000 f6bc1000 r-xp /usr/lib/libecore_x.so.1.7.99
f6bc3000 f6bcc000 r-xp /usr/lib/libvconf.so.0.2.45
f6bd4000 f6be5000 r-xp /usr/lib/libecore_input.so.1.7.99
f6bed000 f6bf2000 r-xp /usr/lib/libecore_file.so.1.7.99
f6bfa000 f6c1c000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6c25000 f6c66000 r-xp /usr/lib/libeina.so.1.7.99
f6c6f000 f6c88000 r-xp /usr/lib/libeet.so.1.7.99
f6c99000 f6d02000 r-xp /lib/libm-2.13.so
f6d0b000 f6d11000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d1a000 f6d1b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d23000 f6d46000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d4e000 f6d53000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d5b000 f6d85000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d8e000 f6da5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dad000 f6db8000 r-xp /lib/libunwind.so.8.0.1
f6de5000 f6e03000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e0d000 f6f31000 r-xp /lib/libc-2.13.so
f6f3f000 f6f47000 r-xp /lib/libgcc_s-4.6.so.1
f6f48000 f6f4c000 r-xp /usr/lib/libsmack.so.1.0.0
f6f55000 f6f5b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f6f63000 f7033000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7034000 f7092000 r-xp /usr/lib/libedje.so.1.7.99
f709c000 f70b3000 r-xp /usr/lib/libecore.so.1.7.99
f70ca000 f7198000 r-xp /usr/lib/libevas.so.1.7.99
f71bd000 f72f9000 r-xp /usr/lib/libelementary.so.1.7.99
f7310000 f7324000 r-xp /lib/libpthread-2.13.so
f732f000 f7331000 r-xp /usr/lib/libdlog.so.0.0.0
f7339000 f733c000 r-xp /usr/lib/libbundle.so.0.1.22
f7344000 f7346000 r-xp /lib/libdl-2.13.so
f734f000 f735c000 r-xp /usr/lib/libaul.so.0.1.0
f736e000 f7374000 r-xp /usr/lib/libappcore-efl.so.1.1
f737d000 f7381000 r-xp /usr/lib/libsys-assert.so
f738a000 f73a7000 r-xp /lib/ld-2.13.so
f73b0000 f73b5000 r-xp /usr/bin/launchpad-loader
f782a000 f7a56000 rw-p [heap]
ffd9d000 ffdbe000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16071)
Call Stack Count: 1
 0: strlen + 0x4 (0xf6e830b4) [/lib/libc.so.6] + 0x760b4
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
ARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-22 12:40:19.739-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-22 12:40:19.739-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 22-2-2017, 18:48:15 (UTC).
02-22 12:40:19.739-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-22 12:40:19.749-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-22 12:40:19.759-0600 W/SNL_W   (15574): <setAlarm:571> setAlarm() - end : mStatus ( 1 ) currentInterval( 480 ) interruptFlag ( 0 ) alarm_id ( 1702342254 )
02-22 12:40:19.759-0600 W/SNL_W   (15574): <sendKeepAliveAllGroup:752> sendKeepAliveAllGroup() - set last interval ( 240 )
02-22 12:40:19.759-0600 W/SNL_W   (15574): <util_pm_unlock:1166> util_pm_unlock() UNLOCK
02-22 12:40:19.759-0600 W/SNL_W   (15574): <sendKeepAliveAllGroup:758> sendKeepAliveAllGroup () - WakeLock release
02-22 12:40:19.759-0600 W/SNL_W   (15574): <sendKeepAliveAllGroup:770> sendKeepAliveAllGroup() - end Error ( 0 )
02-22 12:40:19.819-0600 W/SNL_W   (15574): <releaseWakeLockinTimeThread:815> releaseWakeLockinTimeThread () - WakeLock already released
02-22 12:40:39.789-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: OnTimerTick(164) > [1;35m BEGIN >>>>[0;m
02-22 12:40:39.789-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:39.789-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:39.789-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:39.789-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:39.799-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: UpdateTime(98) > [1;35mtimeString:[19 min ago][0;m
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:39.799-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(264) > [1;35mhide_title_show_main_sub_text[0;m
02-22 12:40:39.799-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(267) > [1;40;33mtag_icon_not_visible[0;m
02-22 12:40:39.799-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: CreateHeartRateSubTimeString(115) > [1;35mdurationMin:30, diffSec:1810[0;m
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:39.799-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:39.799-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: UpdateTagIcon(194) > [1;35mtag_icon_visible[0;m
02-22 12:40:39.799-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: UpdateTagIcon(202) > [1;35mtag_icon_not_visible-Icon[0;m
02-22 12:40:39.799-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: OnTimerTick(177) > [1;35m END <<<<[0;m
02-22 12:40:39.809-0600 E/EFL     ( 2955): edje<2955> edje_util.c:3785 edje_object_size_min_restricted_calc() group home_heartrate_page has a non-fixed part 'part_tag_icon'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
02-22 12:40:55.329-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
02-22 12:40:55.329-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_context_handler(1302) > Skip the background tick update
02-22 12:40:55.329-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-22 12:40:55.329-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-22 12:40:55.329-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [236363.787356] dpms[3 -> 0]sync[0]
02-22 12:40:55.329-0600 I/TDM     ( 1991): 
02-22 12:40:55.329-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [236363.787555] dpms[0 -> 0]done
02-22 12:40:55.329-0600 I/TDM     ( 1991): 
02-22 12:40:55.359-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : -148844088[0;m
02-22 12:40:55.369-0600 W/wnotibp ( 3797): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
02-22 12:40:55.369-0600 I/wnotibp ( 3797): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
02-22 12:40:55.389-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
02-22 12:40:55.389-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_lcd_status_handler(1235) > Skip the background tick update
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_set(167) > timer set
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_del(157) > timer del
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): gesture.c: _apps_status_get(128) > apps status:0
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): gesture.c: _lcd_on_cb(303) > move_to_clock:1 clock_visible:1 info->offtime:60972
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_schedule(209) > schedule, manual render
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _lcd_on_cb(728) > lcd state: 1
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(336) > appcore resumed manually
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): main.c: home_appcore_resume(505) > Home Appcore Resumed
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): main.c: home_resume(530) > clock/widget resumed
02-22 12:40:55.389-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(67), length(2)
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 67%
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 67, isCharging: 0
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_70
02-22 12:40:55.389-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
02-22 12:40:55.399-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
02-22 12:40:55.399-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-22 12:40:55.399-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-22 12:40:55.399-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [60972]ms
02-22 12:40:55.399-0600 W/STARTER ( 2748): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:40:55.409-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: RESUME State: RUNNING
02-22 12:40:55.409-0600 I/GATE    ( 2815): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [236363.876622] layer(0x4f13f8) not usable
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [236363.876681] layer(0x4f13f8) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [236363.876705] layer[0x4f0f48]zpos[1]
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [236363.876817] layer(0x4f1388) not usable
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [236363.876845] layer(0x4f1388) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [236363.876866] layer[0x4f0e28]zpos[0]
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1442) > [236363.876904] layer(0x4f1448) not usable
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_set_info(1459) > [236363.876925] layer(0x4f1448) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
02-22 12:40:55.419-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_set_info(1578) > [236363.876944] layer[0x4f1068]zpos[2]
02-22 12:40:55.419-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_resume(1124) > widget_resume
02-22 12:40:55.419-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(fg) type(watchapp)
02-22 12:40:55.419-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-22 12:40:55.439-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-22 12:40:55.439-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:40:55.439-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:40:55.439-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
02-22 12:40:55.439-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
02-22 12:40:55.439-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_boolean(1173) > preference_get_boolean(3431) : test_healthy_pace error
02-22 12:40:55.449-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:40:55.449-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-22 12:40:55.459-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-22 12:40:55.459-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:40:55.459-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-22 12:40:55.459-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-22 12:40:55.459-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : -151127284[0;m
02-22 12:40:55.459-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
02-22 12:40:55.459-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-22 12:40:55.459-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
02-22 12:40:55.459-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-22 12:40:55.469-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
02-22 12:40:55.469-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
02-22 12:40:55.469-0600 E/WAKEUP-SERVICE( 3403): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
02-22 12:40:55.469-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
02-22 12:40:55.479-0600 I/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-22 12:40:55.479-0600 W/TIZEN_N_SOUND_MANAGER( 3403): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-22 12:40:55.479-0600 W/WAKEUP-SERVICE( 3403): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
02-22 12:40:55.479-0600 I/HIGEAR  ( 3403): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
02-22 12:40:55.579-0600 W/SHealthCommon( 3431): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
02-22 12:40:55.589-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
02-22 12:40:55.589-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_enable(138) > 0
02-22 12:40:55.589-0600 W/W_HOME  ( 2815): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
02-22 12:40:55.599-0600 W/SHealthCommon( 3431): ExerciseHrHourlyMinMaxStorage.cpp: GetExerciseHrHourlyMinMaxDataFromColumns(138) > [1;40;33mNo record[0;m
02-22 12:40:55.599-0600 W/AUL     (16071): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.tralbrecht.GearS3Running)
02-22 12:40:55.599-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessage(564) > [1;40;33mmessageName: recent_hr_updated, pendingClientInfoList.size(): 0[0;m
02-22 12:40:55.599-0600 W/SHealthCommon( 2955): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-22 12:40:55.629-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 0
02-22 12:40:55.629-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1782) > caller pid : 16071
02-22 12:40:55.639-0600 W/AUL_AMD ( 2534): amd_launch.c: _start_app(1959) > caller process & callee process is same.[org.tralbrecht.GearS3Running:16071]
02-22 12:40:55.649-0600 W/STARTER ( 2748): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
02-22 12:40:55.649-0600 W/STARTER ( 2748): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
02-22 12:40:55.659-0600 I/HealthDataService( 3034): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-22 12:40:55.679-0600 W/AUL     (16071): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-7)
02-22 12:40:55.679-0600 E/AUL     (16071): launch.c: app_request_to_launchpad(304) > app_request_to_launchpad : Same Process Send Local
02-22 12:40:55.679-0600 I/APP_CORE(16071): appcore-efl.c: __do_app(453) > [APP 16071] Event: RESET State: PAUSED
02-22 12:40:55.679-0600 I/CAPI_APPFW_APPLICATION(16071): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-22 12:40:55.679-0600 I/APP_CORE(16071): appcore-efl.c: __do_app(529) > Legacy lifecycle: 0
02-22 12:40:55.679-0600 I/APP_CORE(16071): appcore-efl.c: __do_app(531) > [APP 16071] App already running, raise the window
02-22 12:40:55.679-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:40:55.689-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:40:55.689-0600 I/healthData( 3431): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-22 12:40:55.689-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: latest_hr_updated client list: [2:com.samsung.shealth.widget.heartrate (379618)]][0;m
02-22 12:40:55.699-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:40:55.709-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:40:55.709-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-22 12:40:55.769-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[16071] goes to (3)
02-22 12:40:55.769-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-22 12:40:55.769-0600 W/AUL_AMD ( 2534): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-22 12:40:55.769-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.tralbrecht.GearS3Running) pid(16071) status(fg) type(uiapp)
02-22 12:40:55.779-0600 I/APP_CORE(16071): appcore-efl.c: __do_app(535) > [APP 16071] Call the resume_cb
02-22 12:40:55.779-0600 I/CAPI_APPFW_APPLICATION(16071): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
02-22 12:40:55.779-0600 D/UIB_APP (16071): resuming
02-22 12:40:55.799-0600 W/W_HOME  ( 2815): event_manager.c: _ecore_x_message_cb(428) > state: 0 -> 1
02-22 12:40:55.799-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.799-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.809-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.809-0600 W/W_HOME  ( 2815): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
02-22 12:40:55.809-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:40:55.839-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:40:55.879-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.31][0;m
02-22 12:40:55.889-0600 W/SHealthWidget( 2955): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.heartrate (379618), msgName: latest_hr_updated[0;m
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(1)
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(483) > state: 1 -> 0
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(327) > appcore paused manually
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): main.c: home_appcore_pause(514) > Home Appcore Paused
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _app_pause_cb(397) > state: 1 -> 2
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): main.c: home_pause(546) > clock/widget paused
02-22 12:40:55.889-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-22 12:40:55.889-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:40:55.899-0600 W/SHealthCommon( 2955): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: latest_hr_updated[0;m
02-22 12:40:55.899-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: OnIpcProxyMessageReceived(86) > [1;35m BEGIN >>>>[0;m
02-22 12:40:55.899-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: OnIpcProxyMessageReceived(87) > [1;35mmsgName:[latest_hr_updated], serializedStr:[][0;m
02-22 12:40:55.899-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: UpdateLatestData(128) > [1;35m BEGIN >>>>[0;m
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-22 12:40:55.899-0600 I/MESSAGE_PORT( 2527): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-22 12:40:55.899-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(bg) type(uiapp)
02-22 12:40:55.899-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (4)
02-22 12:40:55.899-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(4)
02-22 12:40:55.899-0600 I/TDM     ( 1991): tdm_display.c: tdm_layer_unset_buffer(1602) > [236364.357759] layer(0x4f1388) now usable
02-22 12:40:55.899-0600 I/TDM     ( 1991): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [236364.357775] layer[0x4f0e28]zpos[0]
02-22 12:40:55.899-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:55.899-0600 W/W_HOME  ( 2815): main.c: _window_visibility_cb(963) > Window [0x2000003] is now visible(1)
02-22 12:40:55.899-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: PAUSE State: RUNNING
02-22 12:40:55.899-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-22 12:40:55.899-0600 W/W_HOME  ( 2815): main.c: _appcore_pause_cb(487) > appcore pause
02-22 12:40:55.899-0600 E/W_HOME  ( 2815): main.c: _pause_cb(465) > paused already
02-22 12:40:55.909-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
02-22 12:40:55.909-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:40:55.909-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [94], notiboard card appending count [210].
02-22 12:40:55.909-0600 I/GATE    ( 2815): <GATE-M>SCREEN_LOADED_HOME</GATE-M>
02-22 12:40:55.919-0600 I/APP_CORE(16071): appcore-efl.c: __do_app(453) > [APP 16071] Event: RESUME State: RUNNING
02-22 12:40:55.919-0600 I/GATE    (16071): <GATE-M>APP_FULLY_LOADED_GearS3Running</GATE-M>
02-22 12:40:55.919-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: PrepareLastestHeartRate(109) > [1;35mlist size:2[0;m
02-22 12:40:55.919-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: PrepareLastestHeartRate(118) > [1;35m ###[0;m
02-22 12:40:55.919-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: UpdateLatestData(133) > [1;35m ###[0;m
02-22 12:40:55.919-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:55.919-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:55.919-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:55.919-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:55.919-0600 E/CAPI_APPFW_APP_CONTROL( 3522): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-22 12:40:55.919-0600 W/MUSIC_CONTROL_SERVICE( 3522): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3522]   [com.samsung.w-home]register msg port [false][0m
02-22 12:40:55.919-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_pause(1113) > widget_pause
02-22 12:40:55.919-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(bg) type(watchapp)
02-22 12:40:55.929-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: UpdateTime(98) > [1;35mtimeString:[Now][0;m
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:55.929-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(264) > [1;35mhide_title_show_main_sub_text[0;m
02-22 12:40:55.929-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: SetEDCStateByCurrentHRValueType(267) > [1;40;33mtag_icon_not_visible[0;m
02-22 12:40:55.929-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: CreateHeartRateSubTimeString(115) > [1;35mdurationMin:20, diffSec:1203[0;m
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:55.929-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:55.929-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: UpdateTagIcon(194) > [1;35mtag_icon_visible[0;m
02-22 12:40:55.929-0600 W/SHealthAppCommon( 2955): HeartRateLayout.cpp: UpdateTagIcon(202) > [1;35mtag_icon_not_visible-Icon[0;m
02-22 12:40:55.929-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: UpdateLatestData(159) > [1;35m END <<<<[0;m
02-22 12:40:55.929-0600 W/SHealthWidget( 2955): HeartRateWidgetViewController.cpp: OnIpcProxyMessageReceived(99) > [1;35m END <<<<[0;m
02-22 12:40:55.929-0600 I/CAPI_WIDGET_APPLICATION( 2955): widget_app.c: __provider_update_cb(281) > received updating signal
02-22 12:40:55.939-0600 E/EFL     ( 2955): edje<2955> edje_util.c:3785 edje_object_size_min_restricted_calc() group home_heartrate_page has a non-fixed part 'part_tag_icon'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
02-22 12:40:55.949-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 0
02-22 12:40:55.949-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_unregister(426) > [windicator_battery_vconfkey_unregister:426] Unset battery cb
02-22 12:40:55.959-0600 W/SHealthCommon( 3431): SystemUtil.cpp: OnDeviceStatusChanged(1064) > [1;35mlcdState:1[0;m
02-22 12:40:55.959-0600 W/SHealthService( 3431): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : pedometer_inactive_period error
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_10min_precaution_millisec error
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-22 12:40:55.989-0600 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3431): preference.c: preference_get_double(1214) > preference_get_double(3431) : inactive_before_10min_precaution_millisec error
02-22 12:40:55.989-0600 W/SHealthCommon( 3431): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1487721600000.000000[0;m
02-22 12:40:56.009-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (828693)]][0;m
02-22 12:40:56.039-0600 W/SHealthWidget( 2955): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (828693), msgName: timeline_summary_updated[0;m
02-22 12:40:56.039-0600 W/SHealthCommon( 2955): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
02-22 12:40:56.039-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.31][0;m
02-22 12:40:56.039-0600 W/SHealthWidget( 2955): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
02-22 12:40:56.049-0600 I/HealthDataService( 3034): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-22 12:40:56.049-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1487767256057.000000, pattern:[HH:mm][0;m
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:56.049-0600 E/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
02-22 12:40:56.049-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[12:40][0;m
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-22 12:40:56.049-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-22 12:40:56.069-0600 I/CAPI_WIDGET_APPLICATION( 2955): widget_app.c: __provider_update_cb(281) > received updating signal
02-22 12:40:56.099-0600 I/healthData( 3431): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-22 12:40:56.279-0600 E/AUL     ( 2534): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
02-22 12:40:56.399-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: MEM_FLUSH State: PAUSED
02-22 12:40:57.039-0600 E/EFL     (16071): ecore_x<16071> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236365418 button=1
02-22 12:40:57.039-0600 E/EFL     (16071): ecore_x<16071> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236365495 button=1
02-22 12:40:57.039-0600 D/UIB_APP (16071): Pausing fit
02-22 12:40:57.739-0600 E/EFL     (16071): ecore_x<16071> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=236366190 button=1
02-22 12:40:57.809-0600 E/EFL     (16071): ecore_x<16071> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=236366262 button=1
02-22 12:40:58.059-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 16071 pgid = 16071
02-22 12:40:58.059-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-22 12:40:58.159-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (3)
02-22 12:40:58.159-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(3)
02-22 12:40:58.159-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-22 12:40:58.159-0600 W/AUL_AMD ( 2534): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-22 12:40:58.159-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(fg) type(uiapp)
02-22 12:40:58.219-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-22 12:40:58.219-0600 W/W_HOME  ( 2815): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-22 12:40:58.219-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.219-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.219-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.219-0600 W/W_HOME  ( 2815): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-22 12:40:58.239-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-22 12:40:58.239-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-22 12:40:58.239-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-22 12:40:58.249-0600 I/AUL_AMD ( 2534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16071
02-22 12:40:58.249-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16071)
02-22 12:40:58.289-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
02-22 12:40:58.289-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-22 12:40:58.289-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.289-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.289-0600 W/W_HOME  ( 2815): main.c: _window_visibility_cb(963) > Window [0x2000003] is now visible(0)
02-22 12:40:58.299-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: RESUME State: PAUSED
02-22 12:40:58.299-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): main.c: _appcore_resume_cb(478) > appcore resume
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): main.c: home_resume(530) > clock/widget resumed
02-22 12:40:58.299-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-22 12:40:58.299-0600 I/GATE    ( 2815): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-22 12:40:58.299-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-22 12:40:58.299-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-22 12:40:58.299-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
02-22 12:40:58.309-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_resume(1124) > widget_resume
02-22 12:40:58.309-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(fg) type(watchapp)
02-22 12:40:58.309-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-22 12:40:58.329-0600 W/CRASH_MANAGER(16212): worker.c: worker_job(1199) > 1116071676561148778885
