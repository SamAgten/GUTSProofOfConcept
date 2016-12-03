using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using Microsoft.Win32;
using NUnit.Framework;
using System.IO;
using TestStack.White;

using System.Windows;


namespace SimpleButtons.Tests
{
    [TestFixture]
    class MainWindowTests
    {
        private Window _window;
        private Application _application;

        private Button _button1;        //Button with 1 on it
        private Button _button2;        //Button with 2 on it
        private Button _button3;        //Button with 3 on it
        private Label _labelA;          //Label with A on it
        private Label _labelB;          //Label with B on it
        private Label _labelC;          //Label with C on it

        [OneTimeSetUp]
        public void SetupTests()
        {
            var applicationDirectory = TestContext.CurrentContext.TestDirectory;
            var applicationPath = Path.Combine(applicationDirectory, "SimpleButtons.exe");
            //Console.WriteLine(applicationPath);
            _application = Application.Launch(applicationPath);
            _window = _application.GetWindow("MainWindow");
            Assert.That(_window, Is.Not.Null);

            //Find all the UI Elements 
            _button1 = _window.Get<Button>(SearchCriteria.ByText("1"));
            _button2 = _window.Get<Button>(SearchCriteria.ByText("2"));
            _button3 = _window.Get<Button>(SearchCriteria.ByText("3"));

            _labelA = _window.Get<Label>(SearchCriteria.ByText("A"));
            _labelB = _window.Get<Label>(SearchCriteria.ByText("B"));
            _labelC = _window.Get<Label>(SearchCriteria.ByText("C"));
        }

        [Test]
        public void ShouldHaveButtonWithText1()
        {
            Assert.That(_button1, Is.Not.Null);
        }

        [Test]
        public void ShouldHaveButtonWithText2()
        {
            Assert.That(_button2, Is.Not.Null);
        }

        [Test]
        public void ShouldHaveButtonWithText3()
        {
            Assert.That(_button3, Is.Not.Null);
        }

        [Test]
        public void ShouldHaveLabelWithTextA()
        {
            Assert.That(_labelA, Is.Not.Null);
        }

        [Test]
        public void ShouldHaveLabelWithTextB()
        {
            Assert.That(_labelB, Is.Not.Null);
        }

        [Test]
        public void ShouldHaveLabelWithTextC()
        {
            Assert.That(_labelC, Is.Not.Null);
        }

        [Test]
        public void ShouldChangeLabelsToJaWhenPressingButton1()
        {
            //Arrange
            //See setup

            //Act
            _button1.Click();

            //Check all the labels
            string ja = "Ja";
            Assert.That(_labelA.Text, Is.EqualTo(ja).IgnoreCase);
            Assert.That(_labelB.Text, Is.EqualTo(ja).IgnoreCase);
            Assert.That(_labelC.Text, Is.EqualTo(ja).IgnoreCase);
        }

        [Test]
        public void ShouldChangeLabelsToNeeWhenPressingButton2()
        {
            //Arrange
            //See setup

            //Act
            _button2.Click();

            //Check all the labels
            string nee = "Nee";
            Assert.That(_labelA.Text, Is.EqualTo(nee).IgnoreCase);
            Assert.That(_labelB.Text, Is.EqualTo(nee).IgnoreCase);
            Assert.That(_labelC.Text, Is.EqualTo(nee).IgnoreCase);
        }

        [Test]
        public void ShouldChangeLabelsToABCWhenPressingButton3()
        {
            //Arrange
            //See setup

            //Act
            _button3.Click();

            //Check all the labels
            Assert.That(_labelA.Text, Is.EqualTo("A").IgnoreCase);
            Assert.That(_labelB.Text, Is.EqualTo("B").IgnoreCase);
            Assert.That(_labelC.Text, Is.EqualTo("C").IgnoreCase);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _application.Close();
        }

    }
}
