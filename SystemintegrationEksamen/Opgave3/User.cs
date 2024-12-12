namespace SystemintegrationEksamen._3x2Messages;

public class User
{
    private ushort MedlemsNummer { get; set; }
    public bool MedlemsStatus { get; set; }
    private string Fornavn { get; set; }
    private string Efternavn { get; set; }
    
    //Opgave 7 tilføjelse
    
    private string datoBrev { get; set; }

    public User(ushort medlemsNummer, string fornavn, string efternavn)
    {
        MedlemsNummer = medlemsNummer;
        Fornavn = fornavn;
        Efternavn = efternavn;
    }
    
    public void setMedlemsStatus(bool status)
    {
        MedlemsStatus = status;
    }
    
    public ushort getMedlemsNummer()
    {
        return MedlemsNummer;
    }

    public string getdatoBrev()
    {
        return datoBrev;
    }
}