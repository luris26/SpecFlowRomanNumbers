namespace SpecFlowRomanNumbers.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        public class RomanizingSteps
        {
            ClassLibraryRomanNumbers.RomanNumbers roman = new ClassLibraryRomanNumbers.RomanNumbers();

            [Given(@"input of (.*)")]
            public void GivenInputOf(int p0)
            {
                throw new PendingStepException();
            }

            [When(@"converted to Roman numerals")]
            public void WhenConvertedToRomanNumerals()
            {
                throw new PendingStepException();
            }

            [Then(@"the result should be III")]
            public void ThenTheResultShouldBeIII()
            {
                throw new PendingStepException();
            }

        }
    }
}