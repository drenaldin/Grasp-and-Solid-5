namespace Full_GRASP_And_SOLID
{

    // Cree la interfaz TextPrint para que ConsolePrinter no dependa de Recipe. TextPrint obtiene el texto y ConsolePrinter lo imprime.
    public interface ITextPrint
    {
        string GetTextToPrint();
    }
}