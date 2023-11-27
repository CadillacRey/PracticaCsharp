using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClase13FinalCarrito
{
    public class Class1
    {
        [TestFixture]
        public class PrimerTest
        {
            [Test]
            public void test1()
            {

                
                IWebDriver driver = new ChromeDriver();

                //Maximizar la ventana
                driver.Manage().Window.Maximize();

                //Ir a la pagina
                driver.Navigate().GoToUrl("https://demo.nopcommerce.com/");

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                var textElectronicos = "Electronics";
                wait.Until(d => d.FindElement(By.LinkText(textElectronicos)));
                var BotonElectronicos = driver.FindElement(By.LinkText(textElectronicos));
                BotonElectronicos.Click();

                var textCelulares = "Cell phones";
                wait.Until(d => d.FindElement(By.LinkText(textCelulares)));
                var linkCelulares = driver.FindElement(By.LinkText(textCelulares));
                linkCelulares.Click();

                var textCelularElegido = "Nokia Lumia 1020";
                wait.Until(d => d.FindElement(By.LinkText(textCelularElegido)));
                var linkCelularElegido = driver.FindElement(By.LinkText(textCelularElegido));
                linkCelularElegido.Click();

                driver.FindElement(By.Id("add-to-cart-button-20")).Click();
                driver.FindElement(By.CssSelector(".cart-label")).Click();
                driver.FindElement(By.Id("termsofservice")).Click();
                driver.FindElement(By.Id("checkout")).Click();
                driver.FindElement(By.CssSelector(".checkout-as-guest-button")).Click();

              
                //var pathAgregarCarrito = "//button[@id='add-to-cart-button-20']";
                //wait.Until(d => d.FindElement(By.XPath(pathAgregarCarrito)));
                //var botonAgregarCarrito = driver.FindElement(By.XPath(pathAgregarCarrito));
                //botonAgregarCarrito.Click();



                //var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //Esto lo encontre con el IDE
                //driver.FindElement(By.CssSelector(".cart-button")).Click();
                //var irAlCarrito = "//button[@ class='button-1 cart-button']";
                //wait.Until(d=> d.FindElement(By.XPath(irAlCarrito)));
                //var botonIrAlCarrito = driver.FindElement(By.XPath(irAlCarrito));
                //botonIrAlCarrito.Click();  para comentar cntrl k c y descomentar control k q 


                driver.FindElement(By.CssSelector(".checkout-as-guest-button")).Click();
                var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
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

                //falta poner el tiempo de espera para que se vea el resultado

                //Cerrar el chrome
                driver.Close();
                //Terminar el proceso
                driver.Quit();

            }


            [Test]
            public void test2()
            {
                //Assert.Fail();
            }

        }
    }
}

