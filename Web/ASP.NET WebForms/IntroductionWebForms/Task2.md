# Web Forms Files and Folders

## Folders

The "Account" folder contains logon and security files
The "App_Data" folder contains databases and data files
The "Images" folder contains images
The "Scripts" folder contains browser scripts
The "Shared" folder contains common files (like layout and style files)

## App_Start
### BundleConfig.cs
Bundling and minification of scrips is done in this file.

### IdentityConfig.cs
Based on the configuration components and helpers defined in IdentityConfig.cs, the identity behavior
in a Web Forms application is set at runtime.

### RouteConfig.cs
Route are configured in this file. In the default version friendly urls are also enabled.

### Startup.Auth.cs
In this file is the configutration of the authentication, the configuration of db context, cookies 
configuration, login verification.

## Root Directory

### Global.asax
The Global.asax, also known as the ASP.NET application file, is used to serve application-level and session-level events.
 
### Startup.cs
The Startup class is the convention that Katana/OWIN looks for to initialize the pipeline. When your app starts, the code inside of the Configuration function is run to set up the components that'll be used. In the MVC 5 templates, it's used to wire up the authentication middleware which is all built on top of OWIN.

# Code Behind
ASP.NET 2.0 introduces an improved runtime for code-behind pages that simplifies the connections between the page and code. In this new code-behind model, the page is declared as a partial class, which enables both the page and code files to be compiled into a single class at runtime. The page code refers to the code-behind file in the CodeFile attribute of the <%@ Page %> directive, specifying the class name in the Inherits attribute. Note that members of the code behind class must be either public or protected (they cannot be private). 

VB CodeBehind Code Separation
 Run Sample  View Source

The advantage of the simplified code-behind model over previous versions is that you do not need to maintain separate declarations of server control variables in the code-behind class. Using partial classes (new in 2.0) allows the server control IDs of the ASPX page to be accessed directly in the code-behind file. This greatly simplifies the maintenance of code-behind pages. 

