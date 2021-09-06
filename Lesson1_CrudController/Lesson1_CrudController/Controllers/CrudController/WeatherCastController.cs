using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson1_CrudController.Controllers.CrudController
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherCastController : ControllerBase
    {
        private readonly ValuesHolder _holder;

        public WeatherCastController(ValuesHolder holder)
        {
            _holder = holder;
        }

        /// <summary>
        /// Осуществляет сохранение пары значение-время
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="temperature"></param>
        [HttpPost]
        public IActionResult Create([FromBody] WeatherCast cast)
        {
            _holder.Values.Add(cast);
            return Ok();

        }

        /// <summary>
        /// Замена значения температуры в указанное время
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="newTemperature"></param>
        // PUT api/<WeatherCastController>/5
        [HttpPut("{dateTime}")]
        public IActionResult Update(DateTime dateTime, [FromBody] int newTemperature)
        {
            for (int i = 0; i < _holder.Values.Count; i++)
            {
                if (_holder.Values[i].DateTimeOfMeas == dateTime)
                {
                    _holder.Values[i].Temperature = newTemperature;
                }
            }
            return Ok();
        }

        // DELETE api/<WeatherCastController>/5/6
        /// <summary>
        /// Удаление значений в выбранном диапазоне
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpDelete("{from}/{to}")]
        public IActionResult Delete(DateTime from, DateTime to)
        {
            _holder.Values = _holder.Values.Where(x => x.DateTimeOfMeas < from && x.DateTimeOfMeas > to).ToList();
            return Ok();
        }

        // GET api/<WeatherCastController>/5/6
        /// <summary>
        /// Возращает значения температуры в указанный промежуток времени
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpGet("{from}/{to}")]
        public IActionResult Read(DateTime from, DateTime to)
        {
            var result = _holder.Values.Where(x => x.DateTimeOfMeas > from && x.DateTimeOfMeas < to);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult ReadAll()
        {
            return Ok(_holder.Values);
        }




    }
}
