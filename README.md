**<h1 align = "center">Sneuss Factory**

<h1 align="center">
  <img width="900" height="450" src="https://coding-assets.s3-us-west-2.amazonaws.com/readme_hero_images/Factory.Solution.jpg">
</h1>

**<h1 align="center">"Think left and think right and think low and think high. Oh, the thinks you can think up if you only try! - Dr. Seuss"**

**<h4 align = "center">
  <a href="#✅requirements">Requirements</a> •
  <a href="#💻setup">Setup</a> •
  <a href="#🔧protecting-your-data">Protecting Data<a> •
  <a href="#📫questions-and-concerns">Q's & C's</a> •
  <a href="#🔧technologies-used">Technologies</a> •
  <a href="#🐛bugs">Bugs</a> •  
  <a href="#❤️contributors">Contributors</a> •
  <a href="#📘license">License</a>**

<br>
<h2 align = "center">
</h1>

**ABOUT**

* As factory manager, I need to keep track of who is an employed engineer

* As factory manager, I need to keep track of machines

* As factory manager, I need to keep track of which engineer is licensed for which of our machines.

* As factory manager, I need to be able to add machines if I have zero engineers employed

* As factory manager, I need to be able to hire engineers, even if I have no machines in my factory

* As factory manager, I need to be able to navigate to a list of all engineers

* As factory manager, I need to be able to navigate to a list of all machines

* As factory manager, I need to be able to navigate details of both the factory machines and the factory engineers at an individual level.


## **✅REQUIREMENTS** 

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)


## **🔧PROTECTING YOUR DATA** 
(when modifying for personal use)

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: commit that .gitignore file (this prevents your sensitive information from being shown to others). **⚠️DO NOT PROCEED UNTIL YOU DO!⚠️**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/entity-readme-image.png "Set up instructions")

#### Step 3: **To commit your .gitignore file enter the following commands**

## **💻SETUP**

copy this url to clone this project to your local system:
```html
https://github.com/tmemmerson/DoctorOffice.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

<br>

With the project open to the root directory, navigate to the production directory with the following commands in your terminal.
```js 
cd Factory
```

```js 
dotnet restore 
```

```js 
dotnet build 
``` 

```js 
dotnet ef database update 
``` 

Your application is now built, as well as the requisite database for this application. Now we run the program with...
```js 
dotnet run 
``` 



```js
git add .gitignore
```
```js
git commit -m "protect data"
```

#### Step 4: **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

## **📫QUESTIONS AND CONCERNS**

_Questions, comments and concerns can be directed to the author [Tristan Emmerson](tristan@stickerslug.com) & [Micheal Hansen](micheal.hansen@gmail.com)_

<br>

## **🔧Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>

## **🐛Known Bugs**

_**None as of:** 8/7/2020_

<br>

## **❤️Contributors**
| [<img src="https://coding-assets.s3-us-west-2.amazonaws.com/img/tristan_emmerson.jpg" width="160px;"/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br /> |
| :-----------------------------------------------------------------------------------------------------------------------------------------------------------------: |
