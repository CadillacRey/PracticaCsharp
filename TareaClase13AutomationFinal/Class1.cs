using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TareaClase13AutomationFinal
{
    public class Class1
    {
        [TestFixture]
        public class PrimerTest
        {
            [Test]
            public void test1()
            {
                //Inicializo Chrome
                IWebDriver driver = new ChromeDriver();
                //Maximizo Ventana
                driver.Manage().Window.Maximize();
                var options = new ChromeOptions();

                // Desactiva el autocompletado de direcciones
                //options.AddUserProfilePreference("profile.address_autocomplete_enabled", false);
                //IWebDriver driver1 = new ChromeDriver(options);
                //driver.Navigate().GoToUrl("chrome://settings/addresses");
                //// Ejecuta un script JavaScript para desactivar el autocompletado de direcciones
                //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                //js.ExecuteScript("document.querySelector('input[type=\"text\"][autocomplete=\"address-line1\"]').autocomplete = 'off';");
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                    driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
                    //Borro las cookies
                    driver.Manage().Cookies.DeleteAllCookies();
                    driver.FindElement(By.LinkText("Electronics")).Click();
                    driver.FindElement(By.LinkText("Cell phones")).Click();
                    driver.FindElement(By.CssSelector(".item-box:nth-child(3) .details a")).Click();
                    driver.FindElement(By.Id("add-to-cart-button-20")).Click();
                    driver.FindElement(By.CssSelector(".cart-label")).Click();
                    driver.FindElement(By.Id("termsofservice")).Click();
                    driver.FindElement(By.Id("checkout")).Click();
                    driver.FindElement(By.CssSelector(".checkout-as-guest-button")).Click();
                    var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(4));
                    driver.FindElement(By.Id("BillingNewAddress_FirstName")).Click();
                    driver.FindElement(By.Id("BillingNewAddress_FirstName")).SendKeys("Emanuel");
                    driver.FindElement(By.Id("BillingNewAddress_LastName")).SendKeys("Reynoso");
                    driver.FindElement(By.Id("BillingNewAddress_Email")).SendKeys("reynosoemanuel04@gmail.com");
                    driver.FindElement(By.Id("BillingNewAddress_Company")).SendKeys("E-corp");
                    driver.FindElement(By.Id("BillingNewAddress_CountryId")).Click();
                    {
                        var dropdown = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
                        dropdown.FindElement(By.XPath("//option[. = 'Argentina']")).Click();
                    }
                    driver.FindElement(By.Id("BillingNewAddress_City")).Click();
                    driver.FindElement(By.Id("BillingNewAddress_City")).SendKeys("Buenos Aires");
                    driver.FindElement(By.Id("BillingNewAddress_Address1")).Click();
                    driver.FindElement(By.Id("BillingNewAddress_Address1")).SendKeys("Av. Siempre Viva 1234");
                    driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).Click();
                    driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).SendKeys("1753");
                    driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).Click();
                    driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).SendKeys("1111111111");
                    driver.FindElement(By.Name("save")).Click();
                    driver.FindElement(By.CssSelector(".shipping-method-next-step-button")).Click();
                    driver.FindElement(By.CssSelector(".payment-method-next-step-button")).Click();
                    driver.FindElement(By.CssSelector(".payment-info-next-step-button")).Click();
                    driver.FindElement(By.CssSelector(".confirm-order-next-step-button")).Click();
                    driver.FindElement(By.CssSelector(".order-completed-continue-button")).Click();
                    //Cerrar el chrome
                    driver.Close();
                    //Terminar el proceso
                    driver.Quit();
            }
        }
    }

 } 


