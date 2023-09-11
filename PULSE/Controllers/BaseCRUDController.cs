using Microsoft.AspNetCore.Mvc;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch> where T : class where TSearch
            : class where TInsert : class where TUpdate : class
    {
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
        }

        [HttpPost]
        public virtual ActionResult<T> Insert([FromBody] TInsert insert)
        {
            try
            {
                return Ok(((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Insert(insert));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public virtual ActionResult<T> Update(int id, [FromBody] TUpdate update)
        {
            try
            {
                return Ok(((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Update(id, update));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public virtual ActionResult<T> Delete(int id)
        {
            try
            {
                return Ok(((ICRUDService<T, TSearch, TInsert, TUpdate>)this.Service).Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
