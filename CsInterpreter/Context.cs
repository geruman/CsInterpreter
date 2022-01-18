namespace CsInterpreter
{
    public class Context
    {
        private string nextOperation = "+";
        private int number = 0;
        private int result = 0;

        public Context()
        {
          
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
        public int GetInteger(string input)
        {
            var switchExpr = input.ToLower();
            switch (switchExpr)
            {
                case "cero":
                    {
                        return 0;
                    }

                case "uno":
                    {
                        return 1;
                    }

                case "dos":
                    {
                        return 2;
                    }

                case "tres":
                    {
                        return 3;
                    }

                case "cuatro":
                    {
                        return 4;
                    }

                case "cinco":
                    {
                        return 5;
                    }

                case "seis":
                    {
                        return 6;
                    }

                case "siete":
                    {
                        return 7;
                    }

                case "ocho":
                    {
                        return 8;
                    }

                case "nueve":
                    {
                        return 9;
                    }

                default:
                    {
                        return -1;
                    }
            }
        }

        public bool IsOperation(string text)
        {
            if (text.ToLower().Equals("mas")||text.ToLower().Equals("menos"))
            {
                return true;
            }
            return false;
        }
        public int GetResult()
        {
            return result;
        }
        public void SetOperation(string token)
        {
            if (token.ToLower().Equals("mas"))
            {
                nextOperation = "+";
            }else if (token.ToLower().Equals("menos"))
            {
                nextOperation = "-";
            }
        }
        public void Calculate()
        {
            if (nextOperation.Equals("+"))
            {
                result += number;
            }else if (nextOperation.Equals("-"))
            {
                result -= number;
            }
        }
    }
}