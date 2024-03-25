using System;
class HelloWorld {
  static void Main() {
      double cateto1, cateto2, hipotenusa;
      string conta;
    Console.WriteLine("O que você quer descobrir?");
    conta = Console.ReadLine();
    switch (conta){
        case "cateto 1":
           Console.WriteLine("Digite o cateto 2:");
           cateto2 = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite a hipotenusa:");
           hipotenusa = double.Parse(Console.ReadLine());
           cateto1 = Math.Sqrt((hipotenusa*hipotenusa)-(cateto2*cateto2));
           Console.WriteLine("O valor de cateto 1 é: " + cateto1);
           break;
           case "cateto 2":
           Console.WriteLine("Digite o cateto 1:");
           cateto1 = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite a hipotenusa:");
           hipotenusa = double.Parse(Console.ReadLine());
           cateto2 = Math.Sqrt((hipotenusa*hipotenusa)-(cateto1*cateto1));
           Console.WriteLine("O valor de cateto 2 é: " + cateto2);
           break;
           case "hipotenusa":
           Console.WriteLine("Digite o cateto 1:");
           cateto1 = double.Parse(Console.ReadLine());
           Console.WriteLine("Digite a cateto 2:");
           cateto2 = double.Parse(Console.ReadLine());
           hipotenusa = Math.Sqrt((cateto1*cateto1)+(cateto2*cateto2));
           Console.WriteLine("O valor da hipotenusa é: " + hipotenusa);
           break;
           default:
           Console.WriteLine("Isso não daí não dá doido.");
           break;
    }
  }
}