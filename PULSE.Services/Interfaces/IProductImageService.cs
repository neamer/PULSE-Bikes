﻿using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;

namespace PULSE.Services.Interfaces
{
    public interface IProductImageService 
        : ICRUDService<ProductImage, ProductImageSearchObject, ProductImageUpsertRequest, ProductImageUpsertRequest>
    {}
}
