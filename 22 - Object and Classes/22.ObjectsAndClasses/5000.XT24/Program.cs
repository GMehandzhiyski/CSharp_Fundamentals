public class Test
{
    public static void Main()
    {
        Kashon kashon = new Kashon();

        Palet palet = new Palet();

        DHL kamion = new DHL();


        XT24 product1 = new XT24(3, 3, true, false);
        kashon.SlaganeNaProduct(product1);

        XT24 prodcut2 = new XT24(3, 3, true, true);
        kashon.SlaganeNaProduct(prodcut2);

        XT24 product3 = new XT24(3, 3, true, false);
        kashon.SlaganeNaProduct(product3);


        XT24 productVzetOtKashona = kashon.TursenenNaDefektnaBroika();

        Console.WriteLine($"Negoden li e producta: {productVzetOtKashona.Defekten}");

        productVzetOtKashona.Defekten = false;


        palet.AddKashonToPalet(kashon);

        //Idva vtori kashon
        Kashon kashon2 = new Kashon();


        XT24 product4 = new XT24(3, 3, true, false);
        kashon.SlaganeNaProduct(product1);

        XT24 prodcut5 = new XT24(3, 3, true, true);
        kashon.SlaganeNaProduct(prodcut2);

        XT24 product6 = new XT24(3, 3, true, false);
        kashon.SlaganeNaProduct(product3);


        palet.AddKashonToPalet(kashon2);

        //idd kashon 3

        Kashon kashon3 = new Kashon();

        XT24 product7 = new XT24(3, 3, true, false);
        kashon3.SlaganeNaProduct(product7);

        XT24 product8 = new XT24(3, 3, true, false);
        kashon3.SlaganeNaProduct(product8);

        palet.AddKashonToPalet(kashon3);


        kamion.AddPaletToDHL(palet);



    }
}

public class XT24
{
    public XT24(int poles, int kapak, bool etiket, bool defekten)
    {
        Poles = poles;
        Kapak = kapak;
        Etiket = etiket;
        Defekten = defekten;
    }

    public int Poles { get; set; }
    public int Kapak { get; set; }
    public bool Etiket { get; set; }
    public bool Defekten { get; set; }
}

public class Kashon
{
    public Kashon()
    {
        GotoviProdukti = new List<XT24>();
    }

    public List<XT24> GotoviProdukti;


    public void SlaganeNaProduct(XT24 edinGotovProduct)
    {
        GotoviProdukti.Add(edinGotovProduct);
    }

    public XT24 TursenenNaDefektnaBroika()
    {
        foreach (XT24 produkt in GotoviProdukti)
        {
            if (produkt.Defekten == true)
            {
                return produkt;
            }
        }

        return null;
    }
}


public class Palet
{
    public Palet()
    {
        Kashoni = new List<Kashon>();
    }

    public List<Kashon> Kashoni;

    public void AddKashonToPalet(Kashon edinKashon)
    {
        Kashoni.Add(edinKashon);
    }
}

public class DHL
{
    public DHL()
    {
        Paleti = new List<Palet>();
    }

    public List<Palet> Paleti;

    public void AddPaletToDHL(Palet edinpalet)
    {
        Paleti.Add(edinpalet);
    }
}