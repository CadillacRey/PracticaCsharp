using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TareaClase13AutomationFinal
{
    public class Class1
    {
        [TestFixture]
        public class PrimerTest
        {
            //Caso de Test con 2 compras, Celular y Libro, como Guest. 
            [Test]
            public void test1()
            {

                //Inicializo Chrome
                ChromeOptions chromeOptions = new ChromeOptions();

                //Deshabilito los guardados de chrome
                chromeOptions.AddUserProfilePreference("disable-popup-blocking", true);
                chromeOptions.AddUserProfilePreference("autofill.profile_enabled", false);
                IWebDriver driver = new ChromeDriver(chromeOptions);
                //Maximizo la ventana
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");
                driver.FindElement(By.LinkText("Electronics")).Click();
                driver.FindElement(By.LinkText("Cell phones")).Click();
                driver.FindElement(By.CssSelector(".item-box:nth-child(3) .product-box-add-to-cart-button")).Click();
                driver.FindElement(By.LinkText("Books")).Click();
                driver.FindElement(By.CssSelector(".item-box:nth-child(1) .product-box-add-to-cart-button")).Click();
                driver.FindElement(By.CssSelector(".cart-label")).Click();
                driver.FindElement(By.Id("termsofservice")).Click();
                driver.FindElement(By.Id("checkout")).Click();
                driver.FindElement(By.CssSelector(".checkout-as-guest-button")).Click();
                driver.FindElement(By.Id("BillingNewAddress_FirstName")).Click();
                driver.FindElement(By.Id("BillingNewAddress_FirstName")).SendKeys("Emanuel");
                driver.FindElement(By.Id("BillingNewAddress_LastName")).SendKeys("Reynoso");
                driver.FindElement(By.Id("BillingNewAddress_Email")).SendKeys("reynosoemanuel04@gmail.com");
                driver.FindElement(By.Id("BillingNewAddress_Company")).SendKeys("E-Corp");
                driver.FindElement(By.Id("BillingNewAddress_CountryId")).Click();
                {
                    //Elemento desplegable
                    var dropdown = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
                    dropdown.FindElement(By.XPath("//option[. = 'Argentina']")).Click();
                }
                driver.FindElement(By.Id("BillingNewAddress_City")).Click();
                driver.FindElement(By.Id("BillingNewAddress_City")).SendKeys("Buenos Aires");
                driver.FindElement(By.Id("BillingNewAddress_Address1")).Click();
                driver.FindElement(By.Id("BillingNewAddress_Address1")).SendKeys("Av. Siempre Viva 1234");
                driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).SendKeys("1753");
                driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).SendKeys("111111111111111");
                driver.FindElement(By.Name("save")).Click();
                //Agrego la espera por cada boton
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@class='button-1 shipping-method-next-step-button']")));
                driver.FindElement(By.XPath("//button[@class='button-1 shipping-method-next-step-button']")).Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".payment-method-next-step-button")));
                driver.FindElement(By.CssSelector(".payment-method-next-step-button")).Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".payment-info-next-step-button")));
                driver.FindElement(By.CssSelector(".payment-info-next-step-button")).Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".confirm-order-next-step-button")));
                driver.FindElement(By.CssSelector(".confirm-order-next-step-button")).Click();
                wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".order-completed-continue-button")));
                driver.FindElement(By.CssSelector(".order-completed-continue-button")).Click();
                //Cerrar el chrome
                driver.Close();
                //Terminar el proceso
                driver.Quit();
            }
                 
        }
    }
}


