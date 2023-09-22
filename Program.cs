// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using tl2_tp1_2023_MarceAbr;

var cadeteria = new Cadeteria("Rapi", "45698778");

var cad1 = new Cadete("Marcelo", "Mi casa", "123456789");
var cad2 = new Cadete("Braian", "Otra casa", "987321654");
var cad3 = new Cadete("Abregu", "Tercera casa", "444444444");

cadeteria.agregarNuevoCadete(cad1);
cadeteria.agregarNuevoCadete(cad2);
cadeteria.agregarNuevoCadete(cad3);

// var ped1 = new Pedido(1,"asdasd", "Lionel", "Miami", "18122022", "Estatua cerca");
// var ped2 = new Pedido(2,"aaaaaa", "Andres", "Miami", "7777777", "estadio cerca");
// var ped3 = new Pedido(3,"dddddd", "Messi", "Miami", "8888888", "escuela cerca");

cadeteria.listarCadetes();
// cadeteria.asignarPedidoACadete(cad1, ped1);
// cadeteria.asignarPedidoACadete(cad2, ped2);
// cadeteria.asignarPedidoACadete(cad1, ped3);

// cad1.cambiarEstado(2, estado.Entregado);
// cad1.cambiarEstado(3, estado.Entregado);
// cad1.mostrarPedidos();

// Console.WriteLine("Cantidad a pagar: " + cad1.JornalACobrar());
// cadeteria.asignarPedidoACadete(cad1, ped2);
// cad1.mostrarPedidos();
// Console.WriteLine("\n----------------------\n");
// cad2.mostrarPedidos();