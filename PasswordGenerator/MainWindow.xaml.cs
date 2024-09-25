using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public int EnteredPasswordAmount { get; set; }


        private void GeneratePassword_Click(object sender, RoutedEventArgs e)
        {
            string[] norskeSubstantiv = new string[] { "Avstand", "Bakgrunn", "Ball", "Bilde", "Blod", "Bok", "Bokstav", "Bunn", "By", "Del", "Drøm", "Eksempel", "Eske", "Evne", "Familie", "Farge", "Feil", "Fest", "Flagg", "Flaske", "Fordel", "Forhold", "Form", "Forskjell", "Forslag", "Gang", "Grense", "Grunn", "Håp", "Humør", "Hus", "Idrett", "Jobb", "Kamp", "Kart", "Konge", "Konkurranse", "Kropp", "Lag", "Land", "Liv", "Lov", "Løype", "Luft", "Lyd", "Lys", "Mål", "Mat", "Måte", "Menneske", "Merke", "Miljø", "Møte", "Nøkkel", "område", "oppgave", "ord", "øyeblikk", "pause", "pose", "pris", "prøve", "Retning", "Sak", "Salg", "Samfunn", "samtale", "sang", "seier", "seng", "side", "situasjon", "skade", "skilt", "skole", "skritt", "slutt", "søvn", "spill", "spøk", "spørsmål", "sted", "stemme", "stjerne", "støtte", "stund", "Stykke", "Svar", "Sykdom", "Tall", "Tekst", "Tid", "Time", "Ting", "Utfordring", "Vær", "Valg", "Vei", "Venn", "Årsak" };
            string[] norskeAdjektiv = new string[] { "Aktuell", "Alvorlig", "Ansvarlig", "Berømt", "Betydelig", "Bevisst", "Bred", "Dum", "Dyp", "Ekkel", "Eksisterende", "Ekte", "Enkel", "Ensom", "Falsk", "Fast", "Felles", "Fersk", "Fjern", "Flau", "Følsom", "Forsiktig", "Fremmed", "Fryktelig", "Glatt", "Gravid", "Grunnleggende", "Heldig", "Hemmelig", "Hjelpsom", "Hyppig", "Imponerende", "Kjedelig", "Kul", "Langsom", "Lat", "Lav", "Lignende", "Løs", "Lovlig", "Lykkelig", "Lys", "Menneskelig", "Merkelig", "Midlertidig", "Mistenkelig", "Modig", "Mørk", "Morsom", "Motsatt", "Mulig", "Naturlig", "Nåværende", "Nødvendig", "Nøyaktig", "Nysgjerrig", "Nyttig", "Offentlig", "Opprinnelig", "Ordentlig", "Plutselig", "Rå", "Rask", "Regelmessig", "Ren", "Rettferdig", "Rimelig", "Rund", "Ryddig", "Sannsynlig", "Selvsikker", "Sint", "Skarp", "Skikkelig", "Skyldig", "Smal", "Søt", "Spennende", "Stille", "Stolt", "Stram", "Streng", "Stygg", "Sulten", "Sunn", "Synlig", "Tilgjengelig", "Tilstrekkelig", "Tung", "Tynn", "Uavhengig", "Ujevnt", "Ulovlig", "Ulykkelig", "Umiddelbar", "Urettferdig", "Vellykket", "Vennlig", "Verdifull", "Vill", "Villig", "Voksen", "Ærlig", "Åpen", "Åpenbar" };
            string[] spesialtegn = new string[] { ".", ",", "!", "@", "#", "-", "?" };

            Random random = new Random();

            PasswordTextbox.Text = "";

            if (EnteredPasswordAmount > 100)
            {
                EnteredPasswordAmount = 100;
            }

            for (int i = 0; i < EnteredPasswordAmount; i++)
            {
                int randomAdjektivNumber = random.Next(0, norskeAdjektiv.Length);
                int randomSubstantivNumber = random.Next(0, norskeSubstantiv.Length);
                int randomSpesialtegnNumber = random.Next(0, spesialtegn.Length);
                int randomNumber = random.Next(10,100);

                string adjektiv = norskeAdjektiv[randomAdjektivNumber].Substring(0,1).ToUpper() + norskeAdjektiv[randomAdjektivNumber].Substring(1).ToLower();
                string substantiv = norskeSubstantiv[randomSubstantivNumber].Substring(0,1).ToUpper() + norskeSubstantiv[randomSubstantivNumber].Substring(1).ToLower();

                string password = adjektiv + substantiv + randomNumber.ToString() + spesialtegn[randomSpesialtegnNumber] + "\n";

                PasswordTextbox.Text += password;
            }    
        }

        private void PasswordAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(PasswordAmount.Text, out int result))
            {
                EnteredPasswordAmount = result;
            }
        }
    }
}