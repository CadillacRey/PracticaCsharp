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


                var pathAgregarCarrito = "//button[@id='add-to-cart-button-20']";
                wait.Until(d => d.FindElement(By.XPath(pathAgregarCarrito)));
                var botonAgregarCarrito = driver.FindElement(By.XPath(pathAgregarCarrito));
                botonAgregarCarrito.Click();



                var wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //Esto lo encontre con el IDE
                driver.FindElement(By.CssSelector(".cart-button")).Click();
                //var irAlCarrito = "//button[@ class='button-1 cart-button']";
                //wait.Until(d=> d.FindElement(By.XPath(irAlCarrito)));
                //var botonIrAlCarrito = driver.FindElement(By.XPath(irAlCarrito));
                //botonIrAlCarrito.Click();  para comentar cntrl k c y descomentar control k q 


                //seleccionamos el boton
                IWebElement boton = driver.FindElement(By.XPath("//input[@class='button']"));

                //hacemos click en el boton
                boton.Click();

                try // intenta buscar por etiqueta
                {
                    IWebElement resultado = driver.FindElement(By.XPath("//span[@id='output']"));

                    //afirmacion de si el resultado es 194
                    Assert.AreEqual(resultado.Text, "194");

                }
                //error por no se encuentra la etiqueta
                catch (NoSuchElementException ex)
                {
                    Assert.Fail("La etiqueta buscada no es la correcta");

                }
                //error general
                catch (Exception ex)
                {
                    Assert.Fail($"Error general. Mensaje: {ex.Message}");

                }

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

