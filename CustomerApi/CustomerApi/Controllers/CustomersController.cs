using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
// Lisää nämä kaksi:
using CustomerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Controllers
{
    // Oletusreitti: api/Customers
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerContext _dbContext;


        public CustomersController(CustomerContext dbContext)
        {

            _dbContext = dbContext;

        }

        // GET: api/Customers --> Haetaan kaikki taulun tiedot.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()

        {

            if (_dbContext.Customers == null)

            {

                return NotFound("Tietoja ei löytynyt. Tietokantataulu on tyhjä.");

            }
            // Muista lisätä ylös using Microsoft.EntityFrameworkCore;
            return await _dbContext.Customers.ToListAsync();

        }
        [HttpGet("{id}")]
        // GET: api/Customers/5 --> Yhden rivin tietojen haku id-arvon perusteella.
        public async Task<ActionResult<Customer>> GetCustomer(int id)

        {

            if (_dbContext.Customers == null)

            {

                return NotFound("Tietoja ei löytynyt. Tietokantataulu on tyhjä.");

            }

            var customer = await _dbContext.Customers.FindAsync(id);



            if (customer == null)

            {

                return NotFound("Asiakasta ei löytynyt. Antamasi id " + id + " ei tuottanut hakutuloksia.");

            }

            return customer;

        }

        // POST: api/Customers --> Uuden rivin lisäys.
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)

        {

            _dbContext.Customers.Add(customer);

            await _dbContext.SaveChangesAsync();



            return CreatedAtAction(nameof(GetCustomers), new { id = customer.Id }, customer);



        }

        // PUT: api/Customers/5 --> Rivin päivitys.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)

        {

            if (id != customer.Id)
            {

                return BadRequest("Tarkista antamasi id ja Request Body id! Id arvot eivät täsmää.");

            }

            _dbContext.Entry(customer).State = EntityState.Modified;

            try

            {

                await _dbContext.SaveChangesAsync();

            }

            catch (DbUpdateConcurrencyException)
            {


                if (!CustomerExists(id))

                {

                    return NotFound("Tarkista id. Annoit id arvon " + id + ". Tietoa ei löydy annetun id:n perusteella.");

                }
                else

                {

                    throw;

                }

            }


            return Ok("Päivitys suoritettu onnistuneesti. Rivi, jonka id on " + id + " päivitys suoritettu.");

        }

        private bool CustomerExists(long id)

        {

            return (_dbContext.Customers?.Any(e => e.Id == id)).GetValueOrDefault();

        }

        // DELETE: api/Customers/5 --> Poistetaan rivi annetun id-arvon perusteella.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)

        {

            if (_dbContext.Customers == null)

            {

                return NotFound("Tietoja ei löytynyt. Tietokantataulu on tyhjä.");

            }


            var customer = await _dbContext.Customers.FindAsync(id);


            if (customer == null)

            {

                return NotFound("Asiakasta ei löytynyt antamasi id:n " + id + "perusteella.");

            }


            _dbContext.Customers.Remove(customer);

            await _dbContext.SaveChangesAsync();


            return Ok("Poisto suoritettu onnistuneesti. Rivi, jonka id on " + id + ", on nyt poistettu tietokantataulusta.");

        }

    }

}