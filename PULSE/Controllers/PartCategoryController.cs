﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.Services.Data;
using PULSE.Services.Interfaces;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PartCategoryController : BaseCRUDController<Model.ProductCategory, NameGenericSearchObject, ProductCategoryUpsertRequest, ProductCategoryUpsertRequest>
    {
        public PartCategoryController(IProductCategoryService<Model.ProductCategory, PartCategory> service)
            : base(service)
        {
        }

        [Authorize(Roles = "Administrator,Storekeeper,Mechanic")]
        public override ActionResult<Model.ProductCategory> Insert([FromBody] ProductCategoryUpsertRequest insert)
        {
            return base.Insert(insert);
        }

        [Authorize(Roles = "Administrator,Storekeeper,Mechanic")]
        public override ActionResult<Model.ProductCategory> Update(int id, [FromBody] ProductCategoryUpsertRequest update)
        {
            return base.Update(id, update);
        }

    }
}
