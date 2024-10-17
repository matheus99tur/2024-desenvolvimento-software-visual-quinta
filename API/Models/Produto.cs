using System;

namespace API.Models;

public class Produto
{

  //C# - Construtor
  public Produto()
  {
    Id = Guid.NewGuid().ToString();
    CriadoEm = DateTime.Now;
  }
  //C# - Atributos/Propriedades/Características, get e set
  public string? Id { get; set; }
  public string? Nome { get; set; }
  public string? Descricao { get; set; }
  public double Preco { get; set; }
  public int Quantidade { get; set; }
  public DateTime CriadoEm { get; set; }

}
