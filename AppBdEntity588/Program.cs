using System;
using System.Linq;
using AppBdEntity588.Modelo;


namespace AppBdEntity588
{
    class Program
    {
        static Validaciones Vericar = new Validaciones();
        static GestorDatos datos = new GestorDatos();
        static void Main(string[] args)
        {
            int Menu = 0;
            string temporal;
            do
            {
                bool EntradaValida = false;
                Console.Clear();
                Gui.Marco(1, 100, 1, 7);
                Gui.Marco(1, 100, 9, 27);
                Gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
                Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
                Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
                Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
                Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
                Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
                Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
                Console.SetCursorPosition(42, 12); Console.Write("BIENVENIDOS");
                Console.SetCursorPosition(2, 18); Console.Write("  /██████  /████████ /██   /██  /██████ ");
                Console.SetCursorPosition(2, 19); Console.Write(" /██__  ██| ██_____/| ███ | ██ /██__  ██");
                Console.SetCursorPosition(2, 20); Console.Write("| ██  |__/| ██      | ████| ██| ██  | ██");
                Console.SetCursorPosition(2, 21); Console.Write("|  ██████ | █████   | ██ ██ ██| ████████");
                Console.SetCursorPosition(2, 22); Console.Write(" |____  ██| ██__/   | ██  ████| ██__  ██");
                Console.SetCursorPosition(2, 23); Console.Write(" /██  | ██| ██      | ██|  ███| ██  | ██");
                Console.SetCursorPosition(2, 24); Console.Write("|  ██████/| ████████| ██ |  ██| ██  | ██");
                Console.SetCursorPosition(2, 25); Console.Write(" |______/ |________/|__/  |__/|__/  |__/");
                Console.SetCursorPosition(60, 21); Console.Write("Johanna Milena Garcia");
                Console.SetCursorPosition(57, 23); Console.Write("Lenguaje de programación .NET");
                Console.SetCursorPosition(50, 25); Console.Write("Analisis y Desarrollo de Sitemas de Informacion");

                do
                {
                    Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");
                    Console.SetCursorPosition(75, 3); temporal = Console.ReadLine();
                    if (!Vericar.Vacio(temporal))
                        if (Vericar.TipoNumero(temporal))
                            EntradaValida = true;
                } while (!EntradaValida);

                Menu = int.Parse(temporal);

                switch (Menu)
                {
                    case 1:
                        crearRegistro();
                        break;
                    case 2:
                        ListarRegistro();
                        break;
                    case 3:
                        BuscarRegistro();
                        break;
                    case 4:
                        EditarRegistro();
                        break;
                    case 5:
                        EliminarRegistro();
                        break;
                    case 0:
                        {
                            Console.Clear();
                            Gui.Marco(1, 100, 1, 7);
                            Gui.Marco(1, 100, 9, 27);
                            Gui.BorrarLinea(40, 22, 80);
                            Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
                            Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
                            Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
                            Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
                            Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
                            Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
                            Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
                            Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");
                            Console.SetCursorPosition(35, 18); Console.Write("Gracias por usar nuestro programa");
                            Gui.BorrarLinea(37, 26, 80);
                            Console.SetCursorPosition(2, 26); Console.Write("Presione cualquier tecla para salir");
                        }

                        break;
                    default:
                        {
                            Gui.BorrarLinea(40, 22, 80);
                            Console.SetCursorPosition(40, 22); Console.Write("Opcion Invalida");
                        }

                        break;
                }
                Gui.BorrarLinea(38, 26, 80);
                Console.SetCursorPosition(38, 26); Console.Write("Presione cualquier tecla para continuar");
                Console.ReadKey();
            } while (Menu > 0);
        }   
        static void crearRegistro()
        {
            bool EntradaValidaNom = false;
            bool EntradaValidaCod = false;
            bool EntradaValidaCor = false;
            bool EntradaValidaNot1 = false;
            bool EntradaValidaNot2 = false;
            bool EntradaValidaNot3 = false;

            double not1, not2, not3, NotF;
            string nom, cor = "";
            int cod = 0;
            string codTxt, not1Txt, not2Txt, not3Txt;
            Console.Clear();
            Gui.Marco(1, 100, 1, 7);
            Gui.Marco(1, 100, 9, 27);
            Gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
            Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
            Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
            Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
            Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
            Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
            Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
            Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");
            Console.SetCursorPosition(34, 11); Console.Write("AGREGAR ESTUDIANTE");
            // ------------------------------cargo los datos por pantalla
            do
            {
                Gui.BorrarLinea(56, 14, 86);
                Console.SetCursorPosition(34, 14); Console.Write("Digite el Codigo     :");
                codTxt = Console.ReadLine();
                if (!Vericar.Vacio(codTxt))
                    if (Vericar.TipoNumero(codTxt))
                        EntradaValidaCod = true;
            } while (!EntradaValidaCod);

            cod = int.Parse(codTxt);


            // -----------------------------verificar si el registro existe
            var db = new tallersena588Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe == null)
            {
                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Gui.BorrarLinea(56, 15, 86);
                    Console.SetCursorPosition(34, 15); Console.Write("Digite el Nombre     :");
                    nom = Console.ReadLine();
                    if (!Vericar.Vacio(nom))
                        if (Vericar.TipoTexto(nom))
                            EntradaValidaNom = true;
                } while (!EntradaValidaNom);

                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Gui.BorrarLinea(56, 16, 86);
                    Console.SetCursorPosition(34, 16); Console.Write("Digite el Correo     :");
                    cor = Console.ReadLine();
                    if (!Vericar.Vacio(cor))
                        if (Vericar.TipoEmail(cor))
                            EntradaValidaCor = true;
                } while (!EntradaValidaCor);

                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Gui.BorrarLinea(56, 17, 86);
                    Console.SetCursorPosition(34, 17); Console.Write("Digite Nota 1        :");
                    not1Txt = Console.ReadLine();
                    if (!Vericar.Vacio(not1Txt))
                        if (Vericar.TipoNumero(not1Txt))
                            EntradaValidaNot1 = true;
                } while (!EntradaValidaNot1);
                not1 = double.Parse(not1Txt);

                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Gui.BorrarLinea(56, 18, 86);
                    Console.SetCursorPosition(34, 18); Console.Write("Digite Nota 2        :");
                    not2Txt = Console.ReadLine();
                    if (!Vericar.Vacio(not2Txt))
                        if (Vericar.TipoNumero(not2Txt))
                            EntradaValidaNot2 = true;
                } while (!EntradaValidaNot2);
                not2 = double.Parse(not2Txt);
                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Gui.BorrarLinea(56, 19, 86);
                    Console.SetCursorPosition(34, 19); Console.Write("Digite Nota 3        :");
                    not3Txt = Console.ReadLine();
                    if (!Vericar.Vacio(not3Txt))
                        if (Vericar.TipoNumero(not3Txt))
                            EntradaValidaNot3 = true;
                } while (!EntradaValidaNot3);
                not3 = double.Parse(not3Txt);

                Estudiantes estudiante = new Estudiantes();
                estudiante.Codigo = cod;
                estudiante.Nombre = nom;
                estudiante.Correo = cor;
                estudiante.Nota1 = not1;
                estudiante.Nota2 = not2;
                estudiante.Nota3 = not3;

                db.Estudiantes.Add(estudiante);
                db.SaveChanges();
                Console.SetCursorPosition(38, 26); Console.Write("El registro fue agregado con exito");

            }
            else
            {
                Gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(34, 21); Console.Write("El usuario con el codigo " + cod + " Ya Existe en el sistema");
            }
        }

        static void ListarRegistro()
        {
            Console.Clear();
            Gui.Marco(1, 100, 1, 7);
            Gui.Marco(1, 100, 9, 27);
            Gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
            Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
            Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
            Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
            Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
            Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
            Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
            Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");
            Console.SetCursorPosition(34, 11); Console.Write("LISTA DE ESTUDIANTES");
            int altura = 14;

            Console.SetCursorPosition(2, 13); Console.Write("Codigo");
            Console.SetCursorPosition(12, 13); Console.Write("Nombre");
            Console.SetCursorPosition(30, 13); Console.Write("Correo");
            Console.SetCursorPosition(53, 13); Console.Write("Nota 1");
            Console.SetCursorPosition(63, 13); Console.Write("Nota 2");
            Console.SetCursorPosition(72, 13); Console.Write("Nota 3");
            Console.SetCursorPosition(80, 13); Console.Write("N.Final");
            Console.SetCursorPosition(90, 13); Console.Write("Concepto");
            var db = new tallersena588Context();
            var estudiantes = db.Estudiantes.ToList();
            foreach (var myEstudiante in estudiantes)
            {
                double NF = (myEstudiante.Nota1 + myEstudiante.Nota2 + myEstudiante.Nota3) / 3;
                Console.SetCursorPosition(2, altura); Console.Write(myEstudiante.Codigo);
                Console.SetCursorPosition(12, altura); Console.Write(myEstudiante.Nombre);
                Console.SetCursorPosition(30, altura); Console.Write(myEstudiante.Correo);
                Console.SetCursorPosition(53, altura); Console.Write(myEstudiante.Nota1);
                Console.SetCursorPosition(63, altura); Console.Write(myEstudiante.Nota2);
                Console.SetCursorPosition(72, altura); Console.Write(myEstudiante.Nota3);
                Console.SetCursorPosition(80, altura); Console.Write(string.Format("{0:0}", NF));
                Console.SetCursorPosition(90, altura); Console.Write(myEstudiante.Concepto(NF));
                altura++;
            }
            Gui.BorrarLinea(38, 26, 80);
            Console.SetCursorPosition(38, 26); Console.Write("Presione cualquier tecla para continuar");
            Console.SetCursorPosition(77, 26);
            Console.ReadKey();
        }
        static void BuscarRegistro()
        {
            bool EntradaValidaCod = false;
            int cod = 0;
            string codTxt;
            Console.Clear();
            Gui.Marco(1, 100, 1, 7);
            Gui.Marco(1, 100, 9, 27);
            Gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
            Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
            Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
            Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
            Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
            Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
            Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
            Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");

            do
            {
                Gui.BorrarLinea(35, 11, 86);
                Console.SetCursorPosition(2, 11); Console.Write("Codigo del estudiante a Buscar [     ]");
                Console.SetCursorPosition(35, 11); codTxt = Console.ReadLine();
                if (!Vericar.Vacio(codTxt))
                    if (Vericar.TipoNumero(codTxt))
                        EntradaValidaCod = true;
            } while (!EntradaValidaCod);

            cod = int.Parse(codTxt);

            Console.SetCursorPosition(2, 13); Console.Write("Digite el Codigo     :");
            Console.SetCursorPosition(2, 14); Console.Write("Digite el Nombre     :");
            Console.SetCursorPosition(2, 15); Console.Write("Digite el Correo     :");
            Console.SetCursorPosition(2, 16); Console.Write("Digite el Nota 1     :");
            Console.SetCursorPosition(2, 17); Console.Write("Digite el Nota 2     :");
            Console.SetCursorPosition(2, 18); Console.Write("Digite el Nota 3     :");

            var db = new tallersena588Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe != null)
            {
                Gui.BorrarLinea(40, 22, 80);
                var myEstudiante = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod);
                Console.SetCursorPosition(25, 13); Console.Write(myEstudiante.Codigo);
                Console.SetCursorPosition(25, 14); Console.Write(myEstudiante.Nombre);
                Console.SetCursorPosition(25, 15); Console.Write(myEstudiante.Correo);
                Console.SetCursorPosition(25, 16); Console.Write(myEstudiante.Nota1);
                Console.SetCursorPosition(25, 17); Console.Write(myEstudiante.Nota2);
                Console.SetCursorPosition(25, 18); Console.Write(myEstudiante.Nota3);
            }
            else
            {
                Gui.BorrarLinea(30, 26, 80);
                Console.SetCursorPosition(38, 24); Console.Write("No existe registro");
            }     
        }
        static void EditarRegistro()
        {
            bool EntradaValidaNom = false;
            bool EntradaValidaCod = false;
            bool EntradaValidaCor = false;
            bool EntradaValidaNot1 = false;
            bool EntradaValidaNot2 = false;
            bool EntradaValidaNot3 = false;
            int cod = 0;
            string codTxt, not1Txt, not2Txt, not3Txt;
            double not1, not2, not3 = 0;
            string nom, cor = "";
            Console.Clear();
            Gui.Marco(1, 100, 1, 7);
            Gui.Marco(1, 100, 9, 27);
            Gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
            Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
            Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
            Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
            Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
            Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
            Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
            Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");

            do
            {
                Gui.BorrarLinea(35, 11, 86);
                Console.SetCursorPosition(2, 11); Console.Write("Codigo del estudiante a Editar [     ]");
                Console.SetCursorPosition(35, 11); codTxt = Console.ReadLine();
                if (!Vericar.Vacio(codTxt))
                    if (Vericar.TipoNumero(codTxt))
                        EntradaValidaCod = true;
            } while (!EntradaValidaCod);
            cod = int.Parse(codTxt);

            Console.SetCursorPosition(2, 14); Console.Write("Digite el Codigo     :");
            Console.SetCursorPosition(2, 15); Console.Write("Digite el Nombre     :");
            Console.SetCursorPosition(2, 16); Console.Write("Digite el Correo     :");
            Console.SetCursorPosition(2, 17); Console.Write("Digite el Nota 1     :");
            Console.SetCursorPosition(2, 18); Console.Write("Digite el Nota 2     :");
            Console.SetCursorPosition(2, 19); Console.Write("Digite el Nota 3     :");
            Console.SetCursorPosition(50, 14); Console.Write("Nuevos Datos");
            var db = new tallersena588Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe != null)
            {
                Gui.BorrarLinea(40, 22, 80);
                var myEstudiante = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod);
                Console.SetCursorPosition(25, 14); Console.Write(myEstudiante.Codigo);
                Console.SetCursorPosition(25, 15); Console.Write(myEstudiante.Nombre);
                Console.SetCursorPosition(25, 16); Console.Write(myEstudiante.Correo);
                Console.SetCursorPosition(25, 17); Console.Write(myEstudiante.Nota1);
                Console.SetCursorPosition(25, 18); Console.Write(myEstudiante.Nota2);
                Console.SetCursorPosition(25, 19); Console.Write(myEstudiante.Nota3);

                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Console.SetCursorPosition(50, 15); Console.Write(":");
                    nom = Console.ReadLine();
                    if (!Vericar.Vacio(nom))
                        if (Vericar.TipoTexto(nom))
                            EntradaValidaNom = true;
                } while (!EntradaValidaNom);

                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Console.SetCursorPosition(50, 16); Console.Write(":");
                    cor = Console.ReadLine();
                    if (!Vericar.Vacio(cor))
                        if (Vericar.TipoEmail(cor))
                            EntradaValidaCor = true;
                } while (!EntradaValidaCor);
                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Console.SetCursorPosition(50, 17); Console.Write(":");
                    not1Txt = Console.ReadLine();
                    if (!Vericar.Vacio(not1Txt))
                        if (Vericar.TipoNumero(not1Txt))
                            EntradaValidaNot1 = true;
                } while (!EntradaValidaNot1);
                not1 = double.Parse(not1Txt);

                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Console.SetCursorPosition(50, 18); Console.Write(":");
                    not2Txt = Console.ReadLine();
                    if (!Vericar.Vacio(not2Txt))
                        if (Vericar.TipoNumero(not2Txt))
                            EntradaValidaNot2 = true;
                } while (!EntradaValidaNot2);
                not2 = double.Parse(not2Txt);
                do
                {
                    Gui.BorrarLinea(40, 22, 80);
                    Console.SetCursorPosition(50, 19); Console.Write(":");
                    not3Txt = Console.ReadLine();
                    if (!Vericar.Vacio(not3Txt))
                        if (Vericar.TipoNumero(not3Txt))
                            EntradaValidaNot3 = true;
                } while (!EntradaValidaNot3);
                not3 = double.Parse(not3Txt);

                myEstudiante.Nombre = nom;
                myEstudiante.Correo = cor;
                myEstudiante.Nota1 = not1;
                myEstudiante.Nota2 = not2;
                myEstudiante.Nota3 = not3;
                db.SaveChanges();
                Gui.BorrarLinea(14, 23, 80);
                Console.SetCursorPosition(14, 23); Console.Write("El registro fue editado con exito");
            }
            else
            {
                Gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(38, 24); Console.Write("No existe registro");
            }
        }
        static void EliminarRegistro()
        {
            bool EntradaValidaCod = false;
            int cod = 0;
            string codTxt;
            Console.Clear();
            Gui.Marco(1, 100, 1, 7);
            Gui.Marco(1, 100, 9, 27);
            Gui.BorrarLinea(40, 22, 80);
            Console.SetCursorPosition(6, 3); Console.Write("APP ESTUDIANTE");
            Console.SetCursorPosition(2, 5); Console.Write("1. Agregar");
            Console.SetCursorPosition(18, 5); Console.Write("2. Listar");
            Console.SetCursorPosition(34, 5); Console.Write("3. Buscar");
            Console.SetCursorPosition(50, 5); Console.Write("4. Editar");
            Console.SetCursorPosition(66, 5); Console.Write("5. Borrar");
            Console.SetCursorPosition(84, 5); Console.Write("0. Salir");
            Console.SetCursorPosition(56, 3); Console.Write("Elija una opcion [   ]");

            do
            {
                Console.SetCursorPosition(2, 11); Console.Write("Codigo del estudiante a Borrar [     ]");
                Console.SetCursorPosition(35, 11); codTxt = Console.ReadLine();
                if (!Vericar.Vacio(codTxt))
                    if (Vericar.TipoNumero(codTxt))
                        EntradaValidaCod = true;
            } while (!EntradaValidaCod);

            cod = int.Parse(codTxt);

            Console.SetCursorPosition(2, 13); Console.Write("Digite el Codigo     :");
            Console.SetCursorPosition(2, 14); Console.Write("Digite el Nombre     :");
            Console.SetCursorPosition(2, 15); Console.Write("Digite el Correo     :");
            Console.SetCursorPosition(2, 16); Console.Write("Digite el Nota 1     :");
            Console.SetCursorPosition(2, 17); Console.Write("Digite el Nota 2     :");
            Console.SetCursorPosition(2, 18); Console.Write("Digite el Nota 3     :");

            var db = new tallersena588Context();
            var existe = db.Estudiantes.Find(cod);

            if (existe != null)
            {
                Gui.BorrarLinea(40, 22, 80);
                var myEstudiante = db.Estudiantes.FirstOrDefault(e => e.Codigo == cod);
                Console.SetCursorPosition(25, 13); Console.Write(myEstudiante.Codigo);
                Console.SetCursorPosition(25, 14); Console.Write(myEstudiante.Nombre);
                Console.SetCursorPosition(25, 15); Console.Write(myEstudiante.Correo);
                Console.SetCursorPosition(25, 16); Console.Write(myEstudiante.Nota1);
                Console.SetCursorPosition(25, 17); Console.Write(myEstudiante.Nota2);
                Console.SetCursorPosition(25, 18); Console.Write(myEstudiante.Nota3);

                string confirmar = "n";
                Gui.BorrarLinea(14, 22, 80);
                Console.SetCursorPosition(14, 22); Console.Write($"Esta seguro de borrar el registro {myEstudiante.Codigo} S/N");
                confirmar = Console.ReadLine();
                if (confirmar == "s")
                {
                    db.Estudiantes.Remove(myEstudiante);
                    db.SaveChanges();
                    Gui.BorrarLinea(14, 23, 80);
                    Console.SetCursorPosition(14, 23); Console.Write("El registro ha sido borrado con exito");
                }
            }
            else
            {
                Gui.BorrarLinea(40, 22, 80);
                Console.SetCursorPosition(38, 24); Console.Write("No existe registro");
            }
        }
    }
    
}
