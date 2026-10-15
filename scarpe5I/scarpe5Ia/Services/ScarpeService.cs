public class ScarpeService
{
    public List<Scarpa> GetAll() => new()
    {
        new Scarpa {Marca="Adidas", Modello = "Run 70s", Misura = 43, Prezzo = 48.99},
        new Scarpa {Marca="Adidas", Modello = "VL corto", Misura = 44, Prezzo = 32.99},
        new Scarpa {Marca="Fila", Modello = "Disrupto II", Misura = 41, Prezzo = 69.50},
        new Scarpa {Marca="Nike", Modello = "Air Monarch IvTraining", Misura = 41, Prezzo = 71.91},
        new Scarpa {Marca="Nike", Modello = "Air Monarch IvTraining", Misura = 42, Prezzo = 71.91},
        new Scarpa {Marca="Nike", Modello = "Air Monarch IvTraining", Misura = 43, Prezzo = 71.91},
        new Scarpa {Marca="Nike", Modello = "Air Monarch IvTraining", Misura = 44, Prezzo = 71.91}
    
    };

    public List<Scarpa> GetByMisura (string misura){
        List<Scarpa> risultato = new();

        foreach (Scarpa scarpa in GetAll()){
            if (scarpa.Misura.ToString() == misura){
                risultato.Add(scarpa);
            }
        }
        return risultato;
    }

}