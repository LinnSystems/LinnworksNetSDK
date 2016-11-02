#What is this
This is a native module that can be used in Linnworks.net. Unlike external user interfaces native modules directly sit in Linnworks.net and use the current users session. This means you have access to ALL Linnworks.net code including the ability to override any part of the user interface.


#Setup Guide

1. Upload either application to your web server
2. Add the manifest.json to your application pointing to your webserver (change PATH variable).
3. Linnworks works in a way that it will request your PATH variable, concatenated with /Simple/ and then request the Javascript files for the moduleName (eg. MyModule.html, MyModule.css, MyModule.js).

eg. 

https://www.myapp.com/Dashboard/Simple/OrdersDashboard.html
https://www.myapp.com/Dashboard/Simple/OrdersDashboard.cs
https://www.myapp.com/Dashboard/Simple/OrdersDashboard.js

Where the path would be:

https://www.myapp.com/Dashboard/


All applications must be served with HTTPS AND have CORS enabled (Make sure with CORS that you do not change this for your entire web server if it is shared with other applications).

If you have any issues with this please raise a ticket at help.linnworks.com

If you would like to push a change please feel free to contribute via github.