# MarioExamenParcial
EXAMEN Parcial

Pregunta 1:
Indicar la complejidad de ambos algoritmos en notación Big O.
Es una manera representativa de la complejida del algoritmo empleado, para este caso es un algoritmo de tipo Lineal
Pregunta 2:
Azure DevOps: Son repositorios en la nube , que nos ayuda mucho en el despliegue de aplicaciones en la nube.
Jira: Es un sofware empleado para gestion de Proyectos   u otros , donde podemos medir el SLA de un requerimientos, su vance, los pendientes , u otros.
NodeJS:Es un Framework de desarrollo web , utilizado para desarrollo aplicaciones web, incorpora su propio servidor.
Pregunta 3 :
Proponer casos de código sucio (dirty code) y código limpio (clean code) de lo siguiente:

Assign Booleans Implicitly.
Ejemplo:

//dirty code
            if (!true)
            {

                var b= "False";

            }
//clean code

            if (false)
            {

                var b = "False";

            }


Fail Fast.

//dirty code

 public  class Alumno
        {
            public string Nombre { get; set; }
            public string Apelllido { get; set; }
            public string DNI { get; set; }
            public string CODIGO { get; set; }
           
            public static List<Alumno> Buscar  (Alumno alumno)
            {

                List < Alumno > personas = Repository.Busqued(alumno.CODIGO); 

                return personas;
            }




        }

//clean code
     public  class Alumno
        {
            public string Nombre { get; set; }
            public string Apelllido { get; set; }
            public string DNI { get; set; }
            public string CODIGO { get; set; }
           
            public static List<Alumno> BuscarAlumno (Alumno alumno)
            {

                List < Alumno > Alumnos = Repository.Busqued(alumno.CODIGO); 

                return Alumnos;
            }




        }

Return Early.

Pregunta 4 :
Definir cada uno de los principios SOLID:

Single Responsibility Principle:Cada proceso tiene un sola respoenabilidad y es independiente.
Open Closed Principle: Tiene que tener el codigo necesario y justo, para que no necesite nigun modificacion en el futuro
Liskov Substitution Principle:Ningun cambio realizado afectara a otro modulos del cual tiene una relacion.
Interface Segregation Principle:Pueden agregarse clase de nivel segundario , y no causaran impacto a la interface, que es utilizada por todas las clases.
Dependency Inversion Principle:QUE LAS CLASES DE NIVEL PRINCIPAL, NO DEPENDAN DE OTRAS CLASES DE NIVEL SEGUNDARIO.


Pregunta 6. 
Explicar las características de una arquitectura limpia:

La clase de principal debe relacionarse en la determinacion de los nombres de sus metodos.
No debe de tener comentarios innecesarios , en el codigo.
Los metodos de negocio no deben redundar en codificacion.
Mantener un orden en la estrucutura de las capas(PATRON DE DISEÑO), Capa de negocio almacenar la Logica, Capa de Datos , Capa Entidades  que almacenar las clases consus respectivos contructores , encargada de sustraer la informacion de BD, y la Capa de presentacion  es el UI O la cara de la aplicacion.
, tener un patron de diseño.






