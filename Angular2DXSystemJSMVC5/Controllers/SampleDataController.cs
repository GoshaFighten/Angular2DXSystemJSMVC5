using Angular2DXSystemJSMVC5.Models;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Angular2DXSystemJSMVC5.Controllers {
    public class SampleDataController : ApiController {
        private static IList<Order> orders = new List<Order>() {
            new Order() { OrderID = 10248, OrderDate = new DateTime(1996, 07, 04), CustomerName = "Paul Henriot", ShipCountry = "France", ShipCity = "Reims" },
            new Order() { OrderID = 10249, OrderDate = new DateTime(1996, 07, 05), CustomerName = "Karin Josephs", ShipCountry = "Germany", ShipCity = "Münster" },
            new Order() { OrderID = 10250, OrderDate = new DateTime(1996, 07, 08), CustomerName = "Mario Pontes", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" },
            new Order() { OrderID = 10251, OrderDate = new DateTime(1996, 07, 08), CustomerName = "Mary Saveley", ShipCountry = "France", ShipCity = "Lyon" },
            new Order() { OrderID = 10252, OrderDate = new DateTime(1996, 07, 09), CustomerName = "Pascale Cartrain", ShipCountry = "Belgium", ShipCity = "Charleroi" },
            new Order() { OrderID = 10253, OrderDate = new DateTime(1996, 07, 10), CustomerName = "Mario Pontes", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" },
            new Order() { OrderID = 10254, OrderDate = new DateTime(1996, 07, 11), CustomerName = "Yang Wang", ShipCountry = "Switzerland", ShipCity = "Bern" },
            new Order() { OrderID = 10255, OrderDate = new DateTime(1996, 07, 12), CustomerName = "Michael Holz", ShipCountry = "Switzerland", ShipCity = "Genève" },
            new Order() { OrderID = 10256, OrderDate = new DateTime(1996, 07, 15), CustomerName = "Paula Parente", ShipCountry = "Brazil", ShipCity = "Resende" },
            new Order() { OrderID = 10257, OrderDate = new DateTime(1996, 07, 16), CustomerName = "Carlos Hernández", ShipCountry = "Venezuela", ShipCity = "San Cristóbal" },
            new Order() { OrderID = 10258, OrderDate = new DateTime(1996, 07, 17), CustomerName = "Roland Mendel", ShipCountry = "Austria", ShipCity = "Graz" },
            new Order() { OrderID = 10259, OrderDate = new DateTime(1996, 07, 18), CustomerName = "Francisco Chang", ShipCountry = "Mexico", ShipCity = "México D.F." },
            new Order() { OrderID = 10260, OrderDate = new DateTime(1996, 07, 19), CustomerName = "Henriette Pfalzheim", ShipCountry = "Germany", ShipCity = "Köln" },
            new Order() { OrderID = 10261, OrderDate = new DateTime(1996, 07, 19), CustomerName = "Bernardo Batista", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" },
            new Order() { OrderID = 10262, OrderDate = new DateTime(1996, 07, 22), CustomerName = "Paula Wilson", ShipCountry = "USA", ShipCity = "Albuquerque" },
            new Order() { OrderID = 10263, OrderDate = new DateTime(1996, 07, 23), CustomerName = "Roland Mendel", ShipCountry = "Austria", ShipCity = "Graz" },
            new Order() { OrderID = 10264, OrderDate = new DateTime(1996, 07, 24), CustomerName = "Maria Larsson", ShipCountry = "Sweden", ShipCity = "Bräcke" },
            new Order() { OrderID = 10265, OrderDate = new DateTime(1996, 07, 25), CustomerName = "Frédérique Citeaux", ShipCountry = "France", ShipCity = "Strasbourg" },
            new Order() { OrderID = 10266, OrderDate = new DateTime(1996, 07, 26), CustomerName = "Pirkko Koskitalo", ShipCountry = "Finland", ShipCity = "Oulu" },
            new Order() { OrderID = 10267, OrderDate = new DateTime(1996, 07, 29), CustomerName = "Peter Franken", ShipCountry = "Germany", ShipCity = "München" },
            new Order() { OrderID = 10268, OrderDate = new DateTime(1996, 07, 30), CustomerName = "Manuel Pereira", ShipCountry = "Venezuela", ShipCity = "Caracas" },
            new Order() { OrderID = 10269, OrderDate = new DateTime(1996, 07, 31), CustomerName = "Karl Jablonski", ShipCountry = "USA", ShipCity = "Seattle" },
            new Order() { OrderID = 10270, OrderDate = new DateTime(1996, 08, 01), CustomerName = "Pirkko Koskitalo", ShipCountry = "Finland", ShipCity = "Oulu" },
            new Order() { OrderID = 10271, OrderDate = new DateTime(1996, 08, 01), CustomerName = "Art Braunschweiger", ShipCountry = "USA", ShipCity = "Lander" },
            new Order() { OrderID = 10272, OrderDate = new DateTime(1996, 08, 02), CustomerName = "Paula Wilson", ShipCountry = "USA", ShipCity = "Albuquerque" },
            new Order() { OrderID = 10273, OrderDate = new DateTime(1996, 08, 05), CustomerName = "Horst Kloss", ShipCountry = "Germany", ShipCity = "Cunewalde" },
            new Order() { OrderID = 10274, OrderDate = new DateTime(1996, 08, 06), CustomerName = "Paul Henriot", ShipCountry = "France", ShipCity = "Reims" },
            new Order() { OrderID = 10275, OrderDate = new DateTime(1996, 08, 07), CustomerName = "Giovanni Rovelli", ShipCountry = "Italy", ShipCity = "Bergamo" },
            new Order() { OrderID = 10276, OrderDate = new DateTime(1996, 08, 08), CustomerName = "Miguel Angel Paolino", ShipCountry = "Mexico", ShipCity = "México D.F." },
            new Order() { OrderID = 10277, OrderDate = new DateTime(1996, 08, 09), CustomerName = "Alexander Feuer", ShipCountry = "Germany", ShipCity = "Leipzig" },
            new Order() { OrderID = 10278, OrderDate = new DateTime(1996, 08, 12), CustomerName = "Christina Berglund", ShipCountry = "Sweden", ShipCity = "Luleå" },
            new Order() { OrderID = 10279, OrderDate = new DateTime(1996, 08, 13), CustomerName = "Renate Messner", ShipCountry = "Germany", ShipCity = "Frankfurt a.M." },
            new Order() { OrderID = 10280, OrderDate = new DateTime(1996, 08, 14), CustomerName = "Christina Berglund", ShipCountry = "Sweden", ShipCity = "Luleå" },
            new Order() { OrderID = 10281, OrderDate = new DateTime(1996, 08, 14), CustomerName = "Alejandra Camino", ShipCountry = "Spain", ShipCity = "Madrid" },
            new Order() { OrderID = 10282, OrderDate = new DateTime(1996, 08, 15), CustomerName = "Alejandra Camino", ShipCountry = "Spain", ShipCity = "Madrid" },
            new Order() { OrderID = 10283, OrderDate = new DateTime(1996, 08, 16), CustomerName = "Carlos González", ShipCountry = "Venezuela", ShipCity = "Barquisimeto" },
            new Order() { OrderID = 10284, OrderDate = new DateTime(1996, 08, 19), CustomerName = "Renate Messner", ShipCountry = "Germany", ShipCity = "Frankfurt a.M." },
            new Order() { OrderID = 10285, OrderDate = new DateTime(1996, 08, 20), CustomerName = "Horst Kloss", ShipCountry = "Germany", ShipCity = "Cunewalde" },
            new Order() { OrderID = 10286, OrderDate = new DateTime(1996, 08, 21), CustomerName = "Horst Kloss", ShipCountry = "Germany", ShipCity = "Cunewalde" },
            new Order() { OrderID = 10287, OrderDate = new DateTime(1996, 08, 22), CustomerName = "Janete Limeira", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" },
            new Order() { OrderID = 10288, OrderDate = new DateTime(1996, 08, 23), CustomerName = "Maurizio Moroni", ShipCountry = "Italy", ShipCity = "Reggio Emilia" },
            new Order() { OrderID = 10289, OrderDate = new DateTime(1996, 08, 26), CustomerName = "Victoria Ashworth", ShipCountry = "UK", ShipCity = "London" },
            new Order() { OrderID = 10290, OrderDate = new DateTime(1996, 08, 27), CustomerName = "Pedro Afonso", ShipCountry = "Brazil", ShipCity = "Sao Paulo" },
            new Order() { OrderID = 10291, OrderDate = new DateTime(1996, 08, 27), CustomerName = "Bernardo Batista", ShipCountry = "Brazil", ShipCity = "Rio de Janeiro" },
            new Order() { OrderID = 10292, OrderDate = new DateTime(1996, 08, 28), CustomerName = "Anabela Domingues", ShipCountry = "Brazil", ShipCity = "Sao Paulo" },
            new Order() { OrderID = 10293, OrderDate = new DateTime(1996, 08, 29), CustomerName = "Miguel Angel Paolino", ShipCountry = "Mexico", ShipCity = "México D.F." },
            new Order() { OrderID = 10294, OrderDate = new DateTime(1996, 08, 30), CustomerName = "Paula Wilson", ShipCountry = "USA", ShipCity = "Albuquerque" },
            new Order() { OrderID = 10295, OrderDate = new DateTime(1996, 09, 02), CustomerName = "Paul Henriot", ShipCountry = "France", ShipCity = "Reims" },
            new Order() { OrderID = 10296, OrderDate = new DateTime(1996, 09, 03), CustomerName = "Carlos González", ShipCountry = "Venezuela", ShipCity = "Barquisimeto" },
            new Order() { OrderID = 10297, OrderDate = new DateTime(1996, 09, 04), CustomerName = "Frédérique Citeaux", ShipCountry = "France", ShipCity = "Strasbourg" },
        };
        private static IList<Country> countries = new List<Country>() {
            new Country() { CountryName = "France" },
            new Country() { CountryName = "Germany" },
            new Country() { CountryName = "Brazil" },
            new Country() { CountryName = "Belgium" },
            new Country() { CountryName = "Switzerland" },
            new Country() { CountryName = "Venezuela" },
            new Country() { CountryName = "Austria" },
            new Country() { CountryName = "Mexico" },
            new Country() { CountryName = "USA" },
            new Country() { CountryName = "Sweden" },
            new Country() { CountryName = "Finland" },
            new Country() { CountryName = "Italy" },
            new Country() { CountryName = "Spain" },
            new Country() { CountryName = "UK" }
        };
        private static IList<City> cities = new List<City>() {
            new City() { CityName = "Reims", Country = "France" },
            new City() { CityName = "Münster", Country = "Germany" },
            new City() { CityName = "Rio de Janeiro", Country = "Brazil" },
            new City() { CityName = "Lyon", Country = "France" },
            new City() { CityName = "Charleroi", Country = "Belgium" },
            new City() { CityName = "Bern", Country = "Switzerland" },
            new City() { CityName = "Genève", Country = "Switzerland" },
            new City() { CityName = "Resende", Country = "Brazil" },
            new City() { CityName = "San Cristóbal", Country = "Venezuela" },
            new City() { CityName = "Graz", Country = "Austria" },
            new City() { CityName = "México D.F.", Country = "Mexico" },
            new City() { CityName = "Köln", Country = "Germany" },
            new City() { CityName = "Albuquerque", Country = "USA" },
            new City() { CityName = "Bräcke", Country = "Sweden" },
            new City() { CityName = "Strasbourg", Country = "France" },
            new City() { CityName = "Oulu", Country = "Finland" },
            new City() { CityName = "München", Country = "Germany" },
            new City() { CityName = "Caracas", Country = "Venezuela" },
            new City() { CityName = "Seattle", Country = "USA" },
            new City() { CityName = "Lander", Country = "USA" },
            new City() { CityName = "Cunewalde", Country = "Germany" },
            new City() { CityName = "Bergamo", Country = "Italy" },
            new City() { CityName = "Leipzig", Country = "Germany" },
            new City() { CityName = "Luleå", Country = "Sweden" },
            new City() { CityName = "Frankfurt a.M.", Country = "Germany" },
            new City() { CityName = "Madrid", Country = "Spain" },
            new City() { CityName = "Barquisimeto", Country = "Venezuela" },
            new City() { CityName = "Reggio Emilia", Country = "Italy" },
            new City() { CityName = "London", Country = "UK" },
            new City() { CityName = "Sao Paulo", Country = "Brazil" },
        };

        [HttpGet]
        public HttpResponseMessage Orders(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(orders, loadOptions));
        }

        [HttpPost]
        public HttpResponseMessage AddOrder(FormDataCollection form) {
            var values = form.Get("values");

            var newOrder = new Order();
            JsonConvert.PopulateObject(values, newOrder);

            Validate(newOrder);
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.GetFullErrorMessage());

            orders.Add(newOrder);

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        [HttpPut]
        public HttpResponseMessage UpdateOrder(FormDataCollection form) {
            var key = Convert.ToInt32(form.Get("key"));
            var values = form.Get("values");
            var order = orders.First(o => o.OrderID == key);

            JsonConvert.PopulateObject(values, order);

            Validate(order);
            if (!ModelState.IsValid)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState.GetFullErrorMessage());

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public void DeleteOrder(FormDataCollection form) {
            var key = Convert.ToInt32(form.Get("key"));
            var order = orders.First(o => o.OrderID == key);

            orders.Remove(order);
        }

        [HttpGet]
        public HttpResponseMessage Countries(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(countries, loadOptions));
        }

        [HttpGet]
        public HttpResponseMessage Cities(DataSourceLoadOptions loadOptions) {
            return Request.CreateResponse(DataSourceLoader.Load(cities, loadOptions));
        }
    }
}