# ios9ForceTouchTest
This is a simple app I've put together to check out the ForceTouch API.

There are a few things within the file that are worth note. Having not had the chance to run this on a real device, the code is in a state of flux. 

The main ForceTouch things this project is doing are:

1) Checking for the existing of ForceTouch. I'm doing a check for iOS9 and then using the Traits to determine if we can use the ForceTouch. All of this code is in the ViewController.cs
2) I'm registering some fixed shortcuts in the Info.plist file. Its probably best to look at the file in a Text Editor to see the registration
3) I'm also registering some dynamic shortcuts in the project too. You can see this in the FinishedLaunching method of the app delegate
4) I've got an empty initialization of the handler for the shortcut for the AppDelegate. When a shortcut is selected, this method should fire on the AppDelegate 
