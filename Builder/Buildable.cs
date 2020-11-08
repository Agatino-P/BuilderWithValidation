namespace Builder
{
    public class Buildable
    {
        public string Testo { get; private set; }
        private Buildable()
        {

        }

        public class Builder
        {
            private Buildable _buildable = new Buildable();
            private bool isValid { get; set; } = false;

            public Builder()
            {
                reset();
            }
            private void reset()
            {
                _buildable = new Buildable();
                isValid = false;
            }

            public Builder FromInt(int i)
            {
                if (i < 1 || i > 2)
                {
                    isValid = false;
                }
                else
                {
                    switch (i)
                    {
                        case 1:
                            _buildable.Testo = "Uno";
                            isValid = true;
                            break;
                        case 2:
                            _buildable.Testo = "Due";
                            isValid = true;
                            break;
                    }
                }

                return this;
            }

            public Buildable Build()
            {
                isValid = isValid && !string.IsNullOrWhiteSpace(_buildable.Testo);
                return isValid ? _buildable : null;
            }
        }
    }
}
