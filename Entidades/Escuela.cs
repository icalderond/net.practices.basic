namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public Escuela(string _nombre, int _añoCreacion)
        => (Nombre, AñoDeCreacion) = (_nombre, _añoCreacion);

        public Escuela(
            string _nombre, 
            int _añoCreacion,
            TiposEscuela _tipo,
            string _pais="",
            string _ciudad="")
            {
                (Nombre, AñoDeCreacion,TipoEscuela,Pais,Ciudad) = (_nombre, _añoCreacion,_tipo,_pais,_ciudad);
             }

        private string nombre;
        public string Nombre
        {
            get { return "Copia: "+nombre;}
            set { nombre = value;}
        }
        
        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }

        public string Ciudad { get; set; }    

        public TiposEscuela TipoEscuela { get; set; } 

        public override string ToString(){
            return $"Nombre: {Nombre},{System.Environment.NewLine}Tipo: {TipoEscuela},{System.Environment.NewLine}Pais: {Pais}";
        }
    }   
}