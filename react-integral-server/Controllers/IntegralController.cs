
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReactBackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IntegralController : ControllerBase
    {

        [HttpGet("getQuestions")]
        public ActionResult<List<string>> GetQuestions()
        {
            List<string> questions = new List<string>()
            {
                "1. В чем ограничение метода Симпсона?",
                "2. Неопределенный интеграл от функции - это...",
                "3. Чему равен неопределенный интеграл от 1?",
                "4. Какого метода прямоугольных треугольников не бывает?",
                "5. Какой порядок точности у метода трапеций?",
            };

            return questions;

        }

        [HttpGet("getAnswers")]
        public ActionResult<List<string[]>> GetAnswers()
        {
            List<string[]> answers = new List<string[]>
            {
                new string[]{ "Невозможность задания границ дробными чилами", "Четное число разбиений", "Невозможность изменять границы", "Погрешность более 0.01" },
                new string[]{ "площадь криволинейной трапеции, ограниченной графиком функции, осью абсцисс и еще двумя прямыми", "одна первообразная функции", "совокупность всех производных функции", "промежуток, на котором необходимо проинтегрировать функцию" },
                new string[]{ "x+C", "0", "1+С", "С" },
                new string[]{ "Средних","Правых","Левых","Верхних" },
                new string[]{ "1", "2","3","4" },
            };

            return answers;
        }

        [HttpPost("checkAnswers")]
        public ActionResult<double> CheckAnswers([FromBody] List<int> data)
        {
            List<int> expected = new List<int>() { 2, 3, 3, 4, 1};
            double mark = 0.0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == expected[i]) mark += 5/data.Count;
            }

            return mark;
        }

      
    }
}
