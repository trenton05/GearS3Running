S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.2
Build-Number: Tizen-2.3.2_Wearable-Emulator_20161010.0722
Build-Date: 2016.10.10 07:22:19

Crash Information
Process Name: runner
PID: 4946
Date: 2017-02-15 13:57:30+0900
Executable File Path: /opt/usr/apps/org.example.Running/bin/runner
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4946, uid 5000)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7ad7d98, esi = 0xb7ad7d98
ebp = 0xbfcb4df8, esp = 0xbfcb4dc0
eax = 0xb3e23000, ebx = 0xb3e23000
ecx = 0x00000000, edx = 0xb7aa1e90
eip = 0xb3e1782d

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         6 KB
Cached:     215912 KB
VmPeak:     138212 KB
VmSize:     138212 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20780 KB
VmRSS:       20780 KB
VmData:      38692 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       66992 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4946 TID = 4946
4946 4953 4955 4956 

Maps Information
af5a3000 af5a7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
af5a8000 af5ac000 r-xp /usr/lib/location/module/libgps.so.0.6.5
afe7a000 afe9e000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b0901000 b0903000 r-xp /usr/lib/liblbs-agps.so.0.1.0
b0905000 b0906000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b091a000 b091d000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b091e000 b092c000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b092d000 b093c000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b1958000 b195a000 r-xp /usr/lib/elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so
b195d000 b1968000 r-xp /usr/lib/libminizip.so.1.0.0
b1969000 b196b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b196c000 b1973000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b1974000 b19e1000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b19e2000 b19ea000 r-xp /usr/lib/libjson.so.0.1.0
b19eb000 b19f2000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b19f3000 b19fc000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b19fd000 b19ff000 r-xp /usr/lib/libcamsrcjpegenc.so.0.0.0
b1a00000 b1a2a000 r-xp /usr/lib/libexif.so.12.3.3
b1a36000 b1a3e000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b1a3f000 b1a61000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b1a62000 b1ab7000 r-xp /usr/lib/libpulse.so.0.16.2
b1ab8000 b1abd000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1abe000 b1ac3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1ac4000 b1ac7000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b1ac8000 b1acc000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b1acd000 b1ad4000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b1ad5000 b1b45000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b1b4b000 b1b5b000 r-xp /usr/lib/libspdy.so.0.0.0
b1b5c000 b1b64000 r-xp /usr/lib/libxcb-render.so.0.0.0
b1b65000 b1b67000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b1b68000 b1b7e000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
b1b7f000 b1b9e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b1b9f000 b1ba7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.4
b1ba8000 b1bc5000 r-xp /usr/lib/libtts.so
b1bc6000 b1bcf000 r-xp /usr/lib/libtbm.so.1.0.0
b1bd0000 b1bef000 r-xp /usr/lib/libstt.so
b1bf0000 b1bf6000 r-xp /usr/lib/libmmfsession.so.0.0.0
b1bf7000 b1bf8000 r-xp /usr/lib/libmmfbootsound.so.0.0.0
b1bf9000 b1bfa000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1bfb000 b1c1b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1c1c000 b1c22000 r-xp /usr/lib/libmemenv.so.1.1.0
b1c23000 b1c6a000 r-xp /usr/lib/libleveldb.so.1.1.0
b1c6b000 b1c7e000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b1c7f000 b1c82000 r-xp /usr/lib/libdri2.so.0.0.0
b1c83000 b1c8c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1c8d000 b1c9a000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b1c9e000 b1ca8000 r-xp /usr/lib/libgstfft-0.10.so.0.25.0
b1ca9000 b1ce4000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b1ce6000 b1cff000 r-xp /usr/lib/yagl/libEGL.so.1.0
b1d00000 b1d48000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b1d4b000 b1d60000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b1d61000 b1d81000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b1d83000 b1d8f000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b1d90000 b1df2000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b1df3000 b1ed1000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b1ed6000 b1ee1000 r-xp /usr/lib/libdrm.so.2.4.0
b1ee2000 b1f18000 r-xp /usr/lib/libxslt.so.1.1.16
b1f19000 b1f27000 r-xp /usr/lib/libcert-svc.so.1.0.0
b1f28000 b1f40000 r-xp /usr/lib/libefl-assist.so.0.1.0
b1f41000 b1f54000 r-xp /usr/lib/libcapi-media-camera.so.0.1.79
b1f55000 b1fcc000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b1fcf000 b2113000 r-xp /usr/lib/libcairo.so.2.11200.14
b2117000 b211d000 r-xp /usr/lib/libctx-client.so.0.8.3
b211e000 b2128000 r-xp /usr/lib/libctx-shared.so.0.8.3
b2129000 b213b000 r-xp /usr/lib/libdeviced.so.0.1.0
b213c000 b215b000 r-xp /usr/lib/libSLP-location.so.0.9.5
b215c000 b3cdb000 r-xp /usr/lib/libewebkit2.so.152340_0.10.254.0
b3dcc000 b3def000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3df0000 b3e01000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b3e03000 b3e12000 r-xp /usr/lib/libcapi-location-manager.so.0.4.7
b3e13000 b3e22000 r-xp /opt/usr/apps/org.example.Running/bin/runner
b3e24000 b3e2f000 r-xp /lib/libnss_files-2.13.so
b4031000 b4058000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4059000 b407e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b407f000 b41a0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b41b0000 b41e6000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b41e8000 b41eb000 r-xp /usr/lib/libiniparser.so.0
b41ed000 b41f7000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b41f8000 b4201000 r-xp /usr/lib/libappsvc.so.0.1.0
b4202000 b4205000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4206000 b420c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b420d000 b4214000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b4215000 b421b000 r-xp /usr/lib/libogg.so.0.7.1
b421c000 b4247000 r-xp /usr/lib/libvorbis.so.0.4.3
b4248000 b4333000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4341000 b4343000 r-xp /usr/lib/libXau.so.6.0.0
b4344000 b439d000 r-xp /usr/lib/libssl.so.1.0.0
b43a2000 b43d3000 r-xp /usr/lib/libidn.so.11.5.44
b43d4000 b43e4000 r-xp /usr/lib/libcares.so.2.1.0
b43e5000 b444e000 r-xp /usr/lib/libsndfile.so.1.0.25
b4454000 b4460000 r-xp /usr/lib/libsensord-shared.so
b4461000 b4487000 r-xp /lib/libexpat.so.1.5.2
b4489000 b44b0000 r-xp /usr/lib/libpng12.so.0.50.0
b44b1000 b44d1000 r-xp /usr/lib/libxcb.so.1.1.0
b44d2000 b4541000 r-xp /usr/lib/libcurl.so.4.3.0
b4543000 b454e000 r-xp /usr/lib/libethumb.so.1.7.99
b5dcb000 b5ea3000 r-xp /usr/lib/libstdc++.so.6.0.16
b5eaf000 b5eb2000 r-xp /usr/lib/libctxdata.so.0.0.0
b5eb3000 b5ec9000 r-xp /usr/lib/libremix.so.0.0.0
b5eca000 b5ecc000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5ecd000 b5ef9000 r-xp /usr/lib/liblua-5.1.so
b5efa000 b5f04000 r-xp /usr/lib/libembryo.so.1.7.99
b5f05000 b5f4b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f5c000 b5f8b000 r-xp /usr/lib/libsensor.so.1.9.0
b5f8c000 b600e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6013000 b6047000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6049000 b60a4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b60a6000 b60bc000 r-xp /usr/lib/libfribidi.so.0.3.1
b60bd000 b6149000 r-xp /usr/lib/libfreetype.so.6.11.3
b614d000 b6150000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6151000 b6157000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6158000 b615e000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6160000 b6171000 r-xp /usr/lib/libXext.so.6.4.0
b6172000 b62a6000 r-xp /usr/lib/libX11.so.6.3.0
b62aa000 b62af000 r-xp /usr/lib/libXtst.so.6.1.0
b62b0000 b62b8000 r-xp /usr/lib/libXrender.so.1.3.0
b62b9000 b62c2000 r-xp /usr/lib/libXrandr.so.2.2.0
b62c3000 b62c5000 r-xp /usr/lib/libXinerama.so.1.0.0
b62c6000 b62d4000 r-xp /usr/lib/libXi.so.6.1.0
b62d5000 b62d9000 r-xp /usr/lib/libXfixes.so.3.1.0
b62da000 b62dc000 r-xp /usr/lib/libXgesture.so.7.0.0
b62dd000 b62df000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62e0000 b62e2000 r-xp /usr/lib/libXdamage.so.1.1.0
b62e3000 b62ec000 r-xp /usr/lib/libXcursor.so.1.0.2
b62ed000 b6318000 r-xp /usr/lib/libecore_con.so.1.7.99
b631a000 b6322000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6323000 b632e000 r-xp /usr/lib/libethumb_client.so.1.7.99
b632f000 b6335000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6336000 b6357000 r-xp /usr/lib/libefreet.so.1.7.99
b6359000 b6365000 r-xp /usr/lib/libedbus.so.1.7.99
b6366000 b64f5000 r-xp /usr/lib/libicuuc.so.57.1
b6504000 b6780000 r-xp /usr/lib/libicui18n.so.57.1
b6789000 b6827000 r-xp /usr/lib/libedje.so.1.7.99
b6829000 b683a000 r-xp /usr/lib/libecore_input.so.1.7.99
b683b000 b6842000 r-xp /usr/lib/libecore_file.so.1.7.99
b6843000 b6869000 r-xp /usr/lib/libeet.so.1.7.99
b6872000 b699c000 r-xp /usr/lib/libevas.so.1.7.99
b69ba000 b69ee000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69f0000 b6a34000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a36000 b6c31000 r-xp /usr/lib/libelementary.so.1.7.99
b6c40000 b6c42000 r-xp /usr/lib/libharfbuzz-icu.so.0.940.0
b6c43000 b6c49000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c4a000 b6c4e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c53000 b6c54000 r-xp /usr/lib/libjournal.so.0.1.0
b6c55000 b6d9d000 r-xp /usr/lib/libxml2.so.2.7.8
b6da3000 b6db6000 r-xp /lib/libresolv-2.13.so
b6dba000 b6dd7000 r-xp /lib/libz.so.1.2.5
b6dd8000 b6ddb000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6ddd000 b6de2000 r-xp /usr/lib/libffi.so.5.0.10
b6de3000 b6de4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6de5000 b6de9000 r-xp /lib/libattr.so.1.1.0
b6dea000 b6ffd000 r-xp /usr/lib/libcrypto.so.1.0.0
b7018000 b7039000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b703b000 b7063000 r-xp /lib/libm-2.13.so
b7065000 b70c0000 r-xp /usr/lib/libeina.so.1.7.99
b70c2000 b70cd000 r-xp /usr/lib/libvconf.so.0.2.45
b70ce000 b70d1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70d2000 b7120000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7122000 b7283000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7287000 b728e000 r-xp /lib/librt-2.13.so
b7290000 b7297000 r-xp /usr/lib/libcapi-base-common.so.0.1.10
b7299000 b72b3000 r-xp /lib/libgcc_s-4.6.4.so.1
b72b4000 b72bc000 r-xp /lib/libcrypt-2.13.so
b72e6000 b72ea000 r-xp /lib/libcap.so.2.21
b72eb000 b72ed000 r-xp /usr/lib/libiri.so
b72ee000 b731a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b731b000 b733b000 r-xp /usr/lib/libecore.so.1.7.99
b734a000 b7353000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7354000 b7477000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7479000 b748c000 r-xp /usr/lib/libail.so.0.1.0
b748d000 b74b2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b74b3000 b74bd000 r-xp /lib/libunwind.so.8.0.1
b74c7000 b7647000 r-xp /lib/libc-2.13.so
b764e000 b7698000 r-xp /usr/lib/libdbus-1.so.3.7.2
b769a000 b769f000 r-xp /usr/lib/libbundle.so.0.1.22
b76a0000 b76a3000 r-xp /lib/libdl-2.13.so
b76a5000 b76bc000 r-xp /lib/libpthread-2.13.so
b76c0000 b76c3000 r-xp /usr/lib/libdlog.so.0.0.0
b76c4000 b76c6000 r-xp /usr/lib/libttrace.so.1.1
b76c7000 b76cc000 r-xp /usr/lib/libsmack.so.1.0.0
b76cd000 b7775000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7778000 b7792000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7793000 b77a3000 r-xp /usr/lib/libaul.so.0.1.0
b77a6000 b77ac000 r-xp /usr/lib/libappcore-common.so.1.1
b77ad000 b77b2000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b4000 b77b9000 r-xp /usr/lib/libsys-assert.so
b77bc000 b77bd000 r-xp [vdso]
b77bd000 b77db000 r-xp /lib/ld-2.13.so
b77dd000 b77e4000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4946)
Call Stack Count: 17
 0: gps_toggle_running + 0x5d (0xb3e1782d) [/opt/usr/apps/org.example.Running/bin/runner] + 0x482d
 1: view1_topLabel_onclicked + 0x2d (0xb3e1ae4d) [/opt/usr/apps/org.example.Running/bin/runner] + 0x7e4d
 2: evas_object_smart_callback_call + 0xe2 (0xb68b9532) [/usr/lib/libevas.so.1] + 0x47532
 3: (0xb6b2c4e4) [/usr/lib/libelementary.so.1] + 0xf64e4
 4: (0xb688a371) [/usr/lib/libevas.so.1] + 0x18371
 5: evas_event_feed_mouse_up + 0x4c1 (0xb6893711) [/usr/lib/libevas.so.1] + 0x21711
 6: (0xb614ee9d) [/usr/lib/libecore_input_evas.so.1] + 0x1e9d
 7: (0xb7324519) [/usr/lib/libecore.so.1] + 0x9519
 8: (0xb732947a) [/usr/lib/libecore.so.1] + 0xe47a
 9: ecore_main_loop_begin + 0x3f (0xb73299cf) [/usr/lib/libecore.so.1] + 0xe9cf
10: elm_run + 0x17 (0xb6b3f0f7) [/usr/lib/libelementary.so.1] + 0x1090f7
11: appcore_efl_main + 0x418 (0xb77affe8) [/usr/lib/libappcore-efl.so.1] + 0x2fe8
12: ui_app_main + 0x130 (0xb6c4c5f0) [/usr/lib/libcapi-appfw-application.so.0] + 0x25f0
13: uib_app_run + 0x1f6 (0xb3e162c6) [/opt/usr/apps/org.example.Running/bin/runner] + 0x32c6
14: main + 0x7b (0xb3e1a7db) [/opt/usr/apps/org.example.Running/bin/runner] + 0x77db
15: _on_create_cb + 0x379 (0xb77e0659) [/opt/usr/apps/org.example.Running/bin/runner] + 0xb77e0659
16: __libc_start_main + 0xf3 (0xb74e01a3) [/lib/libc.so.6] + 0x191a3
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
m/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
02-15 13:56:57.316+0900 E/EFL     ( 4946): ecore_evas<4946> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
02-15 13:56:57.316+0900 D/W_HOME  ( 2391): main.c: _window_focus_out_cb(869) > focus out
02-15 13:56:57.316+0900 D/W_HOME  ( 2391): main.c: _pause_cb(600) > Paused
02-15 13:56:57.326+0900 D/W_HOME  ( 2391): page.c: page_focus(696) > focus set to 0xb7b73548
02-15 13:56:57.326+0900 E/EFL     ( 4946): eina_module<4946> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so", RTLD_NOW): /opt/home/app/.elementary/modules/naviframe_effect/linux-gnu-i686-1.7.99/module.so: cannot open shared object file: No such file or directory
02-15 13:56:57.326+0900 W/W_HOME  ( 2391): main.c: _pause_cb(613) > clock/widget paused
02-15 13:56:57.336+0900 D/AUL_PAD ( 2366): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
02-15 13:56:57.346+0900 D/W_HOME  ( 2391): clock_view.c: clock_view_event_handler(843) > event:10002 received
02-15 13:56:57.386+0900 D/UIB_APP ( 4946): Initializing
02-15 13:56:57.386+0900 D/AUL     ( 2303): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
02-15 13:56:57.386+0900 D/W_HOME  ( 2391): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb7bd8b60 is paused
02-15 13:56:57.446+0900 D/UIB_APP ( 4946): Loading oauth
02-15 13:56:57.446+0900 D/RESOURCED( 2513): proc-noti.c: recv_str(87) > [recv_str,87] str is null
02-15 13:56:57.456+0900 D/AUL_PAD ( 2366): sigchild.h: __send_app_launch_signal(112) > send launch signal done
02-15 13:56:57.456+0900 E/AUL     ( 2303): simple_util.c: __trm_app_info_send_socket(264) > access
02-15 13:56:57.466+0900 E/APPS    ( 2391): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
02-15 13:56:57.506+0900 D/UIB_APP ( 4946): Starting fit track in /opt/usr/apps/org.example.Running/data/running1487134617.gpx
02-15 13:56:57.516+0900 D/AUL_PAD ( 2366): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
02-15 13:56:57.516+0900 D/RESOURCED( 2513): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2303
02-15 13:56:57.546+0900 D/RESOURCED( 2513): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.Running, pid 4946, type 4 
02-15 13:56:57.546+0900 D/RESOURCED( 2513): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.Running, 4946
02-15 13:56:57.546+0900 D/RESOURCED( 2513): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.Running with pkgname
02-15 13:56:57.546+0900 D/DATA_PROVIDER_MASTER( 2436): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2391 is paused
02-15 13:56:57.546+0900 D/DATA_PROVIDER_MASTER( 2436): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-15 13:56:57.546+0900 E/RESOURCED( 2513): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 351
02-15 13:56:57.546+0900 D/RESOURCED( 2513): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
02-15 13:56:57.546+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _ecore_evas_msg_parent_handle(1334) > Receive msg from clien msg_domain=0 msg_id=0 size=9
02-15 13:56:57.536+0900 D/UIB_APP ( 4946): Starting gps
02-15 13:56:57.556+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _ecore_evas_msg_parent_handle(1335) >  ########## data : mc_pause
02-15 13:56:57.626+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_create(702) > location_manager_create (method : 1)
02-15 13:56:57.626+0900 W/LOCATION( 4946): module-internal.c: module_is_supported(260) > module name(gps) is found
02-15 13:56:57.626+0900 D/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: initialize(148) > Initialize privacy : org.example.Running org.example.Running
02-15 13:56:57.626+0900 D/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: updateCache(575) > [SECURE_LOG] Privacy found : http://tizen.org/privacy/location 1
02-15 13:56:57.626+0900 I/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: initialize(166) > Got lock. Starting initialize
02-15 13:56:57.626+0900 I/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: runSignalListenerThread(196) > Running g main loop for signal
02-15 13:56:57.626+0900 I/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: initializeDbus(222) > Starting initialize
02-15 13:56:57.626+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _ecore_evas_msg_parent_handle(1340) > ##### mc_pause
02-15 13:56:57.656+0900 I/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: initializeDbus(237) > Initialized
02-15 13:56:57.656+0900 I/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: initialize(184) > Initialized
02-15 13:56:57.656+0900 D/LOCATION( 4946): location-privacy.c: location_privacy_initialize(189) > Success to initialize privacy checker
02-15 13:56:57.656+0900 D/LOCATION( 4946): location.c: location_new(125) > method: 1
02-15 13:56:57.656+0900 D/LOCATION( 4946): location-gps.c: location_gps_class_init(1152) > location_gps_class_init
02-15 13:56:57.656+0900 D/LOCATION( 4946): location-gps.c: location_gps_init(1107) > location_gps_init
02-15 13:56:57.656+0900 W/LOCATION( 4946): module-internal.c: module_new(231) > module (gps) open success
02-15 13:56:57.656+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_set_position_updated_cb(1264) > location_manager_set_position_updated_cb
02-15 13:56:57.656+0900 D/LOCATION( 4946): location-gps.c: location_gps_set_property(622) > Set prop>> update-interval: 1
02-15 13:56:57.656+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __set_callback(415) > event type : 1
02-15 13:56:57.656+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: gps_status_set_satellite_updated_cb(1479) > gps_status_set_satellite_updated_cb
02-15 13:56:57.656+0900 E/CAPI_LOCATION_MANAGER( 4946): locations.c: gps_status_set_satellite_updated_cb(1480) > LOCATIONS_ERROR_NOT_SUPPORTED(0xc0000002)
02-15 13:56:57.656+0900 W/UIB_APP ( 4946): Failed to register satellites -1073741822
02-15 13:56:57.656+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_start(778) > location_manager_start
02-15 13:56:57.666+0900 D/PRIVACY-MANAGER-CLIENT( 4946): PrivacyChecker.cpp: updateCache(575) > [SECURE_LOG] Privacy found : http://tizen.org/privacy/location 1
02-15 13:56:57.666+0900 D/LOCATION( 4946): location-gps.c: location_gps_start(297) > location_gps_start
02-15 13:56:57.676+0900 W/LOCATION( 4946): location-setting.c: location_setting_add_notify(84) > [SECURE_LOG] vconf notify added [db/location/setting/GpsEnabled]
02-15 13:56:57.676+0900 W/LOCATION( 4946): location-setting.c: location_setting_add_notify(84) > [SECURE_LOG] vconf notify added [memory/location/gps/state]
02-15 13:56:57.676+0900 D/UIB_APP ( 4946): Started location services
02-15 13:56:57.696+0900 D/UIB_APP ( 4946): Started hrm
02-15 13:56:57.696+0900 D/LAUNCH  ( 4946): appcore-efl.c: __before_loop(1066) > [Running:Application:create:done]
02-15 13:56:57.696+0900 D/APP_CORE( 4946): appcore-efl.c: __check_wm_rotation_support(765) > Disable window manager rotation
02-15 13:56:57.696+0900 D/APP_CORE( 4946): appcore-rotation.c: __changed_cb(123) > [APP 4946] Rotation: 0 -> 1
02-15 13:56:57.696+0900 D/APP_CORE( 4946): appcore-rotation.c: __changed_cb(128) > [APP 4946] Rotation: 0 -> 1
02-15 13:56:57.696+0900 I/CAPI_APPFW_APPLICATION( 4946): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
02-15 13:56:57.696+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:56:57.696+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:56:57.696+0900 D/APP_CORE( 4946): appcore-efl.c: __show_cb(839) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
02-15 13:56:57.696+0900 D/APP_CORE( 4946): appcore-efl.c: __add_win(685) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
02-15 13:56:57.736+0900 D/APP_CORE( 4946): appcore.c: __aul_handler(423) > [APP 4946]     AUL event: AUL_START
02-15 13:56:57.736+0900 D/APP_CORE( 4946): appcore-efl.c: __do_app(471) > [APP 4946] Event: RESET State: CREATED
02-15 13:56:57.736+0900 D/APP_CORE( 4946): appcore-efl.c: __do_app(497) > [APP 4946] RESET
02-15 13:56:57.736+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(499) > [Running:Application:reset:start]
02-15 13:56:57.736+0900 I/CAPI_APPFW_APPLICATION( 4946): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
02-15 13:56:57.736+0900 D/APP_SVC ( 4946): appsvc.c: __set_bundle(161) > __set_bundle
02-15 13:56:57.736+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(506) > [Running:Application:reset:done]
02-15 13:56:57.736+0900 I/APP_CORE( 4946): appcore-efl.c: __do_app(512) > Legacy lifecycle: 0
02-15 13:56:57.736+0900 I/APP_CORE( 4946): appcore-efl.c: __do_app(514) > [APP 4946] Initial Launching, call the resume_cb
02-15 13:56:57.736+0900 I/CAPI_APPFW_APPLICATION( 4946): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
02-15 13:56:57.736+0900 D/UIB_APP ( 4946): resuming
02-15 13:56:57.736+0900 D/APP_CORE( 4946): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
02-15 13:56:57.746+0900 D/APP_CORE( 4946): appcore.c: __prt_ltime(183) > [APP 4946] first idle after reset: 513 msec
02-15 13:56:57.746+0900 W/W_HOME  ( 2391): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
02-15 13:56:57.746+0900 D/APP_CORE( 4946): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
02-15 13:56:57.746+0900 D/APP_CORE( 4946): appcore-efl.c: __visibility_cb(897) > bvisibility 1, b_active -1
02-15 13:56:57.746+0900 D/APP_CORE( 4946): appcore-efl.c: __visibility_cb(900) >  Go to Resume state
02-15 13:56:57.746+0900 D/APP_CORE( 4946): appcore-efl.c: __do_app(471) > [APP 4946] Event: RESUME State: RUNNING
02-15 13:56:57.746+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(566) > [Running:Application:resume:start]
02-15 13:56:57.746+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(580) > [Running:Application:resume:done]
02-15 13:56:57.746+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(582) > [Running:Application:Launching:done]
02-15 13:56:57.746+0900 D/APP_CORE( 4946): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
02-15 13:56:57.746+0900 E/APP_CORE( 4946): appcore-efl.c: __trm_app_info_send_socket(234) > access
02-15 13:56:57.746+0900 D/APP_CORE( 2391): appcore-efl.c: __update_win(731) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
02-15 13:56:57.746+0900 D/APP_CORE( 2391): appcore-efl.c: __visibility_cb(897) > bvisibility 0, b_active 1
02-15 13:56:57.746+0900 D/APP_CORE( 2391): appcore-efl.c: __visibility_cb(911) >  Go to Pasue state 
02-15 13:56:57.746+0900 D/APP_CORE( 2391): appcore-efl.c: __do_app(471) > [APP 2391] Event: PAUSE State: RUNNING
02-15 13:56:57.746+0900 D/APP_CORE( 2391): appcore-efl.c: __do_app(543) > [APP 2391] PAUSE
02-15 13:56:57.746+0900 I/CAPI_APPFW_APPLICATION( 2391): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
02-15 13:56:57.746+0900 D/W_HOME  ( 2391): main.c: _pause_cb(600) > Paused
02-15 13:56:57.746+0900 E/W_HOME  ( 2391): main.c: _pause_cb(603) > paused already
02-15 13:56:57.746+0900 D/APP_CORE( 2391): appcore-efl.c: __trm_app_info_send_socket(231) > __trm_app_info_send_socket
02-15 13:56:57.746+0900 E/APP_CORE( 2391): appcore-efl.c: __trm_app_info_send_socket(234) > access
02-15 13:56:57.776+0900 D/RESOURCED( 2513): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2391, type = 2
02-15 13:56:57.776+0900 D/AUL_AMD ( 2303): amd_launch.c: __e17_status_handler(1939) > pid(4946) status(3)
02-15 13:56:57.776+0900 D/RESOURCED( 2513): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4946, type = 0
02-15 13:56:57.776+0900 D/RESOURCED( 2513): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4946
02-15 13:56:57.776+0900 I/RESOURCED( 2513): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4946, oom : 200
02-15 13:56:57.776+0900 E/RESOURCED( 2513): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
02-15 13:56:58.516+0900 D/AUL_AMD ( 2303): amd_request.c: __add_history_handler(255) > [SECURE_LOG] add rua history org.example.Running /opt/usr/apps/org.example.Running/bin/runner
02-15 13:56:58.516+0900 D/RUA     ( 2303): rua.c: rua_add_history(179) > rua_add_history start
02-15 13:56:58.516+0900 D/RUA     ( 2303): rua.c: rua_add_history(247) > rua_add_history ok
02-15 13:56:58.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:56:58.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:56:58.996+0900 D/LOCATION( 4946): location-gps.c: location_setting_search_cb(245) > location_setting_search_cb
02-15 13:56:58.996+0900 W/LOCATION( 4946): location-setting.c: location_setting_get_key_val(39) > [SECURE_LOG] Setting changed [memory/location/gps/state]:[2]
02-15 13:56:58.996+0900 D/LOCATION( 4946): location-signaling-util.c: enable_signaling(76) > Signal emit: SERVICE_ENABLED
02-15 13:56:58.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_enabled(253) > Callback function has been invoked. 
02-15 13:56:58.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:56:58.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134618
02-15 13:56:58.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:56:58.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:56:58.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:56:59.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:56:59.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:56:59.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:56:59.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134619
02-15 13:56:59.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:56:59.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:56:59.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:00.676+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2394): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
02-15 13:57:00.676+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2394): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
02-15 13:57:00.676+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2394): preference.c: preference_get_int(1063) > preference_get_int(2394) : key(clock_font_color) error
02-15 13:57:00.676+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2394): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
02-15 13:57:00.676+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2394): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
02-15 13:57:00.676+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2394): preference.c: preference_get_int(1063) > preference_get_int(2394) : key(showdate) error
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: clock_view_set_info_time(877) > show_date:1
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(11)[Wed, 15 Feb][1487134620]
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: clock_view_set_info_time(885) > 
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[pm][1487134620]
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[1:57][1487134620]
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: clock_view_set_info_time(899) > utc_time=1:57, utc_ampm=[2]pm
02-15 13:57:00.676+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: clock_view_set_info_time(937) > time_str=<color=#FFFFFFFF>1:57<font_size=24><font=Tizen:style=Bold>pm</font></font_size></color>
02-15 13:57:00.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:00.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:00.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:00.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134620
02-15 13:57:00.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:00.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:00.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:01.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:01.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:01.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:01.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134621
02-15 13:57:01.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:01.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:01.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:02.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:02.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:02.816+0900 D/APP_CORE( 2391): appcore-efl.c: __do_app(471) > [APP 2391] Event: MEM_FLUSH State: PAUSED
02-15 13:57:02.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:02.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134622
02-15 13:57:02.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:02.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:02.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:03.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:03.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:03.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:03.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134623
02-15 13:57:03.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:03.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:03.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:04.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:04.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:04.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:04.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134624
02-15 13:57:04.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:04.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:04.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:05.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:05.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:05.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:05.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134625
02-15 13:57:05.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:05.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:05.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:06.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:06.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:06.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:06.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134626
02-15 13:57:06.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:06.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:06.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:07.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:07.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:07.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:07.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134627
02-15 13:57:07.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:07.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:07.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:08.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:08.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:08.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:08.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134628
02-15 13:57:08.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:08.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:08.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:09.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:09.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:09.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:09.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134629
02-15 13:57:09.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:09.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:09.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:10.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:10.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:10.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:10.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134630
02-15 13:57:10.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:10.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:10.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:11.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:11.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:11.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:11.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134631
02-15 13:57:11.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:11.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:11.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:12.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:12.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:12.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:12.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134632
02-15 13:57:12.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:12.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:12.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:13.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:13.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:13.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:13.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134633
02-15 13:57:13.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:13.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:13.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:14.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:14.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:14.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:14.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134634
02-15 13:57:14.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:14.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:14.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:15.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:15.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:15.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:15.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134635
02-15 13:57:15.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:15.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:15.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:16.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:16.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:16.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:16.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134636
02-15 13:57:16.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:16.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:16.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:17.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:17.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:17.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:17.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134637
02-15 13:57:17.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:17.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:17.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:18.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:18.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:18.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:18.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134638
02-15 13:57:18.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:18.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:18.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:19.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:19.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:19.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:19.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134639
02-15 13:57:19.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:19.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:19.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:20.006+0900 D/NET_NFC_MANAGER( 2429): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 2[0;m
02-15 13:57:20.006+0900 D/NET_NFC_MANAGER( 2429): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
02-15 13:57:20.006+0900 D/DATA_PROVIDER_MASTER( 2436): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-15 13:57:20.006+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [1]
02-15 13:57:20.006+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _device_state_changed_cb(1155) > Not interested PM STATE
02-15 13:57:20.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:20.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:20.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:20.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134640
02-15 13:57:20.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:20.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:20.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:21.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:21.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:21.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:21.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134641
02-15 13:57:21.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:21.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:21.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:22.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:22.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:22.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:22.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134642
02-15 13:57:22.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:22.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:22.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:23.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:23.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:23.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:23.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134643
02-15 13:57:23.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:23.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:23.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:24.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:24.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:24.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:24.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134644
02-15 13:57:24.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:24.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:24.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:25.356+0900 I/GESTURE ( 2231): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
02-15 13:57:25.356+0900 D/NET_NFC_MANAGER( 2429): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(139) > [0;35mpm_state : 1[0;m
02-15 13:57:25.356+0900 D/NET_NFC_MANAGER( 2429): net_nfc_server_vconf.c: net_nfc_server_vconf_pm_state_changed(146) > [0;35mlock_screen_set : 0[0;m
02-15 13:57:25.356+0900 D/DATA_PROVIDER_MASTER( 2436): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
02-15 13:57:25.356+0900 D/IDLE-CLOCK-DIGITAL( 2394): clock_view.c: _device_state_changed_cb(1131) > DISPLAY STATE [0]
02-15 13:57:25.356+0900 D/NET_NFC_MANAGER( 2429): net_nfc_server_common.c: restart_polling_loop_thread_func(456) > [0;35mlock_screen_set:0 ,pm_state:1,lock_state:0[0;m
02-15 13:57:25.356+0900 E/NFC_PLUGIN_EMUL( 2429): oem_emul.c: net_nfc_emul_controller_configure_discovery(2048) > [0;36m BEGIN >>>>[0;m
02-15 13:57:25.356+0900 E/NFC_PLUGIN_EMUL( 2429): oem_emul.c: net_nfc_emul_controller_configure_discovery(2071) > [0;36m Create Thread[0;m
02-15 13:57:25.356+0900 E/NFC_PLUGIN_EMUL( 2429): oem_emul.c: net_nfc_emul_controller_init(1871) > [0;36m BEGIN >>>>[0;m
02-15 13:57:25.356+0900 E/NFC_PLUGIN_EMUL( 2429): oem_emul.c: net_nfc_emul_controller_init(1873) > [0;36m start stack init [0;m
02-15 13:57:25.356+0900 E/NFC_PLUGIN_EMUL( 2429): oem_emul.c: net_nfc_emul_controller_init(1877) > [0;36m Already statck is initialized[0;m
02-15 13:57:25.356+0900 E/NFC_PLUGIN_EMUL( 2429): oem_emul.c: net_nfc_emul_controller_configure_discovery(2076) > [0;36m END >>>>[0;m
02-15 13:57:25.356+0900 D/NET_NFC_MANAGER( 2429): net_nfc_server_common.c: restart_polling_loop_thread_func(468) > [0;35mpolling enable[0;m
02-15 13:57:25.366+0900 D/APP_SVC ( 4946): appsvc.c: __get_alias_appid(568) > [SECURE_LOG] alias_id : (null)
02-15 13:57:25.366+0900 D/APP_SVC ( 4946): appsvc.c: __set_bundle(161) > __set_bundle
02-15 13:57:25.366+0900 D/APP_SVC ( 4946): appsvc.c: __set_bundle(161) > __set_bundle
02-15 13:57:25.366+0900 D/APP_SVC ( 4946): appsvc.c: __run_svc_with_pkgname(237) > [SECURE_LOG] pkg_name : org.example.Running - no result
02-15 13:57:25.366+0900 D/AUL     ( 4946): launch.c: app_request_to_launchpad(287) > [SECURE_LOG] launch request : org.example.Running
02-15 13:57:25.366+0900 D/AUL     ( 4946): app_sock.c: __app_send_raw(270) > pid(-2) : cmd(0)
02-15 13:57:25.366+0900 D/AUL_AMD ( 2303): amd_request.c: __request_handler(506) > __request_handler: 0
02-15 13:57:25.366+0900 D/AUL_AMD ( 2303): amd_request.c: __request_handler(549) > launch a single-instance appid: org.example.Running
02-15 13:57:25.366+0900 D/AUL_AMD ( 2303): amd_launch.c: _start_app(1491) > [SECURE_LOG] caller : org.example.Running
02-15 13:57:25.366+0900 D/AUL_AMD ( 2303): amd_launch.c: _start_app(1632) > [SECURE_LOG] caller process & callee process is same.[org.example.Running:4946]
02-15 13:57:25.366+0900 D/AUL_AMD ( 2303): amd_launch.c: _start_app(1859) > pid(-128) ecore_x_pointer_ungrab
02-15 13:57:25.366+0900 D/AUL     ( 4946): launch.c: app_request_to_launchpad(301) > launch request result : -7
02-15 13:57:25.366+0900 E/AUL     ( 4946): launch.c: app_request_to_launchpad(307) > app_request_to_launchpad : Same Process Send Local
02-15 13:57:25.366+0900 D/APP_CORE( 4946): appcore.c: __aul_handler(423) > [APP 4946]     AUL event: AUL_START
02-15 13:57:25.366+0900 D/APP_CORE( 4946): appcore-efl.c: __do_app(471) > [APP 4946] Event: RESET State: RUNNING
02-15 13:57:25.366+0900 D/APP_CORE( 4946): appcore-efl.c: __do_app(497) > [APP 4946] RESET
02-15 13:57:25.366+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(499) > [Running:Application:reset:start]
02-15 13:57:25.366+0900 I/CAPI_APPFW_APPLICATION( 4946): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
02-15 13:57:25.366+0900 D/LAUNCH  ( 4946): appcore-efl.c: __do_app(506) > [Running:Application:reset:done]
02-15 13:57:25.366+0900 I/APP_CORE( 4946): appcore-efl.c: __do_app(519) > Legacy lifecycle: 0
02-15 13:57:25.366+0900 I/APP_CORE( 4946): appcore-efl.c: __do_app(521) > [APP 4946] App already running, raise the window
02-15 13:57:25.376+0900 D/APP_CORE( 4946): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
02-15 13:57:25.376+0900 D/APP_CORE( 4946): appcore.c: __prt_ltime(183) > [APP 4946] first idle after reset: 28145 msec
02-15 13:57:25.406+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1872384 button=1
02-15 13:57:25.526+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1872527 button=1
02-15 13:57:25.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:25.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:25.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:25.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134645
02-15 13:57:25.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:25.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:25.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:26.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:26.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:26.856+0900 I/GESTURE ( 2231): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
02-15 13:57:26.916+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1873865 button=1
02-15 13:57:26.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:26.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134646
02-15 13:57:26.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:26.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:26.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:27.006+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1874015 button=1
02-15 13:57:27.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:27.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:27.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:27.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134647
02-15 13:57:27.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:27.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:27.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:28.116+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1874977 button=1
02-15 13:57:28.116+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1875128 button=1
02-15 13:57:28.116+0900 D/UIB_APP ( 4946): Resuming fit
02-15 13:57:28.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:28.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:28.816+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1875641 button=1
02-15 13:57:28.816+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1875823 button=1
02-15 13:57:28.816+0900 D/UIB_APP ( 4946): Pausing fit
02-15 13:57:28.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:28.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134648
02-15 13:57:28.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:28.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:28.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:29.516+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1876327 button=1
02-15 13:57:29.516+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1876523 button=1
02-15 13:57:29.516+0900 D/UIB_APP ( 4946): Resuming fit
02-15 13:57:29.686+0900 D/UIB_APP ( 4946): Heart: 100.000000, 0.000000, 600.000000, 0.000000
02-15 13:57:29.686+0900 D/UIB_APP ( 4946): Heart: 100.000000
02-15 13:57:29.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:29.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(205) > Current position: timestamp : 1487134649
02-15 13:57:29.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: location_manager_get_last_accuracy(1208) > location_manager_get_last_accuracy
02-15 13:57:29.996+0900 D/UIB_APP ( 4946): Location: 37.258889, 127.055297, 0.000000, 0.000000, 0.000000
02-15 13:57:29.996+0900 D/CAPI_LOCATION_MANAGER( 4946): locations.c: __cb_service_updated(193) > Callback function has been invoked. 
02-15 13:57:30.186+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1877042 button=1
02-15 13:57:30.186+0900 D/EFL     ( 4946): ecore_x<4946> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1877195 button=1
02-15 13:57:30.216+0900 W/CRASH_MANAGER( 4971): worker.c: worker_job(1189) > 110494672756e148713465
