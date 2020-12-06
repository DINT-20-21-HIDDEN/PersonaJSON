using System.ComponentModel;

namespace PersonaJSON
{
    public class Persona : INotifyPropertyChanged
    {
        //Propiedades
        //En caso de que se cambie el valor, se debe llamar al método que lanza el evento PropertyChanged
        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (this._nombre != value)
                {
                    this._nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }

        private int _edad;
        public int Edad
        {
            get { return this._edad; }
            set
            {
                if (this._edad != value)
                {
                    this._edad = value;
                    this.NotifyPropertyChanged("Edad");
                }
            }
        }

        //Constructores
        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        //Implementación de la interfaz INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
