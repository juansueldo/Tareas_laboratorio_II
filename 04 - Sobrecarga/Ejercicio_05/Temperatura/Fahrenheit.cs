namespace Temperatura
{
    public class Fahrenheit
    {
        #region ATRIBUTOS
        private double fahrenheit;
        #endregion

        #region CONSTRUCTORES
        public Fahrenheit(double fahrenheit)
        {
            this.fahrenheit = fahrenheit;
        }
        #endregion

        #region PROPIEDADES
        public double GetFahrenheit
        {
            get { return this.fahrenheit; }
        }
        #endregion

        #region CONVERSIONES
        public static implicit operator Fahrenheit(double numero)
        {
            return new Fahrenheit(numero);
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            return new Celsius((f.GetFahrenheit -32)*5/9);
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.GetFahrenheit + 459.67) * 5 / 9);
        }
        #endregion

        #region OPERACIONES
        public static Fahrenheit operator +(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetFahrenheit + ((Fahrenheit)c).GetFahrenheit);
        }
        public static Fahrenheit operator -(Fahrenheit f, Celsius c)
        {
            return new Fahrenheit(f.GetFahrenheit - ((Fahrenheit)c).GetFahrenheit);
        }
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetFahrenheit + ((Fahrenheit)k).GetFahrenheit);
        }
        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            return new Fahrenheit(f.GetFahrenheit - ((Fahrenheit)k).GetFahrenheit);
        }
        #endregion

        #region COMPRARACIONES
        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            bool retorno = false;
            if(f.GetFahrenheit == ((Fahrenheit)c).GetFahrenheit)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == c);
        }
        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            bool retorno = false;
            if (f.GetFahrenheit == ((Fahrenheit)k).GetFahrenheit)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            return !(f == k);
        }
        #endregion
    }
}