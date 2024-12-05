using ClasesGenericas;

//MinhaClasseGenerica<int> minhaClasse = new MinhaClasseGenerica<int>(10);
//Console.WriteLine(minhaClasse.ObterValor());
//minhaClasse.MostrarTipo();

//MinhaClasseGenerica<string> minhaClasse2 = new MinhaClasseGenerica<string>("teste");
//Console.WriteLine(minhaClasse2.ObterValor());

// classes genericas deixam os metodos reutilizaveis tornando eles mais maleaveis asssim voce
// pode usar ele do geito que voce quiser


Pilha<Pessoa> pilha = new Pilha<Pessoa>();
pilha.Push(new Pessoa() { Id=1, Nome="Pessoa1" });
pilha.Push(new Pessoa() { Id = 1, Nome = "Pessoa2" });
pilha.Push(new Pessoa() { Id = 1, Nome = "Pessoa3" });
pilha.Push(new Pessoa() { Id = 1, Nome = "Pessoa4" });
pilha.MostrarElementos();
pilha.Pop();
Console.WriteLine("-------------------------------");
pilha.MostrarElementos();


