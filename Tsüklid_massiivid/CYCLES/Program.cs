namespace CYCLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Do-while ülesanded*/

            // 1. "arvuta kuni summani"
            // tee muutuja "täisarv" mille sees on täisarv 0
            // kirjuta do while tsükkel
            // tsükli tegevusena lahuta muutujast "täisarv" maha 2
            // ja kuva muutuja "täisarv" välja
            // -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib kas muutujas "täisarv" on arv miinuses rohkem kui -31
            // peale tsüklit kuva sõnum "tsükkel lõppes"

            int täisArv = 0;
            do
            {
                täisArv -= 2;
                Console.WriteLine(täisArv);
            }
            while (täisArv > -31);
            Console.WriteLine("tsükkel lõppes");


            // 2. "pikenda sõnumit"
            // tee muutuja "sõnum" mille sees on tühi string, nt ""
            // kirjuta do while tsükkel
            // tsükli tegevusena küsi kasutajalt sõnumile lisa "palun lisa järgmine sõnumi osa
            // lisa muutujasse "sõnum" kasutaja poolt tehtud sisestus
            // kuva muutuja "sõnum" välja
            // -> do while tsükli tingimuseks kirjuta kontroll, mis kontrollib muutuja "sõnum" pikkust .Length abil, kui sõnum on pikem kui 140 tähte, siis tsükkel lõppeb
            // peale tsüklit kuva sõnum "see sõnum enam twitterisse ei mahuks, kirjuta vähem fam"

            /* While ülesanded*/

            // 1. "niikaua kuni ohtu pole"
            // tee muutuja "CO2tase" mille sees on komakohaga float 0.0f
            // kirjuta while tsükkel
            // -> while tsükli tingimuseks kirjuta kontroll, mis kontrollib kas muutujas "CO2tase" on arv väiksem kui 40.000
            // tsükli tegevusena kuva sõnum "mis on co2 tase?"
            // pane muutujasse "CO2tase" info kasutajalt
            // tee tingimuslauseline kontroll, mis kontrollib, kui kasutaja sisestus on väiksem kui 40.000,
            // siis kuva sõnum kasutajale teavitades, et otsest ohtu ei ole
            // peale tsüklit kuva sõnum "evakueeri hoonest, süsihappegaasi tase on liiga kõrgel"
            /* 
             * NB programm peab niikaua käima kuni kasutaja sisestus on suurem või võrdne kui 40.000
             */

            // 2. "vibumees"
            // tee muutuja "mehike" mille sees on täisarv 0
            // tee muutuja "vastus" mille sees on tühi tekst
            // kirjuta while tsükkel
            // -> while tsükli tingimuseks kirjuta kontroll:
            //      mis kontrollib kas muutujas "mehike" on täisarv 5 või vähem
            //      või
            //      muutujas "vastus" on tekst "jah"
            // tsükli tegevuseks küsi kasutajalt "kas tahad mehikesse noole lasta?"
            // tsükli tegevuseks pane muutujasse "vastus" väärtus kasutajalt käsurea pealt 
            // tsükli tegevuseks kontrolli tingimuslausega kas vastus oli "jah"
            // tsükli tegevuseks Kui tingimuslause vastus oli jah, siis:
            // kuva kasutajale tekst "mitu noolt lased?"
            // lisa muutujasse "mehike" kasutajalt saadud täisarv
            // peale tsüklit kontrolli kas muutujas "mehike" olev arv on väiksem kui 5
            // kui on väiksem kui 5 siis kuva sõnum "mehike elab :D"
            // kõikidel muudel juhtudel kuva sõnum "tapsid mehikese ära :c"

            /* For ülesanded*/

            // 1. "prindi numbrid"
            // tee muutuja "kuipalju" milles on täisarv 0 
            // kuva kasutajale tekst millega küsid kasutajalt mitu numbrit ta tahab
            // omista käsurealt saadud arv muutujasse "kuipalju"
            // kirjuta for tsükkel, tsükli teise parameetrisse - kontrolli aseta i vastu muutuja "kuipalju"
            // tsükli tegevusena kuva kasutajale välja i, aga liida sellele üks juurde et lugemine algaks arvust 1
            // peale tsüklit kuva kasutajale sõnum "tsükkel lõppes"

            /*
            int kuiPalju = 0;
            Console.WriteLine("mitu numbrit te tahate?");
            kuiPalju = int.Parse(Console.ReadLine());
            for(int i = 0;i < kuiPalju;i++)
            {
                Console.WriteLine(i+1);
            }
            Console.WriteLine("tsükkel lõppes");
            */

            // 2. "Ruut"
            // tee muutuja "ruudukülg" milles on täisarv 0
            // kuva kasutajale tekst millega küsid kasutajalt kui suurt ruutu ta tahab
            // omista käsurealt saadud arv muutujasse "ruudukülg"
            // kirjuta for tsükkel, tsükli tingimuse kontrolli pane i kontrollimisse muutuja "ruudukülg"
            // tsükli sisse kirjuta sõne tüüpi muutuja, "seeRida", kuhu omistad tühja sõne.
            // tsükli sees on omakorda teine for tsükkel, ka selle tingimuse kontrolli pane i kontrollimisse muutuja "ruudukülg"'
            // nüüd sisemise tsükli sees, omista muutujale "seeRida" juurde liites sisse väärtus "HH" 
            // kui sisemine tsükkel on lõpetanud, siis kuva kasutajale see rida välja
            // kui ka esimene tsükkel on lõpetanud, siis kuva kasutajale tekst "tsüklid on lõpetanud"

            /*
            int ruudukülg = 0;
            Console.WriteLine("kui suurt ruutu te tahate");
            ruudukülg = int.Parse(Console.ReadLine());
            for (int i = 0; i < ruudukülg; i++)
            {
                string seeRida = "";
                for (int j = 0; j < ruudukülg; j++)
                {
                    seeRida = seeRida + "HH";
                }
                Console.WriteLine(seeRida);
            }
            Console.WriteLine("tsüklid on lõppenud");
            */

            /* Foreach + list ülesanded */

            // 1. "suured summad"
            // kirjuta viie elemendiga massiiv, elemendid on 1,50,10,15,20, muutuja nimi otsusta ise.
            // kirjuta foreach tsükkel, ja võta kollektsiooniparameetriks oma viie elemendiga massiivi muutuja nimetus
            // tsükli sisse tee tingimuslause, mis kontrollib kas element on suurem kui 15
            // kui on suurem, siis kuva see element kasutajale välja
            /* vihje, 
             * kui programm on õigesti kirjutatud, 
             * siis kuvatakse kasutajale välja elemendid kakskümmend ja viiskümmend
             */

            // 2. "summeerimine"
            // kirjuta viie elemendiga massiiv, elemendid on 343,686,2300,4439,6996, muutuja nimi otsusta ise.
            // kirjuta täisarvu tüüpi muutuja mille sisse omistad väärtuse 0 ning mille nime otsustad ise
            // kirjuta foreach tsükkel, ja võta kollektsiooniparameetriks oma viie elemendiga massiivi muutuja nimetus
            // tsükli sisse liida oma täisarvu tüüpi muutujale elemendi sees olev arv juurde
            // peale tsüklit kuva kasutajale oma täisarvu tüüpi muutuja välja

        }
    }
}
