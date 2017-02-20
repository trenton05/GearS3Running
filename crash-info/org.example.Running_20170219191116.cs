S/W Version Information
Model: SM-R765A
Tizen-Version: 2.3.2.0
Build-Number: R765AUCU1APJ8
Build-Date: 2016.10.20 20:15:27

Crash Information
Process Name: runner
PID: 4984
Date: 2017-02-19 19:11:16-0600
Executable File Path: /opt/usr/apps/org.example.Running/bin/runner
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4984, uid 5000)

Register Information
r0   = 0x00000028, r1   = 0xee814724
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x00000000, r5   = 0xf1c90578
r6   = 0xee8146f8, r7   = 0xff9e6d88
r8   = 0xf1ca48e8, r9   = 0x00000000
r10  = 0x00000001, fp   = 0x0000000f
ip   = 0xf71caa9c, sp   = 0xff9e6c08
lr   = 0xf71caaac, pc   = 0xf71caaac
cpsr = 0x60000010

Memory Information
MemTotal:   620364 KB
MemFree:     10108 KB
Buffers:      6460 KB
Cached:     121780 KB
VmPeak:     150628 KB
VmSize:     150624 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       42336 KB
VmRSS:       42332 KB
VmData:      58756 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       44808 KB
VmPTE:         192 KB
VmSwap:          0 KB

Threads Information
Threads: 7
PID = 4984 TID = 4984
4984 5063 5070 5071 5111 5112 5114 

Maps Information
eee25000 eee35000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
eee3d000 eee49000 r-xp /usr/lib/libhogweed.so.2.0
eee52000 eee79000 r-xp /usr/lib/libgmp.so.3.4.1
eee82000 eeea3000 r-xp /usr/lib/libnettle.so.4.0
eeeab000 eef22000 r-xp /usr/lib/libgnutls.so.26.22.4
eef37000 eef3c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
eef44000 eef4f000 r-xp /usr/lib/gio/modules/libgiognutls.so
ef0d5000 ef953000 rw-p [stack:5114]
efb50000 f034f000 rw-p [stack:5111]
f0350000 f0b4f000 rw-p [stack:5071]
f0b50000 f134f000 rw-p [stack:5070]
f134f000 f1351000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f135a000 f1b59000 rw-p [stack:5063]
f1d01000 f1d05000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f1d10000 f1d11000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
f1d19000 f1d1c000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.86
f1d24000 f1d28000 r-xp /usr/lib/location/module/libgps.so.0.5.86
f1e87000 f2686000 rw-p [stack:5112]
f2686000 f2688000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
f2690000 f26a7000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
f26b4000 f26b9000 r-xp /usr/lib/bufmgr/libtbm_exynos.so.0.0.0
f26c1000 f26cc000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
f29f4000 f2ae6000 r-xp /usr/lib/libCOREGL.so.4.0
f2aff000 f2b03000 r-xp /usr/lib/libogg.so.0.7.1
f2b0b000 f2b2d000 r-xp /usr/lib/libvorbis.so.0.4.3
f2b35000 f2b3a000 r-xp /usr/lib/libsystem.so.0.0.0
f2b44000 f2b4a000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f2b52000 f2b61000 r-xp /usr/lib/libmdm-common.so.1.1.22
f2b6a000 f2bb1000 r-xp /usr/lib/libsndfile.so.1.0.26
f2bbd000 f2c06000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
f2c0f000 f2c14000 r-xp /usr/lib/libjson.so.0.0.1
f2c1c000 f2c1f000 r-xp /usr/lib/libtinycompress.so.0.0.0
f2c27000 f2c2d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
f2c35000 f2c40000 r-xp /usr/lib/libresourced.so.0.2.96
f2c48000 f2c49000 r-xp /usr/lib/librd-network.so.0.2.96
f2c51000 f2c52000 r-xp /usr/lib/libresponse.so.0.2.96
f2c5a000 f2c5f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f2c68000 f2c6a000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f2c72000 f2c79000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f2c82000 f2c87000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
f2c8f000 f2c91000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
f2c99000 f2cba000 r-xp /usr/lib/libexif.so.12.3.3
f2ccd000 f2ce6000 r-xp /usr/lib/libnetwork.so.0.0.0
f2cee000 f2cf4000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f2cfd000 f2d45000 r-xp /usr/lib/libmdm.so.1.2.62
f2d46000 f2d53000 r-xp /usr/lib/libail.so.0.1.0
f2d5c000 f2d5f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
f2d67000 f2d9f000 r-xp /usr/lib/libpulse.so.0.16.2
f2da0000 f2da3000 r-xp /usr/lib/libpulse-simple.so.0.0.4
f2dab000 f2e0c000 r-xp /usr/lib/libasound.so.2.0.0
f2e16000 f2e30000 r-xp /usr/lib/libavsysaudio.so.0.0.1
f2e38000 f2e3f000 r-xp /usr/lib/libmmfcommon.so.0.0.0
f2e47000 f2e4b000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
f2e53000 f2e57000 r-xp /usr/lib/libmmfsession.so.0.0.0
f2e60000 f2e62000 r-xp /usr/lib/libttrace.so.1.1
f4702000 f4703000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
f470c000 f470f000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
f4717000 f4739000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f4742000 f4747000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
f474f000 f479f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
f47a5000 f47ae000 r-xp /usr/lib/libcom-core.so.0.0.1
f47b7000 f47c1000 r-xp /usr/lib/libspdy.so.0.0.0
f47ca000 f47d0000 r-xp /usr/lib/libxcb-render.so.0.0.0
f47d8000 f47d9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
f47e2000 f47f1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f47fa000 f4804000 r-xp /usr/lib/libsensord-shared.so
f480c000 f481c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.63
f4824000 f483d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f4845000 f484c000 r-xp /usr/lib/libminizip.so.1.0.0
f4854000 f485f000 r-xp /usr/lib/libtbm.so.1.0.0
f4867000 f4880000 r-xp /usr/lib/libstt.so
f4888000 f489f000 r-xp /usr/lib/libmmfsound.so.0.1.0
f48b1000 f48b6000 r-xp /usr/lib/libmemenv.so.1.1.0
f48be000 f48fa000 r-xp /usr/lib/libleveldb.so.1.1.0
f4903000 f4910000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
f4919000 f491b000 r-xp /usr/lib/libdri2.so.0.0.0
f4923000 f492e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
f493b000 f4942000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
f494a000 f4973000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
f497c000 f4980000 r-xp /usr/lib/libEGL.so.1.4
f4990000 f49a1000 r-xp /usr/lib/libGLESv2.so.2.0
f49b1000 f49bf000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
f49c8000 f49e0000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
f49e9000 f49f2000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
f49fa000 f4a3b000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
f4a44000 f4adf000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
f4aeb000 f4af3000 r-xp /usr/lib/libdrm.so.2.4.0
f4afb000 f4c01000 r-xp /usr/lib/libicuuc.so.57.1
f4c17000 f4d9f000 r-xp /usr/lib/libicui18n.so.57.1
f4daf000 f4dd2000 r-xp /usr/lib/libui-extension.so.0.1.0
f4ddb000 f4ded000 r-xp /usr/lib/libefl-assist.so.0.1.0
f4df5000 f4dfd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f4e05000 f4e17000 r-xp /usr/lib/libcapi-media-camera.so.0.1.35
f4e1f000 f4e22000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
f4e2a000 f4e3d000 r-xp /usr/lib/libwidget_service.so.1.0.0
f4e46000 f4e92000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
f4e9c000 f4e9d000 r-xp /usr/lib/libharfbuzz-icu.so.0.10200.4
f4ea5000 f4f5d000 r-xp /usr/lib/libcairo.so.2.11200.14
f4f68000 f4f6d000 r-xp /usr/lib/libctx-client.so.0.8.3
f4f75000 f4f7c000 r-xp /usr/lib/libctx-shared.so.0.8.3
f4f84000 f4fae000 r-xp /usr/lib/libsensor.so.1.9.3
f4fb7000 f4ff1000 r-xp /usr/lib/libSLP-location.so.0.9.23
f4ffa000 f5010000 r-xp /usr/lib/libtts.so
f5019000 f501e000 r-xp /usr/lib/libstorage.so.0.1
f5026000 f5eea000 r-xp /usr/lib/libewebkit2.so.152340_0.10.283.4
f5fd0000 f5ff1000 r-xp /usr/lib/libefl-extension.so.0.1.0
f5ff9000 f6005000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f600e000 f6013000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f601b000 f6020000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
f6028000 f6036000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f603f000 f604c000 r-xp /opt/usr/apps/org.example.Running/bin/runner
f61ee000 f61f8000 r-xp /lib/libnss_files-2.13.so
f6201000 f62d0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
f62e6000 f630a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
f6313000 f6319000 r-xp /usr/lib/libappsvc.so.0.1.0
f6321000 f6325000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6332000 f633d000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
f6345000 f6347000 r-xp /usr/lib/libiniparser.so.0
f6350000 f6355000 r-xp /usr/lib/libappcore-common.so.1.1
f635d000 f635f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6368000 f636c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
f6379000 f637b000 r-xp /usr/lib/libXau.so.6.0.0
f6383000 f638a000 r-xp /lib/libcrypt-2.13.so
f63ba000 f63bc000 r-xp /usr/lib/libiri.so
f63c5000 f656e000 r-xp /usr/lib/libcrypto.so.1.0.0
f658e000 f65d5000 r-xp /usr/lib/libssl.so.1.0.0
f65e1000 f660f000 r-xp /usr/lib/libidn.so.11.5.44
f6617000 f6620000 r-xp /usr/lib/libcares.so.2.1.0
f662a000 f663d000 r-xp /usr/lib/libxcb.so.1.1.0
f6646000 f6649000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6651000 f6653000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f665c000 f6728000 r-xp /usr/lib/libxml2.so.2.7.8
f6735000 f6737000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6740000 f6745000 r-xp /usr/lib/libffi.so.5.0.10
f674d000 f674e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6756000 f6759000 r-xp /lib/libattr.so.1.1.0
f6761000 f67f5000 r-xp /usr/lib/libstdc++.so.6.0.16
f6808000 f6825000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f682f000 f6847000 r-xp /usr/lib/libpng12.so.0.50.0
f684f000 f6865000 r-xp /lib/libexpat.so.1.6.0
f686f000 f68b3000 r-xp /usr/lib/libcurl.so.4.3.0
f68bc000 f68c6000 r-xp /usr/lib/libXext.so.6.4.0
f68cf000 f68d3000 r-xp /usr/lib/libXtst.so.6.1.0
f68db000 f68e1000 r-xp /usr/lib/libXrender.so.1.3.0
f68e9000 f68ef000 r-xp /usr/lib/libXrandr.so.2.2.0
f68f7000 f68f8000 r-xp /usr/lib/libXinerama.so.1.0.0
f6901000 f690a000 r-xp /usr/lib/libXi.so.6.1.0
f6912000 f6915000 r-xp /usr/lib/libXfixes.so.3.1.0
f691d000 f691f000 r-xp /usr/lib/libXgesture.so.7.0.0
f6927000 f6929000 r-xp /usr/lib/libXcomposite.so.1.0.0
f6931000 f6933000 r-xp /usr/lib/libXdamage.so.1.1.0
f693b000 f6942000 r-xp /usr/lib/libXcursor.so.1.0.2
f694a000 f694d000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
f6955000 f6959000 r-xp /usr/lib/libecore_ipc.so.1.7.99
f6962000 f6967000 r-xp /usr/lib/libecore_fb.so.1.7.99
f6970000 f6a51000 r-xp /usr/lib/libX11.so.6.3.0
f6a5c000 f6a7f000 r-xp /usr/lib/libjpeg.so.8.0.2
f6a97000 f6aad000 r-xp /lib/libz.so.1.2.5
f6ab5000 f6ab7000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6abf000 f6b34000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b3e000 f6b58000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b60000 f6b94000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b9d000 f6c70000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c7b000 f6c8b000 r-xp /lib/libresolv-2.13.so
f6c8f000 f6ca7000 r-xp /usr/lib/liblzma.so.5.0.3
f6caf000 f6cb2000 r-xp /lib/libcap.so.2.21
f6cba000 f6ce9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cf1000 f6cf2000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
f6cfa000 f6d00000 r-xp /usr/lib/libecore_imf.so.1.7.99
f6d08000 f6d1f000 r-xp /usr/lib/liblua-5.1.so
f6d28000 f6d2f000 r-xp /usr/lib/libembryo.so.1.7.99
f6d37000 f6d3d000 r-xp /lib/librt-2.13.so
f6d46000 f6d9c000 r-xp /usr/lib/libpixman-1.so.0.28.2
f6da9000 f6dff000 r-xp /usr/lib/libfreetype.so.6.11.3
f6e0b000 f6e33000 r-xp /usr/lib/libfontconfig.so.1.8.0
f6e34000 f6e79000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
f6e82000 f6e95000 r-xp /usr/lib/libfribidi.so.0.3.1
f6e9d000 f6eb7000 r-xp /usr/lib/libecore_con.so.1.7.99
f6ec0000 f6ec9000 r-xp /usr/lib/libedbus.so.1.7.99
f6ed1000 f6f21000 r-xp /usr/lib/libecore_x.so.1.7.99
f6f23000 f6f2c000 r-xp /usr/lib/libvconf.so.0.2.45
f6f34000 f6f45000 r-xp /usr/lib/libecore_input.so.1.7.99
f6f4d000 f6f52000 r-xp /usr/lib/libecore_file.so.1.7.99
f6f5a000 f6f7c000 r-xp /usr/lib/libecore_evas.so.1.7.99
f6f85000 f6fc6000 r-xp /usr/lib/libeina.so.1.7.99
f6fcf000 f6fe8000 r-xp /usr/lib/libeet.so.1.7.99
f6ff9000 f7062000 r-xp /lib/libm-2.13.so
f706b000 f7071000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f707a000 f707b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7083000 f70a6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70ae000 f70b3000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70bb000 f70e5000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70ee000 f7105000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f710d000 f7118000 r-xp /lib/libunwind.so.8.0.1
f7145000 f7163000 r-xp /usr/lib/libsystemd.so.0.4.0
f716d000 f7291000 r-xp /lib/libc-2.13.so
f729f000 f72a7000 r-xp /lib/libgcc_s-4.6.so.1
f72a8000 f72ac000 r-xp /usr/lib/libsmack.so.1.0.0
f72b5000 f72bb000 r-xp /usr/lib/libprivilege-control.so.0.0.2
f72c3000 f7393000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7394000 f73f2000 r-xp /usr/lib/libedje.so.1.7.99
f73fc000 f7413000 r-xp /usr/lib/libecore.so.1.7.99
f742a000 f74f8000 r-xp /usr/lib/libevas.so.1.7.99
f751d000 f7659000 r-xp /usr/lib/libelementary.so.1.7.99
f7670000 f7684000 r-xp /lib/libpthread-2.13.so
f768f000 f7691000 r-xp /usr/lib/libdlog.so.0.0.0
f7699000 f769c000 r-xp /usr/lib/libbundle.so.0.1.22
f76a4000 f76a6000 r-xp /lib/libdl-2.13.so
f76af000 f76bc000 r-xp /usr/lib/libaul.so.0.1.0
f76ce000 f76d4000 r-xp /usr/lib/libappcore-efl.so.1.1
f76dd000 f76e1000 r-xp /usr/lib/libsys-assert.so
f76ea000 f7707000 r-xp /lib/ld-2.13.so
f7710000 f7715000 r-xp /usr/bin/launchpad-loader
f7d6b000 f8170000 rw-p [heap]
ff9c9000 ff9ea000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4984)
Call Stack Count: 6
 0: fputs + 0x10 (0xf71caaac) [/lib/libc.so.6] + 0x5daac
 1: __send_response + 0x138 (0xf604660d) [/opt/usr/apps/org.example.Running/bin/runner] + 0x760d
 2: _on_auth_grant_received + 0x226 (0xf604697b) [/opt/usr/apps/org.example.Running/bin/runner] + 0x797b
 3: __on_web_url_change + 0x38 (0xf60463e9) [/opt/usr/apps/org.example.Running/bin/runner] + 0x73e9
 4: evas_object_smart_callback_call + 0x88 (0xf745f5cd) [/usr/lib/libevas.so.1] + 0x355cd
 5: (0xf528d4d5) [/usr/lib/libewebkit2.so.0] + 0x2674d5
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
 W/SHealthCommon( 2955): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
02-19 19:11:00.361-0600 W/SHealthWidget( 2955): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
02-19 19:11:00.361-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1487531460372.000000, pattern:[HH:mm][0;m
02-19 19:11:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-19 19:11:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-19 19:11:00.361-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-19 19:11:00.361-0600 E/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale en_US[0;m
02-19 19:11:00.371-0600 W/SHealthCommon( 3431): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.31][0;m
02-19 19:11:00.371-0600 W/WSLib   ( 2955): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[19:11][0;m
02-19 19:11:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-19 19:11:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
02-19 19:11:00.371-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2955): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
02-19 19:11:00.371-0600 I/CAPI_WIDGET_APPLICATION( 2955): widget_app.c: __provider_update_cb(281) > received updating signal
02-19 19:11:00.401-0600 I/HealthDataService( 3034): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
02-19 19:11:00.421-0600 I/healthData( 3431): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
02-19 19:11:00.541-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=834058 button=1
02-19 19:11:00.641-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [0][0m
02-19 19:11:00.701-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=20[0m
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-19 19:11:00.961-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-19 19:11:00.981-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-19 19:11:00.981-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:00.981-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-19 19:11:00.981-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-19 19:11:00.991-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
02-19 19:11:00.991-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:00.991-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
02-19 19:11:00.991-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2994): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
02-19 19:11:01.651-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1c00003 time=834263
02-19 19:11:01.651-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=834263
02-19 19:11:02.131-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=835639 button=1
02-19 19:11:02.781-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=836296 button=1
02-19 19:11:03.251-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=836763 button=1
02-19 19:11:03.391-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=836902 button=1
02-19 19:11:03.651-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_reset_ise_input_context(1367) > [0;36m[hidden state:false][0m
02-19 19:11:03.691-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=0[0m
02-19 19:11:03.701-0600 E/SWIFTKEY( 2650): swiftkey_engine.cpp: IME_Learn_sentence(2549) > [0;31mskip : session is null[0m
02-19 19:11:03.701-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_reset_ise_input_context(1367) > [0;36m[hidden state:false][0m
02-19 19:11:03.791-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x3a0000f FAILED!
02-19 19:11:03.801-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x3a0000f FAILED!
02-19 19:11:03.801-0600 E/ISE_MULTI( 2784): ise-rotary-event-listener.cpp: rotary_input_clear(129) > [0;31mrotary_input_clear[0m
02-19 19:11:03.801-0600 I/efl-extension( 2784): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
02-19 19:11:03.801-0600 I/efl-extension( 2784): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
02-19 19:11:03.801-0600 I/efl-extension( 2784): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
02-19 19:11:03.801-0600 E/ISE_MULTI( 2784): rotary_input.cpp: destroy_rotary_input_layout(755) > [0;31mdestroy_rotary_input_layout[0m
02-19 19:11:03.801-0600 E/ISE_MULTI( 2784): ise-ui.cpp: destroy_indicator(1517) > [0;31mdestroy_indicator[0m
02-19 19:11:04.721-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=838238 button=1
02-19 19:11:04.821-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=838337 button=1
02-19 19:11:05.161-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x3a0000f FAILED!
02-19 19:11:05.161-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x3a0000f FAILED!
02-19 19:11:05.181-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_set_return_key_disable(1247) > [0;36m[hidden state:true] disabled=0[0m
02-19 19:11:05.181-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2784): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
02-19 19:11:05.181-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2784): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
02-19 19:11:05.181-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2784): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=4
02-19 19:11:05.181-0600 E/TIZEN_N_SYSTEM_SETTINGS( 2784): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 4, key = 4, type = 0
02-19 19:11:05.311-0600 I/ISE_MULTI( 2784): xt9-setting.cpp: xt9_change_onoff(133) > [0;36mxt9_change_onoff, fEnable[0],xt9Context.xt9OnOff[0],gFPredictionDisabled[1] [0m
02-19 19:11:05.311-0600 I/ISE_MULTI( 2784): ise.cpp: ise_show(2296) > [0;36m--------BEFORE set is_candidate_on-----------[0m
02-19 19:11:05.311-0600 I/ISE_MULTI( 2784): ise.cpp: relocate_main_window(335) > [0;36m----------START----------[0m
02-19 19:11:05.311-0600 E/ISE_MULTI( 2784): ise-rotary-event-listener.cpp: rotary_input_init(119) > [0;31mrotary_input_init[0m
02-19 19:11:05.401-0600 I/CANDIDATE( 2784): soft_candidate.cpp: ui_candidate_hide(1039) > [0;36mcandidate_hide[0m
02-19 19:11:05.451-0600 E/ISE_MULTI( 2784): ise-ui.cpp: indicator_popup_show_cb(1533) > [0;31mindicator_popup_show_cb[0m
02-19 19:11:05.451-0600 E/MALI    ( 2784): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-19 19:11:05.491-0600 E/MALI    ( 2784): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-19 19:11:05.501-0600 E/MALI    ( 2784): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-19 19:11:05.701-0600 E/AUL_AMD ( 2534): amd_appinfo.c: appinfo_get_value(1257) > appinfo get value: Invalid argument, 9
02-19 19:11:05.701-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2784] goes to (3)
02-19 19:11:05.831-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3a0000f time=839228
02-19 19:11:05.831-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=839228
02-19 19:11:05.841-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=839228
02-19 19:11:05.961-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1c00003 FAILED!
02-19 19:11:05.961-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x1c00003 FAILED!
02-19 19:11:08.121-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=841629 button=1
02-19 19:11:08.201-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57591][0m
02-19 19:11:08.211-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57591
02-19 19:11:08.211-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57591
02-19 19:11:08.231-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=1[0m
02-19 19:11:08.361-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=841871 button=1
02-19 19:11:08.421-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57591][0m
02-19 19:11:08.421-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57591
02-19 19:11:08.421-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57591
02-19 19:11:08.531-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=842042 button=1
02-19 19:11:08.651-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57591][0m
02-19 19:11:08.671-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57591
02-19 19:11:08.671-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57591
02-19 19:11:09.321-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=842835 button=1
02-19 19:11:09.401-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57590][0m
02-19 19:11:09.411-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57590
02-19 19:11:09.411-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57590
02-19 19:11:09.521-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=2[0m
02-19 19:11:09.561-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=843069 button=1
02-19 19:11:09.621-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57590][0m
02-19 19:11:09.621-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57590
02-19 19:11:09.621-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57590
02-19 19:11:09.731-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=843242 button=1
02-19 19:11:09.841-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57590][0m
02-19 19:11:09.841-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57590
02-19 19:11:09.841-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57590
02-19 19:11:10.391-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=843904 button=1
02-19 19:11:10.481-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57588][0m
02-19 19:11:10.481-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57588
02-19 19:11:10.481-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57588
02-19 19:11:10.501-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=3[0m
02-19 19:11:11.001-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=844509 button=1
02-19 19:11:11.081-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57592][0m
02-19 19:11:11.081-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57592
02-19 19:11:11.081-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57592
02-19 19:11:11.101-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=4[0m
02-19 19:11:11.211-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=844727 button=1
02-19 19:11:11.291-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57592][0m
02-19 19:11:11.291-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57592
02-19 19:11:11.291-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57592
02-19 19:11:12.171-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=845680 button=1
02-19 19:11:12.251-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57587][0m
02-19 19:11:12.251-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57587
02-19 19:11:12.251-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57587
02-19 19:11:12.271-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=5[0m
02-19 19:11:12.391-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=845905 button=1
02-19 19:11:12.481-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [57587][0m
02-19 19:11:12.481-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57587
02-19 19:11:12.481-0600 W/IMMODULE( 4984): isf_imf_context.cpp: feed_key_event(2501) > Unknown key code : 57587
02-19 19:11:13.101-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=846617 button=1
02-19 19:11:13.261-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: recv - ConnID( 3 ), Res( -4 )
02-19 19:11:13.261-0600 W/SNL_W   ( 3767): <sec_recv_w:365> sec_recv_w res ( -4 ) sendKeepAliveAllgroup start
02-19 19:11:13.261-0600 W/SNL_W   ( 3767): <sec_recv_w:369> sendKeepAliveAllGroupThread detached successfully
02-19 19:11:13.261-0600 E/SCSD    ( 3767): <recv_thread:183> sec_recv() ret: -4
02-19 19:11:13.261-0600 W/SNL_W   ( 3767): <sec_close_w:323> sec_close_w - sec_close_w begin()
02-19 19:11:13.261-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: close - Call ConnID( 3 ), Timeout ( 0 )
02-19 19:11:13.261-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:672> sendKeepAliveAllGroup() - begin
02-19 19:11:13.261-0600 W/SNL_W   ( 3767): <releaseAlarm:495> stop alarm_id(582828755)
02-19 19:11:13.261-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: release_conn(3) read(18384), sent(792)
02-19 19:11:13.271-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [3767].
02-19 19:11:13.271-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(582828755)
02-19 19:11:13.271-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-19 19:11:13.271-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-19 19:11:13.271-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 20-2-2017, 02:04:35 (UTC).
02-19 19:11:13.271-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: send_msg - ( 0xf7 ), type( 0x03 ), res( 296 ), seq( 0 )
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: noti_ps - Call()
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: noti_ps - Res( 0 )
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <presSendNotify_i:996> presSendNotify_w ( 1a3cd1e255442a96e0b3c138 ) - begin
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <presSendNotify_i:1001> presSendNotify_w ( 1a3cd1e255442a96e0b3c138 ) - Interrupt (Not SKA)
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: get_glist - Call()
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: dcc - id( 3 )
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: get_glist - Res( 0 )
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <releaseAlarm:495> stop alarm_id(582828755)
02-19 19:11:13.281-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: d_c_s_l - con_candidate seq( 1 )
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: d_c_s_l - con_candidate seq( 1 ), connid( 3 )
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: scs_dis-connid( 3 ), peer( -143781856 )
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: sc_dis connid( 3 ), way( 4)
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: sc_dis .
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: scs_dis-res
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: dcc - end(0)
02-19 19:11:13.281-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: close - Res( 0 )
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <deleteConnIdData:205> ==== deleteConnIdData Start conn_id[3] ====
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <deleteConnIdData:218> deleteConnIdData timestamp( 1487552832 )
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <deleteConnIdData:233> ==== deleteConnIdData end res[0] ====
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <sec_close_w:327> sec_close_w - D2D close is Running -conn_id ( 3) deleted 
02-19 19:11:13.281-0600 W/SNL_W   ( 3767): <sec_close_w:330> sec_close_w - sec_close_w res( 0 )
02-19 19:11:13.281-0600 W/SCSD    ( 3767): <_disconnected_cb:492> SCS Peer Disconnected !!!
02-19 19:11:13.281-0600 W/SCSD    ( 3767): <_disconnected_cb:493>  - conn_id: 3
02-19 19:11:13.281-0600 W/SCSD    ( 3767): <util_dbus_set_connection_status:267> set connection_status: 0
02-19 19:11:13.281-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[582828755] is removed.
02-19 19:11:13.281-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [3767].
02-19 19:11:13.281-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2455) > Unable to delete the alarm! alarm_id[582828755], return_code[-9]
02-19 19:11:13.291-0600 W/SNL_W   ( 3767): <setAlarm:522> setAlarm() - begin 
02-19 19:11:13.291-0600 W/SNL_W   ( 3767): <initAlarm:507> InitAlarm() - begin
02-19 19:11:13.291-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: get_glist - Call()
02-19 19:11:13.291-0600 W/SNL_W   ( 3767): <initAlarm:513> InitAlarm() success - end
02-19 19:11:13.291-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: get_glist - Res( 0 )
02-19 19:11:13.291-0600 W/SNL_W   ( 3767): <util_pm_lock:1144> util_pm_lock() LOCK
02-19 19:11:13.291-0600 E/ALARM_MANAGER( 3767): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(1435), start(19-2-2017, 19:35:08), repeat(0), interval(0), type(-1073741822)
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(397) > network status : 0
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(402) > sap_connected : 1
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(408) > sap connectivity type : 16
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(414) > network status : 2
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(421) > svc type : 7
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(428) > scs login : 1
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_event.c: _wmanager_connectivity_get(456) > network connection via WIFI : no checking svc_type
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_view_indicator.c: _view_remove_by_type(267) > removed:4
02-19 19:11:13.301-0600 W/W_HOME  ( 2815): clock_indicator.c: clock_indicator_pop(364) > icon:5(0) is popped from clock indicator
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(42) > [windicator_scs_update:42] sales code : 0
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(49) > [windicator_scs_update:49] sap connected : 1
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(63) > [windicator_scs_update:63] ciss_request_type : 0
02-19 19:11:13.301-0600 I/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(73) > [windicator_scs_update:73] Hide (Callforwarding requested)
02-19 19:11:13.301-0600 I/W_INDICATOR( 2749): windicator.c: windicator_is_lo_connected(945) > [windicator_is_lo_connected:945] Connected target vendor : ZTE
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(108) > [windicator_scs_update:108] sap connectivity type : 16
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(115) > [windicator_scs_update:115] network status : 2
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(122) > [windicator_scs_update:122] svc type : 7
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(130) > [windicator_scs_update:130] scs login : 1
02-19 19:11:13.301-0600 W/W_INDICATOR( 2749): windicator_scs.c: windicator_scs_update(139) > [windicator_scs_update:139] network connection via WIFI : no checking svc_type
02-19 19:11:13.311-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:708> releaseWakeLockinTimeThread detached successfully
02-19 19:11:13.311-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:721> 0 sendKeepAliveThread detached successfully
02-19 19:11:13.311-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [3767].
02-19 19:11:13.311-0600 W/SNL_W   ( 3767): <sendKeepAliveThread:865> sendKeepAliveThread() - presSendNotify(1) begin
02-19 19:11:13.311-0600 W/SCSD    ( 3767): <on_presSendNotify:426> sent keepalive (group_id: 1a3cd1e255442a96e0b3c138) (S:10/F:11/T:21) (msg_id: 1)
02-19 19:11:13.311-0600 W/SCSD    ( 3767): <_keepalive_cb:520> entrance
02-19 19:11:13.311-0600 W/SCSD    ( 3767): <util_dbus_send_keepalive_sent:287> entrance
02-19 19:11:13.311-0600 W/SNL_W   ( 3767): <sendKeepAliveThread:867> sendKeepAliveThread() - presSendNotify(1) end
02-19 19:11:13.311-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: sKA - group( 1a3cd1e255442a96e0b3c138 ) mtype( 0 ) timeout( 30000 )
02-19 19:11:13.311-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: sKA
02-19 19:11:13.311-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: send_msg - ( 0xfc ), type( 0x01 ), res( 152 ), seq( 1021 )
02-19 19:11:13.311-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: noti_ps - Call()
02-19 19:11:13.311-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: noti_ps - Res( 0 )
02-19 19:11:13.311-0600 W/SNL_W   ( 3767): <presSendNotify_i:996> presSendNotify_w ( 1a3cd1e255442a96e0b3c138 ) - begin
02-19 19:11:13.311-0600 W/SNL_W   ( 3767): <presSendNotify_i:1019> presSendNotify_w ( 1a3cd1e255442a96e0b3c138 ) - end
02-19 19:11:13.311-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: noti_ps_th - Res( )
02-19 19:11:13.321-0600 W/SCSD    ( 3767): <util_tel_set_ps_dormant:19> request FD, svc_type (7)
02-19 19:11:13.331-0600 I/AUL     ( 2496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
02-19 19:11:13.331-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 15
02-19 19:11:13.331-0600 E/ALARM_MANAGER( 2496): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1487554508, Sun Feb 19 19:35:08 2017
02-19 19:11:13.331-0600 E/ALARM_MANAGER( 2496): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1537563564, next duetime: 1487554508
02-19 19:11:13.331-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1537563564)
02-19 19:11:13.331-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1487556275), due_time(1487554508)
02-19 19:11:13.341-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-19 19:11:13.341-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-19 19:11:13.341-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 20-2-2017, 01:35:08 (UTC).
02-19 19:11:13.341-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-19 19:11:13.341-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-19 19:11:13.351-0600 W/SNL_W   ( 3767): <setAlarm:571> setAlarm() - end : mStatus ( 2 ) currentInterval( 1440 ) interruptFlag ( 0 ) alarm_id ( 1537563564 )
02-19 19:11:13.351-0600 W/SNL_W   ( 3767): <presSendNotify_i:1019> presSendNotify_w ( 1a3cd1e255442a96e0b3c138 ) - end
02-19 19:11:13.351-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: noti_ps_th - Res( )
02-19 19:11:13.481-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1c00003 time=846625
02-19 19:11:13.481-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=846625
02-19 19:11:13.611-0600 E/MALI    ( 2784): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-19 19:11:13.641-0600 E/MALI    ( 2784): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-19 19:11:13.651-0600 E/MALI    ( 2784): mali_egl_winsys.c: window_surface_new(889) >  Create Window, it runs with MALI_X11_ASYNC_PAGEFLIP 1 
02-19 19:11:13.721-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: recv_msg(res) - ( 0xfc ), seq( 1021 )
02-19 19:11:13.721-0600 W/SNL     ( 3767): Scone_Log.cpp: dump(2973) > SNL :: sKA - res( 0 )
02-19 19:11:13.721-0600 W/SNL_W   ( 3767): <sendKeepAliveThread:872> sendKeepAliveThread() - group_id ( 1a3cd1e255442a96e0b3c138 ) sendKeepAliveType ( 0 ), PING_CNT ( 4 ) 
02-19 19:11:13.721-0600 W/SNL_W   ( 3767): <sendKeepAliveThread:881> sendKeepAliveThread() - presSendNotify(0) begin
02-19 19:11:13.721-0600 W/SCSD    ( 3767): <on_presSendNotify:426> sent keepalive (group_id: 1a3cd1e255442a96e0b3c138) (S:11/F:11/T:22) (msg_id: 0)
02-19 19:11:13.721-0600 W/SNL_W   ( 3767): <sendKeepAliveThread:883> sendKeepAliveThread() - presSendNotify(0) end
02-19 19:11:13.721-0600 W/SCSD    ( 3767): <_keepalive_cb:520> entrance
02-19 19:11:13.731-0600 W/SCSD    ( 3767): <util_tel_set_ps_dormant:19> request FD, svc_type (7)
02-19 19:11:13.811-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:733> sendKeepAliveAllgroup() - groupList.size() : 0(f) + 1(p)
02-19 19:11:13.811-0600 W/SNL_W   ( 3767): <setAlarm:522> setAlarm() - begin 
02-19 19:11:13.811-0600 W/SNL_W   ( 3767): <releaseAlarm:495> stop alarm_id(1537563564)
02-19 19:11:13.811-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [3767].
02-19 19:11:13.811-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1537563564)
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 20-2-2017, 02:04:35 (UTC).
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1537563564] is removed.
02-19 19:11:13.821-0600 W/SNL_W   ( 3767): <initAlarm:507> InitAlarm() - begin
02-19 19:11:13.821-0600 W/SNL_W   ( 3767): <initAlarm:513> InitAlarm() success - end
02-19 19:11:13.821-0600 E/ALARM_MANAGER( 3767): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(1435), start(19-2-2017, 19:35:09), repeat(0), interval(0), type(-1073741822)
02-19 19:11:13.831-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [3767].
02-19 19:11:13.841-0600 I/AUL     ( 2496): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/scsd, ret : 0
02-19 19:11:13.841-0600 W/AUL_AMD ( 2534): amd_request.c: __request_handler(669) > __request_handler: 15
02-19 19:11:13.841-0600 E/ALARM_MANAGER( 2496): alarm-manager-schedule.c: __alarm_next_duetime_once(174) > Final due_time = 1487554509, Sun Feb 19 19:35:09 2017
02-19 19:11:13.841-0600 E/ALARM_MANAGER( 2496): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1537563564, next duetime: 1487554509
02-19 19:11:13.841-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1537563564)
02-19 19:11:13.841-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1487556275), due_time(1487554509)
02-19 19:11:13.851-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
02-19 19:11:13.851-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-19 19:11:13.851-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 20-2-2017, 01:35:09 (UTC).
02-19 19:11:13.851-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-19 19:11:13.851-0600 E/ALARM_MANAGER( 2496): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
02-19 19:11:13.861-0600 W/SNL_W   ( 3767): <setAlarm:571> setAlarm() - end : mStatus ( 2 ) currentInterval( 1440 ) interruptFlag ( 0 ) alarm_id ( 1537563564 )
02-19 19:11:13.861-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:752> sendKeepAliveAllGroup() - set last interval ( 1440 )
02-19 19:11:13.861-0600 W/SNL_W   ( 3767): <util_pm_unlock:1166> util_pm_unlock() UNLOCK
02-19 19:11:13.871-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:758> sendKeepAliveAllGroup () - WakeLock release
02-19 19:11:13.871-0600 W/SNL_W   ( 3767): <sendKeepAliveAllGroup:770> sendKeepAliveAllGroup() - end Error ( 0 )
02-19 19:11:13.931-0600 W/SNL_W   ( 3767): <releaseWakeLockinTimeThread:815> releaseWakeLockinTimeThread () - WakeLock already released
02-19 19:11:14.051-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [53][0m
02-19 19:11:14.061-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
02-19 19:11:14.061-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
02-19 19:11:14.071-0600 W/ISE_MULTI_MCF( 2784): mcfevents-efl.cpp: destroy_tts_win(681) > [0;33mf7d1bbf8 ?? 0[0m
02-19 19:11:14.111-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_update_cursor_position(1167) > [0;36m[hidden state:false] pos=6[0m
02-19 19:11:15.491-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=848999 button=1
02-19 19:11:15.631-0600 W/ISE_MULTI( 2784): ise.cpp: on_event_key_clicked(1004) > [0;33mkeyEventDesc.keyModifier [0] and key event [65293][0m
02-19 19:11:15.631-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=1
02-19 19:11:15.631-0600 E/EFL     ( 4984): ecore_x<4984> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=1
02-19 19:11:15.641-0600 E/SWIFTKEY( 2650): swiftkey_engine.cpp: IME_Learn_sentence(2549) > [0;31mskip : session is null[0m
02-19 19:11:15.641-0600 W/IMMODULE( 4984): isf_imf_context.cpp: isf_imf_context_filter_event(2138) > S/W key event is not valid
02-19 19:11:15.751-0600 I/ISE_MULTI( 2784): isemain.cpp: slot_reset_ise_input_context(1367) > [0;36m[hidden state:false][0m
02-19 19:11:15.761-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x3a0000f FAILED!
02-19 19:11:15.761-0600 W/ISF_PANEL_EFL( 2709): isf_panel_efl.cpp: efl_get_window_rotate_angle(3446) > WINDOW angle of 0x3a0000f FAILED!
02-19 19:11:15.801-0600 E/ISE_MULTI( 2784): ise-rotary-event-listener.cpp: rotary_input_clear(129) > [0;31mrotary_input_clear[0m
02-19 19:11:15.801-0600 I/efl-extension( 2784): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
02-19 19:11:15.801-0600 I/efl-extension( 2784): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
02-19 19:11:15.801-0600 I/efl-extension( 2784): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
02-19 19:11:15.801-0600 E/ISE_MULTI( 2784): rotary_input.cpp: destroy_rotary_input_layout(755) > [0;31mdestroy_rotary_input_layout[0m
02-19 19:11:15.801-0600 E/ISE_MULTI( 2784): ise-ui.cpp: destroy_indicator(1517) > [0;31mdestroy_indicator[0m
02-19 19:11:16.331-0600 D/UIB_APP ( 4984): Oauth code url: http://localhost/?state=&code=3dc16501872a5ac25777cd6f97136d851d027150
02-19 19:11:16.701-0600 D/UIB_APP ( 4984): Oauth token response: {"access_token":"f37aea6acacfb7f1be3bba05e55f0ff8f31c89c1","token_type":"Bearer","athlete":{"id":6367912,"username":null,"resource_state":3,"firstname":"Trenton","lastname":"Albrecht","city":"Bel Aire","state":"Kansas","country":"United States","sex":"M","premium":false,"created_at":"2014-09-09T19:13:23Z","updated_at":"2017-02-20T01:11:16Z","badge_type_id":0,"profile_medium":"avatar/athlete/medium.png","profile":"avatar/athlete/large.png","friend":null,"follower":null,"follower_count":1,"friend_count":1,"mutual_friend_count":0,"athlete_type":0,"date_preference":"%m/%d/%Y","measurement_preference":"feet","clubs":[],"email":"tralbrecht@gmail.com","ftp":null,"weight":95.0,"bikes":[],"shoes":[]}}
02-19 19:11:16.731-0600 D/UIB_APP ( 4984): Storing oauth token: f37aea6acacfb7f1be3bba05e55f0ff8f31c89c1
02-19 19:11:16.731-0600 D/UIB_APP ( 4984): Storing oauth file: /opt/usr/media/Others/strava.token
02-19 19:11:16.781-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=850289 button=1
02-19 19:11:16.781-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=850289 button=1
02-19 19:11:16.891-0600 E/EFL     ( 2366): ecore_x<2366> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=850400 button=1
02-19 19:11:17.031-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4984 pgid = 4984
02-19 19:11:17.031-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
02-19 19:11:17.061-0600 I/efl-extension( 5113): efl_extension.c: eext_mod_shutdown(46) > Shutdown
02-19 19:11:17.071-0600 W/PROCESSMGR( 2366): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
02-19 19:11:17.081-0600 W/W_HOME  ( 2815): event_manager.c: _ecore_x_message_cb(428) > state: 1 -> 0
02-19 19:11:17.081-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.081-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.081-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.081-0600 W/W_HOME  ( 2815): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(473) > Window [0x2000003] is now visible(0)
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _window_visibility_cb(483) > state: 0 -> 1
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): main.c: _window_visibility_cb(963) > Window [0x2000003] is now visible(0)
02-19 19:11:17.131-0600 I/APP_CORE( 2815): appcore-efl.c: __do_app(453) > [APP 2815] Event: RESUME State: PAUSED
02-19 19:11:17.131-0600 I/CAPI_APPFW_APPLICATION( 2815): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): main.c: _appcore_resume_cb(478) > appcore resume
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _app_resume_cb(380) > state: 2 -> 1
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): main.c: home_resume(530) > clock/widget resumed
02-19 19:11:17.131-0600 W/W_HOME  ( 2815): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-19 19:11:17.131-0600 I/GATE    ( 2815): <GATE-M>APP_FULLY_LOADED_w-home</GATE-M>
02-19 19:11:17.161-0600 I/wnotib  ( 2815): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
02-19 19:11:17.161-0600 E/wnotib  ( 2815): w-notification-board-action.c: wnb_action_is_drawer_hidden(4793) > [NULL==g_wnb_action_data] msg Drawer not initialized.
02-19 19:11:17.161-0600 W/wnotib  ( 2815): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
02-19 19:11:17.181-0600 W/WATCH_CORE( 2918): appcore-watch.c: __widget_resume(1124) > widget_resume
02-19 19:11:17.181-0600 W/AUL     ( 2918): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(U1buYqN5qZ.AllinOne) pid(2918) status(fg) type(watchapp)
02-19 19:11:17.181-0600 I/CAPI_WATCH_APPLICATION( 2918): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
02-19 19:11:17.241-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-19 19:11:17.261-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-19 19:11:17.261-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-19 19:11:17.281-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-19 19:11:17.281-0600 W/CoreGL  ( 2937): coregl_fastpath_gl.c: fastpath_glGetString(387) >  [40;31;1mFastpath can't support OpenGL ES 3.1 v1.r12p1-00dev0.058f236b794e233145003a6d9c972ad6 (Fixed to OpenGL ES 3.0)[0m
02-19 19:11:17.301-0600 W/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(449) > [_proc_mgr_status_cb:449] >> P[2815] goes to (3)
02-19 19:11:17.301-0600 E/STARTER ( 2748): pkg-monitor.c: _proc_mgr_status_cb(451) > [_proc_mgr_status_cb:451] >>>>H(pid 2815)'s state(3)
02-19 19:11:17.301-0600 W/AUL_AMD ( 2534): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-19 19:11:17.301-0600 W/AUL_AMD ( 2534): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
02-19 19:11:17.301-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(2815) status(fg) type(uiapp)
02-19 19:11:17.311-0600 W/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
02-19 19:11:17.311-0600 I/WATCH_CORE( 2918): appcore-watch.c: __signal_process_manager_handler(1273) > Skip the background tick update
02-19 19:11:17.351-0600 W/AUL_PAD ( 3427): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
02-19 19:11:17.351-0600 I/AUL_AMD ( 2534): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4984
02-19 19:11:17.351-0600 W/AUL     ( 2534): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4984)
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator.c: _home_screen_clock_visibility_changed_cb(988) > [_home_screen_clock_visibility_changed_cb:988] Clock visibility : 1
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_vconfkey_register(416) > [windicator_battery_vconfkey_register:416] Set battery cb
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(53), length(2)
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 53%
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 53, isCharging: 0
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_55
02-19 19:11:17.381-0600 W/W_INDICATOR( 2749): windicator_battery.c: windicator_battery_icon_update(375) > [windicator_battery_icon_update:375] Normal charging status !!
02-19 19:11:17.381-0600 E/W_INDICATOR( 2749): windicator_dynamic.c: dynamic_event_icon_refresh_position_for_3g(418) > [dynamic_event_icon_refresh_position_for_3g:418] rssi 0 connection 0
02-19 19:11:17.411-0600 W/CRASH_MANAGER( 5155): worker.c: worker_job(1199) > 110498472756e148755307
