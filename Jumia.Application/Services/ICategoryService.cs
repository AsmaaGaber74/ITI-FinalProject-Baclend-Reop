﻿using Jumia.Dtos.ResultView;
using Jumia.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumia.Application.Services
{
    public interface ICategoryService
    {
        Task<ResultView<CategoryDto>> Create(CategoryDto category);
        Task<ResultView<CategoryDto>> Update(CategoryDto category);
        Task<ResultView<CategoryDto>> SoftDelete(int categoryId);
        Task<ResultDataList<CategoryDto>> GetallPigintaion(int iteam, int pageNumbers);
        Task<CategoryDto> GetById(int id);
    }
}