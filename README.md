# PSMoveTest

A Unity-based testbed for interacting with the PS Move controller.

## Dependencies

### Software

- [PSMoveAPI](https://github.com/thp/psmoveapi)
- [UniMove](https://github.com/CopenhagenGameCollective/UniMove)
- [Macam](http://webcam-osx.sourceforge.net/downloads.html) (Mac PS Eye driver).

### Hardware

- [PS Move Controller](https://www.playstation.com/en-us/explore/accessories/playstation-move/)
- [PS Eye](http://www.amazon.com/PlayStation-Eye-3/dp/B000VTQ3LU)
- [PS Navigation Controller](http://us.playstation.com/ps3/accessories/playstation-move-navigation-controller-ps3.html)

#### Notes

- Technically you should be able to use any webcam in place of the PS Eye, however the PS Eye is cheap (less than $8 on Amazon at the time of this writing) and capable (it can record at up to 120Hz).
- Presently the Navigation Controller is not supported by PSMoveAPI (the piece that allows the controllers to talk to the computer). The plan is to add support for this.

## Setup

Setup can be a little bit gnarly and will be platform dependent (i.e., different on Mac than on Windows). Setup can also vary between versions of an OS for extra fun! If you contribute to this project please provide detailed setup and configuration instructions. Err on the side of __too__ detailed.

### Mac OSX

This setup was done on Mac OS 10.10.4 on a mid-2011 13" MacBook Air.

1. Download Macam and install `macam.component`. You simply need to drag it to the folder that is to the right of the component. This is hidden by default, make the macam Finder window wider to reveal it. You'll need to enter your admin password to complete the installation.
2. Follow the [PSMoveAPI setup instructions](https://docs.google.com/document/d/16oB5jpbCpeRWb0o7w0b9bFbT3vEzWGqEPESWZUSCPuU/edit). A copy of these instructions is saved as `GetstartedwithPSmoveApionMacOSX.pdf` in the `docs` folder of this repo.
  1. Be sure to run the examples to verify the PSMoveAPI installation.
3. Create an empty Unity project and import the `UniMove` asset. The UniMove README provides instructions for this.
4. UniMove only works when the PS Move controller is connected via Bluetooth. It will not properly function with controllers connected via USB. This is annoying as connecting via Bluetooth is a bit finicky while USB "just works"... These are the steps I've used to successfully connect via Bluetooth:
  1. Turn on Bluetooth
  2. Connect PS Move controller via USB.
  3. Run the `psmovepair` utility in the `{psmoveapi}/build/` folder.
  4. Press the "PS" button on the Move controller to connect via Bluetooth.
  5. Hope and pray. In the Bluetooth menu you should see "Motion Controller" in the Devices list.
5. Run the UniMove test scene.





