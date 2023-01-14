using System;

Console.WriteLine(EAlcoolica(new Vinho()));
ExibirInformacoes(new Vinho());
Console.ReadLine();

bool EAlcoolica(Bebida bebida)
{
    //return bebida.EAlcoolica();
    return bebida is BebidaAlcoolica;
}

bool ENatural(BebidaNaoAlcoolica bebida)
{
    //return bebida is INatural;
    return typeof(INatural).IsAssignableFrom(bebida.GetType());
}

bool EComLeite(Bebida bebida)
{
    return bebida is IAoLeite;
}

double GetTeorAlcoolico(BebidaAlcoolica bebida) => bebida.TeorAlcoolico;

void ExibirInformacoes(Bebida bebida)
{
    Console.WriteLine(bebida.ToString());
}

abstract class Bebida
{
    public string Nome { get; set; }
    public string Coloracao { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome} - Coloracao: {Coloracao}";
    }

    public bool EAlcoolica()
    {
        return this is BebidaAlcoolica;
    }
}

abstract class BebidaAlcoolica : Bebida
{
    public double TeorAlcoolico { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" - Teor alcoolico: {TeorAlcoolico}";
    }
}

class BebidaNaoAlcoolica : Bebida
{

}

class BebidaDestilada: BebidaAlcoolica
{
    public double TemperaturaDestilacao { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" - Temperatura destilacao: {TemperaturaDestilacao}";
    }
}

class BebidaFermentada : BebidaAlcoolica
{
    public int TempoFermentacao { get; set; }

    public override string ToString()
    {
        return base.ToString() + $" - Temperatura fermentacao: {TempoFermentacao}";
    }
}

interface INatural
{

}
interface IArtifical
{

}

interface IAoLeite
{

}

class SucoDeLaranja : BebidaNaoAlcoolica, INatural
{

}

class SucoDeLaranjaAoLeite : SucoDeLaranja, IAoLeite
{

}

class Vodka : BebidaDestilada
{

}

class Vinho : BebidaFermentada
{

}

class SucoDeUva : BebidaNaoAlcoolica, IArtifical
{

}

class CafeComLeite: BebidaNaoAlcoolica, INatural, IAoLeite
{

}

class Pilk : BebidaNaoAlcoolica, IArtifical, IAoLeite
{

}

class ChaMate: BebidaNaoAlcoolica, INatural
{

}