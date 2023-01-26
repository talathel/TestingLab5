using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();

        private double _result;

        private Exception _exception;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(double number)
        {
            _calculator.ArgumentString = number.ToString();
            //_calculator.Calculate();

        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _calculator.CurrentOperation = Operation.Plus;
            _calculator.Calculate();
            //_result = _calculator.Result;;
        }
        [When("the two numbers are multiplied")]

        public void WhenTheTwoNumbersAreMultiplied() 
        {
            _calculator.CurrentOperation = Operation.Multiply;
            _calculator.Calculate();
        }

        [When("the number is reduced")]
        public void WhenTheNumberIsReduced() 
        {
            _calculator.CurrentOperation = Operation.Minus;
            _calculator.Calculate();
        }

        [When("the number is divided")]
        public void WhenTheNumberIsDivided()
        {
            _calculator.CurrentOperation = Operation.Divide;
            _calculator.Calculate();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(double number)
        {
            _calculator.ArgumentString = number.ToString();
            _calculator.Calculate();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(double result)
        {
            _result = _calculator.Result;
            _result.Should().Be(result);
        }

        [Given("the number is (.*)")]

        public void GivenTheNumberIs(double number)
        {
            try
            {
                _calculator.ArgumentString = number.ToString();
                _calculator.Calculate();
            }
            catch (Exception ex) 
            {
                _exception = ex;
            }

            
        }

        [Then(@"catch OU exception")]

        public void ThenCatchOUException()
        {
            Assert.NotNull(_exception);
            Assert.Equal(_exception.Message, "Operation Uncpecified"); 
        }

        [Given("the string is (.*)")]

        public void GivenTheStringIs(string str)
        {
            _calculator.ArgumentString = str;
        }


        [When("try to add")]

        public void WhenTryToAdd()
        {
            _calculator.CurrentOperation = Operation.Plus;
            try
            {
                _calculator.Calculate();
            }
            catch (Exception ex)
            {
                _exception = ex;
            }
        }


        [Then(@"catch SystemFormatException")]

        public void ThenCatchSystemFormatException()
        {
            Assert.NotNull(_exception);
            Assert.Equal(_exception.Message, "Input string was not in a correct format.");
        }

        [Then(@"it should be infinity")]

        public void ThenItShouldBeInfinity()
        {
            _result = _calculator.Result;
            _result.Should().Be(Double.PositiveInfinity);
        }
    }
}