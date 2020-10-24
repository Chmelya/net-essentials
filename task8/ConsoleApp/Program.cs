using System;
using DelegatesLibarary;
using FiguresLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangleValidator = new ValidatorBuilder<Triangle>()
                .AddRule(t => t.Name == "Triangle", t => $"Name {t.Name} is not correct")
                .AddRule(t => t.GetArea() > 20, t => $"Area value {t.GetArea()} is not correct. Should be more than 30")
                .Build();

            var validationResult = triangleValidator.Validate(new Triangle(3, 6));
            if (!validationResult.IsValid)
            {
                Console.WriteLine(string.Join(Environment.NewLine, validationResult.ErrorMessages));
            }
        }

    }
}
