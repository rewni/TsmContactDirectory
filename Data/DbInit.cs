using System.Linq;
using TsmContactDirectory.Models;

namespace TsmContactDirectory.Data
{
    public static class DbInit
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.Contacts.Any())
            {
                return;
            }

            // mock data array
            var contacts = new Contact[]
            {
                new Contact  { FirstName = "Maite", LastName = "Wiggins", Phone = "281-507-0103", Email = "eu@Vivamussitamet.com" },
                new Contact  { FirstName = "Kai", LastName = "Mccarthy", Phone = "759-380-0870", Email = "aliquet.Phasellus@eget.org" },
                new Contact  { FirstName = "Willa", LastName = "Ortiz", Phone = "216-973-4455", Email = "egestas.a@consectetuer.co.uk" },
                new Contact  { FirstName = "Noel", LastName = "Snider", Phone = "589-100-0545", Email = "nunc@mollisInteger.co.uk" },
                new Contact  { FirstName = "Armand", LastName = "Franks", Phone = "165-140-1551", Email = "placerat.eget.venenatis@tristiquepellentesquetellus.net" },
                new Contact  { FirstName = "Madeline", LastName = "Small", Phone = "660-918-6999", Email = "eu.eros@Nam.net" },
                new Contact  { FirstName = "Jerry", LastName = "Maldonado", Phone = "186-779-9791", Email = "elit.a.feugiat@risusQuisque.ca" },
                new Contact  { FirstName = "Eric", LastName = "Mcleod", Phone = "726-884-3896", Email = "et@lectussitamet.co.uk" },
                new Contact  { FirstName = "Blythe", LastName = "new Contact ton", Phone = "394-730-6268", Email = "gravida.Aliquam@ametmassaQuisque.com" },
                new Contact  { FirstName = "Tate", LastName = "Mcdaniel", Phone = "625-591-9012", Email = "et@semmolestiesodales.com" },
                new Contact  { FirstName = "Rafael", LastName = "Baird", Phone = "845-823-9116", Email = "ipsum.primis@diam.net" },
                new Contact  { FirstName = "Penelope", LastName = "Stafford", Phone = "557-455-8013", Email = "non.justo.Proin@mi.org" },
                new Contact  { FirstName = "Knox", LastName = "Massey", Phone = "421-168-2333", Email = "commodo.at@nonummy.ca" },
                new Contact  { FirstName = "Ulric", LastName = "Williams", Phone = "160-982-6441", Email = "quis.pede@semperauctorMauris.co.uk" },
                new Contact  { FirstName = "Noelani", LastName = "Callahan", Phone = "813-679-1848", Email = "netus.et@arcu.net" },
                new Contact  { FirstName = "Lael", LastName = "Pickett", Phone = "967-959-1878", Email = "mauris.ut.mi@lacinia.ca" },
                new Contact  { FirstName = "Isaac", LastName = "Ayers", Phone = "697-714-1471", Email = "amet@aliquet.net" },
                new Contact  { FirstName = "Darius", LastName = "Livingston", Phone = "348-212-1505", Email = "sit.amet@eu.co.uk" },
                new Contact  { FirstName = "Illana", LastName = "Jacobson", Phone = "471-238-7263", Email = "ligula@et.org" },
                new Contact  { FirstName = "Kim", LastName = "Adams", Phone = "678-136-7256", Email = "egestas.Sed.pharetra@commodoauctor.ca" },
                new Contact  { FirstName = "Martin", LastName = "Gilbert", Phone = "790-934-9283", Email = "nunc@Nunc.co.uk" },
                new Contact  { FirstName = "Lucy", LastName = "Parrish", Phone = "256-518-4350", Email = "cursus@Duis.org" },
                new Contact  { FirstName = "Porter", LastName = "Hicks", Phone = "629-877-5397", Email = "lobortis@nequeSed.edu" },
                new Contact  { FirstName = "Timon", LastName = "Ewing", Phone = "514-735-1342", Email = "mattis.Cras.eget@arcu.org" },
                new Contact  { FirstName = "Jason", LastName = "Griffith", Phone = "360-174-0704", Email = "Integer.vulputate.risus@ligulatortor.org" },
                new Contact  { FirstName = "Sean", LastName = "Odonnell", Phone = "888-942-5445", Email = "ipsum.porta@pedeacurna.com" },
                new Contact  { FirstName = "Gemma", LastName = "Edwards", Phone = "893-332-9732", Email = "eros@semperNamtempor.edu" },
                new Contact  { FirstName = "Nero", LastName = "Mccullough", Phone = "570-109-6296", Email = "faucibus.orci@inmolestietortor.ca" },
                new Contact  { FirstName = "Marshall", LastName = "Cardenas", Phone = "424-952-8877", Email = "nec@necdiam.co.uk" },
                new Contact  { FirstName = "Tiger", LastName = "Wyatt", Phone = "925-797-9905", Email = "metus.In.nec@orciluctuset.ca" },
                new Contact  { FirstName = "Josephine", LastName = "Orr", Phone = "297-132-1838", Email = "Curabitur@habitantmorbitristique.co.uk" },
                new Contact  { FirstName = "Lionel", LastName = "Wiley", Phone = "559-488-8018", Email = "Duis@semperauctor.com" },
                new Contact  { FirstName = "Selma", LastName = "Summers", Phone = "101-822-4577", Email = "ornare.sagittis.felis@molestietortornibh.ca" },
                new Contact  { FirstName = "Colette", LastName = "Moore", Phone = "842-105-4722", Email = "Phasellus.elit.pede@sitamet.net" },
                new Contact  { FirstName = "Ima", LastName = "Kirkland", Phone = "603-739-4370", Email = "augue.ac@Sed.net" },
                new Contact  { FirstName = "Alika", LastName = "Adkins", Phone = "623-761-1357", Email = "id@eu.edu" },
                new Contact  { FirstName = "Quinlan", LastName = "Ellis", Phone = "543-207-7571", Email = "ipsum@aliquetvelvulputate.org" },
                new Contact  { FirstName = "Tobias", LastName = "Acosta", Phone = "560-801-1018", Email = "pede.ultrices.a@lectus.edu" },
                new Contact  { FirstName = "Althea", LastName = "Waters", Phone = "872-482-1356", Email = "enim.Curabitur@Donecporttitortellus.com" },
                new Contact  { FirstName = "Kenyon", LastName = "Valdez", Phone = "389-879-2985", Email = "sed@fringillaest.com" },
                new Contact  { FirstName = "Jamal", LastName = "Wong", Phone = "374-195-4000", Email = "venenatis@lacusNulla.co.uk" },
                new Contact  { FirstName = "Erin", LastName = "Haley", Phone = "473-935-9311", Email = "neque.Sed@cursus.co.uk" },
                new Contact  { FirstName = "Jorden", LastName = "Morrow", Phone = "284-969-5063", Email = "lorem@acfermentum.edu" },
                new Contact  { FirstName = "Jada", LastName = "Cortez", Phone = "853-249-0096", Email = "Curabitur@inconsectetuer.com" },
                new Contact  { FirstName = "Sade", LastName = "Bright", Phone = "323-796-2511", Email = "in.tempus@non.co.uk" },
                new Contact  { FirstName = "Aurelia", LastName = "Morin", Phone = "251-350-6443", Email = "dolor.tempus@ipsumacmi.org" },
                new Contact  { FirstName = "Beatrice", LastName = "Henderson", Phone = "257-224-2569", Email = "Aenean.egestas@ornaresagittis.org" },
                new Contact  { FirstName = "Armand", LastName = "Mills", Phone = "218-306-1798", Email = "quam.Curabitur.vel@ligulaDonecluctus.com" },
                new Contact  { FirstName = "Howard", LastName = "Munoz", Phone = "524-501-5838", Email = "felis.eget@hendreritidante.com" },
                new Contact  { FirstName = "Katell", LastName = "Mendoza", Phone = "542-873-9452", Email = "vitae.erat.Vivamus@convallisdolorQuisque.ca" },
                new Contact  { FirstName = "Adrian", LastName = "Sanchez", Phone = "851-552-8874", Email = "In@CraspellentesqueSed.org" },
                new Contact  { FirstName = "Karen", LastName = "Burton", Phone = "966-701-6753", Email = "nec@Sednulla.co.uk" },
                new Contact  { FirstName = "Branden", LastName = "Velazquez", Phone = "753-202-6081", Email = "et.malesuada.fames@erateget.com" },
                new Contact  { FirstName = "Robert", LastName = "Parsons", Phone = "371-353-1049", Email = "neque.Nullam@tellusSuspendisse.com" },
                new Contact  { FirstName = "Sybill", LastName = "Rivas", Phone = "314-437-4765", Email = "Duis@cursus.net" },
                new Contact  { FirstName = "Timon", LastName = "Blackburn", Phone = "117-764-6522", Email = "ipsum.Phasellus.vitae@ipsumprimisin.edu" },
                new Contact  { FirstName = "Robert", LastName = "Browning", Phone = "992-807-0763", Email = "Suspendisse.aliquet@semegetmassa.com" },
                new Contact  { FirstName = "Rigel", LastName = "Serrano", Phone = "449-550-4172", Email = "nonummy@dapibusgravidaAliquam.com" },
                new Contact  { FirstName = "Declan", LastName = "Monroe", Phone = "586-498-8326", Email = "ut.nisi@Duisacarcu.ca" },
                new Contact  { FirstName = "Maile", LastName = "Lester", Phone = "879-160-5945", Email = "Mauris.vel@nec.co.uk" },
                new Contact  { FirstName = "Amery", LastName = "Macdonald", Phone = "963-690-5153", Email = "laoreet@cubiliaCuraePhasellus.com" },
                new Contact  { FirstName = "Nicholas", LastName = "Goodman", Phone = "386-538-0292", Email = "ut@et.org" },
                new Contact  { FirstName = "Flynn", LastName = "Knox", Phone = "863-502-8995", Email = "posuere@odioEtiamligula.com" },
                new Contact  { FirstName = "Kay", LastName = "Casey", Phone = "388-972-8667", Email = "ad@magnaPraesentinterdum.net" },
                new Contact  { FirstName = "Tobias", LastName = "Jarvis", Phone = "571-218-3655", Email = "porttitor.vulputate.posuere@In.edu" },
                new Contact  { FirstName = "Jin", LastName = "Winters", Phone = "825-306-5640", Email = "Suspendisse.dui.Fusce@porttitor.org" },
                new Contact  { FirstName = "Jackson", LastName = "Dixon", Phone = "194-463-5232", Email = "gravida.sagittis.Duis@molestie.com" },
                new Contact  { FirstName = "Henry", LastName = "Carson", Phone = "317-953-0042", Email = "ullamcorper.magna@Nunc.com" },
                new Contact  { FirstName = "Karen", LastName = "Peterson", Phone = "780-555-9219", Email = "non.sollicitudin@fermentummetusAenean.com" },
                new Contact  { FirstName = "Alisa", LastName = "Haley", Phone = "603-674-9989", Email = "diam@convallisest.net" },
                new Contact  { FirstName = "TaShya", LastName = "Morton", Phone = "334-588-7357", Email = "Cras@arcuacorci.edu" },
                new Contact  { FirstName = "Hop", LastName = "Hartman", Phone = "382-174-4651", Email = "amet.lorem.semper@justofaucibus.co.uk" },
                new Contact  { FirstName = "Yael", LastName = "Flowers", Phone = "137-754-3509", Email = "pede.nec.ante@netus.ca" },
                new Contact  { FirstName = "Samuel", LastName = "Kirkland", Phone = "410-427-8789", Email = "adipiscing.elit.Aliquam@Nuncullamcorpervelit.net" },
                new Contact  { FirstName = "Kelsie", LastName = "Meadows", Phone = "925-908-3548", Email = "arcu@loremsemperauctor.net" },
                new Contact  { FirstName = "Quentin", LastName = "Ortega", Phone = "806-647-1800", Email = "ridiculus.mus.Aenean@dolorNullasemper.org" },
                new Contact  { FirstName = "Griffith", LastName = "York", Phone = "271-644-1239", Email = "et@sollicitudinadipiscing.com" },
                new Contact  { FirstName = "Savannah", LastName = "Phelps", Phone = "859-908-7147", Email = "Mauris.molestie.pharetra@tinciduntpede.net" },
                new Contact  { FirstName = "Debra", LastName = "Black", Phone = "756-748-3933", Email = "penatibus.et.magnis@mauriselit.edu" },
                new Contact  { FirstName = "Zahir", LastName = "Lawrence", Phone = "193-623-2997", Email = "Mauris.molestie.pharetra@Aenean.com" },
                new Contact  { FirstName = "Marah", LastName = "Nixon", Phone = "904-760-1092", Email = "urna@laoreetliberoet.ca" },
                new Contact  { FirstName = "Joan", LastName = "Wilkinson", Phone = "217-733-6925", Email = "diam@elit.org" },
                new Contact  { FirstName = "Carl", LastName = "Bowers", Phone = "259-998-3224", Email = "Nunc@Nuncsollicitudincommodo.com" },
                new Contact  { FirstName = "Melvin", LastName = "Alvarez", Phone = "327-516-8117", Email = "semper.egestas.urna@velitdui.ca" },
                new Contact  { FirstName = "Olympia", LastName = "Kelley", Phone = "479-666-6955", Email = "ipsum@egestas.co.uk" },
                new Contact  { FirstName = "Fatima", LastName = "Stevens", Phone = "314-945-3610", Email = "massa.Integer@anteVivamusnon.net" },
                new Contact  { FirstName = "Norman", LastName = "Sharpe", Phone = "904-938-0518", Email = "ac.ipsum@elit.co.uk" },
                new Contact  { FirstName = "Wing", LastName = "Sellers", Phone = "523-447-6355", Email = "Nulla.interdum@est.com" },
                new Contact  { FirstName = "Dana", LastName = "Garrison", Phone = "275-204-0164", Email = "nisl.sem@imperdieterat.net" },
                new Contact  { FirstName = "Xaviera", LastName = "Duke", Phone = "869-952-3905", Email = "amet.ultricies.sem@vulputateposuerevulputate.edu" },
                new Contact  { FirstName = "Rhona", LastName = "Gordon", Phone = "391-558-2175", Email = "in.magna.Phasellus@euismodmauris.ca" },
                new Contact  { FirstName = "Lance", LastName = "Peck", Phone = "123-742-1257", Email = "et@justofaucibus.ca" },
                new Contact  { FirstName = "Grady", LastName = "Mays", Phone = "487-930-4263", Email = "vehicula.et.rutrum@pedeNuncsed.net" },
                new Contact  { FirstName = "Carissa", LastName = "Roman", Phone = "659-853-0572", Email = "lacus.Quisque.purus@molestietellus.com" },
                new Contact  { FirstName = "Fulton", LastName = "Maynard", Phone = "856-208-3000", Email = "quis.accumsan@odio.com" },
                new Contact  { FirstName = "Allistair", LastName = "Elliott", Phone = "961-935-1212", Email = "cursus.vestibulum@dictumsapien.org" },
                new Contact  { FirstName = "Chancellor", LastName = "Santiago", Phone = "883-157-4009", Email = "Sed@acmetus.edu" },
                new Contact  { FirstName = "Amity", LastName = "Bentley", Phone = "423-676-6124", Email = "nisl@facilisis.edu" },
                new Contact  { FirstName = "Seth", LastName = "Lindsey", Phone = "723-384-1502", Email = "vitae@est.ca" },
                new Contact  { FirstName = "Zia", LastName = "Welch", Phone = "640-839-7410", Email = "scelerisque.sed@Integersem.com" }
            };

            foreach (Contact c in contacts)
            {
                context.Contacts.Add(c);
            }

            context.SaveChanges();
        }
    }
}
