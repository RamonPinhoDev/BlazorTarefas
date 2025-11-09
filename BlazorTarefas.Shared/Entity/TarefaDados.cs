namespace BlazorTarefas.Shared.Data;

    public static class TarefaDados
    {

        public static List<Tarefa> ObterTarefas() => new()
        {

         new Tarefa
            {
                 id = Guid.NewGuid(),
                     Descricao = "Estudar Blazor",
                     Concluida = false,
                     DataCriacao = DateTime.Now
            },

                 new Tarefa
                 {
                     id = Guid.NewGuid(),
                     Descricao = "Estudar Blazor",
                     Concluida = false,
                     DataCriacao = DateTime.Now
                 },
                 new Tarefa
                 {
                     id = Guid.NewGuid(),
                     Descricao = "Estudar Blazor",
                     Concluida = true,
                     DataCriacao = DateTime.Now
                 },
                 new Tarefa
                 {
                     id = Guid.NewGuid(),
                     Descricao = "Estudar Blazor",
                     Concluida = false,
                     DataCriacao = DateTime.Now
                 },
                 new Tarefa
                 {  id = Guid.NewGuid(),
                     Descricao = "Estudar Blazor",
                     Concluida = false,
                     DataCriacao = DateTime.Now
                 },
                 new Tarefa
                 {
                      id = Guid.NewGuid(),
                     Descricao = "Estudar Blazor",
                     Concluida = true,
                     DataCriacao = DateTime.Now
                 } ,


        };
    }

