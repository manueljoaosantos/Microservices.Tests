//using System.Text.Json;
using Core.Entities.AdventureWorks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Infrastructure.Data.AdventureWorks
{
    public class AdventureWorksContextSeed
    {
        public static async Task SeedAsync(AdventureWorksContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.SalesAgent!.Any())
                {
                    var SalesAgentsData = File.ReadAllText("../Infrastructure/Data/AdventureWorks/SeedData/salesAgents.json");

                    var salesAgents = System.Text.Json.JsonSerializer.Deserialize<List<SalesAgent>>(SalesAgentsData);

                    foreach (var item in salesAgents)
                    {
                        context.SalesAgent!.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
                
                //Explorar();

                if (!context.Customer!.Any())
                {
                    var customersData = File.ReadAllText("../Infrastructure/Data/AdventureWorks/SeedData/customers.json");

                    var customers = JsonConvert.DeserializeObject<List<Customer>>(customersData);

                    foreach (var item in customers)
                    {
                        context.Customer!.Add(item);
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<AdventureWorksContext>();
                logger.LogError(ex.Message);
            }
        }

        private void Explorar()
        {
            List<Customer> lCustomer = new List<Customer>();

            Customer customer = new Customer();
            customer.CompanyName = "Teste";
            customer.CreatedBy="mjos";
            customer.CreatedOnUtc = System.DateTimeOffset.Now;// DateTime.UtcNow;
            customer.EmailAddress = "teste@teste.pt";
            customer.Name="Manuel";
            customer.Num = "12345678901";
            customer.Phone = "5675475467";
            customer.SalesAgentId = 1;
            customer.SalesAgent = new SalesAgent{
                Name = "Sales 1",
                LoginId="1"
            };
            CustomerAddress address = new CustomerAddress();
            address.AddressType ="tipo 1";
            address.City="Porto";
            address.CountryRegion= "Norte";
            address.CreatedBy = "Manuel";
            address.CreatedOnUtc = System.DateTimeOffset.Now;
            address.Line1 = "45";
            address.Line2 = "3245";
            address.PostalCode = "4567";
            address.StateProvince = "PT";
            customer.CustomerAddresses.Add(address);
            lCustomer.Add(customer);

            string json = JsonConvert.SerializeObject(lCustomer, Formatting.Indented);
            var l = JsonConvert.DeserializeObject<List<Customer>>(json); 
        }
    }
}