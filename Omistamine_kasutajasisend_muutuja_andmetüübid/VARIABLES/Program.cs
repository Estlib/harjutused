namespace VARIABLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //omistamine & andmetüübid 1

            //1. kirjuta muutuja sõne andmetüübiga ja omista talle sisse tekst: musta lehma taga valge lehma saba.
            //kuva muutuja välja

            //2. kirjuta muutuja täisarvu andmetüübiga ja omista talle sisse täisarv, mis on käimasoleva kuu arv.
            //kuva muutuja välja

            //3. kirjuta muutuja booleani andmetüübiga ja omista talle sisse väärtusena false.
            //kuva muutuja välja

            //4. kirjuta muutuja komakohaga andmetüübiga ja omista talle väärtuseks 3.14
            //kuva muutuja välja

            //omistamine & andmetüübid 2

            //5. kirjuta muutuja mille andmetüüp veel ei ole teada, ning omista talle väärtuseks tekst: valge lehma taga musta lehma saba
            //kirjuta ka teine muutuja, mille andmetüüp veel ei ole teada, ning omista talle väärtuseks tekst: kirju lehma taga pruuni lehma saba
            //tee uus muutuja kuhu liidad eelnevad muutujad kokku. lisa nende vahele punkt ja tühik.
            //kuva uus muutuja välja

            var keeleVäänaja = "valge lehma taga musta lehma saba";
            var keeleVäänaja2 = "kirju lehma taga pruuni lehma saba";
            var keeleVäänaja3 = keeleVäänaja + ". " + keeleVäänaja2;
            Console.WriteLine(keeleVäänaja3);

            //6. kirjuta muutuja sõne andmetüübiga ja omista talle sisse tekst: musta lehma taga valge lehma saba.
            //uuel koodireal liida sellele muutujale omistusoperaatoriga += otsa valge lehma taga musta lehma saba.
            //uuel koodireal liida sellele muutujale omistusoperaatoriga += otsa kirju lehma taga pruuni lehma saba.
            //uuel koodireal liida sellele muutujale omistusoperaatoriga += otsa pruuni lehma taga kirju lehma saba.
            //kuva muutuja sisu välja

            //7. kirjuta muutuja täisarvu andmetüübiga ja omista talle sisse täisarv 2.
            //kirjuta teine muutuja täisarvu andmetüübiga ja omista talle sisse täisarv 3.
            //kuva esimene muutuja välja
            //esimesse muutujasse omista teise muutuja arvuga korrutustehe, kasutades omistusoperaatorit *=
            //kuva esimene muutuja uuesti välja, muutujas peaks nüüd 6 olema.

            //8. kirjuta muutuja täisarvu andmetüübiga ja omista talle sisse täisarv 2.
            //kirjuta teine muutuja täisarvu andmetüübiga ja omista talle sisse täisarv 6.
            //kuva teine muutuja välja
            //teise muutujasse omista esimese muutuja arvuga jagamistehe, kasutades omistusoperaatorit /=
            //kuva teine muutuja uuesti välja, muutujas peaks nüüd 3 olema.

            //9. kirjuta muutuja komakohalise arvu andmetüübiga ja omista talle sisse väärtuseks 6.0.
            //kirjuta teine muutuja komakohalise arvu andmetüübiga ja omista talle sisse väärtuseks 2.5.
            //kuva esimene muutuja välja
            //esimesse muutujasse omista teise muutuja arvuga lahutamistehe, kasutades omistusoperaatorit -=
            //kuva esimene muutuja uuesti välja, muutujas peaks nüüd ~3.5 olema.

            //10. kirjuta muutuja komakohalise arvu andmetüübiga ja omista talle sisse väärtuseks 8.25.
            //kirjuta teine muutuja täisarvu andmetüübiga ja omista talle sisse väärtuseks 2.
            //kuva esimene muutuja välja
            //esimesse muutujasse omista teise muutuja arvuga liitmistehe, kasutades omistusoperaatorit +=
            //kuva esimene muutuja uuesti välja, muutujas peaks nüüd ~10.25 olema.

        }
    }
}
