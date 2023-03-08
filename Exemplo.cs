namespace exercicio;
class Exemplo
{
    //ATRIBUTOS
  public string nome="";
  public int idade=0;
  public bool vacinado=false; 

  //MÉTODOS
  public void mostramsg(){
    Console.WriteLine("Oieeee 2F");
  } 
  public void pegaNome(string texto){
    Console.WriteLine("Oieeee: " + texto);
  }

  public string mensagem(){
    return "Devolvendo um texto";
  }
  public int somar (int a, int b){
    return a+b;

  }
}