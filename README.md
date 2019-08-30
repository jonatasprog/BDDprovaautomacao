# BDDprovaautomacao
BDDprovaautomacao is a Web Behavior-Driven Development (BDD) Test Automation Project example on .Net Platform using Selenium Webdriver API and Specflow as BDD tool. It's used C# as object-oriented programming language and Gherkin language in SpecFlow by wich use feature files to specify acceptance criteria for features (user cases, user stories) inside the application by using a specific syntax. The Gherkin language defines the structure and a basic syntax for describing tests.
## Requirements

* Microsoft Visual Studio 2017 as integrated development environment (IDE).
* .NET Framework 4.6.1 (To set this framework go to Project > Properties > Application > Targer framework = .NET Framework 4.6.1).

If some installed dependencies do not work, they can be found in NuGet Package Manager on Visual Studio:
* Selenium.WebDriver
* Selenium.Support 
* Selenium.Chrome.WebDriver
* WebDriverManager
* SpecFlow
* NUnit
* NUnit3TestAdapter
* ExtentReports
* DotNetSeleniumExtras.WaitHelpers

Tell me if you have any version conflicts using these references.

## Usage

* At first, build the solution by going to Build > Build Solution
* Now to run our tests we just need to make sure that NUnit3 Test Adapter has detected our BDD features on Test Explorer. Then we can run It according to the selected test.

To open Test Explorer go to Test > Windows > Test Explorer: The Test Explorer lists the Test Studio tests within the currently opened solution.

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
