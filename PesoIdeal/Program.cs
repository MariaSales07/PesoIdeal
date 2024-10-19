char sexo, decisao = 'S';
double altura,masculino,feminino;
bool sexo_valido;


do{
    Console.WriteLine("Digite seu sexo [M] - Masculino [F] - Feminino: ");
    sexo = Convert.ToChar(Console.ReadLine()!.ToUpper());
    sexo_valido = sexo == 'M' || sexo == 'F';
    if(!sexo_valido){

        Console.WriteLine("Opção invalida");
        Console.WriteLine("Deseja continuar? [S] - Sim [N] - Não");
        decisao = Convert.ToChar(Console.ReadLine()!);
        if(decisao == 'N'){
            return;
        }
        
    }
}while(!sexo_valido);

Console.WriteLine("Digite sua altura em m.... : ");
altura = Convert.ToDouble(Console.ReadLine()!);

masculino = altura * 72.7 - 58.0;
feminino = altura * 62.1 - 44.7;

if(sexo == 'M'){
    Console.WriteLine($"Seu peso ideal é {masculino:N1}kg");
}
else{
    Console.WriteLine($"Seu peso ideal é {feminino:N1}kg");
}



//Eu amo minha mulher









