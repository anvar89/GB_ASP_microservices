using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson1_CrudController.Controllers.CrudController
{
    public class ValuesHolder
    {
        private List<WeatherCast> _values;

        public List<WeatherCast> Values
        {
            get => _values;

            set
            {
                _values = value;
            }
        }

        public ValuesHolder()
        {
            _values = new List<WeatherCast>();
        }
    }
}
