using ExemploMetodosConstrutores.Models;

Pessoa p1 = new Pessoa(nome: "Ulisses", sobrenome: "Moraes");
//p1.Nome = "Ulisses";
//p1.SobreNome = "Moraes";

Pessoa p2 = new Pessoa(nome: "João", sobrenome: "Pedro");
//p2.Nome = "João";
//p2.SobreNome = "Pedro";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

Curso cursoDeCsharp = new Curso();
cursoDeCsharp.Nome = "C#";
cursoDeCsharp.Alunos = new List<Pessoa>();

Curso cursoDeBancoDeDados = new Curso();
cursoDeBancoDeDados.Nome = "SQL Server";
cursoDeBancoDeDados.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

cursoDeCsharp.AdicionarAluno(p1);
cursoDeCsharp.ListarAlunos();

cursoDeBancoDeDados.AdicionarAluno(p2);
cursoDeBancoDeDados.ListarAlunos();
