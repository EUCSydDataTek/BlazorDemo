using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestCalculatorDemo.Components;

namespace BunitTestDemo
{
    public class CalculatorComponentTestClass
    {
        [Fact]
        public void TestIfCalculationIsCorrect()
        {
            //Arrange
            TestContext context = new TestContext();

            //Act
            var cut = context.RenderComponent<CalculatorComponent>(parameters => {
                parameters.Add(c => c.ParameterA, 2);
                parameters.Add(c => c.ParameterB, 4);
            });

            //Assert
            cut.MarkupMatches("""<div class="alert alert-primary" style="width:100px">2 + 4 = 6</div>""");
        }

    }
}
