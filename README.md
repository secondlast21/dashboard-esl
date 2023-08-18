# dashboard-esl

## .Net Core Installation
### Prerequisites
.NET CORE 7 SDK and VISUAL STUDIO 2022, SQL SERVER

### Installation Steps
* Open solution file DocumentManagement.sln from .Net core folder into visual studio 2022.
* Right click on solution explorer and Restore nuget packages.
* Change database connection string in appsettings.Development.json in DocumentManagement.API project.
* Open package manager console from visual studio menu --> Tools --> nuget Package Manager --> Package Manager Console
* In package manager console, Select default project as DocumentManagement.Domain
* Run Update-Database command in package manager console which create database and insert intial data.
* From Solution Explorer, Right click on DocumentManagement.API project and click on Set as Startup Project from menu.
* To run project Press F5.

## Angular Installation
### Install tools
* Node version >= 4.0 and NPM >= 3
* Globally installed typescript
* Installing Angular-CLI globally is as simple as running this simple command: npm install -g @angular/cli
* After the tools is installed, go inside of the Angular directory and run below command to install dependencies:
* Run npm install -f to install node dependencies defined in package.json.

### Running local copy
* To run a local copy in development mode, replace REST API URI (apiUrl) variable in environment file inside src --> environments -->environment.ts
* Execute ng serve and go to http://localhost:4200 in your browser.
* To run the local copy in production mode and build the sources, execute ng build --prod. This will builds a production version of the application. All html,css and js code is minified and put to dist folder. The contents of this folder you can to put to your production server when publishing the application.
