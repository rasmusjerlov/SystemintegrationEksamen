namespace Opgave7;

class Program
{
    static void Main(string[] args)
    {
        string nyhedsbrevDato = "03/25/2024";
        string MedlemsregisterDato = "25.marts.2024";

        // Konvertering fra NyhedsbrevSystem format til Canonical format
        string canonicalFromNewsletter = DateTranslator.TranslateFraNyhedsbrevFormat(nyhedsbrevDato);
        Console.WriteLine($"Nyhedsbrev dato {nyhedsbrevDato} konverteret til Canonical format: {canonicalFromNewsletter}");

        // Konvertering fra MedlemsregisterSystem format til Canonical format
        string canonicalFromMember = DateTranslator.TranslateFraMedlemsregisterFormat(MedlemsregisterDato);
        Console.WriteLine($"Medlemsregister dato {MedlemsregisterDato} konverteret til Canonical format: {canonicalFromMember}");
    }
}