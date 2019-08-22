using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Features.Indexed;
using GeometricShapes.Domain.Shapes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeometricShapes.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShapesController : ControllerBase
    {
        public readonly IIndex<EnumShapes, IShape> shape;

        public ShapesController(IIndex<EnumShapes, IShape> shape)
        {
            this.shape = shape;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var square = shape[EnumShapes.Square].GetArea();
            var rectangle = shape[EnumShapes.Rectangle].GetArea();

            return new JsonResult(new { AreaQuadrado = square, AreaRetangulo = rectangle });
        }
    }
}