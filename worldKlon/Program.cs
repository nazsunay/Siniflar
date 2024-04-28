﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worldKlon

{
    internal class Program
    {
        static void Yaz(string metin, bool yanyanaYaz = false, ConsoleColor renk = ConsoleColor.White, ConsoleColor arkaPlan = ConsoleColor.Black)
        {
            Console.BackgroundColor = arkaPlan;
            Console.ForegroundColor = renk;
            if (yanyanaYaz)
            {
                Console.Write(metin);
            }
            else
            {
                Console.WriteLine(metin);
            }
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            var kelimeler = new string[]{"Abadi",
            "Abani",
            "Abide",
            "Abiye",
            "Abuli",
            "Acemi",
            "Acibe",
            "Adedi",
            "Afaki",
            "Afazi",
            "Afife",
            "Afili",
            "Afişe",
            "Afoni",
            "Afşin",
            "Agami",
            "Ahali",
            "Ahize",
            "Aidat",
            "Ajite",
            "Akait",
            "Akemi",
            "Akide",
            "Aktif",
            "Aleni",
            "Alevi",
            "Alize",
            "Alkil",
            "Ameli",
            "Amigo",
            "Ampir",
            "Amudi",
            "Anemi",
            "Anide",
            "Anime",
            "Anjin",
            "Antik",
            "Anüri",
            "Apiko",
            "Aplik",
            "Apoşi",
            "April",
            "Apsis",
            "Arabi",
            "Arami",
            "Arazi",
            "Arızi",
            "Arife",
            "Ariya",
            "Ariza",
            "Arsin",
            "Arşiv",
            "Asabi",
            "Aside",
            "Asist",
            "Astik",
            "Aşari",
            "Aşevi",
            "Aşina",
            "Atari",
            "Atina",
            "Avize",
            "Ayevi",
            "Azami",
            "Azeri",
            "Azize",
            "Aznif",
            "Azoik",
            "Babai",
            "Badik",
            "Bahai",
            "Bahir",
            "Bahis",
            "Bahri",
            "Bakir",
            "Baliğ",
            "Barit",
            "Bariz",
            "Basil",
            "Basit",
            "Batik",
            "Bazik",
            "Bazit",
            "Bedii",
            "Bedik",
            "Bedir",
            "Bekçi",
            "Bekri",
            "Belgi",
            "Beliğ",
            "Belik",
            "Belit",
            "Belki",
            "Belli",
            "Benci",
            "Bengi",
            "Beniz",
            "Benli",
            "Beril",
            "Berri",
            "Besin",
            "Besni",
            "Beşik",
            "Beşiz",
            "Beşli",
            "Betik",
            "Betim",
            "Beyin",
            "Beyit",
            "Beyzi",
            "Bezci",
            "Bezgi",
            "Bezik",
            "Bezir",
            "Beziş",
            "Bezsi",
            "Biber",
            "Biblo",
            "Bicik",
            "Biçem",
            "Biçim",
            "Biçiş",
            "Biçki",
            "Biçme",
            "Bidar",
            "Bidat",
            "Bidon",
            "Bihuş",
            "Bikes",
            "Bikir",
            "Bilar",
            "Bilek",
            "Bilet",
            "Bilge",
            "Bilgi",
            "Bilim",
            "Bilir",
            "Biliş",
            "Bilme",
            "Bilye",
            "Bindi",
            "Binek",
            "Biner",
            "Bingi",
            "Biniş",
            "Binit",
            "Binme",
            "Biraz",
            "Birci",
            "Birer",
            "Birey",
            "Birim",
            "Birli",
            "Birun",
            "Bişek",
            "Bitap",
            "Bitek",
            "Bitey",
            "Bitik",
            "Bitim",
            "Bitiş",
            "Bitki",
            "Bitli",
            "Bitme",
            "Bitüm",
            "Biyel",
            "Bizar",
            "Bizce",
            "Bizon",
            "Bobin",
            "Borik",
            "Butik",
            "Cahil",
            "Caize",
            "Calip",
            "Camia",
            "Camit",
            "Canip",
            "Cazip",
            "Cebin",
            "Cebir",
            "Cebri",
            "Cedit",
            "Cehil",
            "Cehri",
            "Celil",
            "Cemil",
            "Cenin",
            "Cepçi",
            "Cesim",
            "Cevir",
            "Ceviz",
            "Cevvi",
            "Cezai",
            "Cezir",
            "Cezri",
            "Cibin",
            "Cibre",
            "Cicik",
            "Cicim",
            "Cicoz",
            "Cidal",
            "Cidar",
            "Ciddi",
            "Ciğer",
            "Cihan",
            "Cihar",
            "Cihat",
            "Cihaz",
            "Cihet",
            "Cilve",
            "Cimri",
            "Cinai",
            "Cinas",
            "Cinci",
            "Cinli",
            "Cinsi",
            "Cirim",
            "Cirit",
            "Cisim",
            "Civan",
            "Civar",
            "Cizre",
            "Cizye",
            "Cuşiş",
            "Çebiç",
            "Çecik",
            "Çedik",
            "Çekiç",
            "Çekik",
            "Çekim",
            "Çekiş",
            "Çelgi",
            "Çelik",
            "Çelim",
            "Çemiç",
            "Çemiş",
            "Çengi",
            "Çepin",
            "Çepni",
            "Çerçi",
            "Çeşit",
            "Çeşni",
            "Çetin",
            "Çevik",
            "Çevri",
            "Çeyiz",
            "Çiçek",
            "Çifte",
            "Çigan",
            "Çiğde",
            "Çiğil",
            "Çiğin",
            "Çiğit",
            "Çiğli",
            "Çilek",
            "Çilli",
            "Çimek",
            "Çimen",
            "Çimme",
            "Çince",
            "Çinko",
            "Çinli",
            "Çipil",
            "Çiriş",
            "Çiroz",
            "Çişik",
            "Çitar",
            "Çiten",
            "Çitme",
            "Çivit",
            "Çizer",
            "Çizge",
            "Çizgi",
            "Çizik",
            "Çizim",
            "Çiziş",
            "Çizme",
            "Dahil",
            "Daima",
            "Daimi",
            "Daire",
            "Dakik",
            "Dasit",
            "Datif",
            "Debil",
            "Defin",
            "Değil",
            "Değim",
            "Değin",
            "Değiş",
            "Deist",
            "Deizm",
            "Delgi",
            "Delhi",
            "Delik",
            "Delil",
            "Demin",
            "Demir",
            "Demli",
            "Denim",
            "Deniz",
            "Denli",
            "Derbi",
            "Dergi",
            "Derik",
            "Derin",
            "Deşik",
            "Devim",
            "Devir",
            "Devri",
            "Deyim",
            "Deyiş",
            "Dibek",
            "Dicle",
            "Didar",
            "Didim",
            "Didon",
            "Digor",
            "Diğer",
            "Dikçe",
            "Dikeç",
            "Dikel",
            "Diken",
            "Dikey",
            "Dikim",
            "Dikiş",
            "Dikit",
            "Dikiz",
            "Dikme",
            "Dikse",
            "Dikta",
            "Dikte",
            "Dilci",
            "Dilek",
            "Dilim",
            "Diliş",
            "Dilli",
            "Dilme",
            "Dilsi",
            "Dimağ",
            "Dinar",
            "Dince",
            "Dinci",
            "Dinek",
            "Dinen",
            "Dingi",
            "Dingo",
            "Diniş",
            "Dinli",
            "Dinme",
            "Dipli",
            "Direk",
            "Diren",
            "Direy",
            "Diriğ",
            "Diril",
            "Dirim",
            "Disko",
            "Dişçi",
            "Dişil",
            "Dişli",
            "Ditme",
            "Dival",
            "Divan",
            "Divik",
            "Divit",
            "Diyar",
            "Diyet",
            "Diyez",
            "Dizek",
            "Dizel",
            "Dizem",
            "Dizge",
            "Dizgi",
            "Dizim",
            "Dizin",
            "Diziş",
            "Dizme",
            "Döviz",
            "Dünit",
            "Dürzi",
            "Ebedi",
            "Ebeli",
            "Edebi",
            "Edinç",
            "Efriz",
            "Eğrim",
            "Ekici",
            "Ekili",
            "Eksik",
            "Eksin",
            "Eksiz",
            "Eküri",
            "Elcik",
            "Elçim",
            "Eleji",
            "Elgin",
            "Elifi",
            "Elips",
            "Ellik",
            "Emcik",
            "Emici",
            "Emlik",
            "Emtia",
            "Emzik",
            "Enayi",
            "Engin",
            "Ensiz",
            "Enzim",
            "Epeyi",
            "Erbin",
            "Ercik",
            "Erciş",
            "Ergin",
            "Erika",
            "Erime",
            "Erinç",
            "Erkin",
            "Erkli",
            "Erlik",
            "Ermin",
            "Ermiş",
            "Eroin",
            "Ersiz",
            "Erzin",
            "Esasi",
            "Esire",
            "Eskil",
            "Eskiz",
            "Espri",
            "Esrik",
            "Eşkin",
            "Eşlik",
            "Eşsiz",
            "Etçik",
            "Etçil",
            "Etkin",
            "Etlik",
            "Etnik",
            "Etsiz",
            "Evcik",
            "Evcil",
            "Evgin",
            "Eviye",
            "Evlik",
            "Evrik",
            "Evrim",
            "Evsin",
            "Evsiz",
            "Ezani",
            "Ezeli",
            "Ezgiç",
            "Ezgin",
            "Ezici",
            "Ezinç",
            "Ezine",
            "Facia",
            "Fahiş",
            "Fahri",
            "Fakih",
            "Fakir",
            "Fanti",
            "Fariğ",
            "Faril",
            "Fasih",
            "Fasit",
            "Fatih",
            "Fecir",
            "Fedai",
            "Fehim",
            "Fenci",
            "Fenik",
            "Fenni",
            "Ferdi",
            "Ferih",
            "Ferik",
            "Ferli",
            "Fesih",
            "Fetih",
            "Fetiş",
            "Fevri",
            "Feyiz",
            "Fıtri",
            "Fiber",
            "Fidan",
            "Fidye",
            "Fifre",
            "Figan",
            "Figür",
            "Fiili",
            "Fikir",
            "Fikri",
            "Filan",
            "Filar",
            "Filet",
            "Filiz",
            "Filoz",
            "Filsi",
            "Filum",
            "Final",
            "Fince",
            "Finiş",
            "Firak",
            "Firar",
            "Firez",
            "Firik",
            "Firma",
            "Fiske",
            "Fisto",
            "Fişek",
            "Fişka",
            "Fişli",
            "Fitçi",
            "Fitil",
            "Fitin",
            "Fitne",
            "Fitre",
            "Fiyat",
            "Fizik",
            "Flori",
            "Fosil",
            "Frigo",
            "Frisa",
            "Gabin",
            "Gadir",
            "Gafil",
            "Gaile",
            "Gaita",
            "Galip",
            "Galiz",
            "Garbi",
            "Garip",
            "Gasil",
            "Gaşiy",
            "Gayri",
            "Geçim",
            "Geçiş",
            "Geçit",
            "Gedik",
            "Gediz",
            "Gelin",
            "Gelir",
            "Geliş",
            "Geniş",
            "Geniz",
            "Geoit",
            "Gerçi",
            "Gergi",
            "Gerim",
            "Geriş",
            "Geriz",
            "Geviş",
            "Geyik",
            "Geziş",
            "Gider",
            "Gidiş",
            "Gidon",
            "Giray",
            "Girdi",
            "Giren",
            "Girim",
            "Giriş",
            "Girme",
            "Gitar",
            "Gitme",
            "Gitti",
            "Giyim",
            "Giyiş",
            "Giyit",
            "Giyme",
            "Giysi",
            "Gizem",
            "Gizil",
            "Gizli",
            "Goril",
            "Gotik",
            "Grizu",
            "Grogi",
            "Habip",
            "Habis",
            "Hacim",
            "Hacir",
            "Haciz",
            "Hadim",
            "Hadis",
            "Hafif",
            "Hafik",
            "Hafit",
            "Haile",
            "Hakim",
            "Hakir",
            "Haliç",
            "Halik",
            "Halim",
            "Halis",
            "Hamil",
            "Hamiş",
            "Hamsi",
            "Hangi",
            "Hanoi",
            "Hapis",
            "Harbi",
            "Hariç",
            "Harim",
            "Harir",
            "Haris",
            "Hasbi",
            "Hasis",
            "Haşin",
            "Haşir",
            "Haşiş",
            "Haşiv",
            "Hatif",
            "Hatim",
            "Hatip",
            "Hatmi",
            "Havai",
            "Havil",
            "Haydi",
            "Hayli",
            "Hazin",
            "Hecin",
            "Hedik",
            "Hekim",
            "Helik",
            "Helis",
            "Hepsi",
            "Herif",
            "Herik",
            "Hicap",
            "Hicaz",
            "Hiciv",
            "Hicri",
            "Hiççi",
            "Hidiv",
            "Hidra",
            "Hikem",
            "Hilaf",
            "Hilal",
            "Hilat",
            "Hilye",
            "Himen",
            "Hindi",
            "Hindu",
            "Hippi",
            "Hisar",
            "Hisli",
            "Hisse",
            "Hissi",
            "Hitam",
            "Hitan",
            "Hitap",
            "Hitit",
            "Hizan",
            "Hizip",
            "Hodri",
            "Hükmi",
            "İbare",
            "İbate",
            "İbdai",
            "İblağ",
            "İblis",
            "İbraz",
            "İbret",
            "İbrik",
            "İbzal",
            "İcbar",
            "İcmal",
            "İçeri",
            "İçici",
            "İçkin",
            "İçlem",
            "İçlik",
            "İçmek",
            "İçrek",
            "İçsel",
            "İçsiz",
            "İçten",
            "İçyüz",
            "İdadi",
            "İdame",
            "İdare",
            "İdari",
            "İddia",
            "İdeal",
            "İdman",
            "İdrak",
            "İdrar",
            "İfade",
            "İffet",
            "İfham",
            "İflah",
            "İflas",
            "İfrağ",
            "İfrat",
            "İfraz",
            "İfrit",
            "İfsat",
            "İftar",
            "İğdir",
            "İğdiş",
            "İğfal",
            "İğlik",
            "İhale",
            "İhata",
            "İhbar",
            "İhdas",
            "İhlal",
            "İhlas",
            "İhmal",
            "İhraç",
            "İhram",
            "İhraz",
            "İhsan",
            "İhsas",
            "İhtar",
            "İhvan",
            "İhzar",
            "İkame",
            "İkbal",
            "İkdam",
            "İkici",
            "İkili",
            "İklim",
            "İkmal",
            "İkrah",
            "İkram",
            "İkrar",
            "İkraz",
            "İksir",
            "İlahe",
            "İlahi",
            "İlave",
            "İlbay",
            "İlenç",
            "İleri",
            "İleti",
            "İlgeç",
            "İlhak",
            "İlham",
            "İlhan",
            "İlkah",
            "İlkel",
            "İlkin",
            "İllet",
            "İlmek",
            "İlmik",
            "İlzam",
            "İmale",
            "İmalı",
            "İmame",
            "İmbat",
            "İmbik",
            "İmdat",
            "İmece",
            "İmkan",
            "İmleç",
            "İmlek",
            "İmlik",
            "İmren",
            "İmroz",
            "İmsak",
            "İnanç",
            "İncik",
            "İncil",
            "İncir",
            "İndis",
            "İnfak",
            "İnfaz",
            "İngin",
            "İnkar",
            "İnmek",
            "İnönü",
            "İnsaf",
            "İnsan",
            "İnşat",
            "İntaç",
            "İntak",
            "İntan",
            "İnzal",
            "İpçik",
            "İpeka",
            "İpham",
            "İplik",
            "İpsiz",
            "İptal",
            "İpucu",
            "İrade",
            "İradi",
            "İrfan",
            "İrice",
            "İrite",
            "İrkme",
            "İrmik",
            "İroni",
            "İrsal",
            "İrsen",
            "İrşat",
            "İsale",
            "İsevi",
            "İshal",
            "İskan",
            "İskoç",
            "İslam",
            "İslav",
            "İslim",
            "İsmen",
            "İsmet",
            "İsnat",
            "İspat",
            "İspir",
            "İspit",
            "İsraf",
            "İstek",
            "İstem",
            "İster",
            "İstif",
            "İstim",
            "İstop",
            "İsyan",
            "İşeme",
            "İşgal",
            "İşkal",
            "İşkil",
            "İşlek",
            "İşlem",
            "İşlev",
            "İşlik",
            "İşmar",
            "İşret",
            "İşsiz",
            "İştah",
            "İşteş",
            "İşyar",
            "İtaat",
            "İteği",
            "İthaf",
            "İthal",
            "İtham",
            "İtici",
            "İtila",
            "İtina",
            "İtlaf",
            "İtlik",
            "İtmam",
            "İtmek",
            "İvedi",
            "İvesi",
            "İvmek",
            "İyice",
            "İzabe",
            "İzafe",
            "İzafi",
            "İzale",
            "İzhar",
            "İzlek",
            "İzlem",
            "İzmir",
            "İznik",
            "İzole",
            "İzzet",
            "Jikle",
            "Jilet",
            "Kabil",
            "Kabin",
            "Kabir",
            "Kadim",
            "Kadir",
            "Kadit",
            "Kafir",
            "Kagir",
            "Kahil",
            "Kahin",
            "Kahir",
            "Kaide",
            "Kaime",
            "Kalbi",
            "Kamil",
            "Kaniş",
            "Kapik",
            "Karni",
            "Kasis",
            "Kasti",
            "Kaşif",
            "Katil",
            "Katip",
            "Kavil",
            "Kavim",
            "Kavis",
            "Kavmi",
            "Kebir",
            "Kefil",
            "Kefir",
            "Kekik",
            "Kelik",
            "Kelli",
            "Kemik",
            "Kendi",
            "Kepir",
            "Kerih",
            "Kerim",
            "Keriz",
            "Kerki",
            "Kerti",
            "Kesbi",
            "Kesif",
            "Kesik",
            "Kesim",
            "Kesin",
            "Kesir",
            "Kesiş",
            "Kesit",
            "Keski",
            "Keşif",
            "Keşik",
            "Keşiş",
            "Keşki",
            "Keyfi",
            "Keyif",
            "Kıpti",
            "Kısmi",
            "Kibar",
            "Kibir",
            "Kifaf",
            "Kikla",
            "Kiler",
            "Kilim",
            "Kilis",
            "Kilit",
            "Kiliz",
            "Killi",
            "Kilsi",
            "Kilüs",
            "Kimse",
            "Kimüs",
            "Kimya",
            "Kinci",
            "Kinik",
            "Kinin",
            "Kiniş",
            "Kinli",
            "Kiraz",
            "Kirde",
            "Kireç",
            "Kiril",
            "Kiriş",
            "Kirli",
            "Kirpi",
            "Kirve",
            "Kisve",
            "Kitap",
            "Kitin",
            "Kitle",
            "Kizir",
            "Klima",
            "Klips",
            "Klişe",
            "Kofti",
            "Kolik",
            "Kolit",
            "Kombi",
            "Komik",
            "Konik",
            "Kopil",
            "Koşin",
            "Kredi",
            "Kriko",
            "Kroki",
            "Kulis",
            "Kutsi",
            "Kuzin",
            "Kübik",
            "Külli",
            "Kürdi",
            "Kürit",
            "Kütin",
            "Laçin",
            "Ladik",
            "Ladin",
            "Lafzi",
            "Lahit",
            "Lakin",
            "Laski",
            "Latif",
            "Latin",
            "Lehim",
            "Lemis",
            "Leyli",
            "Leziz",
            "Libas",
            "Liboş",
            "Libre",
            "Lider",
            "Lifli",
            "Light",
            "Liken",
            "Likit",
            "Likör",
            "Liman",
            "Limbo",
            "Limit",
            "Limon",
            "Linet",
            "Linin",
            "Lipit",
            "Lipom",
            "Liret",
            "Lirik",
            "Lisan",
            "Liste",
            "Litre",
            "Livar",
            "Liyan",
            "Lizol",
            "Lizöz",
            "Lojik",
            "Maddi",
            "Madik",
            "Mafiş",
            "Magri",
            "Mahfi",
            "Mahir",
            "Maile",
            "Maksi",
            "Malik",
            "Mania",
            "Manti",
            "Mariz",
            "Marki",
            "Masif",
            "Matiz",
            "Maviş",
            "Mebiz",
            "Mebni",
            "Medih",
            "Mehdi",
            "Mehil",
            "Mekik",
            "Melik",
            "Menfi",
            "Merci",
            "Meriç",
            "Merih",
            "Mermi",
            "Mersi",
            "Mesai",
            "Mesih",
            "Meşin",
            "Metil",
            "Metin",
            "Metis",
            "Mevki",
            "Mevzi",
            "Meyil",
            "Mıgri",
            "Miçel",
            "Midye",
            "Mikap",
            "Mikoz",
            "Mikro",
            "Milas",
            "Milat",
            "Milel",
            "Milim",
            "Milis",
            "Milli",
            "Mimar",
            "Mimik",
            "Mimli",
            "Minik",
            "Minör",
            "Minsk",
            "Miraç",
            "Miras",
            "Mirat",
            "Mirim",
            "Mirza",
            "Misak",
            "Misal",
            "Misel",
            "Misil",
            "Misis",
            "Mitil",
            "Mitos",
            "Mitoz",
            "Miyar",
            "Miyav",
            "Miyaz",
            "Miyom",
            "Miyop",
            "Mizaç",
            "Mizah",
            "Mizan",
            "Mobil",
            "Motif",
            "Mucip",
            "Mucir",
            "Mucit",
            "Mudil",
            "Muhik",
            "Muhil",
            "Muhip",
            "Muhit",
            "Mujik",
            "Mukim",
            "Mukni",
            "Munis",
            "Muris",
            "Mutki",
            "Muzip",
            "Müfit",
            "Mühim",
            "Mülki",
            "Mümin",
            "Münşi",
            "Mürai",
            "Mürit",
            "Müşir",
            "Müziç",
            "Müzik",
            "Naçiz",
            "Nadim",
            "Nadir",
            "Nafia",
            "Nafiz",
            "Nahif",
            "Nahiv",
            "Nakdi",
            "Nakil",
            "Nakip",
            "Nakit",
            "Nakli",
            "Nakşi",
            "Nanik",
            "Narin",
            "Nasip",
            "Nasir",
            "Naşir",
            "Nazik",
            "Nazil",
            "Nazir",
            "Necip",
            "Nedim",
            "Nefir",
            "Nefis",
            "Nefiy",
            "Nefti",
            "Nehir",
            "Nehiy",
            "Nemli",
            "Nesiç",
            "Nesih",
            "Nesil",
            "Nesim",
            "Nesir",
            "Neşir",
            "Nevir",
            "Nezif",
            "Nezih",
            "Nezir",
            "Nicel",
            "Niçin",
            "Nifak",
            "Niğde",
            "Nihai",
            "Nihan",
            "Nikah",
            "Nikap",
            "Nikel",
            "Nimet",
            "Ninni",
            "Nipel",
            "Nisai",
            "Nisan",
            "Nisap",
            "Nispi",
            "Nişan",
            "Nitel",
            "Niyaz",
            "Niyet",
            "Nizam",
            "Nizip",
            "Ofris",
            "Ojeli",
            "Okapi",
            "Oksit",
            "Oleik",
            "Olein",
            "Oniks",
            "Oosit",
            "Optik",
            "Orcik",
            "Orion",
            "Orkit",
            "Otist",
            "Otizm",
            "Öneri",
            "Örcin",
            "Öteki",
            "Özeni",
            "Panik",
            "Paris",
            "Parti",
            "Pasif",
            "Patik",
            "Peçiç",
            "Pekin",
            "Pelin",
            "Pelit",
            "Penis",
            "Perki",
            "Permi",
            "Peşin",
            "Peşli",
            "Pigme",
            "Pikaj",
            "Pikap",
            "Piket",
            "Pilav",
            "Piliç",
            "Pilli",
            "Pilot",
            "Pinel",
            "Pines",
            "Pinti",
            "Pipet",
            "Pirit",
            "Pisik",
            "Pisin",
            "Pişek",
            "Pişik",
            "Pişim",
            "Pişme",
            "Pişti",
            "Piton",
            "Piyan",
            "Piyaz",
            "Piyes",
            "Piyon",
            "Pizza",
            "Plati",
            "Polip",
            "Polis",
            "Potin",
            "Print",
            "Quito",
            "Rafit",
            "Ragbi",
            "Rahim",
            "Rahip",
            "Rakik",
            "Rakip",
            "Rakit",
            "Ralli",
            "Rayiç",
            "Recim",
            "Redif",
            "Refik",
            "Rehin",
            "Rejim",
            "Rekiz",
            "Remil",
            "Remiz",
            "Resif",
            "Resim",
            "Resmi",
            "Reşit",
            "Revir",
            "Reviş",
            "Rezil",
            "Rical",
            "Ricat",
            "Rijit",
            "Rimel",
            "Ringa",
            "Ritim",
            "Riyad",
            "Riyal",
            "Rotil",
            "Rubai",
            "Rufai",
            "Runik",
            "Rutin",
            "Sabit",
            "Sadik",
            "Safir",
            "Sahih",
            "Sahil",
            "Sahip",
            "Saika",
            "Sakil",
            "Sakim",
            "Sakin",
            "Sakit",
            "Salik",
            "Salim",
            "Salip",
            "Sanki",
            "Sarig",
            "Sarih",
            "Sathi",
            "Satir",
            "Sebil",
            "Seçim",
            "Seçiş",
            "Seçki",
            "Sedir",
            "Sefih",
            "Sefil",
            "Sefir",
            "Sehim",
            "Sehiv",
            "Sekil",
            "Sekiş",
            "Sekiz",
            "Seksi",
            "Selim",
            "Selis",
            "Selvi",
            "Semai",
            "Semih",
            "Semiz",
            "Senir",
            "Senit",
            "Sergi",
            "Serik",
            "Serim",
            "Serin",
            "Seriş",
            "Servi",
            "Sesçi",
            "Sesli",
            "Setik",
            "Setir",
            "Sevgi",
            "Sevim",
            "Sevir",
            "Seviş",
            "Seyir",
            "Seyis",
            "Seyit",
            "Sezgi",
            "Seziş",
            "Sıhhi",
            "Sıhri",
            "Sınai",
            "Sicil",
            "Sicim",
            "Sidik",
            "Sifin",
            "Sifon",
            "Sigar",
            "Siğil",
            "Sihir",
            "Siirt",
            "Sikke",
            "Silah",
            "Silaj",
            "Silgi",
            "Silik",
            "Silis",
            "Siliş",
            "Silki",
            "Sille",
            "Silme",
            "Simav",
            "Simge",
            "Simit",
            "Simya",
            "Sinek",
            "Sinik",
            "Sinir",
            "Siniş",
            "Sinle",
            "Sinme",
            "Sinop",
            "Sinsi",
            "Sinüs",
            "Siper",
            "Sipsi",
            "Siren",
            "Sirke",
            "Sirmo",
            "Siroz",
            "Sirto",
            "Sisli",
            "Sitem",
            "Sitil",
            "Sivas",
            "Sivil",
            "Sivri",
            "Siyah",
            "Siyak",
            "Siyek",
            "Siyer",
            "Siyme",
            "Sizce",
            "Skink",
            "Sorit",
            "Sorti",
            "Sosis",
            "Stilo",
            "Süfli",
            "Sünni",
            "Şafii",
            "Şahin",
            "Şahit",
            "Şahsi",
            "Şaibe",
            "Şaire",
            "Şamil",
            "Şarki",
            "Şarpi",
            "Şayia",
            "Şedit",
            "Şefik",
            "Şehir",
            "Şehit",
            "Şekil",
            "Şekli",
            "Şemsi",
            "Şepit",
            "Şerif",
            "Şerik",
            "Şerir",
            "Şerit",
            "Şetim",
            "Şifon",
            "Şifre",
            "Şikar",
            "Şilem",
            "Şilep",
            "Şilin",
            "Şilte",
            "Şimal",
            "Şimdi",
            "Şinik",
            "Şinto",
            "Şiran",
            "Şirin",
            "Şişek",
            "Şişik",
            "Şişko",
            "Şişli",
            "Şişme",
            "Şömiz",
            "Tabii",
            "Tabip",
            "Tabir",
            "Tacik",
            "Tacil",
            "Tacir",
            "Taciz",
            "Tadil",
            "Tahin",
            "Takim",
            "Takip",
            "Taksi",
            "Takti",
            "Talih",
            "Talik",
            "Talil",
            "Talim",
            "Talip",
            "Tamik",
            "Tamim",
            "Tamir",
            "Tanin",
            "Tapir",
            "Tarif",
            "Tarih",
            "Tarik",
            "Tariz",
            "Tasdi",
            "Tasni",
            "Tatil",
            "Tavik",
            "Taviz",
            "Tayin",
            "Tayip",
            "Tazim",
            "Tazip",
            "Taziz",
            "Teali",
            "Teati",
            "Tecil",
            "Tecim",
            "Tedai",
            "Tedip",
            "Tehir",
            "Teizm",
            "Tekçi",
            "Tekil",
            "Tekin",
            "Tekir",
            "Tekit",
            "Tekli",
            "Telif",
            "Telin",
            "Telis",
            "Telli",
            "Telsi",
            "Temin",
            "Temiz",
            "Tenis",
            "Teori",
            "Tepik",
            "Tepir",
            "Tepiş",
            "Tepki",
            "Tepsi",
            "Terbi",
            "Terfi",
            "Terim",
            "Terki",
            "Terli",
            "Terzi",
            "Tesir",
            "Tesis",
            "Tesit",
            "Tesri",
            "Testi",
            "Teşci",
            "Teşri",
            "Teşyi",
            "Tetik",
            "Tetir",
            "Tevdi",
            "Tevil",
            "Tevki",
            "Tevsi",
            "Tevzi",
            "Teyit",
            "Tezli",
            "Tıbbi",
            "Tifüs",
            "Tikel",
            "Tilki",
            "Timüs",
            "Tiner",
            "Tipik",
            "Tiraj",
            "Tiran",
            "Tirat",
            "Tirit",
            "Tiriz",
            "Tirle",
            "Tirsi",
            "Tirşe",
            "Titan",
            "Titiz",
            "Tonik",
            "Topik",
            "Torik",
            "Triko",
            "Tunik",
            "Türki",
            "Tüvit",
            "Tvist",
            "Umumi",
            "Vacip",
            "Vahim",
            "Vahit",
            "Vahiy",
            "Vahşi",
            "Vakit",
            "Valiz",
            "Varil",
            "Varis",
            "Varit",
            "Vecih",
            "Veciz",
            "Vedia",
            "Vehim",
            "Vekil",
            "Verdi",
            "Vergi",
            "Verim",
            "Veriş",
            "Verit",
            "Vezin",
            "Vezir",
            "Video",
            "Vigla",
            "Villa",
            "Viraj",
            "Viral",
            "Viran",
            "Virüs",
            "Visal",
            "Viski",
            "Vişne",
            "Vites",
            "Vitir",
            "Viyak",
            "Viyol",
            "Vizon",
            "Vizör",
            "Yahni",
            "Yahşi",
            "Yakin",
            "Yasin",
            "Yediz",
            "Yeğin",
            "Yeğni",
            "Yelin",
            "Yelli",
            "Yemci",
            "Yemin",
            "Yemiş",
            "Yengi",
            "Yenik",
            "Yenli",
            "Yergi",
            "Yerli",
            "Yeşil",
            "Yeşim",
            "Yetik",
            "Yetim",
            "Yetki",
            "Yevmi",
            "Yeygi",
            "Yezit",
            "Yiğit",
            "Yirik",
            "Yirmi",
            "Yitik",
            "Yitim",
            "Yitme",
            "Yivli",
            "Yiyim",
            "Yiyiş",
            "Zabit",
            "Zahir",
            "Zahit",
            "Zalim",
            "Zamir",
            "Zarif",
            "Zecir",
            "Zecri",
            "Zefir",
            "Zehir",
            "Zelil",
            "Zemin",
            "Zenci",
            "Zeyil",
            "Zımni",
            "Zifaf",
            "Zifin",
            "Zifir",
            "Zifos",
            "Zigon",
            "Zigot",
            "Zihaf",
            "Zihin",
            "Zihni",
            "Zikir",
            "Zilli",
            "Zimmi",
            "Zinde",
            "Zirai",
            "Zirve",
            "Ziyan",
            "Zloti"};

            Random rastgeleSayi = new Random();
            string rastgeleKelime = kelimeler[rastgeleSayi.Next(kelimeler.Length)].ToUpper();
            rastgeleKelime = "AFAKİ";
            Yaz("Kelime: " + rastgeleKelime);

           

            while (true)
            {
                Yaz("");
                Yaz("Tahmin: ", true);
                string inputTahmin = Console.ReadLine().ToUpper();
                ////Kelime listesinde kelime var mı yok mu?
                //if (!kelimeler.Contains(rastgeleKelime))
                //{
                //    Yaz("Listede böyle bir kelime yok", arkaPlan: ConsoleColor.Red);
                //    break;
                //}

                if (inputTahmin == rastgeleKelime)
                {
                    Yaz(inputTahmin, arkaPlan: ConsoleColor.DarkGreen);
                    Yaz("Tebrikler bildiniz");

                    break;
                }
                //Boş bir değer girilirse?
                if (inputTahmin ==null)
                {
                    Yaz("Lütfen tahmin giriniz");
                    break;
                }
                //Kaç Hakkım Var? Azaltarak hakların bitmesi gerekiyor
                int kalanHak = 6;
                if (inputTahmin != rastgeleKelime)
                {
                    kalanHak--;
                    Yaz($"yanlış tahmin Kalan Hakkınız:  {kalanHak}",arkaPlan: ConsoleColor.Red);
                    if (kalanHak==0)
                    {
                        Yaz($"Hakkınız kalmadı: {rastgeleKelime}",arkaPlan: ConsoleColor.Red);
                        break;
                    }
                }

                var bulunamayanHarfler = rastgeleKelime.ToArray();

                for (var i = 0; i < inputTahmin.Length; i++)
                {
                    if (inputTahmin[i] == rastgeleKelime[i])
                    {
                        bulunamayanHarfler[i] = new char();
                    }
                }

                for (var i = 0; i < inputTahmin.Length; i++)
                {
                    if (inputTahmin[i] == rastgeleKelime[i])
                    {
                        Yaz(inputTahmin[i].ToString(), true, arkaPlan: ConsoleColor.DarkGreen);
                    }
                    else if (bulunamayanHarfler.Contains(inputTahmin[i]))
                    {
                        Yaz(inputTahmin[i].ToString(), true, arkaPlan: ConsoleColor.DarkYellow);
                    }
                    else
                    {
                        Yaz(inputTahmin[i].ToString(), true);
                    }
                }
                
            }



            // kullanıcının tahmin ettiği ile bilgisayarın rastgele kelimesi aynı mı? 
            // tahmin edilen kelimede aranan kelimedeki harfler var mı? -- yeşil
            // kelimedeki harfler doğru indeks sırasında mı? -- sarı





        }
    }
}
