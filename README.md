# WebApp.ExternalIntercept

This project is an example of one way to implement external link confirmation. 

Specifically, the desired behavior is: 

* Upon clicking an external link, which is defined as
  * A link with a web protocol (http, https, or protocol agnostic)
  * A link with a host which does not match the current page
* The containing page is kept open and 
* A new window/tab (browser specific) opens with a confirmation to navigate to the external link.

The confirmation page will: 
* Allow the user to navigate to the requested external URL, and if the user chooses to navigate, 
* The current window navigates to the selected external URL, else if the user chooses to cancel, 
* the confirmation page closes.

The key components are: 

* The script in ~/Views/Shared/Layout.cshtml:40-63 - This is responsible for external link detection behavior.
* The script in ~/Views/Leaving/Index.cshtml:17-24 - This allows the Layout script to use a client-side method to detect (and not intercept) external links on the Leaving/Index page. 
* The server side implementation in ~/Controllers/LeavingController.cs - The server side implementation should be very simple, only setting up a ViewModel with the referrer and external URL to display.
