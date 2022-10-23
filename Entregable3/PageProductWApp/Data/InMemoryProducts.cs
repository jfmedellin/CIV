namespace PageProducts.Data;


public class InMemoryProducts
{
    
    private List<string> Codes = new List<string>{
        "AAA001", "AAA002", "AAA003",
        "BBB001", "BBB002", "BBB003",
        "CCC001", "CCC002", "CCC003",
        "DDD001", "DDD002", "DDD003",
        "EEE001", "EEE002", "EEE003",
        "FFF001", "FFF002", "FFF003"
    };

    private List<string> Names = new List<string>{
        "Aceitunas", "Champiñones enteros/rebanados", "Chícharo con zanahoria", 
        "Chícharos enlatados", "Frijoles enlatados", "Frutas en almíbar", 
        "Sardinas", "Atún en agua/aceite", "Chiles enlatados", 
        "Chiles envasados", "Ensaladas enlatadas", "Granos de elote enlatados", 
        "Sopa en lata", "Vegetales en conserva", "Leche condesada",
        "Papa", "Palomitas", "Frituras de maíz"
    };

    public List<Product> getProducts ()
    {
        List<Product> ListProducts = new ();
        Random random = new Random();
        for(var i = 0; i < 18; i++) {
            Product product = new Product {
                    id = i+1,
                    Code = this.Codes[i],
                    Name = this.Names[i],
                    Price = random.Next(10000)
            };
            ListProducts.Add(product);
        }

        return ListProducts;
    }
}