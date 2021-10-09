using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JsonConverterBible
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<int, BibleModel> LivrosList = new Dictionary<int, BibleModel>();
            LivrosList.Add(1, new BibleModel() { name = "Gênesis", abbrev = "gn" });
            LivrosList.Add(2, new BibleModel() { name = "Êxodo", abbrev = "ex" });
            LivrosList.Add(3, new BibleModel() { name = "Levítico", abbrev = "lv" });
            LivrosList.Add(4, new BibleModel() { name = "Números", abbrev = "nm" });
            LivrosList.Add(5, new BibleModel() { name = "Deuteronômio", abbrev = "dt" });
            LivrosList.Add(6, new BibleModel() { name = "Josué", abbrev = "js" });
            LivrosList.Add(7, new BibleModel() { name = "Juízes", abbrev = "jz" });
            LivrosList.Add(8, new BibleModel() { name = "Rute", abbrev = "rt" });
            LivrosList.Add(9, new BibleModel() { name = "1 Samuel", abbrev = "1sm" });
            LivrosList.Add(10, new BibleModel() { name = "2 Samuel", abbrev = "2sm" });
            LivrosList.Add(11, new BibleModel() { name = "1 Reis", abbrev = "1rs" });
            LivrosList.Add(12, new BibleModel() { name = "2 Reis", abbrev = "2rs" });
            LivrosList.Add(13, new BibleModel() { name = "1 Crônicas", abbrev = "1cr" });
            LivrosList.Add(14, new BibleModel() { name = "2 Crônicas", abbrev = "2cr" });
            LivrosList.Add(15, new BibleModel() { name = "Esdras", abbrev = "ed" });
            LivrosList.Add(16, new BibleModel() { name = "Neemias", abbrev = "ne" });
            LivrosList.Add(17, new BibleModel() { name = "Ester", abbrev = "et" });
            LivrosList.Add(18, new BibleModel() { name = "Jó", abbrev = "jó" });
            LivrosList.Add(19, new BibleModel() { name = "Salmos", abbrev = "sl" });
            LivrosList.Add(20, new BibleModel() { name = "Provérbios", abbrev = "pv" });
            LivrosList.Add(21, new BibleModel() { name = "Eclesiastes", abbrev = "ec" });
            LivrosList.Add(22, new BibleModel() { name = "Cantares", abbrev = "ct" });
            LivrosList.Add(23, new BibleModel() { name = "Isaías", abbrev = "is" });
            LivrosList.Add(24, new BibleModel() { name = "Jeremias", abbrev = "jr" });
            LivrosList.Add(25, new BibleModel() { name = "Lamentações", abbrev = "lm" });
            LivrosList.Add(26, new BibleModel() { name = "Ezequiel", abbrev = "ez" });
            LivrosList.Add(27, new BibleModel() { name = "Daniel", abbrev = "dn" });
            LivrosList.Add(28, new BibleModel() { name = "Oseias", abbrev = "os" });
            LivrosList.Add(29, new BibleModel() { name = "Joel", abbrev = "jl" });
            LivrosList.Add(30, new BibleModel() { name = "Amós", abbrev = "am" });
            LivrosList.Add(31, new BibleModel() { name = "Obadias", abbrev = "ob" });
            LivrosList.Add(32, new BibleModel() { name = "Jonas", abbrev = "jn" });
            LivrosList.Add(33, new BibleModel() { name = "Miqueias", abbrev = "mq" });
            LivrosList.Add(34, new BibleModel() { name = "Naum", abbrev = "na" });
            LivrosList.Add(35, new BibleModel() { name = "Habacuque", abbrev = "hc" });
            LivrosList.Add(36, new BibleModel() { name = "Sofonias", abbrev = "sf" });
            LivrosList.Add(37, new BibleModel() { name = "Ageu", abbrev = "ag" });
            LivrosList.Add(38, new BibleModel() { name = "Zacarias", abbrev = "zc" });
            LivrosList.Add(39, new BibleModel() { name = "Malaquias", abbrev = "ml" });
            LivrosList.Add(40, new BibleModel() { name = "Mateus", abbrev = "mt" });
            LivrosList.Add(41, new BibleModel() { name = "Marcos", abbrev = "mc" });
            LivrosList.Add(42, new BibleModel() { name = "Lucas", abbrev = "lc" });
            LivrosList.Add(43, new BibleModel() { name = "João", abbrev = "jo" });
            LivrosList.Add(44, new BibleModel() { name = "Atos", abbrev = "at" });
            LivrosList.Add(45, new BibleModel() { name = "Romanos", abbrev = "rm" });
            LivrosList.Add(46, new BibleModel() { name = "1 Coríntios", abbrev = "1co" });
            LivrosList.Add(47, new BibleModel() { name = "2 Coríntios", abbrev = "2co" });
            LivrosList.Add(48, new BibleModel() { name = "Gálatas", abbrev = "gl" });
            LivrosList.Add(49, new BibleModel() { name = "Efésios", abbrev = "ef" });
            LivrosList.Add(50, new BibleModel() { name = "Filipenses", abbrev = "fp" });
            LivrosList.Add(51, new BibleModel() { name = "Colossenses", abbrev = "cl" });
            LivrosList.Add(52, new BibleModel() { name = "1 Tessalonicenses", abbrev = "1ts" });
            LivrosList.Add(53, new BibleModel() { name = "2 Tessalonicenses", abbrev = "2ts" });
            LivrosList.Add(54, new BibleModel() { name = "1 Timóteo", abbrev = "1tm" });
            LivrosList.Add(55, new BibleModel() { name = "2 Timóteo", abbrev = "2tm" });
            LivrosList.Add(56, new BibleModel() { name = "Tito", abbrev = "tt" });
            LivrosList.Add(57, new BibleModel() { name = "Filemom", abbrev = "fm" });
            LivrosList.Add(58, new BibleModel() { name = "Hebreus", abbrev = "hb" });
            LivrosList.Add(59, new BibleModel() { name = "Tiago", abbrev = "tg" });
            LivrosList.Add(60, new BibleModel() { name = "1 Pedro", abbrev = "1pe" });
            LivrosList.Add(61, new BibleModel() { name = "2 Pedro", abbrev = "2pe" });
            LivrosList.Add(62, new BibleModel() { name = "1 João", abbrev = "1jo" });
            LivrosList.Add(63, new BibleModel() { name = "2 João", abbrev = "2jo" });
            LivrosList.Add(64, new BibleModel() { name = "3 João", abbrev = "3jo" });
            LivrosList.Add(65, new BibleModel() { name = "Judas", abbrev = "jd" });
            LivrosList.Add(66, new BibleModel() { name = "Apocalipse", abbrev = "ap" });
            using (StreamReader file = new StreamReader(@"C:\Users\david\OneDrive\Projetos\IRB\ARA.json"))
            {
                try
                {
                    List<BibleModel> listExportJson = new List<BibleModel>();
                    
                    
                    string json = file.ReadToEnd();
                    List<BibleImportModel> biblia = JsonConvert.DeserializeObject<List<BibleImportModel>>(json);
                    foreach (BibleImportModel i in biblia)
                    {
                        Console.WriteLine(i.pk.ToString());
                        BibleModel i_b;
                        LivrosList.TryGetValue(Convert.ToInt32(i.book), out i_b);
                        var exist_livro = listExportJson.Where(x => x.name == i_b.name).FirstOrDefault();
                        if(exist_livro == null)
                        {
                            List<List<string>> listCap = new List<List<string>>();
                            List<int> listCapInt = new List<int>();
                            foreach (var capitulos in biblia.Where(x => x.book == i.book))
                            {
                                if (!listCapInt.Contains(capitulos.chapter))
                                {

                                    int total = biblia.Where(x => x.book == i.book).GroupBy(x => x.chapter).Count();
                                    for (int i_cap = 1; i_cap <= total; i_cap++)
                                    {
                                        List<string> versosList = new List<string>();
                                        foreach (var versos in biblia.Where(x => x.book == i.book && x.chapter == i_cap))
                                        {
                                            versosList.Add(versos.text);
                                        }
                                        listCapInt.Add(i_cap);
                                        if (versosList.Count > 0)
                                            listCap.Add(versosList);
                                    }
                                }
                            }
                            exist_livro = new BibleModel() { abbrev = i_b.abbrev, name = i_b.name, chapters = listCap };
                            listExportJson.Add(exist_livro);
                        }
                    }
                    var jsonExport = JsonConvert.SerializeObject(listExportJson);
                    File.WriteAllText(@"C:\Users\david\OneDrive\Projetos\IRB\ARA_new.json", jsonExport);
                }
                catch (Exception)
                {
                    Console.WriteLine("Problem reading file");
                }
            }
        }

    }
}
