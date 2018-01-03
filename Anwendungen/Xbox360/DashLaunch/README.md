<div align="center"><img src="http://www.newsinside.org/wp-content/uploads/2015/05/dashlaunch-360.jpg"></img></div>

DashLaunch 3.18.1 updates:

- critical bug fix
- add 17511 dashboard support
​
How to use:​


To install copy to your Xbox 360, then run the application with XEX Menu or FreeStyle Dash and follow the on screen instructions.

Overview - what it does
================================================================================

- It will launch a XeX or CON file from the path you specified in launch.ini
as long as it's valid
- Depending on the button you hold when the xbox is trying to load the NXE, it
will divert to the xex/con tied to that button or return to default as
defined in launch.ini
- Depending which button is held when closing miniblade in NXE (use Y button to
close, release then hold a QL button) it will quick launch a CON or XEX
from your ini file
- allows one to patch kernel/xam at bootup with a freeBOOT patch style bin file
from usb or hdd (in that order) must be in root of the device and be named
"kxam.patch" and be no larger than 0x4000 bytes. Again, kxam.patch binary
format is the same as a compiled freeboot patch bin, but uses real virtual
addresses rather than offsets - see 1.0 release for a windows patch builder
- with the included patch set, launch.xex acts as a helper to detect when
xbox1 emulator loads, allowing memory unlock patch and xbox1 emulator
to function together.
