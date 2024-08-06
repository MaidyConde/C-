//asyc y Await

using asycAwait;

void SolicitarBebida()
{
    Console.WriteLine("He solicitado las bebidas:");
    Camarero camarero = new Camarero();

    Task<string> bebidaPreparada1 = camarero.PrepararBebidaAsiync("Cerveza");
    Task<string> bebidaPreparada2 = camarero.PrepararBebidaAsiync("Martini");

    do
    {
        //
    } while (bebidaPreparada1.IsCompleted != true & bebidaPreparada2.IsCompleted != true);

    Console.WriteLine($"{bebidaPreparada1.Result} y {bebidaPreparada2.Result}");
}

SolicitarBebida();
