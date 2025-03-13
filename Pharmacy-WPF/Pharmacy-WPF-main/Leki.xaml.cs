using System.Windows;
using System.Windows.Controls;

namespace Pharmacy
{
    /// <summary>
    /// Interaction logic for Leki.xaml
    /// </summary>
    public partial class Leki : UserControl
    {
        public Leki()
        {
            InitializeComponent();
        }
        private void Lek1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 1 Lek ACARD zawiera kwas acetylosalicylowy, który hamuje zlepianie się (agregację) płytek krwi. Lek przeznaczony jest do długotrwałego, profilaktycznego stosowania w chorobach, które grożą powstaniem zakrzepów i zatorów w naczyniach krwionośnych.");
        }

        private void Lek2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 2 Lek Aleve należy do grupy niesteroidowych leków przeciwzapalnych (NLPZ), które poprzez odwracalne hamowanie syntezy prostaglandyn wywierają działanie przeciwbólowe, przeciwgorączkowe i przeciwzapalne. Lek Aleve zmniejsza nasilenie bólu, obniża gorączkę i hamuje reakcje zapalne. Ma szybkie i długotrwałe działanie");
        }

        private void Lek3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 3 Lek APAP jako substancję czynną zawiera paracetamol i jest lekiem przeciwbólowym i przeciwgorączkowym. Wskazaniem do stosowania leku są bóle różnego pochodzenia: głowy (w tym napięciowe bóle głowy), menstruacyjne, zębów, mięśni, kostno-stawowe, gardła, nerwobóle oraz gorączka, np. w przeziębieniu i grypie.");
        }

        private void Lek4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 4 Lek Ibum zawiera ibuprofen – substancję z grupy niesteroidowych leków przeciwzapalnych (NLPZ), mających działanie przeciwbólowe, przeciwgorączkowe i przeciwzapalne.");
        }

        private void Lek5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 5 Lek Ibuprom. Substancja czynna ibuprofen należy do niesteroidowych leków przeciwzapalnych (NLPZ). Ibuprofen zwalcza dolegliwości bólowe i stany zapalne oraz obniża gorączkę. Po podaniu doustnym lek szybko wchłania się z przewodu pokarmowego, a stężenie maksymalne osiąga 1-2 godziny od zażycia.");
        }

        private void Lek6_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 6 Lek Ketonal. Preparat należy do niesteroidowych leków przeciwzapalnych (NLPZ), a jego substancją czynną jest ketoprofen. Mimo iż, Ketonal forte postrzegany jest jako lek na ból, to oprócz działania przeciwbólowego posiada również właściwości przeciwgorączkowe i przeciwzapalne.");
        }

        private void Lek7_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 7 Lek Lernidum zawiera substancję czynną lerkanidypiny chlorowodorek, który należy do grupy tzw. antagonistów wapnia (pochodnych dihydropirydyny) - leków zmniejszających ciśnienie krwi. Lek ten stosuje się w leczeniu wysokiego ciśnienia krwi (nadciśnienia tętniczego) u dorosłych.");
        }

        private void Lek8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 8 Lek Nervosol jest tradycyjnym produktem leczniczym roślinnym do stosowania w określonych wskazaniach, wynikających wyłącznie z jego długotrwałego stosowania. Nervosol jest stosowany w łagodnych stanach napięcia nerwowego i niepokoju oraz w okresowych trudnościach w zasypianiu.");
        }

        private void Lek9_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 9 Lek Nurofen. Substancją czynną preparatu jest ibuprofen, niesteroidowy lek przeciwzapalny (NLPZ) z grupy pochodnych kwasu propionowego. Wykazuje działanie przeciwzapalne, przeciwbólowe i przeciwgorączkowe. Ibuprofen przeciwdziała syntezie prostaglandyn, substancji odgrywających znaczącą rolę w rozwoju stanu zapalnego.");
        }

        private void Lek10_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 10 Chela-Mag B6 to suplement diety, którego działanie wynika z właściwości substancji czynnych. Magnez jest niezbędny do prawidłowej czynności skurczowej serca, a ponadto odgrywa kluczową rolę w procesie mineralizacji kości oraz skurczu mięśni.");
        }

        private void Lek11_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 11 Lek Panadol to produkt leczniczy do stosowania w bólach różnego pochodzenia jak ból głowy, migrena, ból zęba, bóle kostne-stawowe-mięśniowe oraz w gorączce towarzyszącej przeziębieniu.");
        }

        private void Lek12_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("NR 12 Positivium jest suplementem diety zawierającym wyciągi roślinne: z ziela melisy (150 mg), szyszek chmielu (75 mg) oraz ze znamion krokusa uprawnego (3,75 mg). Składniki preparatu wspomagają uzyskanie stanu odprężenia i równowagi emocjonalnej, ułatwiają zasypianie oraz poprawiają jakość snu.");
        }
    }
}
