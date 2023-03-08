// See https://aka.ms/new-console-template for more information

using ConsoleApp_1;

Produto p1 = new Produto(1, "mouse", 10.30m);
Produto p2 = new Produto(2, "teclado", 20.90m);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(29.90m);
p1.setDescricao("mouse razer");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());