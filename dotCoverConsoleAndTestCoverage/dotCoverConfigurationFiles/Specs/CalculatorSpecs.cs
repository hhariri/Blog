using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib;
using Machine.Specifications;

namespace Specs
{

    [Subject("Calculator")]
    public class when_calling_add_with_two_numbers
    {
        Establish context = () =>
        {
            calculator = new Calculator();
        };

        Because of = () =>
        {
            result = calculator.Add(2, 3);
        };

        It should_return_the_sum_of_the_two_numbers = () =>
        {
            result.ShouldEqual(5);
        };

        static Calculator calculator;
        static int result;
    }
    

}
