using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingClase12Automation
{

        [TestFixture]
        public class PrimerTest
        {
            [Test]
            public void test1()
            {

                //creamos una instancia de chrome que podemos automatizar
                IWebDriver driver = new ChromeDriver();

                //maximizar la ventana
                driver.Manage().Window.Maximize();

                // ir a la pagina web
                driver.Navigate().GoToUrl("https://nahual.github.io/qc-celfar/?v=1");

                //seleccione el textbox
                IWebElement textBox = driver.FindElement(By.XPath("//input[@id='input']"));

                //hago click
                textBox.Click();

                //envio el texto
                textBox.SendKeys("90");

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
