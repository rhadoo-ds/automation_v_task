


# Visma Technical Test

<p align="center">
  <a href="https://www.visma.ro/" target="_blank">
    <img src="https://www.visma.com/contentassets/ce3e4a8f642e4f848ba78168a926d666/logohoy_ny.jpg" height="70px">
  </a>
</p>



## Position opening

<p align="left">
  <a href="https://visma.easycruit.com/vacancy/2776779/119661?iso=gb" target="_blank">
Technical Quality Assurer
  </a>
</p>

*****************


## Test requirements:

[**Task 1 (frontend).**](#task-1) Write an automated test that performs the following:

1.  Navigate to [http://way2automation.com/way2auto_jquery/automation-practice-site.html](http://way2automation.com/way2auto_jquery/automation-practice-site.html)
    
2.  Open the "Date picker" widget.
    
3.  Navigate to the "FORMAT DATE" section.
    
4.  Select today's date.
    
5.  Select the "ISO 8601" Format option.
    
6.  Validate the shown date against the current date.
    

[**Task 2 (backtend).**](#task-2) Write an automated test suite that performs the following:

Using the public API: [https://jsonplaceholder.typicode.com/](https://jsonplaceholder.typicode.com/)

1.  Check that a post exists with the title "qui est esse"
    
2.  Add a new user and specify a name, username and email
    
3.  Write a test for one of the API endpoints that will fail if the response time passes a given threshold.

*****************

# Task 1

**Prerequisites:**

We will be using C# and Selenium Web Driver in order to achieve this.
I've used a Windows10 VM, having latest Chrome already installed and the bellow installers.


**Installers:**

1. Visual Studio Community 2019
Navigate to [Visual Studio: IDE and Code Editor for Software Developers and Teams (microsoft.com)](https://visualstudio.microsoft.com/) and download Comunity 2019
<p align="left">  
    <img src="https://i.postimg.cc/vGqNRHj7/1-download-VSC-2019.png">
</p>

Open the downloaded installer 

<p align="left">  
    <img src="https://i.postimg.cc/50MmmGtg/2-download-VSC-2019.png">
</p>

Check
- Universal Windows Platform development
- .Net desktop development

and then click "Install" 

<p align="left">  
    <img src="https://i.postimg.cc/K867ZVtb/3-download-VSC-2019.png">
</p>

... wait a while for files to download and instalation to finish ..

<p align="left">  
    <img src="https://i.postimg.cc/fTbf5YMG/4-download-VSC-2019.png">
</p>
... jump over Sign In ...
<p align="left">  
    <img src="https://i.postimg.cc/V6BWZRr8/5-start-VSC-2019.png">
</p>
... and choose any skin you like :)
<p align="left">  
    <img src="https://i.postimg.cc/90mt67Zq/6-start-VSC-2019.png">
</p>
Now, let's import the project:
<p align="left">  
    <img src="https://i.postimg.cc/gjgqm2Ht/7-start-VSC-2019.png">
</p>
Then locate and open "VismaTask1.sln" file from inside the cloned folder.


2. Selenium WebDriver and other few bits ...

Right Click the project after imported:
- select **Manage NuGet packages**
- search for **Selenium.WebDriver** and click install 
- search for **Selenium.Support** and click install
- search for **Selenium.WebDriver.ChromeDriver** and click install
- search for **DotNetSeleniumExtras.PageObjects** and click install- 
- search for **DotNetSeleniumExtras.PageObjects.Core** and click install
- search for **NUnit** and click install
 


**Test run procedure**

Open "Start.cs" and hit **Ctrl+F5** to start running the test.
If the run was succesfull, you should see the bellow image.

<p align="left">  
    <img src="https://i.postimg.cc/tCmtc7TY/12-run-test-sucesfull.png">
</p>

*****************

# Task 2

**-> Prerequisites:**

Soap UI is needed to import and run the test suite.


**-> Installers:**

You can either go to [Download  SoapUI](https://www.soapui.org/downloads/soapui/) or use directly this link: <a href="https://s3.amazonaws.com/downloads.eviware/soapuios/5.6.0/SoapUI-x64-5.6.0.exe" target="_blank">
SoapUI 5.6.0
  </a>



**-> Project import**

Open SoapUI and use **CTRL + I** shortcut to open Import soapUI project window.

Import **\Task2\Visma-Task-2-soapui-project.xml**


**Test run procedure**

You can either use TestRunner (make sure you run SoapUI as admin, to avoid any potential access issues - not ideal :) )

<p align="left">  
    <img src="https://i.postimg.cc/xdGm9d0G/Test-Runner-Soap-UI.png">
</p>

Just click Launch :

<p align="left">  
    <img src="https://i.postimg.cc/8z6WnH90/Launch-Test-Runner.png">
</p>

... and if all was succesfull, after a little while, you should see the following screen:

<p align="left">  
    <img src="https://i.postimg.cc/QtXTCrt2/Test-Runner-Success.png">
</p>

Or you just run manually each test case and check every assertion:

<p align="left">  
    <img src="https://i.postimg.cc/JhCJwXW4/Soap-UI-individual-TC.png">
</p>


For Point C., SoapUI does not allow the use of Project Property as a value in an SLA Assertion.
In the current implementation, it was added a hardcoded value of 200ms, but using ReadyAPI it can be given a global property of the Project.

Test will fail if response time is bigger than 200ms. Please check the logs and rerun until it passed. :) 
I've managed to get consistenly reponses bellow 50ms ... so for me it passed almost every time.

In order to bypass SoapUI limitation of not being able to use the a Project Property in a SLA Assertion,
will just use a groovy script to test that execution time of GetComments response time is lower than the givenThreshold.
