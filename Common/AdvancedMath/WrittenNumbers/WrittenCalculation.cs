namespace Common.AdvancedMath.WrittenNumbers
{
    public class WrittenCalculation : IWrittenCalculation
    {
        private double _mainNumber;
        private CalculationType _calculationType;
        private IWrittenCalculation _writtenCalculation;
        
        public WrittenCalculation(double mainNumber, CalculationType calculationType)
        {
            _mainNumber = mainNumber;
            _calculationType = calculationType;
        }

        public double GetCalculation()
        {
            double res;
            double innerNumberValue = 0;
            
            if (_calculationType == CalculationType.JustValue)
            {
                res = this._mainNumber;
            }
            else if (_calculationType == CalculationType.Sqrt)
            {
                res = Math.Sqrt(this._mainNumber);
            }
            else
            {
                innerNumberValue = this._writtenCalculation.GetCalculation();
                if (_calculationType == CalculationType.Add)
                {
                    res = this._mainNumber + innerNumberValue;
                }
                else if (_calculationType == CalculationType.Substract)
                {
                    res = this._mainNumber - innerNumberValue;
                }
                else if (_calculationType == CalculationType.Multiply)
                {
                    res = this._mainNumber * innerNumberValue;
                }
                else if (_calculationType == CalculationType.Divide)
                {
                    res = this._mainNumber / innerNumberValue;
                }
                else if (_calculationType == CalculationType.Pow)
                {
                    res = Math.Pow(this._mainNumber, innerNumberValue);
                }
                else
                {
                    throw new Exception();
                }
            }

            return res;
        }

        public void SetCalculation(IWrittenCalculation writtenCalculation)
        {
            if (this._writtenCalculation != null)
            {
                throw new Exception("Reference already set to an instance");
            }

            if (this._calculationType == CalculationType.Sqrt)
            {
                throw new Exception("You cannot do this. Please wrap the sqrt with another calc");
            }

            this._writtenCalculation = writtenCalculation;
        }
    }
}